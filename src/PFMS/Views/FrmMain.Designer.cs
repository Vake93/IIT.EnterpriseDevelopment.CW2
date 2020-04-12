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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NewIncome = new MetroFramework.Controls.MetroTile();
            this.NewExpense = new MetroFramework.Controls.MetroTile();
            this.ManageSources = new MetroFramework.Controls.MetroTile();
            this.BankAccount = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.FlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.FlowLayoutPanel);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(954, 514);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // FlowLayoutPanel
            // 
            this.FlowLayoutPanel.Controls.Add(this.NewIncome);
            this.FlowLayoutPanel.Controls.Add(this.NewExpense);
            this.FlowLayoutPanel.Controls.Add(this.ManageSources);
            this.FlowLayoutPanel.Controls.Add(this.BankAccount);
            this.FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.metroPanel1);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmMain";
            this.Text = "Personal Finance Management Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.metroPanel1.ResumeLayout(false);
            this.FlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel;
        private MetroFramework.Controls.MetroTile NewIncome;
        private MetroFramework.Controls.MetroTile ManageSources;
        private MetroFramework.Controls.MetroTile NewExpense;
        private MetroFramework.Controls.MetroTile BankAccount;
    }
}

