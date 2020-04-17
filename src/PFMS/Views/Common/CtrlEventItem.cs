using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Interfaces;
using PFMS.Domain.Models.Events;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PFMS.Views.Common
{
    public partial class CtrlEventItem : MetroUserControl
    {
        private bool _editMode;

        public CtrlEventItem(
            MetroStyleManager styleManager,
            Event @event)
        {
            InitializeComponent();

            StyleManager = styleManager;
            Event = @event;

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

            if (Event is Event)
            {
                UpdateViewData();
            }

            EditMode = false;
        }

        public delegate void EventItemEvent(CtrlEventItem ctrlEventItem);

        public event EventItemEvent Saved;

        public event EventItemEvent Deleted;

        public Event Event { get; }

        public bool EditMode
        {
            get => _editMode;

            set
            {
                EventTitleText.ReadOnly = !value;
                LocationText.ReadOnly = !value;
                NoteText.ReadOnly = !value;
                CmbStartTimeHrs.Enabled = value;
                CmbStartTimeMins.Enabled = value;
                CmbEndTimeHrs.Enabled = value;
                CmbEndTimeMins.Enabled = value;
                _editMode = value;

                if (_editMode)
                {
                    BtnEditSave.Text = "Save";
                    BtnDeleteCancel.Text = "Cancel";
                }
                else
                {
                    BtnEditSave.Text = "Edit";
                    BtnDeleteCancel.Text = "Delete";
                }
            }
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
            CmbStartTimeHrs.SelectedIndex = Math.Max(date.Hour - 1, 0);

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


            var selectedIndex = date.Minute + 1;

            if (selectedIndex >= 60)
            {
                selectedIndex = 0;
            }

            CmbStartTimeMins.DisplayMember = "Value";
            CmbStartTimeMins.ValueMember = "Key";
            CmbStartTimeMins.SelectedIndex = selectedIndex;

            CmbEndTimeMins.DisplayMember = "Value";
            CmbEndTimeMins.ValueMember = "Key";
            CmbEndTimeMins.SelectedIndex = selectedIndex;
        }

        private void UpdateViewData()
        {
            var endTime = Event.DateTime.AddMinutes(Event.Duration);

            EventTitleText.Text = Event.Title;
            LocationText.Text = Event.Location;
            NoteText.Text = Event.Note;
            CmbStartTimeHrs.SelectedIndex = Event.DateTime.Hour - 1;
            CmbStartTimeMins.SelectedIndex = Event.DateTime.Minute - 1;
            CmbEndTimeHrs.SelectedIndex = endTime.Hour - 1;
            CmbEndTimeMins.SelectedIndex = endTime.Minute - 1;
        }

        private void BtnEditSave_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                if (string.IsNullOrEmpty(EventTitleText.Text))
                {
                    ErrorText.Text = "Event Title is required";
                    return;
                }

                if (CmbStartTimeHrs.SelectedIndex == -1 ||
                    CmbStartTimeMins.SelectedIndex == -1)
                {
                    ErrorText.Text = "Start Time is required";
                    return;
                }

                if (CmbEndTimeHrs.SelectedIndex == -1 ||
                    CmbEndTimeMins.SelectedIndex == -1)
                {
                    ErrorText.Text = "End Time is required";
                    return;
                }

                var start = new DateTime(
                    Event.DateTime.Year,
                    Event.DateTime.Month,
                    Event.DateTime.Day,
                    CmbStartTimeHrs.SelectedIndex + 1,
                    CmbStartTimeMins.SelectedIndex + 1,
                    0);

                var end = new DateTime(
                    Event.DateTime.Year,
                    Event.DateTime.Month,
                    Event.DateTime.Day,
                    CmbEndTimeHrs.SelectedIndex + 1,
                    CmbEndTimeMins.SelectedIndex + 1,
                    0);

                if (start >= end)
                {
                    ErrorText.Text = "Invalid Start Time and End Time";
                    return;
                }

                ErrorText.Text = string.Empty;

                Event.Title = EventTitleText.Text;
                Event.Note = NoteText.Text;
                Event.Location = LocationText.Text;
                Event.DateTime = start;
                Event.Duration = (int)Math.Round((end - start).TotalMinutes);

                Saved?.Invoke(this);
                EditMode = false;
            }
            else
            {
                UpdateViewData();

                ErrorText.Text = string.Empty;
                EditMode = true;
            }
        }

        private void BtnDeleteCancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Event.Title))
            {
                Deleted?.Invoke(this);
                return;
            }

            if (EditMode)
            {
                UpdateViewData();

                EditMode = false;
            }
            else
            {
                var result = MetroMessageBox.Show(
                    this,
                    $"Are you sure you want to delete {Event.Title} ?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Deleted?.Invoke(this);
                }
            }
        }
    }
}
