namespace PFMS.Views
{
    partial class FrmMain
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
            this.Tiles = new MetroFramework.Controls.MetroPanel();
            this.FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NewIncome = new MetroFramework.Controls.MetroTile();
            this.NewExpense = new MetroFramework.Controls.MetroTile();
            this.ManageSources = new MetroFramework.Controls.MetroTile();
            this.BankAccount = new MetroFramework.Controls.MetroTile();
            this.Calendar = new MetroFramework.Controls.MetroTile();
            this.Reports = new MetroFramework.Controls.MetroTile();
            this.Status = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.StatusPanel = new MetroFramework.Controls.MetroPanel();
            this.TotalSavingsText = new MetroFramework.Controls.MetroLabel();
            this.TotalIncome = new MetroFramework.Controls.MetroLabel();
            this.Stats = new MetroFramework.Controls.MetroLabel();
            this.TotalSavings = new MetroFramework.Controls.MetroLabel();
            this.TotalIncomeText = new MetroFramework.Controls.MetroLabel();
            this.TotalExpense = new MetroFramework.Controls.MetroLabel();
            this.TotalExpenseText = new MetroFramework.Controls.MetroLabel();
            this.StatusSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.Tiles.SuspendLayout();
            this.FlowLayoutPanel.SuspendLayout();
            this.Status.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.StatusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tiles
            // 
            this.Tiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tiles.Controls.Add(this.FlowLayoutPanel);
            this.Tiles.HorizontalScrollbarBarColor = true;
            this.Tiles.HorizontalScrollbarHighlightOnWheel = false;
            this.Tiles.HorizontalScrollbarSize = 10;
            this.Tiles.Location = new System.Drawing.Point(23, 63);
            this.Tiles.Name = "Tiles";
            this.Tiles.Size = new System.Drawing.Size(652, 514);
            this.Tiles.TabIndex = 0;
            this.Tiles.VerticalScrollbarBarColor = true;
            this.Tiles.VerticalScrollbarHighlightOnWheel = false;
            this.Tiles.VerticalScrollbarSize = 10;
            // 
            // FlowLayoutPanel
            // 
            this.FlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.FlowLayoutPanel.Controls.Add(this.NewIncome);
            this.FlowLayoutPanel.Controls.Add(this.NewExpense);
            this.FlowLayoutPanel.Controls.Add(this.ManageSources);
            this.FlowLayoutPanel.Controls.Add(this.BankAccount);
            this.FlowLayoutPanel.Controls.Add(this.Calendar);
            this.FlowLayoutPanel.Controls.Add(this.Reports);
            this.FlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanel.Name = "FlowLayoutPanel";
            this.FlowLayoutPanel.Size = new System.Drawing.Size(954, 514);
            this.FlowLayoutPanel.TabIndex = 2;
            // 
            // NewIncome
            // 
            this.NewIncome.ActiveControl = null;
            this.NewIncome.Location = new System.Drawing.Point(3, 3);
            this.NewIncome.Name = "NewIncome";
            this.NewIncome.PaintTileCount = false;
            this.NewIncome.Size = new System.Drawing.Size(225, 125);
            this.NewIncome.Style = MetroFramework.MetroColorStyle.Green;
            this.NewIncome.TabIndex = 0;
            this.NewIncome.Text = "Add New Income";
            this.NewIncome.TileImage = global::PFMS.Properties.Resources.icons8_initiate_money_transfer_101;
            this.NewIncome.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NewIncome.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.NewIncome.UseSelectable = true;
            this.NewIncome.UseTileImage = true;
            this.NewIncome.Click += new System.EventHandler(this.NewIncome_Click);
            // 
            // NewExpense
            // 
            this.NewExpense.ActiveControl = null;
            this.NewExpense.Location = new System.Drawing.Point(3, 134);
            this.NewExpense.Name = "NewExpense";
            this.NewExpense.PaintTileCount = false;
            this.NewExpense.Size = new System.Drawing.Size(225, 125);
            this.NewExpense.Style = MetroFramework.MetroColorStyle.Orange;
            this.NewExpense.TabIndex = 2;
            this.NewExpense.Text = "Add New Expense";
            this.NewExpense.TileImage = global::PFMS.Properties.Resources.icons8_initiate_money_transfer_100;
            this.NewExpense.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NewExpense.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.NewExpense.UseSelectable = true;
            this.NewExpense.UseTileImage = true;
            this.NewExpense.Click += new System.EventHandler(this.NewExpense_Click);
            // 
            // ManageSources
            // 
            this.ManageSources.ActiveControl = null;
            this.ManageSources.Location = new System.Drawing.Point(3, 265);
            this.ManageSources.Name = "ManageSources";
            this.ManageSources.PaintTileCount = false;
            this.ManageSources.Size = new System.Drawing.Size(225, 125);
            this.ManageSources.Style = MetroFramework.MetroColorStyle.Blue;
            this.ManageSources.TabIndex = 1;
            this.ManageSources.Text = "Manage Income/Expense Sources";
            this.ManageSources.TileImage = global::PFMS.Properties.Resources.icons8_exchange_100;
            this.ManageSources.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ManageSources.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.ManageSources.UseSelectable = true;
            this.ManageSources.UseTileImage = true;
            this.ManageSources.Click += new System.EventHandler(this.ManageSources_Click);
            // 
            // BankAccount
            // 
            this.BankAccount.ActiveControl = null;
            this.BankAccount.Location = new System.Drawing.Point(234, 3);
            this.BankAccount.Name = "BankAccount";
            this.BankAccount.PaintTileCount = false;
            this.BankAccount.Size = new System.Drawing.Size(225, 125);
            this.BankAccount.Style = MetroFramework.MetroColorStyle.Purple;
            this.BankAccount.TabIndex = 3;
            this.BankAccount.Text = "Bank Accounts";
            this.BankAccount.TileImage = global::PFMS.Properties.Resources.icons8_merchant_account_100;
            this.BankAccount.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BankAccount.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.BankAccount.UseSelectable = true;
            this.BankAccount.UseTileImage = true;
            this.BankAccount.Click += new System.EventHandler(this.BankAccount_Click);
            // 
            // Calendar
            // 
            this.Calendar.ActiveControl = null;
            this.Calendar.Location = new System.Drawing.Point(234, 134);
            this.Calendar.Name = "Calendar";
            this.Calendar.PaintTileCount = false;
            this.Calendar.Size = new System.Drawing.Size(225, 125);
            this.Calendar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Calendar.TabIndex = 4;
            this.Calendar.Text = "Calendar";
            this.Calendar.TileImage = global::PFMS.Properties.Resources.icons8_calendar_plus_100;
            this.Calendar.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Calendar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Calendar.UseSelectable = true;
            this.Calendar.UseTileImage = true;
            this.Calendar.Click += new System.EventHandler(this.Calendar_Click);
            // 
            // Reports
            // 
            this.Reports.ActiveControl = null;
            this.Reports.Location = new System.Drawing.Point(234, 265);
            this.Reports.Name = "Reports";
            this.Reports.PaintTileCount = false;
            this.Reports.Size = new System.Drawing.Size(225, 125);
            this.Reports.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Reports.TabIndex = 5;
            this.Reports.Text = "Reports";
            this.Reports.TileImage = global::PFMS.Properties.Resources.icons8_profit_report_100;
            this.Reports.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Reports.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Reports.UseSelectable = true;
            this.Reports.UseTileImage = true;
            // 
            // Status
            // 
            this.Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Status.Controls.Add(this.metroPanel1);
            this.Status.Controls.Add(this.StatusPanel);
            this.Status.Controls.Add(this.StatusSpinner);
            this.Status.HorizontalScrollbarBarColor = true;
            this.Status.HorizontalScrollbarHighlightOnWheel = false;
            this.Status.HorizontalScrollbarSize = 10;
            this.Status.Location = new System.Drawing.Point(681, 63);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(307, 514);
            this.Status.TabIndex = 1;
            this.Status.VerticalScrollbarBarColor = true;
            this.Status.VerticalScrollbarHighlightOnWheel = false;
            this.Status.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(6, 134);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(298, 306);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(151, 25);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Upcoming Events";
            // 
            // StatusPanel
            // 
            this.StatusPanel.Controls.Add(this.TotalSavingsText);
            this.StatusPanel.Controls.Add(this.TotalIncome);
            this.StatusPanel.Controls.Add(this.Stats);
            this.StatusPanel.Controls.Add(this.TotalSavings);
            this.StatusPanel.Controls.Add(this.TotalIncomeText);
            this.StatusPanel.Controls.Add(this.TotalExpense);
            this.StatusPanel.Controls.Add(this.TotalExpenseText);
            this.StatusPanel.HorizontalScrollbarBarColor = true;
            this.StatusPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.StatusPanel.HorizontalScrollbarSize = 10;
            this.StatusPanel.Location = new System.Drawing.Point(3, 3);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(301, 125);
            this.StatusPanel.TabIndex = 10;
            this.StatusPanel.VerticalScrollbarBarColor = true;
            this.StatusPanel.VerticalScrollbarHighlightOnWheel = false;
            this.StatusPanel.VerticalScrollbarSize = 10;
            this.StatusPanel.Visible = false;
            // 
            // TotalSavingsText
            // 
            this.TotalSavingsText.Location = new System.Drawing.Point(145, 80);
            this.TotalSavingsText.Name = "TotalSavingsText";
            this.TotalSavingsText.Size = new System.Drawing.Size(135, 19);
            this.TotalSavingsText.Style = MetroFramework.MetroColorStyle.Blue;
            this.TotalSavingsText.TabIndex = 8;
            this.TotalSavingsText.Text = "## #,###,###.##";
            this.TotalSavingsText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TotalSavingsText.UseStyleColors = true;
            // 
            // TotalIncome
            // 
            this.TotalIncome.AutoSize = true;
            this.TotalIncome.Location = new System.Drawing.Point(3, 42);
            this.TotalIncome.Name = "TotalIncome";
            this.TotalIncome.Size = new System.Drawing.Size(83, 19);
            this.TotalIncome.TabIndex = 3;
            this.TotalIncome.Text = "Total Income";
            // 
            // Stats
            // 
            this.Stats.AutoSize = true;
            this.Stats.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Stats.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Stats.Location = new System.Drawing.Point(3, 0);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(159, 25);
            this.Stats.TabIndex = 2;
            this.Stats.Text = "Monthly Summary";
            // 
            // TotalSavings
            // 
            this.TotalSavings.AutoSize = true;
            this.TotalSavings.Location = new System.Drawing.Point(3, 80);
            this.TotalSavings.Name = "TotalSavings";
            this.TotalSavings.Size = new System.Drawing.Size(83, 19);
            this.TotalSavings.TabIndex = 7;
            this.TotalSavings.Text = "Total Savings";
            // 
            // TotalIncomeText
            // 
            this.TotalIncomeText.Location = new System.Drawing.Point(145, 42);
            this.TotalIncomeText.Name = "TotalIncomeText";
            this.TotalIncomeText.Size = new System.Drawing.Size(135, 19);
            this.TotalIncomeText.Style = MetroFramework.MetroColorStyle.Green;
            this.TotalIncomeText.TabIndex = 4;
            this.TotalIncomeText.Text = "## #,###,###.##";
            this.TotalIncomeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TotalIncomeText.UseStyleColors = true;
            // 
            // TotalExpense
            // 
            this.TotalExpense.AutoSize = true;
            this.TotalExpense.Location = new System.Drawing.Point(3, 61);
            this.TotalExpense.Name = "TotalExpense";
            this.TotalExpense.Size = new System.Drawing.Size(87, 19);
            this.TotalExpense.TabIndex = 5;
            this.TotalExpense.Text = "Total Expense";
            // 
            // TotalExpenseText
            // 
            this.TotalExpenseText.Location = new System.Drawing.Point(145, 61);
            this.TotalExpenseText.Name = "TotalExpenseText";
            this.TotalExpenseText.Size = new System.Drawing.Size(135, 19);
            this.TotalExpenseText.Style = MetroFramework.MetroColorStyle.Orange;
            this.TotalExpenseText.TabIndex = 6;
            this.TotalExpenseText.Text = "## #,###,###.##";
            this.TotalExpenseText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TotalExpenseText.UseStyleColors = true;
            // 
            // StatusSpinner
            // 
            this.StatusSpinner.Location = new System.Drawing.Point(239, 446);
            this.StatusSpinner.Maximum = 100;
            this.StatusSpinner.Name = "StatusSpinner";
            this.StatusSpinner.Size = new System.Drawing.Size(65, 65);
            this.StatusSpinner.Spinning = false;
            this.StatusSpinner.TabIndex = 9;
            this.StatusSpinner.UseSelectable = true;
            this.StatusSpinner.Value = 75;
            this.StatusSpinner.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Tiles);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmMain";
            this.Text = "Personal Finance Management Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.Tiles.ResumeLayout(false);
            this.FlowLayoutPanel.ResumeLayout(false);
            this.Status.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel Tiles;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel;
        private MetroFramework.Controls.MetroTile NewIncome;
        private MetroFramework.Controls.MetroTile ManageSources;
        private MetroFramework.Controls.MetroTile NewExpense;
        private MetroFramework.Controls.MetroTile BankAccount;
        private MetroFramework.Controls.MetroPanel Status;
        private MetroFramework.Controls.MetroLabel Stats;
        private MetroFramework.Controls.MetroLabel TotalIncome;
        private MetroFramework.Controls.MetroLabel TotalIncomeText;
        private MetroFramework.Controls.MetroLabel TotalExpenseText;
        private MetroFramework.Controls.MetroLabel TotalExpense;
        private MetroFramework.Controls.MetroLabel TotalSavingsText;
        private MetroFramework.Controls.MetroLabel TotalSavings;
        private MetroFramework.Controls.MetroProgressSpinner StatusSpinner;
        private MetroFramework.Controls.MetroPanel StatusPanel;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile Calendar;
        private MetroFramework.Controls.MetroTile Reports;
    }
}

