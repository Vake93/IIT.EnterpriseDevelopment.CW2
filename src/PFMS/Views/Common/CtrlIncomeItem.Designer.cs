namespace PFMS.Views.Common
{
    partial class CtrlIncomeItem
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
            this.IncomeSource = new MetroFramework.Controls.MetroLabel();
            this.CmbIncomeSource = new MetroFramework.Controls.MetroComboBox();
            this.Title = new MetroFramework.Controls.MetroLabel();
            this.TitleText = new MetroFramework.Controls.MetroTextBox();
            this.IncomeDate = new MetroFramework.Controls.MetroDateTime();
            this.Date = new MetroFramework.Controls.MetroLabel();
            this.Amount = new MetroFramework.Controls.MetroLabel();
            this.IncomeAmountText = new MetroFramework.Controls.MetroTextBox();
            this.ErrorText = new MetroFramework.Controls.MetroLabel();
            this.BtnEditSave = new MetroFramework.Controls.MetroButton();
            this.BtnDeleteCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // IncomeSource
            // 
            this.IncomeSource.AutoSize = true;
            this.IncomeSource.Location = new System.Drawing.Point(6, 106);
            this.IncomeSource.Name = "IncomeSource";
            this.IncomeSource.Size = new System.Drawing.Size(99, 19);
            this.IncomeSource.TabIndex = 0;
            this.IncomeSource.Text = "Income Source:";
            // 
            // CmbIncomeSource
            // 
            this.CmbIncomeSource.FormattingEnabled = true;
            this.CmbIncomeSource.ItemHeight = 23;
            this.CmbIncomeSource.Location = new System.Drawing.Point(108, 96);
            this.CmbIncomeSource.Name = "CmbIncomeSource";
            this.CmbIncomeSource.Size = new System.Drawing.Size(459, 29);
            this.CmbIncomeSource.TabIndex = 3;
            this.CmbIncomeSource.UseSelectable = true;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(6, 7);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(36, 19);
            this.Title.TabIndex = 2;
            this.Title.Text = "Title:";
            // 
            // TitleText
            // 
            // 
            // 
            // 
            this.TitleText.CustomButton.Image = null;
            this.TitleText.CustomButton.Location = new System.Drawing.Point(437, 1);
            this.TitleText.CustomButton.Name = "";
            this.TitleText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TitleText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TitleText.CustomButton.TabIndex = 1;
            this.TitleText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TitleText.CustomButton.UseSelectable = true;
            this.TitleText.CustomButton.Visible = false;
            this.TitleText.Lines = new string[0];
            this.TitleText.Location = new System.Drawing.Point(108, 3);
            this.TitleText.MaxLength = 32767;
            this.TitleText.Name = "TitleText";
            this.TitleText.PasswordChar = '\0';
            this.TitleText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TitleText.SelectedText = "";
            this.TitleText.SelectionLength = 0;
            this.TitleText.SelectionStart = 0;
            this.TitleText.ShortcutsEnabled = true;
            this.TitleText.Size = new System.Drawing.Size(459, 23);
            this.TitleText.TabIndex = 0;
            this.TitleText.UseSelectable = true;
            this.TitleText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TitleText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // IncomeDate
            // 
            this.IncomeDate.Location = new System.Drawing.Point(108, 61);
            this.IncomeDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.IncomeDate.Name = "IncomeDate";
            this.IncomeDate.Size = new System.Drawing.Size(459, 29);
            this.IncomeDate.TabIndex = 2;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(6, 71);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(39, 19);
            this.Date.TabIndex = 4;
            this.Date.Text = "Date:";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(6, 36);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(59, 19);
            this.Amount.TabIndex = 5;
            this.Amount.Text = "Amount:";
            // 
            // IncomeAmountText
            // 
            // 
            // 
            // 
            this.IncomeAmountText.CustomButton.Image = null;
            this.IncomeAmountText.CustomButton.Location = new System.Drawing.Point(437, 1);
            this.IncomeAmountText.CustomButton.Name = "";
            this.IncomeAmountText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.IncomeAmountText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.IncomeAmountText.CustomButton.TabIndex = 1;
            this.IncomeAmountText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.IncomeAmountText.CustomButton.UseSelectable = true;
            this.IncomeAmountText.CustomButton.Visible = false;
            this.IncomeAmountText.Lines = new string[0];
            this.IncomeAmountText.Location = new System.Drawing.Point(108, 32);
            this.IncomeAmountText.MaxLength = 32767;
            this.IncomeAmountText.Name = "IncomeAmountText";
            this.IncomeAmountText.PasswordChar = '\0';
            this.IncomeAmountText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IncomeAmountText.SelectedText = "";
            this.IncomeAmountText.SelectionLength = 0;
            this.IncomeAmountText.SelectionStart = 0;
            this.IncomeAmountText.ShortcutsEnabled = true;
            this.IncomeAmountText.Size = new System.Drawing.Size(459, 23);
            this.IncomeAmountText.TabIndex = 1;
            this.IncomeAmountText.UseSelectable = true;
            this.IncomeAmountText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.IncomeAmountText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorText.Location = new System.Drawing.Point(6, 142);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(65, 19);
            this.ErrorText.TabIndex = 9;
            this.ErrorText.Text = "Error Text";
            this.ErrorText.UseCustomForeColor = true;
            // 
            // BtnEditSave
            // 
            this.BtnEditSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEditSave.Location = new System.Drawing.Point(6, 174);
            this.BtnEditSave.Name = "BtnEditSave";
            this.BtnEditSave.Size = new System.Drawing.Size(75, 23);
            this.BtnEditSave.TabIndex = 11;
            this.BtnEditSave.Text = "Edit";
            this.BtnEditSave.UseSelectable = true;
            this.BtnEditSave.Click += new System.EventHandler(this.BtnEditSave_Click);
            // 
            // BtnDeleteCancel
            // 
            this.BtnDeleteCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteCancel.Location = new System.Drawing.Point(474, 174);
            this.BtnDeleteCancel.Name = "BtnDeleteCancel";
            this.BtnDeleteCancel.Size = new System.Drawing.Size(93, 23);
            this.BtnDeleteCancel.TabIndex = 10;
            this.BtnDeleteCancel.Text = "Delete";
            this.BtnDeleteCancel.UseSelectable = true;
            this.BtnDeleteCancel.Click += new System.EventHandler(this.BtnDeleteCancel_Click);
            // 
            // CtrlIncomeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnEditSave);
            this.Controls.Add(this.BtnDeleteCancel);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.IncomeAmountText);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.IncomeDate);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.CmbIncomeSource);
            this.Controls.Add(this.IncomeSource);
            this.MaximumSize = new System.Drawing.Size(570, 200);
            this.MinimumSize = new System.Drawing.Size(570, 200);
            this.Name = "CtrlIncomeItem";
            this.Size = new System.Drawing.Size(570, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel IncomeSource;
        private MetroFramework.Controls.MetroComboBox CmbIncomeSource;
        private MetroFramework.Controls.MetroLabel Title;
        private MetroFramework.Controls.MetroTextBox TitleText;
        private MetroFramework.Controls.MetroDateTime IncomeDate;
        private MetroFramework.Controls.MetroLabel Date;
        private MetroFramework.Controls.MetroLabel Amount;
        private MetroFramework.Controls.MetroTextBox IncomeAmountText;
        private MetroFramework.Controls.MetroLabel ErrorText;
        private MetroFramework.Controls.MetroButton BtnEditSave;
        private MetroFramework.Controls.MetroButton BtnDeleteCancel;
    }
}
