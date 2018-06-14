namespace FileSplit
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblSourceFileLabel = new System.Windows.Forms.Label();
            this.btnChooseSourceFile = new System.Windows.Forms.Button();
            this.lblSourceFile = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.prgFull = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblOutputDirectoryLabel = new System.Windows.Forms.Label();
            this.btnChooseOutputDirectory = new System.Windows.Forms.Button();
            this.lblOutputDirectory = new System.Windows.Forms.Label();
            this.cbxOutputFileSizeUnit = new System.Windows.Forms.ComboBox();
            this.tbxOutputFileSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblMergeOutputFile = new System.Windows.Forms.Label();
            this.btnChooseMergeOutputFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMergeFiles = new System.Windows.Forms.Label();
            this.lbxMergeFiles = new System.Windows.Forms.ListBox();
            this.btnMergeFileRemove = new System.Windows.Forms.Button();
            this.btnMergeFileMoveDown = new System.Windows.Forms.Button();
            this.btnMergeFileMoveUp = new System.Windows.Forms.Button();
            this.btnClearMergeFiles = new System.Windows.Forms.Button();
            this.btnAddMergeFile = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSourceFileLabel
            // 
            this.lblSourceFileLabel.AutoSize = true;
            this.lblSourceFileLabel.Location = new System.Drawing.Point(3, 7);
            this.lblSourceFileLabel.Name = "lblSourceFileLabel";
            this.lblSourceFileLabel.Size = new System.Drawing.Size(54, 13);
            this.lblSourceFileLabel.TabIndex = 0;
            this.lblSourceFileLabel.Text = "Quelldatei";
            // 
            // btnChooseSourceFile
            // 
            this.btnChooseSourceFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseSourceFile.Location = new System.Drawing.Point(417, 22);
            this.btnChooseSourceFile.Name = "btnChooseSourceFile";
            this.btnChooseSourceFile.Size = new System.Drawing.Size(50, 22);
            this.btnChooseSourceFile.TabIndex = 2;
            this.btnChooseSourceFile.Text = "...";
            this.btnChooseSourceFile.Click += new System.EventHandler(this.btnChooseSourceFile_Click);
            // 
            // lblSourceFile
            // 
            this.lblSourceFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSourceFile.AutoEllipsis = true;
            this.lblSourceFile.BackColor = System.Drawing.SystemColors.Control;
            this.lblSourceFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSourceFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSourceFile.Location = new System.Drawing.Point(6, 22);
            this.lblSourceFile.Name = "lblSourceFile";
            this.lblSourceFile.Padding = new System.Windows.Forms.Padding(3);
            this.lblSourceFile.Size = new System.Drawing.Size(405, 22);
            this.lblSourceFile.TabIndex = 1;
            this.lblSourceFile.Text = "{SourceFile}";
            this.lblSourceFile.Click += new System.EventHandler(this.lblSourceFile_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(412, 340);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 28);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // prgFull
            // 
            this.prgFull.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgFull.Location = new System.Drawing.Point(22, 292);
            this.prgFull.Name = "prgFull";
            this.prgFull.Size = new System.Drawing.Size(461, 12);
            this.prgFull.TabIndex = 7;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgress.Location = new System.Drawing.Point(19, 307);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(464, 14);
            this.lblProgress.TabIndex = 6;
            this.lblProgress.Text = "{Progress}";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutputDirectoryLabel
            // 
            this.lblOutputDirectoryLabel.AutoSize = true;
            this.lblOutputDirectoryLabel.Location = new System.Drawing.Point(3, 56);
            this.lblOutputDirectoryLabel.Name = "lblOutputDirectoryLabel";
            this.lblOutputDirectoryLabel.Size = new System.Drawing.Size(106, 13);
            this.lblOutputDirectoryLabel.TabIndex = 3;
            this.lblOutputDirectoryLabel.Text = "Ausgabe Verzeichnis";
            // 
            // btnChooseOutputDirectory
            // 
            this.btnChooseOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseOutputDirectory.Location = new System.Drawing.Point(417, 71);
            this.btnChooseOutputDirectory.Name = "btnChooseOutputDirectory";
            this.btnChooseOutputDirectory.Size = new System.Drawing.Size(50, 22);
            this.btnChooseOutputDirectory.TabIndex = 5;
            this.btnChooseOutputDirectory.Text = "...";
            this.btnChooseOutputDirectory.Click += new System.EventHandler(this.btnChooseOutputDirectory_Click);
            // 
            // lblOutputDirectory
            // 
            this.lblOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutputDirectory.AutoEllipsis = true;
            this.lblOutputDirectory.BackColor = System.Drawing.SystemColors.Control;
            this.lblOutputDirectory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutputDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOutputDirectory.Location = new System.Drawing.Point(6, 71);
            this.lblOutputDirectory.Name = "lblOutputDirectory";
            this.lblOutputDirectory.Padding = new System.Windows.Forms.Padding(3);
            this.lblOutputDirectory.Size = new System.Drawing.Size(405, 22);
            this.lblOutputDirectory.TabIndex = 4;
            this.lblOutputDirectory.Text = "{SourceFile}";
            this.lblOutputDirectory.Click += new System.EventHandler(this.lblOutputDirectory_Click);
            // 
            // cbxOutputFileSizeUnit
            // 
            this.cbxOutputFileSizeUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxOutputFileSizeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOutputFileSizeUnit.FormattingEnabled = true;
            this.cbxOutputFileSizeUnit.IntegralHeight = false;
            this.cbxOutputFileSizeUnit.Location = new System.Drawing.Point(349, 120);
            this.cbxOutputFileSizeUnit.Name = "cbxOutputFileSizeUnit";
            this.cbxOutputFileSizeUnit.Size = new System.Drawing.Size(118, 21);
            this.cbxOutputFileSizeUnit.TabIndex = 9;
            // 
            // tbxOutputFileSize
            // 
            this.tbxOutputFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxOutputFileSize.Location = new System.Drawing.Point(7, 120);
            this.tbxOutputFileSize.MaxLength = 5;
            this.tbxOutputFileSize.Multiline = true;
            this.tbxOutputFileSize.Name = "tbxOutputFileSize";
            this.tbxOutputFileSize.Size = new System.Drawing.Size(336, 21);
            this.tbxOutputFileSize.TabIndex = 10;
            this.tbxOutputFileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxOutputFileSize.TextChanged += new System.EventHandler(this.tbxOutputFileSize_TextChanged);
            this.tbxOutputFileSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxOutputFileSize_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dateigröße";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(480, 276);
            this.tabControlMain.TabIndex = 11;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.lblSourceFile);
            this.tabPage1.Controls.Add(this.tbxOutputFileSize);
            this.tabPage1.Controls.Add(this.cbxOutputFileSizeUnit);
            this.tabPage1.Controls.Add(this.lblSourceFileLabel);
            this.tabPage1.Controls.Add(this.btnChooseSourceFile);
            this.tabPage1.Controls.Add(this.lblOutputDirectory);
            this.tabPage1.Controls.Add(this.lblOutputDirectoryLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnChooseOutputDirectory);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aufteilen";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnMergeFileRemove);
            this.tabPage2.Controls.Add(this.btnMergeFileMoveDown);
            this.tabPage2.Controls.Add(this.btnMergeFileMoveUp);
            this.tabPage2.Controls.Add(this.btnClearMergeFiles);
            this.tabPage2.Controls.Add(this.btnAddMergeFile);
            this.tabPage2.Controls.Add(this.lblMergeOutputFile);
            this.tabPage2.Controls.Add(this.btnChooseMergeOutputFile);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lblMergeFiles);
            this.tabPage2.Controls.Add(this.lbxMergeFiles);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zusammenführen";
            // 
            // lblMergeOutputFile
            // 
            this.lblMergeOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMergeOutputFile.AutoEllipsis = true;
            this.lblMergeOutputFile.BackColor = System.Drawing.SystemColors.Control;
            this.lblMergeOutputFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMergeOutputFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMergeOutputFile.Location = new System.Drawing.Point(6, 22);
            this.lblMergeOutputFile.Name = "lblMergeOutputFile";
            this.lblMergeOutputFile.Padding = new System.Windows.Forms.Padding(3);
            this.lblMergeOutputFile.Size = new System.Drawing.Size(405, 22);
            this.lblMergeOutputFile.TabIndex = 3;
            this.lblMergeOutputFile.Click += new System.EventHandler(this.lblMergeOutputFile_Click);
            // 
            // btnChooseMergeOutputFile
            // 
            this.btnChooseMergeOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseMergeOutputFile.Location = new System.Drawing.Point(417, 22);
            this.btnChooseMergeOutputFile.Name = "btnChooseMergeOutputFile";
            this.btnChooseMergeOutputFile.Size = new System.Drawing.Size(50, 22);
            this.btnChooseMergeOutputFile.TabIndex = 4;
            this.btnChooseMergeOutputFile.Text = "...";
            this.btnChooseMergeOutputFile.Click += new System.EventHandler(this.btnChooseMergeOutputFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dateien";
            // 
            // lblMergeFiles
            // 
            this.lblMergeFiles.AutoSize = true;
            this.lblMergeFiles.Location = new System.Drawing.Point(3, 7);
            this.lblMergeFiles.Name = "lblMergeFiles";
            this.lblMergeFiles.Size = new System.Drawing.Size(77, 13);
            this.lblMergeFiles.TabIndex = 1;
            this.lblMergeFiles.Text = "Ausgabe Datei";
            // 
            // lbxMergeFiles
            // 
            this.lbxMergeFiles.AllowDrop = true;
            this.lbxMergeFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxMergeFiles.FormattingEnabled = true;
            this.lbxMergeFiles.IntegralHeight = false;
            this.lbxMergeFiles.Location = new System.Drawing.Point(6, 68);
            this.lbxMergeFiles.Name = "lbxMergeFiles";
            this.lbxMergeFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxMergeFiles.Size = new System.Drawing.Size(426, 173);
            this.lbxMergeFiles.TabIndex = 0;
            this.lbxMergeFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbxMergeFiles_DragDrop);
            this.lbxMergeFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbxMergeFiles_DragEnter);
            this.lbxMergeFiles.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbxMergeFiles_KeyUp);
            // 
            // btnMergeFileRemove
            // 
            this.btnMergeFileRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMergeFileRemove.Image = global::FileSplit.Properties.Resources.FilesRemove;
            this.btnMergeFileRemove.Location = new System.Drawing.Point(438, 213);
            this.btnMergeFileRemove.Name = "btnMergeFileRemove";
            this.btnMergeFileRemove.Size = new System.Drawing.Size(28, 28);
            this.btnMergeFileRemove.TabIndex = 5;
            this.btnMergeFileRemove.UseVisualStyleBackColor = true;
            this.btnMergeFileRemove.Click += new System.EventHandler(this.btnMergeFileRemove_Click);
            // 
            // btnMergeFileMoveDown
            // 
            this.btnMergeFileMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMergeFileMoveDown.Image = global::FileSplit.Properties.Resources.FilesDown;
            this.btnMergeFileMoveDown.Location = new System.Drawing.Point(438, 174);
            this.btnMergeFileMoveDown.Name = "btnMergeFileMoveDown";
            this.btnMergeFileMoveDown.Size = new System.Drawing.Size(28, 28);
            this.btnMergeFileMoveDown.TabIndex = 5;
            this.btnMergeFileMoveDown.UseVisualStyleBackColor = true;
            this.btnMergeFileMoveDown.Click += new System.EventHandler(this.btnMergeFileMoveDown_Click);
            // 
            // btnMergeFileMoveUp
            // 
            this.btnMergeFileMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMergeFileMoveUp.Image = global::FileSplit.Properties.Resources.FilesUp;
            this.btnMergeFileMoveUp.Location = new System.Drawing.Point(438, 143);
            this.btnMergeFileMoveUp.Name = "btnMergeFileMoveUp";
            this.btnMergeFileMoveUp.Size = new System.Drawing.Size(28, 28);
            this.btnMergeFileMoveUp.TabIndex = 5;
            this.btnMergeFileMoveUp.UseVisualStyleBackColor = true;
            this.btnMergeFileMoveUp.Click += new System.EventHandler(this.btnMergeFileMoveUp_Click);
            // 
            // btnClearMergeFiles
            // 
            this.btnClearMergeFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearMergeFiles.Image = global::FileSplit.Properties.Resources.FilesClear;
            this.btnClearMergeFiles.Location = new System.Drawing.Point(438, 68);
            this.btnClearMergeFiles.Name = "btnClearMergeFiles";
            this.btnClearMergeFiles.Size = new System.Drawing.Size(28, 28);
            this.btnClearMergeFiles.TabIndex = 5;
            this.btnClearMergeFiles.UseVisualStyleBackColor = true;
            this.btnClearMergeFiles.Click += new System.EventHandler(this.btnClearMergeFiles_Click);
            // 
            // btnAddMergeFile
            // 
            this.btnAddMergeFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMergeFile.Image = global::FileSplit.Properties.Resources.FilesAdd;
            this.btnAddMergeFile.Location = new System.Drawing.Point(438, 104);
            this.btnAddMergeFile.Name = "btnAddMergeFile";
            this.btnAddMergeFile.Size = new System.Drawing.Size(28, 28);
            this.btnAddMergeFile.TabIndex = 5;
            this.btnAddMergeFile.UseVisualStyleBackColor = true;
            this.btnAddMergeFile.Click += new System.EventHandler(this.btnAddMergeFile_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 380);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.prgFull);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 420);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileSplit";
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSourceFileLabel;
        private System.Windows.Forms.Button btnChooseSourceFile;
        private System.Windows.Forms.Label lblSourceFile;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar prgFull;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblOutputDirectoryLabel;
        private System.Windows.Forms.Button btnChooseOutputDirectory;
        private System.Windows.Forms.Label lblOutputDirectory;
        private System.Windows.Forms.ComboBox cbxOutputFileSizeUnit;
        private System.Windows.Forms.TextBox tbxOutputFileSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbxMergeFiles;
        private System.Windows.Forms.Label lblMergeFiles;
        private System.Windows.Forms.Label lblMergeOutputFile;
        private System.Windows.Forms.Button btnChooseMergeOutputFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMergeFileRemove;
        private System.Windows.Forms.Button btnMergeFileMoveDown;
        private System.Windows.Forms.Button btnMergeFileMoveUp;
        private System.Windows.Forms.Button btnClearMergeFiles;
        private System.Windows.Forms.Button btnAddMergeFile;
    }
}

