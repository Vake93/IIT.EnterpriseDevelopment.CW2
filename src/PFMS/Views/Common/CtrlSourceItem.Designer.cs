namespace PFMS.Views.Common
{
    partial class CtrlSourceItem
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
            this.MetroPanel = new MetroFramework.Controls.MetroPanel();
            this.ErrorText = new MetroFramework.Controls.MetroLabel();
            this.BtnEditSave = new MetroFramework.Controls.MetroButton();
            this.BtnDeleteCancel = new MetroFramework.Controls.MetroButton();
            this.Description = new MetroFramework.Controls.MetroLabel();
            this.DescriptionText = new MetroFramework.Controls.MetroTextBox();
            this.TitleText = new MetroFramework.Controls.MetroTextBox();
            this.Title = new MetroFramework.Controls.MetroLabel();
            this.MetroPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MetroPanel
            // 
            this.MetroPanel.Controls.Add(this.ErrorText);
            this.MetroPanel.Controls.Add(this.BtnEditSave);
            this.MetroPanel.Controls.Add(this.BtnDeleteCancel);
            this.MetroPanel.Controls.Add(this.Description);
            this.MetroPanel.Controls.Add(this.DescriptionText);
            this.MetroPanel.Controls.Add(this.TitleText);
            this.MetroPanel.Controls.Add(this.Title);
            this.MetroPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MetroPanel.HorizontalScrollbarBarColor = true;
            this.MetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.MetroPanel.HorizontalScrollbarSize = 10;
            this.MetroPanel.Location = new System.Drawing.Point(0, 0);
            this.MetroPanel.Name = "MetroPanel";
            this.MetroPanel.Size = new System.Drawing.Size(570, 193);
            this.MetroPanel.TabIndex = 0;
            this.MetroPanel.VerticalScrollbarBarColor = true;
            this.MetroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.MetroPanel.VerticalScrollbarSize = 10;
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorText.Location = new System.Drawing.Point(18, 138);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(65, 19);
            this.ErrorText.TabIndex = 8;
            this.ErrorText.Text = "Error Text";
            this.ErrorText.UseCustomForeColor = true;
            // 
            // BtnEditSave
            // 
            this.BtnEditSave.Location = new System.Drawing.Point(18, 167);
            this.BtnEditSave.Name = "BtnEditSave";
            this.BtnEditSave.Size = new System.Drawing.Size(75, 23);
            this.BtnEditSave.TabIndex = 7;
            this.BtnEditSave.Text = "Edit";
            this.BtnEditSave.UseSelectable = true;
            this.BtnEditSave.Click += new System.EventHandler(this.BtnEditSave_Click);
            // 
            // BtnDeleteCancel
            // 
            this.BtnDeleteCancel.Location = new System.Drawing.Point(465, 167);
            this.BtnDeleteCancel.Name = "BtnDeleteCancel";
            this.BtnDeleteCancel.Size = new System.Drawing.Size(93, 23);
            this.BtnDeleteCancel.TabIndex = 6;
            this.BtnDeleteCancel.Text = "Delete";
            this.BtnDeleteCancel.UseSelectable = true;
            this.BtnDeleteCancel.Click += new System.EventHandler(this.BtnDeleteCancel_Click);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(18, 43);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(77, 19);
            this.Description.TabIndex = 5;
            this.Description.Text = "Description:";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.DescriptionText.CustomButton.Image = null;
            this.DescriptionText.CustomButton.Location = new System.Drawing.Point(367, 2);
            this.DescriptionText.CustomButton.Name = "";
            this.DescriptionText.CustomButton.Size = new System.Drawing.Size(87, 87);
            this.DescriptionText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DescriptionText.CustomButton.TabIndex = 1;
            this.DescriptionText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DescriptionText.CustomButton.UseSelectable = true;
            this.DescriptionText.CustomButton.Visible = false;
            this.DescriptionText.Lines = new string[0];
            this.DescriptionText.Location = new System.Drawing.Point(101, 43);
            this.DescriptionText.MaxLength = 32767;
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.PasswordChar = '\0';
            this.DescriptionText.ReadOnly = true;
            this.DescriptionText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DescriptionText.SelectedText = "";
            this.DescriptionText.SelectionLength = 0;
            this.DescriptionText.SelectionStart = 0;
            this.DescriptionText.ShortcutsEnabled = true;
            this.DescriptionText.Size = new System.Drawing.Size(457, 92);
            this.DescriptionText.TabIndex = 4;
            this.DescriptionText.UseSelectable = true;
            this.DescriptionText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DescriptionText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TitleText
            // 
            this.TitleText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TitleText.CustomButton.Image = null;
            this.TitleText.CustomButton.Location = new System.Drawing.Point(435, 1);
            this.TitleText.CustomButton.Name = "";
            this.TitleText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TitleText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TitleText.CustomButton.TabIndex = 1;
            this.TitleText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TitleText.CustomButton.UseSelectable = true;
            this.TitleText.CustomButton.Visible = false;
            this.TitleText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TitleText.Lines = new string[0];
            this.TitleText.Location = new System.Drawing.Point(101, 14);
            this.TitleText.MaxLength = 32767;
            this.TitleText.Name = "TitleText";
            this.TitleText.PasswordChar = '\0';
            this.TitleText.ReadOnly = true;
            this.TitleText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TitleText.SelectedText = "";
            this.TitleText.SelectionLength = 0;
            this.TitleText.SelectionStart = 0;
            this.TitleText.ShortcutsEnabled = true;
            this.TitleText.Size = new System.Drawing.Size(457, 23);
            this.TitleText.TabIndex = 3;
            this.TitleText.UseSelectable = true;
            this.TitleText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TitleText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(18, 14);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(36, 19);
            this.Title.TabIndex = 2;
            this.Title.Text = "Title:";
            // 
            // CtrlSourceItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MetroPanel);
            this.Name = "CtrlSourceItem";
            this.Size = new System.Drawing.Size(570, 193);
            this.MetroPanel.ResumeLayout(false);
            this.MetroPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel MetroPanel;
        private MetroFramework.Controls.MetroLabel Title;
        private MetroFramework.Controls.MetroTextBox TitleText;
        private MetroFramework.Controls.MetroLabel Description;
        private MetroFramework.Controls.MetroTextBox DescriptionText;
        private MetroFramework.Controls.MetroButton BtnDeleteCancel;
        private MetroFramework.Controls.MetroButton BtnEditSave;
        private MetroFramework.Controls.MetroLabel ErrorText;
    }
}
