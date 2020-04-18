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
            this.CurrencyConverterPanel = new MetroFramework.Controls.MetroPanel();
            this.TxtToAmount = new MetroFramework.Controls.MetroTextBox();
            this.CmbToAmount = new MetroFramework.Controls.MetroComboBox();
            this.TxtFromAmount = new MetroFramework.Controls.MetroTextBox();
            this.CmbFromAmount = new MetroFramework.Controls.MetroComboBox();
            this.CurrencyConverter = new MetroFramework.Controls.MetroLabel();
            this.EventsPanel = new MetroFramework.Controls.MetroPanel();
            this.EventsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.UpcomingEvents = new MetroFramework.Controls.MetroLabel();
            this.StatusPanel = new MetroFramework.Controls.MetroPanel();
            this.TotalSavingsText = new MetroFramework.Controls.MetroLabel();
            this.TotalIncome = new MetroFramework.Controls.MetroLabel();
            this.MonthlySummary = new MetroFramework.Controls.MetroLabel();
            this.TotalSavings = new MetroFramework.Controls.MetroLabel();
            this.TotalIncomeText = new MetroFramework.Controls.MetroLabel();
            this.TotalExpense = new MetroFramework.Controls.MetroLabel();
            this.TotalExpenseText = new MetroFramework.Controls.MetroLabel();
            this.Spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.Tiles.SuspendLayout();
            this.FlowLayoutPanel.SuspendLayout();
            this.Status.SuspendLayout();
            this.CurrencyConverterPanel.SuspendLayout();
            this.EventsPanel.SuspendLayout();
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
            this.FlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.FlowLayoutPanel.Controls.Add(this.NewIncome);
            this.FlowLayoutPanel.Controls.Add(this.NewExpense);
            this.FlowLayoutPanel.Controls.Add(this.ManageSources);
            this.FlowLayoutPanel.Controls.Add(this.BankAccount);
            this.FlowLayoutPanel.Controls.Add(this.Calendar);
            this.FlowLayoutPanel.Controls.Add(this.Reports);
            this.FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanel.Name = "FlowLayoutPanel";
            this.FlowLayoutPanel.Size = new System.Drawing.Size(652, 514);
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
            this.ManageSources.TileImage = global::PFMS.Properties.Resources.icons8_cashbook_100;
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
            this.Reports.TileImage = global::PFMS.Properties.Resources.icons8_financial_growth_analysis_100;
            this.Reports.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Reports.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Reports.UseSelectable = true;
            this.Reports.UseTileImage = true;
            this.Reports.Click += new System.EventHandler(this.Reports_Click);
            // 
            // Status
            // 
            this.Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Status.Controls.Add(this.CurrencyConverterPanel);
            this.Status.Controls.Add(this.EventsPanel);
            this.Status.Controls.Add(this.StatusPanel);
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
            // CurrencyConverterPanel
            // 
            this.CurrencyConverterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrencyConverterPanel.Controls.Add(this.TxtToAmount);
            this.CurrencyConverterPanel.Controls.Add(this.CmbToAmount);
            this.CurrencyConverterPanel.Controls.Add(this.TxtFromAmount);
            this.CurrencyConverterPanel.Controls.Add(this.CmbFromAmount);
            this.CurrencyConverterPanel.Controls.Add(this.CurrencyConverter);
            this.CurrencyConverterPanel.HorizontalScrollbarBarColor = true;
            this.CurrencyConverterPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.CurrencyConverterPanel.HorizontalScrollbarSize = 10;
            this.CurrencyConverterPanel.Location = new System.Drawing.Point(3, 3);
            this.CurrencyConverterPanel.Name = "CurrencyConverterPanel";
            this.CurrencyConverterPanel.Size = new System.Drawing.Size(301, 125);
            this.CurrencyConverterPanel.TabIndex = 12;
            this.CurrencyConverterPanel.VerticalScrollbarBarColor = true;
            this.CurrencyConverterPanel.VerticalScrollbarHighlightOnWheel = false;
            this.CurrencyConverterPanel.VerticalScrollbarSize = 10;
            // 
            // TxtToAmount
            // 
            // 
            // 
            // 
            this.TxtToAmount.CustomButton.Image = null;
            this.TxtToAmount.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.TxtToAmount.CustomButton.Name = "";
            this.TxtToAmount.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.TxtToAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtToAmount.CustomButton.TabIndex = 1;
            this.TxtToAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtToAmount.CustomButton.UseSelectable = true;
            this.TxtToAmount.CustomButton.Visible = false;
            this.TxtToAmount.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtToAmount.Lines = new string[0];
            this.TxtToAmount.Location = new System.Drawing.Point(98, 68);
            this.TxtToAmount.MaxLength = 32767;
            this.TxtToAmount.Name = "TxtToAmount";
            this.TxtToAmount.PasswordChar = '\0';
            this.TxtToAmount.ReadOnly = true;
            this.TxtToAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtToAmount.SelectedText = "";
            this.TxtToAmount.SelectionLength = 0;
            this.TxtToAmount.SelectionStart = 0;
            this.TxtToAmount.ShortcutsEnabled = true;
            this.TxtToAmount.Size = new System.Drawing.Size(195, 29);
            this.TxtToAmount.TabIndex = 13;
            this.TxtToAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtToAmount.UseSelectable = true;
            this.TxtToAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtToAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CmbToAmount
            // 
            this.CmbToAmount.FormattingEnabled = true;
            this.CmbToAmount.ItemHeight = 23;
            this.CmbToAmount.Location = new System.Drawing.Point(5, 68);
            this.CmbToAmount.Name = "CmbToAmount";
            this.CmbToAmount.Size = new System.Drawing.Size(87, 29);
            this.CmbToAmount.TabIndex = 12;
            this.CmbToAmount.UseSelectable = true;
            this.CmbToAmount.SelectedIndexChanged += new System.EventHandler(this.CmbToAmount_SelectedIndexChanged);
            // 
            // TxtFromAmount
            // 
            // 
            // 
            // 
            this.TxtFromAmount.CustomButton.Image = null;
            this.TxtFromAmount.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.TxtFromAmount.CustomButton.Name = "";
            this.TxtFromAmount.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.TxtFromAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtFromAmount.CustomButton.TabIndex = 1;
            this.TxtFromAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtFromAmount.CustomButton.UseSelectable = true;
            this.TxtFromAmount.CustomButton.Visible = false;
            this.TxtFromAmount.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtFromAmount.Lines = new string[0];
            this.TxtFromAmount.Location = new System.Drawing.Point(98, 33);
            this.TxtFromAmount.MaxLength = 32767;
            this.TxtFromAmount.Name = "TxtFromAmount";
            this.TxtFromAmount.PasswordChar = '\0';
            this.TxtFromAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtFromAmount.SelectedText = "";
            this.TxtFromAmount.SelectionLength = 0;
            this.TxtFromAmount.SelectionStart = 0;
            this.TxtFromAmount.ShortcutsEnabled = true;
            this.TxtFromAmount.Size = new System.Drawing.Size(195, 29);
            this.TxtFromAmount.TabIndex = 11;
            this.TxtFromAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtFromAmount.UseSelectable = true;
            this.TxtFromAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtFromAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtFromAmount.TextChanged += new System.EventHandler(this.TxtFromAmount_TextChanged);
            this.TxtFromAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFromAmount_KeyPress);
            // 
            // CmbFromAmount
            // 
            this.CmbFromAmount.FormattingEnabled = true;
            this.CmbFromAmount.ItemHeight = 23;
            this.CmbFromAmount.Location = new System.Drawing.Point(5, 33);
            this.CmbFromAmount.Name = "CmbFromAmount";
            this.CmbFromAmount.Size = new System.Drawing.Size(87, 29);
            this.CmbFromAmount.TabIndex = 10;
            this.CmbFromAmount.UseSelectable = true;
            this.CmbFromAmount.SelectedIndexChanged += new System.EventHandler(this.CmbFromAmount_SelectedIndexChanged);
            // 
            // CurrencyConverter
            // 
            this.CurrencyConverter.AutoSize = true;
            this.CurrencyConverter.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.CurrencyConverter.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.CurrencyConverter.Location = new System.Drawing.Point(0, 5);
            this.CurrencyConverter.Name = "CurrencyConverter";
            this.CurrencyConverter.Size = new System.Drawing.Size(163, 25);
            this.CurrencyConverter.TabIndex = 9;
            this.CurrencyConverter.Text = "Currency Converter";
            this.CurrencyConverter.UseCustomForeColor = true;
            // 
            // EventsPanel
            // 
            this.EventsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventsPanel.Controls.Add(this.EventsLayoutPanel);
            this.EventsPanel.Controls.Add(this.UpcomingEvents);
            this.EventsPanel.HorizontalScrollbarBarColor = true;
            this.EventsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.EventsPanel.HorizontalScrollbarSize = 10;
            this.EventsPanel.Location = new System.Drawing.Point(3, 265);
            this.EventsPanel.Name = "EventsPanel";
            this.EventsPanel.Size = new System.Drawing.Size(301, 246);
            this.EventsPanel.TabIndex = 11;
            this.EventsPanel.VerticalScrollbarBarColor = true;
            this.EventsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.EventsPanel.VerticalScrollbarSize = 10;
            // 
            // EventsLayoutPanel
            // 
            this.EventsLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventsLayoutPanel.AutoScroll = true;
            this.EventsLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.EventsLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.EventsLayoutPanel.Location = new System.Drawing.Point(5, 28);
            this.EventsLayoutPanel.Name = "EventsLayoutPanel";
            this.EventsLayoutPanel.Size = new System.Drawing.Size(288, 215);
            this.EventsLayoutPanel.TabIndex = 10;
            this.EventsLayoutPanel.WrapContents = false;
            // 
            // UpcomingEvents
            // 
            this.UpcomingEvents.AutoSize = true;
            this.UpcomingEvents.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.UpcomingEvents.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.UpcomingEvents.Location = new System.Drawing.Point(0, 0);
            this.UpcomingEvents.Name = "UpcomingEvents";
            this.UpcomingEvents.Size = new System.Drawing.Size(151, 25);
            this.UpcomingEvents.TabIndex = 9;
            this.UpcomingEvents.Text = "Upcoming Events";
            this.UpcomingEvents.UseCustomForeColor = true;
            // 
            // StatusPanel
            // 
            this.StatusPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusPanel.Controls.Add(this.TotalSavingsText);
            this.StatusPanel.Controls.Add(this.TotalIncome);
            this.StatusPanel.Controls.Add(this.MonthlySummary);
            this.StatusPanel.Controls.Add(this.TotalSavings);
            this.StatusPanel.Controls.Add(this.TotalIncomeText);
            this.StatusPanel.Controls.Add(this.TotalExpense);
            this.StatusPanel.Controls.Add(this.TotalExpenseText);
            this.StatusPanel.HorizontalScrollbarBarColor = true;
            this.StatusPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.StatusPanel.HorizontalScrollbarSize = 10;
            this.StatusPanel.Location = new System.Drawing.Point(3, 134);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(301, 125);
            this.StatusPanel.TabIndex = 10;
            this.StatusPanel.VerticalScrollbarBarColor = true;
            this.StatusPanel.VerticalScrollbarHighlightOnWheel = false;
            this.StatusPanel.VerticalScrollbarSize = 10;
            // 
            // TotalSavingsText
            // 
            this.TotalSavingsText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TotalSavingsText.Location = new System.Drawing.Point(124, 90);
            this.TotalSavingsText.Name = "TotalSavingsText";
            this.TotalSavingsText.Size = new System.Drawing.Size(169, 25);
            this.TotalSavingsText.Style = MetroFramework.MetroColorStyle.Blue;
            this.TotalSavingsText.TabIndex = 8;
            this.TotalSavingsText.Text = "## #,###,###.##";
            this.TotalSavingsText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TotalSavingsText.UseStyleColors = true;
            // 
            // TotalIncome
            // 
            this.TotalIncome.AutoSize = true;
            this.TotalIncome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TotalIncome.Location = new System.Drawing.Point(3, 40);
            this.TotalIncome.Name = "TotalIncome";
            this.TotalIncome.Size = new System.Drawing.Size(107, 25);
            this.TotalIncome.TabIndex = 3;
            this.TotalIncome.Text = "Total Income";
            // 
            // MonthlySummary
            // 
            this.MonthlySummary.AutoSize = true;
            this.MonthlySummary.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MonthlySummary.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.MonthlySummary.Location = new System.Drawing.Point(0, 0);
            this.MonthlySummary.Name = "MonthlySummary";
            this.MonthlySummary.Size = new System.Drawing.Size(159, 25);
            this.MonthlySummary.TabIndex = 2;
            this.MonthlySummary.Text = "Monthly Summary";
            this.MonthlySummary.UseCustomForeColor = true;
            // 
            // TotalSavings
            // 
            this.TotalSavings.AutoSize = true;
            this.TotalSavings.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TotalSavings.Location = new System.Drawing.Point(5, 65);
            this.TotalSavings.Name = "TotalSavings";
            this.TotalSavings.Size = new System.Drawing.Size(108, 25);
            this.TotalSavings.TabIndex = 7;
            this.TotalSavings.Text = "Total Savings";
            // 
            // TotalIncomeText
            // 
            this.TotalIncomeText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TotalIncomeText.Location = new System.Drawing.Point(124, 40);
            this.TotalIncomeText.Name = "TotalIncomeText";
            this.TotalIncomeText.Size = new System.Drawing.Size(169, 25);
            this.TotalIncomeText.Style = MetroFramework.MetroColorStyle.Green;
            this.TotalIncomeText.TabIndex = 4;
            this.TotalIncomeText.Text = "## #,###,###.##";
            this.TotalIncomeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TotalIncomeText.UseStyleColors = true;
            // 
            // TotalExpense
            // 
            this.TotalExpense.AutoSize = true;
            this.TotalExpense.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TotalExpense.Location = new System.Drawing.Point(5, 90);
            this.TotalExpense.Name = "TotalExpense";
            this.TotalExpense.Size = new System.Drawing.Size(113, 25);
            this.TotalExpense.TabIndex = 5;
            this.TotalExpense.Text = "Total Expense";
            // 
            // TotalExpenseText
            // 
            this.TotalExpenseText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TotalExpenseText.Location = new System.Drawing.Point(124, 65);
            this.TotalExpenseText.Name = "TotalExpenseText";
            this.TotalExpenseText.Size = new System.Drawing.Size(169, 25);
            this.TotalExpenseText.Style = MetroFramework.MetroColorStyle.Orange;
            this.TotalExpenseText.TabIndex = 6;
            this.TotalExpenseText.Text = "## #,###,###.##";
            this.TotalExpenseText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TotalExpenseText.UseStyleColors = true;
            // 
            // Spinner
            // 
            this.Spinner.Location = new System.Drawing.Point(923, -8);
            this.Spinner.Maximum = 100;
            this.Spinner.Name = "Spinner";
            this.Spinner.Size = new System.Drawing.Size(65, 65);
            this.Spinner.Spinning = false;
            this.Spinner.TabIndex = 9;
            this.Spinner.UseSelectable = true;
            this.Spinner.Value = 75;
            this.Spinner.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Tiles);
            this.Controls.Add(this.Spinner);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmMain";
            this.Text = "Personal Finance Management Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.Tiles.ResumeLayout(false);
            this.FlowLayoutPanel.ResumeLayout(false);
            this.Status.ResumeLayout(false);
            this.CurrencyConverterPanel.ResumeLayout(false);
            this.CurrencyConverterPanel.PerformLayout();
            this.EventsPanel.ResumeLayout(false);
            this.EventsPanel.PerformLayout();
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
        private MetroFramework.Controls.MetroLabel MonthlySummary;
        private MetroFramework.Controls.MetroLabel TotalIncome;
        private MetroFramework.Controls.MetroLabel TotalIncomeText;
        private MetroFramework.Controls.MetroLabel TotalExpenseText;
        private MetroFramework.Controls.MetroLabel TotalExpense;
        private MetroFramework.Controls.MetroLabel TotalSavingsText;
        private MetroFramework.Controls.MetroLabel TotalSavings;
        private MetroFramework.Controls.MetroProgressSpinner Spinner;
        private MetroFramework.Controls.MetroPanel StatusPanel;
        private MetroFramework.Controls.MetroPanel EventsPanel;
        private MetroFramework.Controls.MetroLabel UpcomingEvents;
        private MetroFramework.Controls.MetroTile Calendar;
        private MetroFramework.Controls.MetroTile Reports;
        private MetroFramework.Controls.MetroPanel CurrencyConverterPanel;
        private MetroFramework.Controls.MetroLabel CurrencyConverter;
        private MetroFramework.Controls.MetroComboBox CmbFromAmount;
        private MetroFramework.Controls.MetroTextBox TxtFromAmount;
        private MetroFramework.Controls.MetroTextBox TxtToAmount;
        private MetroFramework.Controls.MetroComboBox CmbToAmount;
        private System.Windows.Forms.FlowLayoutPanel EventsLayoutPanel;
    }
}

