namespace PFMS.Views.Common
{
    partial class CtrlEventItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EventTitle = new MetroFramework.Controls.MetroLabel();
            this.EventTitleText = new MetroFramework.Controls.MetroTextBox();
            this.StartTime = new MetroFramework.Controls.MetroLabel();
            this.CmbStartTimeHrs = new MetroFramework.Controls.MetroComboBox();
            this.EndTime = new MetroFramework.Controls.MetroLabel();
            this.CmbStartTimeMins = new MetroFramework.Controls.MetroComboBox();
            this.CmbEndTimeHrs = new MetroFramework.Controls.MetroComboBox();
            this.CmbEndTimeMins = new MetroFramework.Controls.MetroComboBox();
            this.LocationText = new MetroFramework.Controls.MetroTextBox();
            this.Location = new MetroFramework.Controls.MetroLabel();
            this.NoteText = new MetroFramework.Controls.MetroTextBox();
            this.Note = new MetroFramework.Controls.MetroLabel();
            this.ErrorText = new MetroFramework.Controls.MetroLabel();
            this.BtnEditSave = new MetroFramework.Controls.MetroButton();
            this.BtnDeleteCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // EventTitle
            // 
            this.EventTitle.AutoSize = true;
            this.EventTitle.Location = new System.Drawing.Point(3, 3);
            this.EventTitle.Name = "EventTitle";
            this.EventTitle.Size = new System.Drawing.Size(71, 19);
            this.EventTitle.TabIndex = 1;
            this.EventTitle.Text = "Event Title:";
            // 
            // EventTitleText
            // 
            // 
            // 
            // 
            this.EventTitleText.CustomButton.Image = null;
            this.EventTitleText.CustomButton.Location = new System.Drawing.Point(507, 1);
            this.EventTitleText.CustomButton.Name = "";
            this.EventTitleText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EventTitleText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EventTitleText.CustomButton.TabIndex = 1;
            this.EventTitleText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EventTitleText.CustomButton.UseSelectable = true;
            this.EventTitleText.CustomButton.Visible = false;
            this.EventTitleText.Lines = new string[0];
            this.EventTitleText.Location = new System.Drawing.Point(116, 3);
            this.EventTitleText.MaxLength = 32767;
            this.EventTitleText.Name = "EventTitleText";
            this.EventTitleText.PasswordChar = '\0';
            this.EventTitleText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EventTitleText.SelectedText = "";
            this.EventTitleText.SelectionLength = 0;
            this.EventTitleText.SelectionStart = 0;
            this.EventTitleText.ShortcutsEnabled = true;
            this.EventTitleText.Size = new System.Drawing.Size(529, 23);
            this.EventTitleText.TabIndex = 14;
            this.EventTitleText.UseSelectable = true;
            this.EventTitleText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EventTitleText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // StartTime
            // 
            this.StartTime.AutoSize = true;
            this.StartTime.Location = new System.Drawing.Point(3, 32);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(73, 19);
            this.StartTime.TabIndex = 15;
            this.StartTime.Text = "Start Time:";
            // 
            // CmbStartTimeHrs
            // 
            this.CmbStartTimeHrs.FormattingEnabled = true;
            this.CmbStartTimeHrs.ItemHeight = 23;
            this.CmbStartTimeHrs.Location = new System.Drawing.Point(116, 32);
            this.CmbStartTimeHrs.Name = "CmbStartTimeHrs";
            this.CmbStartTimeHrs.Size = new System.Drawing.Size(104, 29);
            this.CmbStartTimeHrs.TabIndex = 16;
            this.CmbStartTimeHrs.UseSelectable = true;
            // 
            // EndTime
            // 
            this.EndTime.AutoSize = true;
            this.EndTime.Location = new System.Drawing.Point(358, 32);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(67, 19);
            this.EndTime.TabIndex = 17;
            this.EndTime.Text = "End Time:";
            // 
            // CmbStartTimeMins
            // 
            this.CmbStartTimeMins.FormattingEnabled = true;
            this.CmbStartTimeMins.ItemHeight = 23;
            this.CmbStartTimeMins.Location = new System.Drawing.Point(226, 32);
            this.CmbStartTimeMins.Name = "CmbStartTimeMins";
            this.CmbStartTimeMins.Size = new System.Drawing.Size(104, 29);
            this.CmbStartTimeMins.TabIndex = 18;
            this.CmbStartTimeMins.UseSelectable = true;
            // 
            // CmbEndTimeHrs
            // 
            this.CmbEndTimeHrs.FormattingEnabled = true;
            this.CmbEndTimeHrs.ItemHeight = 23;
            this.CmbEndTimeHrs.Location = new System.Drawing.Point(431, 32);
            this.CmbEndTimeHrs.Name = "CmbEndTimeHrs";
            this.CmbEndTimeHrs.Size = new System.Drawing.Size(104, 29);
            this.CmbEndTimeHrs.TabIndex = 19;
            this.CmbEndTimeHrs.UseSelectable = true;
            // 
            // CmbEndTimeMins
            // 
            this.CmbEndTimeMins.FormattingEnabled = true;
            this.CmbEndTimeMins.ItemHeight = 23;
            this.CmbEndTimeMins.Location = new System.Drawing.Point(541, 32);
            this.CmbEndTimeMins.Name = "CmbEndTimeMins";
            this.CmbEndTimeMins.Size = new System.Drawing.Size(104, 29);
            this.CmbEndTimeMins.TabIndex = 20;
            this.CmbEndTimeMins.UseSelectable = true;
            // 
            // LocationText
            // 
            // 
            // 
            // 
            this.LocationText.CustomButton.Image = null;
            this.LocationText.CustomButton.Location = new System.Drawing.Point(431, 1);
            this.LocationText.CustomButton.Name = "";
            this.LocationText.CustomButton.Size = new System.Drawing.Size(97, 97);
            this.LocationText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LocationText.CustomButton.TabIndex = 1;
            this.LocationText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LocationText.CustomButton.UseSelectable = true;
            this.LocationText.CustomButton.Visible = false;
            this.LocationText.Lines = new string[0];
            this.LocationText.Location = new System.Drawing.Point(116, 67);
            this.LocationText.MaxLength = 32767;
            this.LocationText.Multiline = true;
            this.LocationText.Name = "LocationText";
            this.LocationText.PasswordChar = '\0';
            this.LocationText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LocationText.SelectedText = "";
            this.LocationText.SelectionLength = 0;
            this.LocationText.SelectionStart = 0;
            this.LocationText.ShortcutsEnabled = true;
            this.LocationText.Size = new System.Drawing.Size(529, 99);
            this.LocationText.TabIndex = 21;
            this.LocationText.UseSelectable = true;
            this.LocationText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LocationText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Location = new System.Drawing.Point(3, 67);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(61, 19);
            this.Location.TabIndex = 22;
            this.Location.Text = "Location:";
            // 
            // NoteText
            // 
            // 
            // 
            // 
            this.NoteText.CustomButton.Image = null;
            this.NoteText.CustomButton.Location = new System.Drawing.Point(449, 1);
            this.NoteText.CustomButton.Name = "";
            this.NoteText.CustomButton.Size = new System.Drawing.Size(79, 79);
            this.NoteText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoteText.CustomButton.TabIndex = 1;
            this.NoteText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NoteText.CustomButton.UseSelectable = true;
            this.NoteText.CustomButton.Visible = false;
            this.NoteText.Lines = new string[0];
            this.NoteText.Location = new System.Drawing.Point(116, 172);
            this.NoteText.MaxLength = 32767;
            this.NoteText.Multiline = true;
            this.NoteText.Name = "NoteText";
            this.NoteText.PasswordChar = '\0';
            this.NoteText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NoteText.SelectedText = "";
            this.NoteText.SelectionLength = 0;
            this.NoteText.SelectionStart = 0;
            this.NoteText.ShortcutsEnabled = true;
            this.NoteText.Size = new System.Drawing.Size(529, 81);
            this.NoteText.TabIndex = 23;
            this.NoteText.UseSelectable = true;
            this.NoteText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NoteText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Note
            // 
            this.Note.AutoSize = true;
            this.Note.Location = new System.Drawing.Point(3, 172);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(41, 19);
            this.Note.TabIndex = 24;
            this.Note.Text = "Note:";
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorText.Location = new System.Drawing.Point(3, 271);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(65, 19);
            this.ErrorText.TabIndex = 25;
            this.ErrorText.Text = "Error Text";
            this.ErrorText.UseCustomForeColor = true;
            // 
            // BtnEditSave
            // 
            this.BtnEditSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEditSave.Location = new System.Drawing.Point(3, 302);
            this.BtnEditSave.Name = "BtnEditSave";
            this.BtnEditSave.Size = new System.Drawing.Size(75, 23);
            this.BtnEditSave.TabIndex = 28;
            this.BtnEditSave.Text = "Edit";
            this.BtnEditSave.UseSelectable = true;
            // 
            // BtnDeleteCancel
            // 
            this.BtnDeleteCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteCancel.Location = new System.Drawing.Point(552, 302);
            this.BtnDeleteCancel.Name = "BtnDeleteCancel";
            this.BtnDeleteCancel.Size = new System.Drawing.Size(93, 23);
            this.BtnDeleteCancel.TabIndex = 27;
            this.BtnDeleteCancel.Text = "Delete";
            this.BtnDeleteCancel.UseSelectable = true;
            // 
            // CtrlEventItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnEditSave);
            this.Controls.Add(this.BtnDeleteCancel);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.NoteText);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.LocationText);
            this.Controls.Add(this.CmbEndTimeMins);
            this.Controls.Add(this.CmbEndTimeHrs);
            this.Controls.Add(this.CmbStartTimeMins);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.CmbStartTimeHrs);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.EventTitleText);
            this.Controls.Add(this.EventTitle);
            this.Name = "CtrlEventItem";
            this.Size = new System.Drawing.Size(648, 328);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel EventTitle;
        private MetroFramework.Controls.MetroTextBox EventTitleText;
        private MetroFramework.Controls.MetroLabel StartTime;
        private MetroFramework.Controls.MetroComboBox CmbStartTimeHrs;
        private MetroFramework.Controls.MetroLabel EndTime;
        private MetroFramework.Controls.MetroComboBox CmbStartTimeMins;
        private MetroFramework.Controls.MetroComboBox CmbEndTimeHrs;
        private MetroFramework.Controls.MetroComboBox CmbEndTimeMins;
        private MetroFramework.Controls.MetroTextBox LocationText;
        private MetroFramework.Controls.MetroLabel Location;
        private MetroFramework.Controls.MetroTextBox NoteText;
        private MetroFramework.Controls.MetroLabel Note;
        private MetroFramework.Controls.MetroLabel ErrorText;
        private MetroFramework.Controls.MetroButton BtnEditSave;
        private MetroFramework.Controls.MetroButton BtnDeleteCancel;
    }
}
