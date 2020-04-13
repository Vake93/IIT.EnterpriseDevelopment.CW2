namespace PFMS.Views.Common
{
    partial class CtrlExpenseItem
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
            this.BtnEditSave = new MetroFramework.Controls.MetroButton();
            this.BtnDeleteCancel = new MetroFramework.Controls.MetroButton();
            this.ErrorText = new MetroFramework.Controls.MetroLabel();
            this.ExpenseAmountText = new MetroFramework.Controls.MetroTextBox();
            this.Amount = new MetroFramework.Controls.MetroLabel();
            this.Date = new MetroFramework.Controls.MetroLabel();
            this.ExpenseDate = new MetroFramework.Controls.MetroDateTime();
            this.TitleText = new MetroFramework.Controls.MetroTextBox();
            this.Title = new MetroFramework.Controls.MetroLabel();
            this.CmbExpenseSource = new MetroFramework.Controls.MetroComboBox();
            this.ExpenseSource = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // BtnEditSave
            // 
            this.BtnEditSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEditSave.Location = new System.Drawing.Point(5, 174);
            this.BtnEditSave.Name = "BtnEditSave";
            this.BtnEditSave.Size = new System.Drawing.Size(75, 23);
            this.BtnEditSave.TabIndex = 22;
            this.BtnEditSave.Text = "Edit";
            this.BtnEditSave.UseSelectable = true;
            this.BtnEditSave.Click += new System.EventHandler(this.BtnEditSave_Click);
            // 
            // BtnDeleteCancel
            // 
            this.BtnDeleteCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteCancel.Location = new System.Drawing.Point(473, 174);
            this.BtnDeleteCancel.Name = "BtnDeleteCancel";
            this.BtnDeleteCancel.Size = new System.Drawing.Size(93, 23);
            this.BtnDeleteCancel.TabIndex = 21;
            this.BtnDeleteCancel.Text = "Delete";
            this.BtnDeleteCancel.UseSelectable = true;
            this.BtnDeleteCancel.Click += new System.EventHandler(this.BtnDeleteCancel_Click);
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorText.Location = new System.Drawing.Point(5, 142);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(65, 19);
            this.ErrorText.TabIndex = 20;
            this.ErrorText.Text = "Error Text";
            this.ErrorText.UseCustomForeColor = true;
            // 
            // ExpenseAmountText
            // 
            // 
            // 
            // 
            this.ExpenseAmountText.CustomButton.Image = null;
            this.ExpenseAmountText.CustomButton.Location = new System.Drawing.Point(437, 1);
            this.ExpenseAmountText.CustomButton.Name = "";
            this.ExpenseAmountText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ExpenseAmountText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ExpenseAmountText.CustomButton.TabIndex = 1;
            this.ExpenseAmountText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ExpenseAmountText.CustomButton.UseSelectable = true;
            this.ExpenseAmountText.CustomButton.Visible = false;
            this.ExpenseAmountText.Lines = new string[0];
            this.ExpenseAmountText.Location = new System.Drawing.Point(107, 32);
            this.ExpenseAmountText.MaxLength = 32767;
            this.ExpenseAmountText.Name = "ExpenseAmountText";
            this.ExpenseAmountText.PasswordChar = '\0';
            this.ExpenseAmountText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ExpenseAmountText.SelectedText = "";
            this.ExpenseAmountText.SelectionLength = 0;
            this.ExpenseAmountText.SelectionStart = 0;
            this.ExpenseAmountText.ShortcutsEnabled = true;
            this.ExpenseAmountText.Size = new System.Drawing.Size(459, 23);
            this.ExpenseAmountText.TabIndex = 14;
            this.ExpenseAmountText.UseSelectable = true;
            this.ExpenseAmountText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ExpenseAmountText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(5, 36);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(59, 19);
            this.Amount.TabIndex = 19;
            this.Amount.Text = "Amount:";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(5, 71);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(39, 19);
            this.Date.TabIndex = 18;
            this.Date.Text = "Date:";
            // 
            // ExpenseDate
            // 
            this.ExpenseDate.Location = new System.Drawing.Point(107, 61);
            this.ExpenseDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.ExpenseDate.Name = "ExpenseDate";
            this.ExpenseDate.Size = new System.Drawing.Size(459, 29);
            this.ExpenseDate.TabIndex = 15;
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
            this.TitleText.Location = new System.Drawing.Point(107, 3);
            this.TitleText.MaxLength = 32767;
            this.TitleText.Name = "TitleText";
            this.TitleText.PasswordChar = '\0';
            this.TitleText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TitleText.SelectedText = "";
            this.TitleText.SelectionLength = 0;
            this.TitleText.SelectionStart = 0;
            this.TitleText.ShortcutsEnabled = true;
            this.TitleText.Size = new System.Drawing.Size(459, 23);
            this.TitleText.TabIndex = 12;
            this.TitleText.UseSelectable = true;
            this.TitleText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TitleText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(5, 7);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(36, 19);
            this.Title.TabIndex = 16;
            this.Title.Text = "Title:";
            // 
            // CmbExpenseSource
            // 
            this.CmbExpenseSource.FormattingEnabled = true;
            this.CmbExpenseSource.ItemHeight = 23;
            this.CmbExpenseSource.Location = new System.Drawing.Point(107, 96);
            this.CmbExpenseSource.Name = "CmbExpenseSource";
            this.CmbExpenseSource.Size = new System.Drawing.Size(459, 29);
            this.CmbExpenseSource.TabIndex = 17;
            this.CmbExpenseSource.UseSelectable = true;
            // 
            // ExpenseSource
            // 
            this.ExpenseSource.AutoSize = true;
            this.ExpenseSource.Location = new System.Drawing.Point(5, 106);
            this.ExpenseSource.Name = "ExpenseSource";
            this.ExpenseSource.Size = new System.Drawing.Size(103, 19);
            this.ExpenseSource.TabIndex = 13;
            this.ExpenseSource.Text = "Expense Source:";
            // 
            // CtrlExpenseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnEditSave);
            this.Controls.Add(this.BtnDeleteCancel);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.ExpenseAmountText);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.ExpenseDate);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.CmbExpenseSource);
            this.Controls.Add(this.ExpenseSource);
            this.MinimumSize = new System.Drawing.Size(570, 200);
            this.Name = "CtrlExpenseItem";
            this.Size = new System.Drawing.Size(570, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnEditSave;
        private MetroFramework.Controls.MetroButton BtnDeleteCancel;
        private MetroFramework.Controls.MetroLabel ErrorText;
        private MetroFramework.Controls.MetroTextBox ExpenseAmountText;
        private MetroFramework.Controls.MetroLabel Amount;
        private MetroFramework.Controls.MetroLabel Date;
        private MetroFramework.Controls.MetroDateTime ExpenseDate;
        private MetroFramework.Controls.MetroTextBox TitleText;
        private MetroFramework.Controls.MetroLabel Title;
        private MetroFramework.Controls.MetroComboBox CmbExpenseSource;
        private MetroFramework.Controls.MetroLabel ExpenseSource;
    }
}
