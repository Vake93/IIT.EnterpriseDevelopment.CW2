namespace PFMS.Views
{
    partial class FrmIncome
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
            this.Month = new MetroFramework.Controls.MetroLabel();
            this.CmbMonth = new MetroFramework.Controls.MetroComboBox();
            this.CmbYear = new MetroFramework.Controls.MetroComboBox();
            this.Year = new MetroFramework.Controls.MetroLabel();
            this.Panel = new MetroFramework.Controls.MetroPanel();
            this.IncomeLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NewIncome = new MetroFramework.Controls.MetroLink();
            this.Spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Month
            // 
            this.Month.AutoSize = true;
            this.Month.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Month.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Month.Location = new System.Drawing.Point(284, 75);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(129, 25);
            this.Month.TabIndex = 0;
            this.Month.Text = "Income Month";
            // 
            // CmbMonth
            // 
            this.CmbMonth.FormattingEnabled = true;
            this.CmbMonth.ItemHeight = 23;
            this.CmbMonth.Location = new System.Drawing.Point(419, 75);
            this.CmbMonth.Name = "CmbMonth";
            this.CmbMonth.Size = new System.Drawing.Size(141, 29);
            this.CmbMonth.TabIndex = 1;
            this.CmbMonth.UseSelectable = true;
            this.CmbMonth.SelectedIndexChanged += new System.EventHandler(this.CmbMonth_SelectedIndexChanged);
            // 
            // CmbYear
            // 
            this.CmbYear.FormattingEnabled = true;
            this.CmbYear.ItemHeight = 23;
            this.CmbYear.Location = new System.Drawing.Point(137, 75);
            this.CmbYear.Name = "CmbYear";
            this.CmbYear.Size = new System.Drawing.Size(141, 29);
            this.CmbYear.TabIndex = 2;
            this.CmbYear.UseSelectable = true;
            this.CmbYear.SelectedIndexChanged += new System.EventHandler(this.CmbYear_SelectedIndexChanged);
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Year.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Year.Location = new System.Drawing.Point(23, 75);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(108, 25);
            this.Year.TabIndex = 3;
            this.Year.Text = "Income Year";
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.Controls.Add(this.IncomeLayoutPanel);
            this.Panel.HorizontalScrollbarBarColor = true;
            this.Panel.HorizontalScrollbarHighlightOnWheel = false;
            this.Panel.HorizontalScrollbarSize = 10;
            this.Panel.Location = new System.Drawing.Point(23, 110);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(954, 427);
            this.Panel.TabIndex = 4;
            this.Panel.VerticalScrollbarBarColor = true;
            this.Panel.VerticalScrollbarHighlightOnWheel = false;
            this.Panel.VerticalScrollbarSize = 10;
            // 
            // IncomeLayoutPanel
            // 
            this.IncomeLayoutPanel.AutoScroll = true;
            this.IncomeLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.IncomeLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncomeLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.IncomeLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.IncomeLayoutPanel.Name = "IncomeLayoutPanel";
            this.IncomeLayoutPanel.Size = new System.Drawing.Size(954, 427);
            this.IncomeLayoutPanel.TabIndex = 2;
            this.IncomeLayoutPanel.WrapContents = false;
            // 
            // NewIncome
            // 
            this.NewIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NewIncome.Location = new System.Drawing.Point(856, 554);
            this.NewIncome.Name = "NewIncome";
            this.NewIncome.Size = new System.Drawing.Size(121, 23);
            this.NewIncome.TabIndex = 5;
            this.NewIncome.Text = "Add New Income";
            this.NewIncome.UseSelectable = true;
            this.NewIncome.Click += new System.EventHandler(this.NewIncome_Click);
            // 
            // Spinner
            // 
            this.Spinner.Location = new System.Drawing.Point(893, 9);
            this.Spinner.Maximum = 100;
            this.Spinner.Name = "Spinner";
            this.Spinner.Size = new System.Drawing.Size(75, 75);
            this.Spinner.Spinning = false;
            this.Spinner.TabIndex = 6;
            this.Spinner.UseSelectable = true;
            this.Spinner.Value = 75;
            this.Spinner.Visible = false;
            // 
            // FrmIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.Spinner);
            this.Controls.Add(this.NewIncome);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.CmbYear);
            this.Controls.Add(this.CmbMonth);
            this.Controls.Add(this.Month);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmIncome";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Income Details";
            this.Shown += new System.EventHandler(this.FrmIncome_Shown);
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Month;
        private MetroFramework.Controls.MetroComboBox CmbMonth;
        private MetroFramework.Controls.MetroComboBox CmbYear;
        private MetroFramework.Controls.MetroLabel Year;
        private MetroFramework.Controls.MetroPanel Panel;
        private MetroFramework.Controls.MetroLink NewIncome;
        private System.Windows.Forms.FlowLayoutPanel IncomeLayoutPanel;
        private MetroFramework.Controls.MetroProgressSpinner Spinner;
    }
}