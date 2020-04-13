namespace PFMS.Views
{
    partial class FrmSources
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
            this.Tabs = new MetroFramework.Controls.MetroTabControl();
            this.Income = new System.Windows.Forms.TabPage();
            this.IncomePanel = new MetroFramework.Controls.MetroPanel();
            this.IncomeLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Expense = new System.Windows.Forms.TabPage();
            this.ExpensePanel = new MetroFramework.Controls.MetroPanel();
            this.ExpenseLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.BtnNewItem = new MetroFramework.Controls.MetroLink();
            this.Tabs.SuspendLayout();
            this.Income.SuspendLayout();
            this.IncomePanel.SuspendLayout();
            this.Expense.SuspendLayout();
            this.ExpensePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Controls.Add(this.Income);
            this.Tabs.Controls.Add(this.Expense);
            this.Tabs.Location = new System.Drawing.Point(23, 63);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(954, 493);
            this.Tabs.TabIndex = 0;
            this.Tabs.UseSelectable = true;
            // 
            // Income
            // 
            this.Income.Controls.Add(this.IncomePanel);
            this.Income.Location = new System.Drawing.Point(4, 38);
            this.Income.Name = "Income";
            this.Income.Size = new System.Drawing.Size(946, 451);
            this.Income.TabIndex = 0;
            this.Income.Text = "Income Sources";
            // 
            // IncomePanel
            // 
            this.IncomePanel.Controls.Add(this.IncomeLayoutPanel);
            this.IncomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncomePanel.HorizontalScrollbarBarColor = true;
            this.IncomePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.IncomePanel.HorizontalScrollbarSize = 10;
            this.IncomePanel.Location = new System.Drawing.Point(0, 0);
            this.IncomePanel.Name = "IncomePanel";
            this.IncomePanel.Size = new System.Drawing.Size(946, 451);
            this.IncomePanel.TabIndex = 0;
            this.IncomePanel.VerticalScrollbarBarColor = true;
            this.IncomePanel.VerticalScrollbarHighlightOnWheel = false;
            this.IncomePanel.VerticalScrollbarSize = 10;
            // 
            // IncomeLayoutPanel
            // 
            this.IncomeLayoutPanel.AutoScroll = true;
            this.IncomeLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.IncomeLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncomeLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.IncomeLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.IncomeLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.IncomeLayoutPanel.Name = "IncomeLayoutPanel";
            this.IncomeLayoutPanel.Size = new System.Drawing.Size(946, 451);
            this.IncomeLayoutPanel.TabIndex = 2;
            this.IncomeLayoutPanel.WrapContents = false;
            // 
            // Expense
            // 
            this.Expense.Controls.Add(this.ExpensePanel);
            this.Expense.Location = new System.Drawing.Point(4, 38);
            this.Expense.Name = "Expense";
            this.Expense.Size = new System.Drawing.Size(696, 451);
            this.Expense.TabIndex = 1;
            this.Expense.Text = "Expense Sources";
            // 
            // ExpensePanel
            // 
            this.ExpensePanel.Controls.Add(this.ExpenseLayoutPanel);
            this.ExpensePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpensePanel.HorizontalScrollbarBarColor = true;
            this.ExpensePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ExpensePanel.HorizontalScrollbarSize = 10;
            this.ExpensePanel.Location = new System.Drawing.Point(0, 0);
            this.ExpensePanel.Name = "ExpensePanel";
            this.ExpensePanel.Size = new System.Drawing.Size(696, 451);
            this.ExpensePanel.TabIndex = 0;
            this.ExpensePanel.VerticalScrollbarBarColor = true;
            this.ExpensePanel.VerticalScrollbarHighlightOnWheel = false;
            this.ExpensePanel.VerticalScrollbarSize = 10;
            // 
            // ExpenseLayoutPanel
            // 
            this.ExpenseLayoutPanel.AutoScroll = true;
            this.ExpenseLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.ExpenseLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpenseLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ExpenseLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ExpenseLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ExpenseLayoutPanel.Name = "ExpenseLayoutPanel";
            this.ExpenseLayoutPanel.Size = new System.Drawing.Size(696, 451);
            this.ExpenseLayoutPanel.TabIndex = 3;
            this.ExpenseLayoutPanel.WrapContents = false;
            // 
            // Spinner
            // 
            this.Spinner.Location = new System.Drawing.Point(902, 8);
            this.Spinner.Maximum = 100;
            this.Spinner.Name = "Spinner";
            this.Spinner.Size = new System.Drawing.Size(75, 75);
            this.Spinner.Spinning = false;
            this.Spinner.TabIndex = 1;
            this.Spinner.UseSelectable = true;
            this.Spinner.Value = 75;
            this.Spinner.Visible = false;
            // 
            // BtnNewItem
            // 
            this.BtnNewItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNewItem.Location = new System.Drawing.Point(858, 562);
            this.BtnNewItem.Name = "BtnNewItem";
            this.BtnNewItem.Size = new System.Drawing.Size(115, 23);
            this.BtnNewItem.TabIndex = 2;
            this.BtnNewItem.Text = "Add New Source";
            this.BtnNewItem.UseSelectable = true;
            this.BtnNewItem.Click += new System.EventHandler(this.BtnNewItem_Click);
            // 
            // FrmSources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.Spinner);
            this.Controls.Add(this.BtnNewItem);
            this.Controls.Add(this.Tabs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmSources";
            this.ShowInTaskbar = false;
            this.Text = "Manage Income/Expense Sources";
            this.Shown += new System.EventHandler(this.FrmManageIncomeExpenseSources_Shown);
            this.Tabs.ResumeLayout(false);
            this.Income.ResumeLayout(false);
            this.IncomePanel.ResumeLayout(false);
            this.Expense.ResumeLayout(false);
            this.ExpensePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl Tabs;
        private System.Windows.Forms.TabPage Income;
        private System.Windows.Forms.TabPage Expense;
        private MetroFramework.Controls.MetroPanel ExpensePanel;
        private MetroFramework.Controls.MetroProgressSpinner Spinner;
        private MetroFramework.Controls.MetroLink BtnNewItem;
        private MetroFramework.Controls.MetroPanel IncomePanel;
        private System.Windows.Forms.FlowLayoutPanel IncomeLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel ExpenseLayoutPanel;
    }
}