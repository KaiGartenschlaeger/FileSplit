using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSplit
{
    public partial class FormMain : Form
    {
        #region Constructor

        public FormMain()
        {
            InitializeComponent();
            InitializeControls();
        }

        #endregion

        #region Helper

        private void InitializeControls()
        {
            lblSourceFile.Text = string.Empty;
            lblOutputDirectory.Text = string.Empty;
            lblProgress.Text = string.Empty;

            tbxOutputFileSize.Text = "100";

            foreach (var item in Enum.GetValues(typeof(FileSizeUnit)))
            {
                cbxOutputFileSizeUnit.Items.Add(item);
            }
            cbxOutputFileSizeUnit.SelectedIndex = (int)FileSizeUnit.Megabyte;

            prgFull.Visible = false;

            CheckStart();
        }

        private void ChooseMergeOutputFile()
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Ausgabe Datei wählen";
                dialog.CheckFileExists = false;
                dialog.Filter = "Alle Dateien|*.*";

                if (!string.IsNullOrEmpty(lblMergeOutputFile.Text))
                {
                    dialog.FileName = lblMergeOutputFile.Text;
                }

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    lblMergeOutputFile.Text = dialog.FileName;
                    CheckStart();
                }
            }
        }

        private void ChooseSourceFile()
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Quelldatei wählen";
                dialog.CheckFileExists = true;
                dialog.Filter = "Alle Dateien|*.*";

                if (!string.IsNullOrEmpty(lblSourceFile.Text))
                {
                    dialog.InitialDirectory = lblSourceFile.Text;
                }

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    lblSourceFile.Text = dialog.FileName;
                    CheckStart();
                }
            }
        }

        private void ChooseOutputDirectory()
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Ausgabe Verzeichnis auswählen:";
                dialog.ShowNewFolderButton = true;
                dialog.RootFolder = Environment.SpecialFolder.MyComputer;

                if (!string.IsNullOrEmpty(lblOutputDirectory.Text))
                {
                    dialog.SelectedPath = lblOutputDirectory.Text;
                }

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    lblOutputDirectory.Text = dialog.SelectedPath;
                    CheckStart();
                }
            }
        }

        private long FileSizeUnitToByteLength()
        {
            long result;
            switch ((FileSizeUnit)cbxOutputFileSizeUnit.SelectedIndex)
            {
                case FileSizeUnit.Byte:
                    result = long.Parse(tbxOutputFileSize.Text);
                    break;
                case FileSizeUnit.Kilobyte:
                    result = long.Parse(tbxOutputFileSize.Text) * 1024;
                    break;
                case FileSizeUnit.Megabyte:
                    result = long.Parse(tbxOutputFileSize.Text) * 1048576;
                    break;
                case FileSizeUnit.Gigabyte:
                    result = long.Parse(tbxOutputFileSize.Text) * 1073741824;
                    break;

                default:
                    throw new NotImplementedException(nameof(FileSizeUnit));
            }

            return result;
        }

        private bool CanSplit()
        {
            return
                !string.IsNullOrEmpty(lblSourceFile.Text)
                && !string.IsNullOrEmpty(lblOutputDirectory.Text)
                && !string.IsNullOrEmpty(tbxOutputFileSize.Text);
        }

        private void SetProgress(int value)
        {
            if (value < prgFull.Minimum)
            {
                prgFull.Value = prgFull.Minimum;
            }
            else if (value > prgFull.Maximum)
            {
                prgFull.Value = prgFull.Maximum;
            }
            else
            {
                prgFull.Value = value;
            }
        }

        private async Task SplitFile()
        {
            // check source file
            FileInfo sourceFile = new FileInfo(lblSourceFile.Text);
            if (!sourceFile.Exists)
            {
                MessageBox.Show("Die Datei '" + lblSourceFile.Text + "' konnte nicht gefunden werden.", "Stop",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            // check output directory
            if (!Directory.Exists(lblOutputDirectory.Text))
            {
                try
                {
                    Directory.CreateDirectory(lblOutputDirectory.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Das Verzeichnis '" + lblOutputDirectory.Text + "' konnte nicht gefunden werden.", "Stop",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

            // split file
            string outputDirectory = lblOutputDirectory.Text;

            long partLength = FileSizeUnitToByteLength();
            byte[] buffer = new byte[1024 * 1024 * 10]; // 10 mb

            int part = 1;
            int partsCount = (int)Math.Ceiling((float)sourceFile.Length / partLength);

            lblProgress.Text = "Berechne Hash..";

            await Task.Run(() =>
            {
                MD5 md5 = MD5.Create();

                using (Stream stream = sourceFile.OpenRead())
                {
                    byte[] hashData = md5.ComputeHash(stream);
                    string hash = BitConverter.ToString(hashData)
                        .Replace("-", string.Empty).ToLower();

                    File.WriteAllText(Path.Combine(outputDirectory, sourceFile.Name + ".hash"), hash);
                }
            });

            using (FileStream source = sourceFile.OpenRead())
            {
                while (source.Position < source.Length)
                {
                    string outputFileName = sourceFile.Name + ".part" + part;

                    lblProgress.Text = "Schreibe " + outputFileName + "..";

                    long outputFileLength = partLength;
                    if ((source.Length - source.Position) < outputFileLength)
                    {
                        outputFileLength = (source.Length - source.Position);
                    }

                    using (Stream output = File.Create(
                        Path.Combine(outputDirectory, outputFileName)))
                    {
                        while (output.Length < outputFileLength)
                        {
                            long bytesToRead = (outputFileLength - output.Length);
                            if (bytesToRead > buffer.Length)
                            {
                                bytesToRead = buffer.Length;
                            }

                            await source.ReadAsync(buffer, 0, (int)bytesToRead);
                            await output.WriteAsync(buffer, 0, (int)bytesToRead);
                        }
                    }

                    part++;
                    SetProgress((int)Math.Ceiling(((float)(part - 1) / partsCount) * 100));
                }
            }

            lblSourceFile.Text = string.Empty;
            lblOutputDirectory.Text = string.Empty;
        }

        private void CheckStart()
        {
            switch (tabControlMain.SelectedIndex)
            {
                case 0:
                    btnStart.Enabled = CanSplit();
                    break;
                case 1:
                    btnStart.Enabled = CanMerge();
                    break;

                default:
                    throw new NotImplementedException();
            }
        }

        private bool CanMerge()
        {
            return
                !string.IsNullOrEmpty(lblMergeOutputFile.Text)
                && (lbxMergeFiles.Items.Count > 0);
        }

        private async Task MergeFile()
        {
            using (Stream output = File.Create(lblMergeOutputFile.Text))
            {
                byte[] buffer = new byte[1024 * 1024 * 10];
                long fullLength = 0;

                FileInfo[] files = new FileInfo[lbxMergeFiles.Items.Count];
                for (int fileIndex = 0; fileIndex < lbxMergeFiles.Items.Count; fileIndex++)
                {
                    files[fileIndex] = new FileInfo(lbxMergeFiles.Items[fileIndex].ToString());
                    if (!files[fileIndex].Exists)
                    {
                        MessageBox.Show("Die Datei '" + files[fileIndex].FullName + "' konnte nicht gefunden werden.", "Fehler",
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        return;
                    }
                    else
                    {
                        fullLength += files[fileIndex].Length;
                    }
                }

                for (int fileIndex = 0; fileIndex < lbxMergeFiles.Items.Count; fileIndex++)
                {
                    foreach (FileInfo sourceFile in files)
                    {
                        lblProgress.Text = "Schreibe " + sourceFile.Name + "..";

                        using (Stream source = sourceFile.OpenRead())
                        {
                            while (source.Position < source.Length)
                            {
                                SetProgress((int)Math.Ceiling(((float)output.Length / fullLength) * 100));

                                long bytesToRead = (source.Length - source.Position);
                                if (bytesToRead > buffer.Length)
                                {
                                    bytesToRead = buffer.Length;
                                }

                                await source.ReadAsync(buffer, 0, (int)bytesToRead);
                                await output.WriteAsync(buffer, 0, (int)bytesToRead);
                            }
                        }
                    }
                }
            }

            lblMergeOutputFile.Text = string.Empty;
            lbxMergeFiles.Items.Clear();
        }

        private void MergeFilesClear()
        {
            lbxMergeFiles.Items.Clear();
        }

        private void MergeFilesAdd()
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Dateien hinzufügen";
                dialog.Filter = "Alle Dateien|*.*";
                dialog.Multiselect = true;
                dialog.CheckFileExists = true;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    lbxMergeFiles.BeginUpdate();
                    foreach (string file in dialog.FileNames)
                    {
                        lbxMergeFiles.Items.Add(file);
                    }
                    lbxMergeFiles.EndUpdate();
                }
            }
        }

        private void MergeFilesRemoveSelection()
        {
            for (int i = lbxMergeFiles.Items.Count - 1; i >= 0; i--)
            {
                if (lbxMergeFiles.GetSelected(i))
                {
                    lbxMergeFiles.Items.RemoveAt(i);
                }
            }
        }

        private void MergeFilesMoveUp()
        {
            if (lbxMergeFiles.SelectedIndices.Count > 0
                && lbxMergeFiles.SelectedIndices[0] > 0)
            {
                int[] selectedItemsPos = lbxMergeFiles.SelectedIndices.Cast<int>().ToArray();
                object[] selectedItems = lbxMergeFiles.SelectedItems.Cast<object>().ToArray();

                for (int i = 0; i < selectedItemsPos.Length; i++)
                {
                    lbxMergeFiles.Items.RemoveAt(selectedItemsPos[i]);

                    lbxMergeFiles.Items.Insert(selectedItemsPos[i] - 1, selectedItems[i]);
                    lbxMergeFiles.SetSelected(selectedItemsPos[i] - 1, true);
                }
            }
        }

        private void MergeFilesMoveDown()
        {
            if (lbxMergeFiles.SelectedIndices.Count > 0
                && lbxMergeFiles.SelectedIndices[lbxMergeFiles.SelectedIndices.Count - 1] + 1 < lbxMergeFiles.Items.Count)
            {
                int[] selectedItemsPos = lbxMergeFiles.SelectedIndices.Cast<int>().ToArray();
                object[] selectedItems = lbxMergeFiles.SelectedItems.Cast<object>().ToArray();

                for (int i = selectedItemsPos.Length - 1; i >= 0; i--)
                {
                    lbxMergeFiles.Items.RemoveAt(selectedItemsPos[i]);

                    lbxMergeFiles.Items.Insert(selectedItemsPos[i]+1, selectedItems[i]);
                    lbxMergeFiles.SetSelected(selectedItemsPos[i]+1, true);
                }
            }
        }

        #endregion

        #region Control events

        private void btnChooseSourceFile_Click(object sender, EventArgs e)
        {
            ChooseSourceFile();
        }

        private void lblSourceFile_Click(object sender, EventArgs e)
        {
            ChooseSourceFile();
        }

        private void btnChooseOutputDirectory_Click(object sender, EventArgs e)
        {
            ChooseOutputDirectory();
        }

        private void lblOutputDirectory_Click(object sender, EventArgs e)
        {
            ChooseOutputDirectory();
        }

        private void tbxOutputFileSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        private void tbxOutputFileSize_TextChanged(object sender, EventArgs e)
        {
            CheckStart();
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckStart();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            tabControlMain.Enabled = false;
            btnStart.Enabled = false;
            SetProgress(0);
            prgFull.Visible = true;
            lblProgress.Text = "Starte..";

            try
            {
                switch (tabControlMain.SelectedIndex)
                {
                    case 0:
                        if (CanSplit())
                        {
                            await SplitFile();
                        }
                        break;

                    case 1:
                        if (CanMerge())
                        {
                            await MergeFile();
                        }
                        break;

                    default:
                        throw new NotImplementedException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Es ist ein Fehler aufgetreten:\n\n" + ex.Message, "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tabControlMain.Enabled = true;
            btnStart.Enabled = true;
            prgFull.Visible = false;
            lblProgress.Text = string.Empty;

            CheckStart();
        }

        #region Merge

        private void lblMergeOutputFile_Click(object sender, EventArgs e)
        {
            ChooseMergeOutputFile();
        }

        private void btnChooseMergeOutputFile_Click(object sender, EventArgs e)
        {
            ChooseMergeOutputFile();
        }

        private void lbxMergeFiles_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Dateien auswählen";
                dialog.Filter = "Aufgeteilte Dateien|*.part?|Alle Dateien|*.*";
                dialog.CheckFileExists = true;
                dialog.Multiselect = true;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    lbxMergeFiles.BeginUpdate();
                    foreach (string file in dialog.FileNames)
                    {
                        lbxMergeFiles.Items.Add(file);
                    }
                    lbxMergeFiles.EndUpdate();

                    CheckStart();
                }
            }
        }

        private void lbxMergeFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lbxMergeFiles_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                lbxMergeFiles.BeginUpdate();
                foreach (string file in files)
                {
                    lbxMergeFiles.Items.Add(file);
                }
                lbxMergeFiles.EndUpdate();

                CheckStart();
            }
        }

        private void lbxMergeFiles_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                MergeFilesRemoveSelection();
            }
        }

        private void btnClearMergeFiles_Click(object sender, EventArgs e)
        {
            MergeFilesClear();
        }

        private void btnAddMergeFile_Click(object sender, EventArgs e)
        {
            MergeFilesAdd();
        }

        private void btnMergeFileMoveUp_Click(object sender, EventArgs e)
        {
            MergeFilesMoveUp();
        }

        private void btnMergeFileMoveDown_Click(object sender, EventArgs e)
        {
            MergeFilesMoveDown();
        }

        private void btnMergeFileRemove_Click(object sender, EventArgs e)
        {
            MergeFilesRemoveSelection();
        }

        #endregion

        #endregion
    }
}