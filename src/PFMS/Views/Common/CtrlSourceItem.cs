using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Interfaces;
using PFMS.Domain.Models.Sources;
using System;
using System.Windows.Forms;

namespace PFMS.Views.Common
{
    public partial class CtrlSourceItem : MetroUserControl
    {
        private bool _editMode;

        public CtrlSourceItem(MetroStyleManager styleManager, ISource source)
        {
            Source = source;

            InitializeComponent();

            StyleManager = styleManager;

            foreach (var control in Controls)
            {
                if (control is IMetroControl metroControl)
                {
                    metroControl.StyleManager = styleManager;
                }
            }

            if (Source is ISource)
            {
                TitleText.Text = Source.Title;
                DescriptionText.Text = Source.Description;
            }

            EditMode = false;
            ErrorText.Text = string.Empty;
        }

        public delegate void SourceEvent(CtrlSourceItem ctrlSourceItem);

        public event SourceEvent Saved;

        public event SourceEvent Deleted;

        public ISource Source { get; }

        public bool EditMode
        {
            get => _editMode;

            set
            {
                TitleText.ReadOnly = !value;
                DescriptionText.ReadOnly = !value;
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

        private void BtnEditSave_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                if (string.IsNullOrEmpty(TitleText.Text))
                {
                    ErrorText.Text = "Title is required";
                    return;
                }

                ErrorText.Text = string.Empty;
                Source.Title = TitleText.Text;
                Source.Description = DescriptionText.Text;
                Saved?.Invoke(this);
                EditMode = false;
            }
            else
            {
                ErrorText.Text = string.Empty;
                TitleText.Text = Source.Title;
                DescriptionText.Text = Source.Description;
                EditMode = true;
            }
        }

        private void BtnDeleteCancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Source.Title))
            {
                Deleted?.Invoke(this);
                return;
            }

            if (EditMode)
            {
                TitleText.Text = Source.Title;
                DescriptionText.Text = Source.Description;
                EditMode = false;
            }
            else
            {
                var result = MetroMessageBox.Show(
                    this,
                    $"Are you sure you want to delete {Source.Title} ?",
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
