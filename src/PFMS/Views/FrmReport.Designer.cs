namespace PFMS.Views
{
    partial class FrmReport
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReportDate = new MetroFramework.Controls.MetroLabel();
            this.CmbReportDate = new MetroFramework.Controls.MetroDateTime();
            this.AvarageIncome = new MetroFramework.Controls.MetroLabel();
            this.AvarageExpense = new MetroFramework.Controls.MetroLabel();
            this.AvarageIncomeText = new MetroFramework.Controls.MetroTextBox();
            this.AvarageExpenseText = new MetroFramework.Controls.MetroTextBox();
            this.Savings = new MetroFramework.Controls.MetroLabel();
            this.SavingsText = new MetroFramework.Controls.MetroTextBox();
            this.PredictedIncome = new MetroFramework.Controls.MetroLabel();
            this.PredictedIncomeText = new MetroFramework.Controls.MetroTextBox();
            this.PredictedExpense = new MetroFramework.Controls.MetroLabel();
            this.PredictedExpenseText = new MetroFramework.Controls.MetroTextBox();
            this.ReportPanel = new MetroFramework.Controls.MetroPanel();
            this.Spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.Prediction = new MetroFramework.Controls.MetroLabel();
            this.ReportPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportDate
            // 
            this.ReportDate.AutoSize = true;
            this.ReportDate.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ReportDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ReportDate.Location = new System.Drawing.Point(23, 77);
            this.ReportDate.Name = "ReportDate";
            this.ReportDate.Size = new System.Drawing.Size(111, 25);
            this.ReportDate.TabIndex = 0;
            this.ReportDate.Text = "Report Date:";
            // 
            // CmbReportDate
            // 
            this.CmbReportDate.Location = new System.Drawing.Point(140, 77);
            this.CmbReportDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.CmbReportDate.Name = "CmbReportDate";
            this.CmbReportDate.Size = new System.Drawing.Size(200, 29);
            this.CmbReportDate.TabIndex = 1;
            this.CmbReportDate.ValueChanged += new System.EventHandler(this.CmbReportDate_ValueChanged);
            // 
            // AvarageIncome
            // 
            this.AvarageIncome.AutoSize = true;
            this.AvarageIncome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.AvarageIncome.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.AvarageIncome.Location = new System.Drawing.Point(3, 0);
            this.AvarageIncome.Name = "AvarageIncome";
            this.AvarageIncome.Size = new System.Drawing.Size(145, 25);
            this.AvarageIncome.TabIndex = 2;
            this.AvarageIncome.Text = "Avarage Income:";
            // 
            // AvarageExpense
            // 
            this.AvarageExpense.AutoSize = true;
            this.AvarageExpense.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.AvarageExpense.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.AvarageExpense.Location = new System.Drawing.Point(3, 31);
            this.AvarageExpense.Name = "AvarageExpense";
            this.AvarageExpense.Size = new System.Drawing.Size(150, 25);
            this.AvarageExpense.TabIndex = 3;
            this.AvarageExpense.Text = "Avarage Expense:";
            // 
            // AvarageIncomeText
            // 
            // 
            // 
            // 
            this.AvarageIncomeText.CustomButton.Image = null;
            this.AvarageIncomeText.CustomButton.Location = new System.Drawing.Point(300, 1);
            this.AvarageIncomeText.CustomButton.Name = "";
            this.AvarageIncomeText.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.AvarageIncomeText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AvarageIncomeText.CustomButton.TabIndex = 1;
            this.AvarageIncomeText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AvarageIncomeText.CustomButton.UseSelectable = true;
            this.AvarageIncomeText.CustomButton.Visible = false;
            this.AvarageIncomeText.Lines = new string[0];
            this.AvarageIncomeText.Location = new System.Drawing.Point(186, 0);
            this.AvarageIncomeText.MaxLength = 32767;
            this.AvarageIncomeText.Name = "AvarageIncomeText";
            this.AvarageIncomeText.PasswordChar = '\0';
            this.AvarageIncomeText.ReadOnly = true;
            this.AvarageIncomeText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AvarageIncomeText.SelectedText = "";
            this.AvarageIncomeText.SelectionLength = 0;
            this.AvarageIncomeText.SelectionStart = 0;
            this.AvarageIncomeText.ShortcutsEnabled = true;
            this.AvarageIncomeText.Size = new System.Drawing.Size(324, 25);
            this.AvarageIncomeText.TabIndex = 4;
            this.AvarageIncomeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AvarageIncomeText.UseSelectable = true;
            this.AvarageIncomeText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AvarageIncomeText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AvarageExpenseText
            // 
            // 
            // 
            // 
            this.AvarageExpenseText.CustomButton.Image = null;
            this.AvarageExpenseText.CustomButton.Location = new System.Drawing.Point(300, 1);
            this.AvarageExpenseText.CustomButton.Name = "";
            this.AvarageExpenseText.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.AvarageExpenseText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AvarageExpenseText.CustomButton.TabIndex = 1;
            this.AvarageExpenseText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AvarageExpenseText.CustomButton.UseSelectable = true;
            this.AvarageExpenseText.CustomButton.Visible = false;
            this.AvarageExpenseText.Lines = new string[0];
            this.AvarageExpenseText.Location = new System.Drawing.Point(186, 31);
            this.AvarageExpenseText.MaxLength = 32767;
            this.AvarageExpenseText.Name = "AvarageExpenseText";
            this.AvarageExpenseText.PasswordChar = '\0';
            this.AvarageExpenseText.ReadOnly = true;
            this.AvarageExpenseText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AvarageExpenseText.SelectedText = "";
            this.AvarageExpenseText.SelectionLength = 0;
            this.AvarageExpenseText.SelectionStart = 0;
            this.AvarageExpenseText.ShortcutsEnabled = true;
            this.AvarageExpenseText.Size = new System.Drawing.Size(324, 25);
            this.AvarageExpenseText.TabIndex = 5;
            this.AvarageExpenseText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AvarageExpenseText.UseSelectable = true;
            this.AvarageExpenseText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AvarageExpenseText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Savings
            // 
            this.Savings.AutoSize = true;
            this.Savings.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Savings.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Savings.Location = new System.Drawing.Point(3, 62);
            this.Savings.Name = "Savings";
            this.Savings.Size = new System.Drawing.Size(77, 25);
            this.Savings.TabIndex = 6;
            this.Savings.Text = "Savings:";
            // 
            // SavingsText
            // 
            // 
            // 
            // 
            this.SavingsText.CustomButton.Image = null;
            this.SavingsText.CustomButton.Location = new System.Drawing.Point(300, 1);
            this.SavingsText.CustomButton.Name = "";
            this.SavingsText.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.SavingsText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SavingsText.CustomButton.TabIndex = 1;
            this.SavingsText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SavingsText.CustomButton.UseSelectable = true;
            this.SavingsText.CustomButton.Visible = false;
            this.SavingsText.Lines = new string[0];
            this.SavingsText.Location = new System.Drawing.Point(186, 62);
            this.SavingsText.MaxLength = 32767;
            this.SavingsText.Name = "SavingsText";
            this.SavingsText.PasswordChar = '\0';
            this.SavingsText.ReadOnly = true;
            this.SavingsText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SavingsText.SelectedText = "";
            this.SavingsText.SelectionLength = 0;
            this.SavingsText.SelectionStart = 0;
            this.SavingsText.ShortcutsEnabled = true;
            this.SavingsText.Size = new System.Drawing.Size(324, 25);
            this.SavingsText.TabIndex = 7;
            this.SavingsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SavingsText.UseSelectable = true;
            this.SavingsText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SavingsText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PredictedIncome
            // 
            this.PredictedIncome.AutoSize = true;
            this.PredictedIncome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PredictedIncome.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.PredictedIncome.Location = new System.Drawing.Point(3, 149);
            this.PredictedIncome.Name = "PredictedIncome";
            this.PredictedIncome.Size = new System.Drawing.Size(154, 25);
            this.PredictedIncome.TabIndex = 8;
            this.PredictedIncome.Text = "Predicted Income:";
            // 
            // PredictedIncomeText
            // 
            // 
            // 
            // 
            this.PredictedIncomeText.CustomButton.Image = null;
            this.PredictedIncomeText.CustomButton.Location = new System.Drawing.Point(300, 1);
            this.PredictedIncomeText.CustomButton.Name = "";
            this.PredictedIncomeText.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.PredictedIncomeText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PredictedIncomeText.CustomButton.TabIndex = 1;
            this.PredictedIncomeText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PredictedIncomeText.CustomButton.UseSelectable = true;
            this.PredictedIncomeText.CustomButton.Visible = false;
            this.PredictedIncomeText.Lines = new string[0];
            this.PredictedIncomeText.Location = new System.Drawing.Point(186, 149);
            this.PredictedIncomeText.MaxLength = 32767;
            this.PredictedIncomeText.Name = "PredictedIncomeText";
            this.PredictedIncomeText.PasswordChar = '\0';
            this.PredictedIncomeText.ReadOnly = true;
            this.PredictedIncomeText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PredictedIncomeText.SelectedText = "";
            this.PredictedIncomeText.SelectionLength = 0;
            this.PredictedIncomeText.SelectionStart = 0;
            this.PredictedIncomeText.ShortcutsEnabled = true;
            this.PredictedIncomeText.Size = new System.Drawing.Size(324, 25);
            this.PredictedIncomeText.TabIndex = 9;
            this.PredictedIncomeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PredictedIncomeText.UseSelectable = true;
            this.PredictedIncomeText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PredictedIncomeText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PredictedExpense
            // 
            this.PredictedExpense.AutoSize = true;
            this.PredictedExpense.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PredictedExpense.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.PredictedExpense.Location = new System.Drawing.Point(3, 180);
            this.PredictedExpense.Name = "PredictedExpense";
            this.PredictedExpense.Size = new System.Drawing.Size(159, 25);
            this.PredictedExpense.TabIndex = 10;
            this.PredictedExpense.Text = "Predicted Expense:";
            // 
            // PredictedExpenseText
            // 
            // 
            // 
            // 
            this.PredictedExpenseText.CustomButton.Image = null;
            this.PredictedExpenseText.CustomButton.Location = new System.Drawing.Point(300, 1);
            this.PredictedExpenseText.CustomButton.Name = "";
            this.PredictedExpenseText.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.PredictedExpenseText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PredictedExpenseText.CustomButton.TabIndex = 1;
            this.PredictedExpenseText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PredictedExpenseText.CustomButton.UseSelectable = true;
            this.PredictedExpenseText.CustomButton.Visible = false;
            this.PredictedExpenseText.Lines = new string[0];
            this.PredictedExpenseText.Location = new System.Drawing.Point(186, 180);
            this.PredictedExpenseText.MaxLength = 32767;
            this.PredictedExpenseText.Name = "PredictedExpenseText";
            this.PredictedExpenseText.PasswordChar = '\0';
            this.PredictedExpenseText.ReadOnly = true;
            this.PredictedExpenseText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PredictedExpenseText.SelectedText = "";
            this.PredictedExpenseText.SelectionLength = 0;
            this.PredictedExpenseText.SelectionStart = 0;
            this.PredictedExpenseText.ShortcutsEnabled = true;
            this.PredictedExpenseText.Size = new System.Drawing.Size(324, 25);
            this.PredictedExpenseText.TabIndex = 11;
            this.PredictedExpenseText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PredictedExpenseText.UseSelectable = true;
            this.PredictedExpenseText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PredictedExpenseText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ReportPanel
            // 
            this.ReportPanel.Controls.Add(this.Prediction);
            this.ReportPanel.Controls.Add(this.PredictedExpense);
            this.ReportPanel.Controls.Add(this.PredictedExpenseText);
            this.ReportPanel.Controls.Add(this.AvarageIncome);
            this.ReportPanel.Controls.Add(this.PredictedIncomeText);
            this.ReportPanel.Controls.Add(this.AvarageExpense);
            this.ReportPanel.Controls.Add(this.PredictedIncome);
            this.ReportPanel.Controls.Add(this.AvarageIncomeText);
            this.ReportPanel.Controls.Add(this.SavingsText);
            this.ReportPanel.Controls.Add(this.AvarageExpenseText);
            this.ReportPanel.Controls.Add(this.Savings);
            this.ReportPanel.HorizontalScrollbarBarColor = true;
            this.ReportPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ReportPanel.HorizontalScrollbarSize = 10;
            this.ReportPanel.Location = new System.Drawing.Point(23, 127);
            this.ReportPanel.Name = "ReportPanel";
            this.ReportPanel.Size = new System.Drawing.Size(513, 219);
            this.ReportPanel.TabIndex = 12;
            this.ReportPanel.VerticalScrollbarBarColor = true;
            this.ReportPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ReportPanel.VerticalScrollbarSize = 10;
            // 
            // Spinner
            // 
            this.Spinner.Location = new System.Drawing.Point(346, 77);
            this.Spinner.Maximum = 100;
            this.Spinner.Name = "Spinner";
            this.Spinner.Size = new System.Drawing.Size(29, 29);
            this.Spinner.Spinning = false;
            this.Spinner.TabIndex = 13;
            this.Spinner.UseSelectable = true;
            this.Spinner.Visible = false;
            // 
            // Prediction
            // 
            this.Prediction.Location = new System.Drawing.Point(8, 121);
            this.Prediction.Name = "Prediction";
            this.Prediction.Size = new System.Drawing.Size(502, 25);
            this.Prediction.TabIndex = 12;
            this.Prediction.Text = "Prediction";
            this.Prediction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Prediction.UseCustomForeColor = true;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.Spinner);
            this.Controls.Add(this.ReportPanel);
            this.Controls.Add(this.CmbReportDate);
            this.Controls.Add(this.ReportDate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmReport";
            this.ShowInTaskbar = false;
            this.Text = "Report";
            this.ReportPanel.ResumeLayout(false);
            this.ReportPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel ReportDate;
        private MetroFramework.Controls.MetroDateTime CmbReportDate;
        private MetroFramework.Controls.MetroLabel AvarageIncome;
        private MetroFramework.Controls.MetroLabel AvarageExpense;
        private MetroFramework.Controls.MetroTextBox AvarageIncomeText;
        private MetroFramework.Controls.MetroTextBox AvarageExpenseText;
        private MetroFramework.Controls.MetroLabel Savings;
        private MetroFramework.Controls.MetroTextBox SavingsText;
        private MetroFramework.Controls.MetroLabel PredictedIncome;
        private MetroFramework.Controls.MetroTextBox PredictedIncomeText;
        private MetroFramework.Controls.MetroLabel PredictedExpense;
        private MetroFramework.Controls.MetroTextBox PredictedExpenseText;
        private MetroFramework.Controls.MetroPanel ReportPanel;
        private MetroFramework.Controls.MetroProgressSpinner Spinner;
        private MetroFramework.Controls.MetroLabel Prediction;
    }
}