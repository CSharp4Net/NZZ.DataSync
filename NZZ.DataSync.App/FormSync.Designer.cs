namespace NZZ.DataSync.App
{
    partial class FormSync
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSync));
            this.PnFooter = new System.Windows.Forms.Panel();
            this.BtnStopProcess = new System.Windows.Forms.Button();
            this.BtnStartProgress = new System.Windows.Forms.Button();
            this.BtnAbort = new System.Windows.Forms.Button();
            this.PbFolderProgress = new System.Windows.Forms.ProgressBar();
            this.PbFileProgress = new System.Windows.Forms.ProgressBar();
            this.LbFolderCount = new System.Windows.Forms.Label();
            this.LbFileCount = new System.Windows.Forms.Label();
            this.TvSyncProtocol = new System.Windows.Forms.TreeView();
            this.ImgListForTree = new System.Windows.Forms.ImageList(this.components);
            this.PnFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnFooter
            // 
            this.PnFooter.Controls.Add(this.BtnStopProcess);
            this.PnFooter.Controls.Add(this.BtnStartProgress);
            this.PnFooter.Controls.Add(this.BtnAbort);
            this.PnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnFooter.Location = new System.Drawing.Point(0, 699);
            this.PnFooter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnFooter.Name = "PnFooter";
            this.PnFooter.Size = new System.Drawing.Size(984, 62);
            this.PnFooter.TabIndex = 5;
            // 
            // BtnStopProcess
            // 
            this.BtnStopProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStopProcess.BackColor = System.Drawing.Color.Transparent;
            this.BtnStopProcess.Enabled = false;
            this.BtnStopProcess.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStopProcess.Location = new System.Drawing.Point(780, 12);
            this.BtnStopProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnStopProcess.Name = "BtnStopProcess";
            this.BtnStopProcess.Size = new System.Drawing.Size(93, 37);
            this.BtnStopProcess.TabIndex = 2;
            this.BtnStopProcess.Text = "Stopp";
            this.BtnStopProcess.UseVisualStyleBackColor = false;
            this.BtnStopProcess.Click += new System.EventHandler(this.BtnStopProcess_Click);
            // 
            // BtnStartProgress
            // 
            this.BtnStartProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStartProgress.BackColor = System.Drawing.Color.Transparent;
            this.BtnStartProgress.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStartProgress.Location = new System.Drawing.Point(879, 12);
            this.BtnStartProgress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnStartProgress.Name = "BtnStartProgress";
            this.BtnStartProgress.Size = new System.Drawing.Size(93, 37);
            this.BtnStartProgress.TabIndex = 1;
            this.BtnStartProgress.Text = "Start";
            this.BtnStartProgress.UseVisualStyleBackColor = false;
            this.BtnStartProgress.Click += new System.EventHandler(this.BtnStartProgress_Click);
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
            // PbFolderProgress
            // 
            this.PbFolderProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbFolderProgress.Location = new System.Drawing.Point(178, 661);
            this.PbFolderProgress.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.PbFolderProgress.Name = "PbFolderProgress";
            this.PbFolderProgress.Size = new System.Drawing.Size(794, 16);
            this.PbFolderProgress.TabIndex = 6;
            // 
            // PbFileProgress
            // 
            this.PbFileProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbFileProgress.Location = new System.Drawing.Point(178, 676);
            this.PbFileProgress.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.PbFileProgress.Name = "PbFileProgress";
            this.PbFileProgress.Size = new System.Drawing.Size(794, 16);
            this.PbFileProgress.TabIndex = 7;
            // 
            // LbFolderCount
            // 
            this.LbFolderCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LbFolderCount.AutoSize = true;
            this.LbFolderCount.Location = new System.Drawing.Point(12, 661);
            this.LbFolderCount.Name = "LbFolderCount";
            this.LbFolderCount.Size = new System.Drawing.Size(89, 16);
            this.LbFolderCount.TabIndex = 8;
            this.LbFolderCount.Tag = "Verzeichnis {0} von {1}";
            this.LbFolderCount.Text = "Verzeichnis ...";
            // 
            // LbFileCount
            // 
            this.LbFileCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LbFileCount.AutoSize = true;
            this.LbFileCount.Location = new System.Drawing.Point(12, 676);
            this.LbFileCount.Name = "LbFileCount";
            this.LbFileCount.Size = new System.Drawing.Size(53, 16);
            this.LbFileCount.TabIndex = 9;
            this.LbFileCount.Tag = "Datei {0} von {1}";
            this.LbFileCount.Text = "Datei ...";
            // 
            // TvSyncProtocol
            // 
            this.TvSyncProtocol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TvSyncProtocol.ImageIndex = 0;
            this.TvSyncProtocol.ImageList = this.ImgListForTree;
            this.TvSyncProtocol.Location = new System.Drawing.Point(12, 12);
            this.TvSyncProtocol.Name = "TvSyncProtocol";
            this.TvSyncProtocol.SelectedImageIndex = 0;
            this.TvSyncProtocol.Size = new System.Drawing.Size(960, 643);
            this.TvSyncProtocol.TabIndex = 10;
            // 
            // ImgListForTree
            // 
            this.ImgListForTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgListForTree.ImageStream")));
            this.ImgListForTree.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgListForTree.Images.SetKeyName(0, "folder");
            this.ImgListForTree.Images.SetKeyName(1, "folder_ignore");
            this.ImgListForTree.Images.SetKeyName(2, "folder-document");
            this.ImgListForTree.Images.SetKeyName(3, "folder-document_ignore");
            this.ImgListForTree.Images.SetKeyName(4, "folder-house");
            this.ImgListForTree.Images.SetKeyName(5, "folder-house_ignore");
            this.ImgListForTree.Images.SetKeyName(6, "folder-music");
            this.ImgListForTree.Images.SetKeyName(7, "folder-music_ignore");
            this.ImgListForTree.Images.SetKeyName(8, "folder-picture");
            this.ImgListForTree.Images.SetKeyName(9, "folder-picture_ignore");
            this.ImgListForTree.Images.SetKeyName(10, "folder-video");
            this.ImgListForTree.Images.SetKeyName(11, "folder-video_ignore");
            this.ImgListForTree.Images.SetKeyName(12, "shared-folder_network");
            this.ImgListForTree.Images.SetKeyName(13, "shared-folder_network_ignore");
            this.ImgListForTree.Images.SetKeyName(14, "Error");
            this.ImgListForTree.Images.SetKeyName(15, "Succeed");
            this.ImgListForTree.Images.SetKeyName(16, "Warning");
            this.ImgListForTree.Images.SetKeyName(17, "Info");
            // 
            // FormSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.TvSyncProtocol);
            this.Controls.Add(this.LbFileCount);
            this.Controls.Add(this.LbFolderCount);
            this.Controls.Add(this.PbFileProgress);
            this.Controls.Add(this.PbFolderProgress);
            this.Controls.Add(this.PnFooter);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSync";
            this.Text = "Synchronisation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSync_FormClosing);
            this.PnFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PnFooter;
        private System.Windows.Forms.Button BtnAbort;
        private System.Windows.Forms.Button BtnStartProgress;
        private System.Windows.Forms.ProgressBar PbFolderProgress;
        private System.Windows.Forms.ProgressBar PbFileProgress;
        private System.Windows.Forms.Label LbFolderCount;
        private System.Windows.Forms.Label LbFileCount;
        private System.Windows.Forms.Button BtnStopProcess;
        private System.Windows.Forms.TreeView TvSyncProtocol;
        private System.Windows.Forms.ImageList ImgListForTree;
    }
}