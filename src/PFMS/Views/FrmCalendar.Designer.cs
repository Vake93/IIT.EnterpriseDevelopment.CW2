namespace PFMS.Views
{
    partial class FrmCalendar
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
            this.Date = new MetroFramework.Controls.MetroLabel();
            this.Spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.Panel = new MetroFramework.Controls.MetroPanel();
            this.EventLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NewEvent = new MetroFramework.Controls.MetroLink();
            this.CmbDate = new MetroFramework.Controls.MetroDateTime();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Date.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Date.Location = new System.Drawing.Point(23, 70);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(53, 25);
            this.Date.TabIndex = 7;
            this.Date.Text = "Date:";
            // 
            // Spinner
            // 
            this.Spinner.Location = new System.Drawing.Point(902, 10);
            this.Spinner.Maximum = 100;
            this.Spinner.Name = "Spinner";
            this.Spinner.Size = new System.Drawing.Size(75, 75);
            this.Spinner.Spinning = false;
            this.Spinner.TabIndex = 8;
            this.Spinner.UseSelectable = true;
            this.Spinner.Value = 75;
            this.Spinner.Visible = false;
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.Controls.Add(this.EventLayoutPanel);
            this.Panel.HorizontalScrollbarBarColor = true;
            this.Panel.HorizontalScrollbarHighlightOnWheel = false;
            this.Panel.HorizontalScrollbarSize = 10;
            this.Panel.Location = new System.Drawing.Point(23, 105);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(954, 443);
            this.Panel.TabIndex = 9;
            this.Panel.VerticalScrollbarBarColor = true;
            this.Panel.VerticalScrollbarHighlightOnWheel = false;
            this.Panel.VerticalScrollbarSize = 10;
            // 
            // EventLayoutPanel
            // 
            this.EventLayoutPanel.AutoScroll = true;
            this.EventLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.EventLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.EventLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.EventLayoutPanel.Name = "EventLayoutPanel";
            this.EventLayoutPanel.Size = new System.Drawing.Size(954, 443);
            this.EventLayoutPanel.TabIndex = 2;
            this.EventLayoutPanel.WrapContents = false;
            // 
            // NewEvent
            // 
            this.NewEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NewEvent.Location = new System.Drawing.Point(856, 554);
            this.NewEvent.Name = "NewEvent";
            this.NewEvent.Size = new System.Drawing.Size(121, 23);
            this.NewEvent.TabIndex = 6;
            this.NewEvent.Text = "Add New Event";
            this.NewEvent.UseSelectable = true;
            this.NewEvent.Click += new System.EventHandler(this.NewEvent_Click);
            // 
            // CmbDate
            // 
            this.CmbDate.Location = new System.Drawing.Point(82, 70);
            this.CmbDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.CmbDate.Name = "CmbDate";
            this.CmbDate.Size = new System.Drawing.Size(200, 29);
            this.CmbDate.TabIndex = 10;
            this.CmbDate.ValueChanged += new System.EventHandler(this.CmbDate_ValueChanged);
            // 
            // FrmCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.CmbDate);
            this.Controls.Add(this.NewEvent);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Spinner);
            this.Controls.Add(this.Date);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmCalendar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Calendar";
            this.Shown += new System.EventHandler(this.FrmCalendar_Shown);
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Date;
        private MetroFramework.Controls.MetroProgressSpinner Spinner;
        private MetroFramework.Controls.MetroPanel Panel;
        private System.Windows.Forms.FlowLayoutPanel EventLayoutPanel;
        private MetroFramework.Controls.MetroLink NewEvent;
        private MetroFramework.Controls.MetroDateTime CmbDate;
    }
}