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
            this.Year = new MetroFramework.Controls.MetroLabel();
            this.CmbYear = new MetroFramework.Controls.MetroComboBox();
            this.CmbMonth = new MetroFramework.Controls.MetroComboBox();
            this.Month = new MetroFramework.Controls.MetroLabel();
            this.Spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.Panel = new MetroFramework.Controls.MetroPanel();
            this.EventLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NewEvent = new MetroFramework.Controls.MetroLink();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Year.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Year.Location = new System.Drawing.Point(23, 70);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(44, 25);
            this.Year.TabIndex = 7;
            this.Year.Text = "Year";
            // 
            // CmbYear
            // 
            this.CmbYear.FormattingEnabled = true;
            this.CmbYear.ItemHeight = 23;
            this.CmbYear.Location = new System.Drawing.Point(73, 70);
            this.CmbYear.Name = "CmbYear";
            this.CmbYear.Size = new System.Drawing.Size(141, 29);
            this.CmbYear.TabIndex = 6;
            this.CmbYear.UseSelectable = true;
            // 
            // CmbMonth
            // 
            this.CmbMonth.FormattingEnabled = true;
            this.CmbMonth.ItemHeight = 23;
            this.CmbMonth.Location = new System.Drawing.Point(291, 70);
            this.CmbMonth.Name = "CmbMonth";
            this.CmbMonth.Size = new System.Drawing.Size(141, 29);
            this.CmbMonth.TabIndex = 5;
            this.CmbMonth.UseSelectable = true;
            // 
            // Month
            // 
            this.Month.AutoSize = true;
            this.Month.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Month.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Month.Location = new System.Drawing.Point(220, 70);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(65, 25);
            this.Month.TabIndex = 4;
            this.Month.Text = "Month";
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
            // FrmCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.NewEvent);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Spinner);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.CmbYear);
            this.Controls.Add(this.CmbMonth);
            this.Controls.Add(this.Month);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmCalendar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Calendar";
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Year;
        private MetroFramework.Controls.MetroComboBox CmbYear;
        private MetroFramework.Controls.MetroComboBox CmbMonth;
        private MetroFramework.Controls.MetroLabel Month;
        private MetroFramework.Controls.MetroProgressSpinner Spinner;
        private MetroFramework.Controls.MetroPanel Panel;
        private System.Windows.Forms.FlowLayoutPanel EventLayoutPanel;
        private MetroFramework.Controls.MetroLink NewEvent;
    }
}