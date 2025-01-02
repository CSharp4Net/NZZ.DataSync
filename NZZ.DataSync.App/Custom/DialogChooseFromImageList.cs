using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NZZ.DataSync.App.Custom
{
    public partial class DialogChooseFromImageList : Form
    {
        public DialogChooseFromImageList(FormMain parent, ImageList imageList)
        {
            AppForm = parent;

            ChooseImageList = imageList;

            InitializeComponent();
        }

        private FormMain AppForm { get; set; }

        private ImageList ChooseImageList { get; set; }

        public string SelectedImageKey { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            try
            {
                LvImageList.LargeImageList = ChooseImageList;

                foreach (string imgKey in ChooseImageList.Images.Keys)
                {
                    if (!imgKey.Contains("ignore"))
                    {

                        ListViewItem item = LvImageList.Items.Add(imgKey);
                        item.ImageKey = imgKey;

                        if (imgKey == SelectedImageKey)
                            item.Selected = true;
                    }
                }
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedImageKey = LvImageList.SelectedItems[0].ImageKey;

                DialogResult = DialogResult.OK;

                this.Close();
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void BtnAbort_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.Cancel;

                this.Close();
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }
    }
}