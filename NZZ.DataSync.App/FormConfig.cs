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

namespace NZZ.DataSync.App
{
    public partial class FormConfig : Form
    {
        public FormConfig(FormMain parent)
        {
            AppForm = parent;

            InitializeComponent();
        }

        private FormMain AppForm { get; set; }

        private bool ChangesMade = false;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            try
            {
                CkComputeMD5.Checked = AppForm.Database.AppConfig.ComputeMD5;

                ChangesMade = false;
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                AppForm.Database.AppConfig.ComputeMD5 = CkComputeMD5.Checked;

                Logic.Database.Save(AppForm.DbFileName, AppForm.Database);

                ChangesMade = false;
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
                this.Close();
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void Control_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ChangesMade = true;
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void FormConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (ChangesMade)
                {
                    if (MessageBox.Show("Nicht gespeicherte Änderungen verwerfen?", "Achtung", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }
    }
}
