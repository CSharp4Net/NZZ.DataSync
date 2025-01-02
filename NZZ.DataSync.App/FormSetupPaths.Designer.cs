namespace NZZ.DataSync.App
{
    partial class FormFolderSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFolderSetup));
            this.LvLocalFolder = new System.Windows.Forms.ListView();
            this.ImgListLocalFolder = new System.Windows.Forms.ImageList(this.components);
            this.PnFooter = new System.Windows.Forms.Panel();
            this.BtnAbort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpFolderDetails = new System.Windows.Forms.GroupBox();
            this.CkIgnore = new System.Windows.Forms.CheckBox();
            this.TbSearchPattern = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CkOverwrite = new System.Windows.Forms.CheckBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnTestSync = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TbLastSync = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnChooseNetworkPath = new System.Windows.Forms.Button();
            this.TbNetworkPath = new System.Windows.Forms.TextBox();
            this.BtnChooseImage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PcImage = new System.Windows.Forms.PictureBox();
            this.BtnChoosePath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TbPath = new System.Windows.Forms.TextBox();
            this.TbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BtnRemoveLocalFolder = new System.Windows.Forms.Button();
            this.BtnAddLocalFolder = new System.Windows.Forms.Button();
            this.PnFooter.SuspendLayout();
            this.GrpFolderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LvLocalFolder
            // 
            this.LvLocalFolder.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.LvLocalFolder.AllowDrop = true;
            this.LvLocalFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LvLocalFolder.FullRowSelect = true;
            this.LvLocalFolder.HideSelection = false;
            this.LvLocalFolder.LargeImageList = this.ImgListLocalFolder;
            this.LvLocalFolder.Location = new System.Drawing.Point(12, 31);
            this.LvLocalFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LvLocalFolder.MultiSelect = false;
            this.LvLocalFolder.Name = "LvLocalFolder";
            this.LvLocalFolder.Size = new System.Drawing.Size(501, 589);
            this.LvLocalFolder.TabIndex = 0;
            this.LvLocalFolder.UseCompatibleStateImageBehavior = false;
            this.LvLocalFolder.View = System.Windows.Forms.View.Tile;
            this.LvLocalFolder.SelectedIndexChanged += new System.EventHandler(this.LvLocalFolder_SelectedIndexChanged);
            // 
            // ImgListLocalFolder
            // 
            this.ImgListLocalFolder.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgListLocalFolder.ImageStream")));
            this.ImgListLocalFolder.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgListLocalFolder.Images.SetKeyName(0, "folder");
            this.ImgListLocalFolder.Images.SetKeyName(1, "folder_ignore");
            this.ImgListLocalFolder.Images.SetKeyName(2, "folder-document");
            this.ImgListLocalFolder.Images.SetKeyName(3, "folder-document_ignore");
            this.ImgListLocalFolder.Images.SetKeyName(4, "folder-house");
            this.ImgListLocalFolder.Images.SetKeyName(5, "folder-house_ignore");
            this.ImgListLocalFolder.Images.SetKeyName(6, "folder-music");
            this.ImgListLocalFolder.Images.SetKeyName(7, "folder-music_ignore");
            this.ImgListLocalFolder.Images.SetKeyName(8, "folder-picture");
            this.ImgListLocalFolder.Images.SetKeyName(9, "folder-picture_ignore");
            this.ImgListLocalFolder.Images.SetKeyName(10, "folder-video");
            this.ImgListLocalFolder.Images.SetKeyName(11, "folder-video_ignore");
            this.ImgListLocalFolder.Images.SetKeyName(12, "shared-folder_network");
            this.ImgListLocalFolder.Images.SetKeyName(13, "shared-folder_network_ignore");
            // 
            // PnFooter
            // 
            this.PnFooter.Controls.Add(this.BtnAbort);
            this.PnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnFooter.Location = new System.Drawing.Point(0, 628);
            this.PnFooter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnFooter.Name = "PnFooter";
            this.PnFooter.Size = new System.Drawing.Size(1164, 62);
            this.PnFooter.TabIndex = 2;
            // 
            // BtnAbort
            // 
            this.BtnAbort.BackColor = System.Drawing.Color.Transparent;
            this.BtnAbort.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbort.Location = new System.Drawing.Point(12, 12);
            this.BtnAbort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAbort.Name = "BtnAbort";
            this.BtnAbort.Size = new System.Drawing.Size(93, 37);
            this.BtnAbort.TabIndex = 0;
            this.BtnAbort.Text = "Schließen";
            this.BtnAbort.UseVisualStyleBackColor = false;
            this.BtnAbort.Click += new System.EventHandler(this.BtnAbort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Verzeichnisse";
            // 
            // GrpFolderDetails
            // 
            this.GrpFolderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpFolderDetails.Controls.Add(this.CkIgnore);
            this.GrpFolderDetails.Controls.Add(this.TbSearchPattern);
            this.GrpFolderDetails.Controls.Add(this.label8);
            this.GrpFolderDetails.Controls.Add(this.CkOverwrite);
            this.GrpFolderDetails.Controls.Add(this.BtnSave);
            this.GrpFolderDetails.Controls.Add(this.BtnTestSync);
            this.GrpFolderDetails.Controls.Add(this.label7);
            this.GrpFolderDetails.Controls.Add(this.TbLastSync);
            this.GrpFolderDetails.Controls.Add(this.label6);
            this.GrpFolderDetails.Controls.Add(this.BtnChooseNetworkPath);
            this.GrpFolderDetails.Controls.Add(this.TbNetworkPath);
            this.GrpFolderDetails.Controls.Add(this.BtnChooseImage);
            this.GrpFolderDetails.Controls.Add(this.label5);
            this.GrpFolderDetails.Controls.Add(this.PcImage);
            this.GrpFolderDetails.Controls.Add(this.BtnChoosePath);
            this.GrpFolderDetails.Controls.Add(this.label4);
            this.GrpFolderDetails.Controls.Add(this.TbPath);
            this.GrpFolderDetails.Controls.Add(this.TbName);
            this.GrpFolderDetails.Controls.Add(this.label3);
            this.GrpFolderDetails.Controls.Add(this.TbID);
            this.GrpFolderDetails.Controls.Add(this.label2);
            this.GrpFolderDetails.Location = new System.Drawing.Point(572, 31);
            this.GrpFolderDetails.Name = "GrpFolderDetails";
            this.GrpFolderDetails.Size = new System.Drawing.Size(580, 589);
            this.GrpFolderDetails.TabIndex = 7;
            this.GrpFolderDetails.TabStop = false;
            this.GrpFolderDetails.Text = "Ausgewähltes Verzeichnis";
            // 
            // CkIgnore
            // 
            this.CkIgnore.AutoSize = true;
            this.CkIgnore.Location = new System.Drawing.Point(75, 273);
            this.CkIgnore.Name = "CkIgnore";
            this.CkIgnore.Size = new System.Drawing.Size(190, 20);
            this.CkIgnore.TabIndex = 27;
            this.CkIgnore.Text = "Synchronisation deaktivieren";
            this.MyToolTip.SetToolTip(this.CkIgnore, "Wenn markiert wird das Verzeichnis bei der Synchronisation übersprungen.");
            this.CkIgnore.UseVisualStyleBackColor = true;
            // 
            // TbSearchPattern
            // 
            this.TbSearchPattern.Location = new System.Drawing.Point(75, 244);
            this.TbSearchPattern.Name = "TbSearchPattern";
            this.TbSearchPattern.Size = new System.Drawing.Size(150, 23);
            this.TbSearchPattern.TabIndex = 26;
            this.MyToolTip.SetToolTip(this.TbSearchPattern, "Optional: Ermöglicht die Einschränkung der Synchronisation auf bestimmte Dateityp" +
        "en. Bspw. *.mp3 oder *.mp3|*.mov\"");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Dateitypen";
            // 
            // CkOverwrite
            // 
            this.CkOverwrite.AutoSize = true;
            this.CkOverwrite.Location = new System.Drawing.Point(75, 218);
            this.CkOverwrite.Name = "CkOverwrite";
            this.CkOverwrite.Size = new System.Drawing.Size(225, 20);
            this.CkOverwrite.TabIndex = 24;
            this.CkOverwrite.Text = "Bestehende Dateien überschreiben";
            this.MyToolTip.SetToolTip(this.CkOverwrite, "Wenn markiert werden bestehende Dateien im Backup-Verzeichnis überschrieben. Nur " +
        "sinnvoll bei Dateien deren Inhalt sich ändert.");
            this.CkOverwrite.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.BackColor = System.Drawing.Color.Transparent;
            this.BtnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Image = global::NZZ.DataSync.App.Properties.Resources.floppy_32;
            this.BtnSave.Location = new System.Drawing.Point(449, 542);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(125, 40);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Speichern";
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnTestSync
            // 
            this.BtnTestSync.BackColor = System.Drawing.Color.Transparent;
            this.BtnTestSync.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTestSync.Image = global::NZZ.DataSync.App.Properties.Resources.NormalSync_32;
            this.BtnTestSync.Location = new System.Drawing.Point(75, 300);
            this.BtnTestSync.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnTestSync.Name = "BtnTestSync";
            this.BtnTestSync.Size = new System.Drawing.Size(200, 40);
            this.BtnTestSync.TabIndex = 23;
            this.BtnTestSync.Text = "Synchronisation testen";
            this.BtnTestSync.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTestSync.UseVisualStyleBackColor = false;
            this.BtnTestSync.Click += new System.EventHandler(this.BtnTestSync_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 562);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Letzte Synchronisation";
            // 
            // TbLastSync
            // 
            this.TbLastSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TbLastSync.Location = new System.Drawing.Point(148, 559);
            this.TbLastSync.Name = "TbLastSync";
            this.TbLastSync.ReadOnly = true;
            this.TbLastSync.Size = new System.Drawing.Size(175, 23);
            this.TbLastSync.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Backup";
            // 
            // BtnChooseNetworkPath
            // 
            this.BtnChooseNetworkPath.Location = new System.Drawing.Point(544, 189);
            this.BtnChooseNetworkPath.Name = "BtnChooseNetworkPath";
            this.BtnChooseNetworkPath.Size = new System.Drawing.Size(30, 23);
            this.BtnChooseNetworkPath.TabIndex = 19;
            this.BtnChooseNetworkPath.Text = "...";
            this.BtnChooseNetworkPath.UseVisualStyleBackColor = true;
            this.BtnChooseNetworkPath.Click += new System.EventHandler(this.BtnChooseNetworkPath_Click);
            // 
            // TbNetworkPath
            // 
            this.TbNetworkPath.Location = new System.Drawing.Point(75, 189);
            this.TbNetworkPath.Name = "TbNetworkPath";
            this.TbNetworkPath.ReadOnly = true;
            this.TbNetworkPath.Size = new System.Drawing.Size(463, 23);
            this.TbNetworkPath.TabIndex = 18;
            this.MyToolTip.SetToolTip(this.TbNetworkPath, "Backup-Verzeichnis in welches die zu kopierenden Daten abgelegt werden.");
            // 
            // BtnChooseImage
            // 
            this.BtnChooseImage.Location = new System.Drawing.Point(145, 160);
            this.BtnChooseImage.Name = "BtnChooseImage";
            this.BtnChooseImage.Size = new System.Drawing.Size(30, 23);
            this.BtnChooseImage.TabIndex = 17;
            this.BtnChooseImage.Text = "...";
            this.BtnChooseImage.UseVisualStyleBackColor = true;
            this.BtnChooseImage.Click += new System.EventHandler(this.BtnChooseImage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Bild";
            // 
            // PcImage
            // 
            this.PcImage.Location = new System.Drawing.Point(75, 119);
            this.PcImage.Name = "PcImage";
            this.PcImage.Size = new System.Drawing.Size(64, 64);
            this.PcImage.TabIndex = 15;
            this.PcImage.TabStop = false;
            // 
            // BtnChoosePath
            // 
            this.BtnChoosePath.Location = new System.Drawing.Point(544, 90);
            this.BtnChoosePath.Name = "BtnChoosePath";
            this.BtnChoosePath.Size = new System.Drawing.Size(30, 23);
            this.BtnChoosePath.TabIndex = 14;
            this.BtnChoosePath.Text = "...";
            this.BtnChoosePath.UseVisualStyleBackColor = true;
            this.BtnChoosePath.Click += new System.EventHandler(this.BtnChoosePath_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pfad";
            // 
            // TbPath
            // 
            this.TbPath.Location = new System.Drawing.Point(75, 90);
            this.TbPath.Name = "TbPath";
            this.TbPath.ReadOnly = true;
            this.TbPath.Size = new System.Drawing.Size(463, 23);
            this.TbPath.TabIndex = 12;
            this.MyToolTip.SetToolTip(this.TbPath, "Quellverzeichnis, welches die zu kopierenden Daten enthält.");
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(75, 61);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(150, 23);
            this.TbName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            // 
            // TbID
            // 
            this.TbID.Location = new System.Drawing.Point(75, 32);
            this.TbID.Name = "TbID";
            this.TbID.ReadOnly = true;
            this.TbID.Size = new System.Drawing.Size(50, 23);
            this.TbID.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // MyToolTip
            // 
            this.MyToolTip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // BtnRemoveLocalFolder
            // 
            this.BtnRemoveLocalFolder.Image = global::NZZ.DataSync.App.Properties.Resources.sign_error_32;
            this.BtnRemoveLocalFolder.Location = new System.Drawing.Point(519, 88);
            this.BtnRemoveLocalFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnRemoveLocalFolder.Name = "BtnRemoveLocalFolder";
            this.BtnRemoveLocalFolder.Size = new System.Drawing.Size(47, 49);
            this.BtnRemoveLocalFolder.TabIndex = 6;
            this.BtnRemoveLocalFolder.UseVisualStyleBackColor = true;
            this.BtnRemoveLocalFolder.Click += new System.EventHandler(this.BtnRemoveLocalFolder_Click);
            // 
            // BtnAddLocalFolder
            // 
            this.BtnAddLocalFolder.Image = global::NZZ.DataSync.App.Properties.Resources.sign_add_32;
            this.BtnAddLocalFolder.Location = new System.Drawing.Point(519, 31);
            this.BtnAddLocalFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAddLocalFolder.Name = "BtnAddLocalFolder";
            this.BtnAddLocalFolder.Size = new System.Drawing.Size(47, 49);
            this.BtnAddLocalFolder.TabIndex = 3;
            this.BtnAddLocalFolder.UseVisualStyleBackColor = true;
            this.BtnAddLocalFolder.Click += new System.EventHandler(this.BtnAddLocalFolder_Click);
            // 
            // FormFolderSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 690);
            this.Controls.Add(this.GrpFolderDetails);
            this.Controls.Add(this.BtnRemoveLocalFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAddLocalFolder);
            this.Controls.Add(this.PnFooter);
            this.Controls.Add(this.LvLocalFolder);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormFolderSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verzeichnisse bearbeiten";
            this.PnFooter.ResumeLayout(false);
            this.GrpFolderDetails.ResumeLayout(false);
            this.GrpFolderDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LvLocalFolder;
        private System.Windows.Forms.Panel PnFooter;
        private System.Windows.Forms.Button BtnAbort;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ImageList ImgListLocalFolder;
        private System.Windows.Forms.Button BtnAddLocalFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRemoveLocalFolder;
        private System.Windows.Forms.GroupBox GrpFolderDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbPath;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbID;
        private System.Windows.Forms.Button BtnChoosePath;
        private System.Windows.Forms.TextBox TbNetworkPath;
        private System.Windows.Forms.Button BtnChooseImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox PcImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbLastSync;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnChooseNetworkPath;
        private System.Windows.Forms.Button BtnTestSync;
        private System.Windows.Forms.CheckBox CkOverwrite;
        private System.Windows.Forms.ToolTip MyToolTip;
        private System.Windows.Forms.TextBox TbSearchPattern;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox CkIgnore;
    }
}