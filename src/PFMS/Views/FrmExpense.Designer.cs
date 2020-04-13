namespace PFMS.Views
{
    partial class FrmExpense
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
            this.Spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.Year = new MetroFramework.Controls.MetroLabel();
            this.CmbYear = new MetroFramework.Controls.MetroComboBox();
            this.CmbMonth = new MetroFramework.Controls.MetroComboBox();
            this.Month = new MetroFramework.Controls.MetroLabel();
            this.Panel = new MetroFramework.Controls.MetroPanel();
            this.ExpnseLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NewExpense = new MetroFramework.Controls.MetroLink();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Spinner
            // 
            this.Spinner.Location = new System.Drawing.Point(902, 22);
            this.Spinner.Maximum = 100;
            this.Spinner.Name = "Spinner";
            this.Spinner.Size = new System.Drawing.Size(75, 75);
            this.Spinner.Spinning = false;
            this.Spinner.TabIndex = 11;
            this.Spinner.UseSelectable = true;
            this.Spinner.Value = 75;
            this.Spinner.Visible = false;
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Year.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Year.Location = new System.Drawing.Point(23, 72);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(113, 25);
            this.Year.TabIndex = 10;
            this.Year.Text = "Expense Year";
            // 
            // CmbYear
            // 
            this.CmbYear.FormattingEnabled = true;
            this.CmbYear.ItemHeight = 23;
            this.CmbYear.Location = new System.Drawing.Point(137, 72);
            this.CmbYear.Name = "CmbYear";
            this.CmbYear.Size = new System.Drawing.Size(141, 29);
            this.CmbYear.TabIndex = 9;
            this.CmbYear.UseSelectable = true;
            this.CmbYear.SelectedIndexChanged += new System.EventHandler(this.CmbYear_SelectedIndexChanged);
            // 
            // CmbMonth
            // 
            this.CmbMonth.FormattingEnabled = true;
            this.CmbMonth.ItemHeight = 23;
            this.CmbMonth.Location = new System.Drawing.Point(424, 72);
            this.CmbMonth.Name = "CmbMonth";
            this.CmbMonth.Size = new System.Drawing.Size(141, 29);
            this.CmbMonth.TabIndex = 8;
            this.CmbMonth.UseSelectable = true;
            this.CmbMonth.SelectedIndexChanged += new System.EventHandler(this.CmbMonth_SelectedIndexChanged);
            // 
            // Month
            // 
            this.Month.AutoSize = true;
            this.Month.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Month.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Month.Location = new System.Drawing.Point(284, 72);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(134, 25);
            this.Month.TabIndex = 7;
            this.Month.Text = "Expense Month";
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.Controls.Add(this.ExpnseLayoutPanel);
            this.Panel.HorizontalScrollbarBarColor = true;
            this.Panel.HorizontalScrollbarHighlightOnWheel = false;
            this.Panel.HorizontalScrollbarSize = 10;
            this.Panel.Location = new System.Drawing.Point(23, 107);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(954, 427);
            this.Panel.TabIndex = 12;
            this.Panel.VerticalScrollbarBarColor = true;
            this.Panel.VerticalScrollbarHighlightOnWheel = false;
            this.Panel.VerticalScrollbarSize = 10;
            // 
            // ExpnseLayoutPanel
            // 
            this.ExpnseLayoutPanel.AutoScroll = true;
            this.ExpnseLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.ExpnseLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpnseLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ExpnseLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ExpnseLayoutPanel.Name = "ExpnseLayoutPanel";
            this.ExpnseLayoutPanel.Size = new System.Drawing.Size(954, 427);
            this.ExpnseLayoutPanel.TabIndex = 2;
            this.ExpnseLayoutPanel.WrapContents = false;
            // 
            // NewExpense
            // 
            this.NewExpense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NewExpense.Location = new System.Drawing.Point(856, 554);
            this.NewExpense.Name = "NewExpense";
            this.NewExpense.Size = new System.Drawing.Size(121, 23);
            this.NewExpense.TabIndex = 13;
            this.NewExpense.Text = "Add New Expense";
            this.NewExpense.UseSelectable = true;
            this.NewExpense.Click += new System.EventHandler(this.NewExpense_Click);
            // 
            // FrmExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.NewExpense);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Spinner);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.CmbYear);
            this.Controls.Add(this.CmbMonth);
            this.Controls.Add(this.Month);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmExpense";
            this.ShowInTaskbar = false;
            this.Text = "Expense Deatils";
            this.Shown += new System.EventHandler(this.FrmExpense_Shown);
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner Spinner;
        private MetroFramework.Controls.MetroLabel Year;
        private MetroFramework.Controls.MetroComboBox CmbYear;
        private MetroFramework.Controls.MetroComboBox CmbMonth;
        private MetroFramework.Controls.MetroLabel Month;
        private MetroFramework.Controls.MetroPanel Panel;
        private System.Windows.Forms.FlowLayoutPanel ExpnseLayoutPanel;
        private MetroFramework.Controls.MetroLink NewExpense;
    }
}