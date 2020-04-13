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
            this.Status = new MetroFramework.Controls.MetroPanel();
            this.Stats = new MetroFramework.Controls.MetroLabel();
            this.TotalIncome = new MetroFramework.Controls.MetroLabel();
            this.TotalIncomeText = new MetroFramework.Controls.MetroLabel();
            this.TotalExpense = new MetroFramework.Controls.MetroLabel();
            this.TotalExpenseText = new MetroFramework.Controls.MetroLabel();
            this.Tiles.SuspendLayout();
            this.FlowLayoutPanel.SuspendLayout();
            this.Status.SuspendLayout();
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
            // 
            // Status
            // 
            this.Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Status.Controls.Add(this.TotalExpenseText);
            this.Status.Controls.Add(this.TotalExpense);
            this.Status.Controls.Add(this.TotalIncomeText);
            this.Status.Controls.Add(this.TotalIncome);
            this.Status.Controls.Add(this.Stats);
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
            // Stats
            // 
            this.Stats.AutoSize = true;
            this.Stats.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Stats.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Stats.Location = new System.Drawing.Point(3, 3);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(159, 25);
            this.Stats.TabIndex = 2;
            this.Stats.Text = "Monthly Summary";
            // 
            // TotalIncome
            // 
            this.TotalIncome.AutoSize = true;
            this.TotalIncome.Location = new System.Drawing.Point(16, 48);
            this.TotalIncome.Name = "TotalIncome";
            this.TotalIncome.Size = new System.Drawing.Size(83, 19);
            this.TotalIncome.TabIndex = 3;
            this.TotalIncome.Text = "Total Income";
            // 
            // TotalIncomeText
            // 
            this.TotalIncomeText.AutoSize = true;
            this.TotalIncomeText.Location = new System.Drawing.Point(183, 48);
            this.TotalIncomeText.Name = "TotalIncomeText";
            this.TotalIncomeText.Size = new System.Drawing.Size(110, 19);
            this.TotalIncomeText.TabIndex = 4;
            this.TotalIncomeText.Text = "## #,###,###.##";
            // 
            // TotalExpense
            // 
            this.TotalExpense.AutoSize = true;
            this.TotalExpense.Location = new System.Drawing.Point(16, 67);
            this.TotalExpense.Name = "TotalExpense";
            this.TotalExpense.Size = new System.Drawing.Size(87, 19);
            this.TotalExpense.TabIndex = 5;
            this.TotalExpense.Text = "Total Expense";
            // 
            // TotalExpenseText
            // 
            this.TotalExpenseText.AutoSize = true;
            this.TotalExpenseText.Location = new System.Drawing.Point(183, 67);
            this.TotalExpenseText.Name = "TotalExpenseText";
            this.TotalExpenseText.Size = new System.Drawing.Size(110, 19);
            this.TotalExpenseText.TabIndex = 6;
            this.TotalExpenseText.Text = "## #,###,###.##";
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
            this.Status.PerformLayout();
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
    }
}

