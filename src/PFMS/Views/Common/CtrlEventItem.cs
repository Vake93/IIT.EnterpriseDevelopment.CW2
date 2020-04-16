using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PFMS.Views.Common
{
    public partial class CtrlEventItem : MetroUserControl
    {
        public CtrlEventItem(MetroStyleManager styleManager)
        {
            InitializeComponent();

            StyleManager = styleManager;

            foreach (var control in Controls)
            {
                if (control is IMetroControl metroControl)
                {
                    metroControl.StyleManager = styleManager;
                }
            }

            ErrorText.Text = string.Empty;

            BindHours();
            BindMinutes();
        }

        private void BindHours()
        {
            var date = DateTime.Now.AddHours(1d);

            CmbStartTimeHrs.DataSource = new BindingSource(
                Enumerable.Range(1, 23)
                    .ToDictionary(x => x, x => x.ToString("D2")), null);

            CmbEndTimeHrs.DataSource = new BindingSource(
                Enumerable.Range(1, 23)
                    .ToDictionary(x => x, x => x.ToString("D2")), null);

            CmbStartTimeHrs.DisplayMember = "Value";
            CmbStartTimeHrs.ValueMember = "Key";
            CmbStartTimeHrs.SelectedIndex = date.Hour - 1;

            CmbEndTimeHrs.DisplayMember = "Value";
            CmbEndTimeHrs.ValueMember = "Key";
            CmbEndTimeHrs.SelectedIndex = date.Hour;
        }

        private void BindMinutes()
        {
            var date = DateTime.Now.AddMinutes(10);

            CmbStartTimeMins.DataSource = new BindingSource(
                Enumerable.Range(1, 59)
                    .ToDictionary(x => x, x => x.ToString("D2")), null);

            CmbEndTimeMins.DataSource = new BindingSource(
                Enumerable.Range(1, 59)
                    .ToDictionary(x => x, x => x.ToString("D2")), null);

            CmbStartTimeMins.DisplayMember = "Value";
            CmbStartTimeMins.ValueMember = "Key";
            CmbStartTimeMins.SelectedIndex = date.Minute + 1;

            CmbEndTimeMins.DisplayMember = "Value";
            CmbEndTimeMins.ValueMember = "Key";
            CmbEndTimeMins.SelectedIndex = date.Minute + 1;
        }
    }
}
