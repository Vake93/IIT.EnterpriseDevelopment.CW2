namespace PFMS.Views
{
    partial class FrmSplash
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
            this.Title = new System.Windows.Forms.Label();
            this.Status = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // Spinner
            // 
            this.Spinner.Location = new System.Drawing.Point(30, 72);
            this.Spinner.Maximum = 100;
            this.Spinner.Name = "Spinner";
            this.Spinner.Size = new System.Drawing.Size(70, 70);
            this.Spinner.TabIndex = 1;
            this.Spinner.UseSelectable = true;
            this.Spinner.Value = 75;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(23, 30);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(418, 39);
            this.Title.TabIndex = 2;
            this.Title.Text = "Personal Finance Management";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(30, 295);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(123, 19);
            this.Status.TabIndex = 3;
            this.Status.Text = "Migrating database";
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 334);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Spinner);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSplash";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmSplash";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSplash_FormClosed);
            this.Shown += new System.EventHandler(this.FrmSplash_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroProgressSpinner Spinner;
        private System.Windows.Forms.Label Title;
        private MetroFramework.Controls.MetroLabel Status;
    }
}