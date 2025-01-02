namespace NZZ.DataSync.App.Custom
{
    partial class DialogChooseFromImageList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogChooseFromImageList));
            this.PnFooter = new System.Windows.Forms.Panel();
            this.BtnAbort = new System.Windows.Forms.Button();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.LvImageList = new System.Windows.Forms.ListView();
            this.PnFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnFooter
            // 
            this.PnFooter.Controls.Add(this.BtnSubmit);
            this.PnFooter.Controls.Add(this.BtnAbort);
            this.PnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnFooter.Location = new System.Drawing.Point(0, 299);
            this.PnFooter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnFooter.Name = "PnFooter";
            this.PnFooter.Size = new System.Drawing.Size(584, 62);
            this.PnFooter.TabIndex = 3;
            // 
            // BtnAbort
            // 
            this.BtnAbort.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbort.Location = new System.Drawing.Point(12, 12);
            this.BtnAbort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAbort.Name = "BtnAbort";
            this.BtnAbort.Size = new System.Drawing.Size(93, 37);
            this.BtnAbort.TabIndex = 0;
            this.BtnAbort.Text = "Abbrechen";
            this.BtnAbort.UseVisualStyleBackColor = true;
            this.BtnAbort.Click += new System.EventHandler(this.BtnAbort_Click);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSubmit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Location = new System.Drawing.Point(479, 12);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(93, 37);
            this.BtnSubmit.TabIndex = 1;
            this.BtnSubmit.Text = "OK";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // LvImageList
            // 
            this.LvImageList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.LvImageList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LvImageList.HideSelection = false;
            this.LvImageList.Location = new System.Drawing.Point(12, 12);
            this.LvImageList.MultiSelect = false;
            this.LvImageList.Name = "LvImageList";
            this.LvImageList.Size = new System.Drawing.Size(560, 280);
            this.LvImageList.TabIndex = 7;
            this.LvImageList.UseCompatibleStateImageBehavior = false;
            // 
            // DialogChooseFromImageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.LvImageList);
            this.Controls.Add(this.PnFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogChooseFromImageList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bild auswählen";
            this.TopMost = true;
            this.PnFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnFooter;
        private System.Windows.Forms.Button BtnAbort;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.ListView LvImageList;
    }
}