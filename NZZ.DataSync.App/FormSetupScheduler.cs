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
    public partial class FormSetupScheduler : Form
    {
        public FormSetupScheduler(FormMain parent)
        {
            AppForm = parent;

            InitializeComponent();
        }

        private FormMain AppForm { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            try
            {
                ClWeekdays.Items.Add(new WeekdayItem(DayOfWeek.Monday, "Montag"));
                ClWeekdays.Items.Add(new WeekdayItem(DayOfWeek.Tuesday, "Dienstag"));
                ClWeekdays.Items.Add(new WeekdayItem(DayOfWeek.Wednesday, "Mittwoch"));
                ClWeekdays.Items.Add(new WeekdayItem(DayOfWeek.Thursday, "Donnerstag"));
                ClWeekdays.Items.Add(new WeekdayItem(DayOfWeek.Friday, "Freitag"));
                ClWeekdays.Items.Add(new WeekdayItem(DayOfWeek.Saturday, "Samstag"));
                ClWeekdays.Items.Add(new WeekdayItem(DayOfWeek.Sunday, "Sonntag"));

                //ClWeekdays.Items.Cast<List<ListItem>>()
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private class WeekdayItem
        {
            internal WeekdayItem(DayOfWeek name, string text)
            {
                Name = name;
                Text = text;
            }

            public DayOfWeek Name { get; set; }
            public string Text { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}
