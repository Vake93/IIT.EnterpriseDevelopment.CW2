namespace PFMS.Views
{
    partial class FrmBankAccount
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
            this.MetroPanel = new MetroFramework.Controls.MetroPanel();
            this.NewBankAccount = new MetroFramework.Controls.MetroLink();
            this.FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MetroPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Spinner
            // 
            this.Spinner.Location = new System.Drawing.Point(902, 8);
            this.Spinner.Maximum = 100;
            this.Spinner.Name = "Spinner";
            this.Spinner.Size = new System.Drawing.Size(75, 75);
            this.Spinner.Spinning = false;
            this.Spinner.TabIndex = 12;
            this.Spinner.UseSelectable = true;
            this.Spinner.Value = 75;
            this.Spinner.Visible = false;
            // 
            // MetroPanel
            // 
            this.MetroPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetroPanel.Controls.Add(this.FlowLayoutPanel);
            this.MetroPanel.HorizontalScrollbarBarColor = true;
            this.MetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.MetroPanel.HorizontalScrollbarSize = 10;
            this.MetroPanel.Location = new System.Drawing.Point(23, 63);
            this.MetroPanel.Name = "MetroPanel";
            this.MetroPanel.Size = new System.Drawing.Size(954, 485);
            this.MetroPanel.TabIndex = 13;
            this.MetroPanel.VerticalScrollbarBarColor = true;
            this.MetroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.MetroPanel.VerticalScrollbarSize = 10;
            // 
            // NewBankAccount
            // 
            this.NewBankAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NewBankAccount.Location = new System.Drawing.Point(856, 554);
            this.NewBankAccount.Name = "NewBankAccount";
            this.NewBankAccount.Size = new System.Drawing.Size(121, 23);
            this.NewBankAccount.TabIndex = 14;
            this.NewBankAccount.Text = "Add Bank Account";
            this.NewBankAccount.UseSelectable = true;
            this.NewBankAccount.Click += new System.EventHandler(this.NewBankAccount_Click);
            // 
            // FlowLayoutPanel
            // 
            this.FlowLayoutPanel.AutoScroll = true;
            this.FlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanel.Name = "FlowLayoutPanel";
            this.FlowLayoutPanel.Size = new System.Drawing.Size(954, 485);
            this.FlowLayoutPanel.TabIndex = 2;
            this.FlowLayoutPanel.WrapContents = false;
            // 
            // FrmBankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.NewBankAccount);
            this.Controls.Add(this.MetroPanel);
            this.Controls.Add(this.Spinner);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmBankAccount";
            this.ShowInTaskbar = false;
            this.Text = "Bank Account Details";
            this.Shown += new System.EventHandler(this.FrmBankAccount_Shown);
            this.MetroPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner Spinner;
        private MetroFramework.Controls.MetroPanel MetroPanel;
        private MetroFramework.Controls.MetroLink NewBankAccount;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel;
    }
}