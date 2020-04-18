namespace PFMS.Views.Common
{
    partial class CtrlUpcomingEventItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EventTitle = new MetroFramework.Controls.MetroLabel();
            this.EventDate = new MetroFramework.Controls.MetroLabel();
            this.EventLocation = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // EventTitle
            // 
            this.EventTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.EventTitle.Location = new System.Drawing.Point(3, 0);
            this.EventTitle.Name = "EventTitle";
            this.EventTitle.Size = new System.Drawing.Size(254, 23);
            this.EventTitle.TabIndex = 0;
            this.EventTitle.Text = "Event Title";
            this.EventTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EventTitle.UseCustomForeColor = true;
            // 
            // EventDate
            // 
            this.EventDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventDate.Location = new System.Drawing.Point(3, 23);
            this.EventDate.Name = "EventDate";
            this.EventDate.Size = new System.Drawing.Size(254, 23);
            this.EventDate.TabIndex = 1;
            this.EventDate.Text = "Event Date";
            this.EventDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EventLocation
            // 
            this.EventLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventLocation.Location = new System.Drawing.Point(3, 56);
            this.EventLocation.Name = "EventLocation";
            this.EventLocation.Size = new System.Drawing.Size(254, 44);
            this.EventLocation.TabIndex = 2;
            this.EventLocation.Text = "Event Location";
            // 
            // CtrlUpcomingEventItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EventLocation);
            this.Controls.Add(this.EventDate);
            this.Controls.Add(this.EventTitle);
            this.Name = "CtrlUpcomingEventItem";
            this.Size = new System.Drawing.Size(260, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel EventTitle;
        private MetroFramework.Controls.MetroLabel EventDate;
        private MetroFramework.Controls.MetroLabel EventLocation;
    }
}
