namespace PFMS.Views
{
    partial class FrmLogin
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
            this.UserName = new MetroFramework.Controls.MetroLabel();
            this.UserNameText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.PasswordText = new MetroFramework.Controls.MetroTextBox();
            this.BtnLogin = new MetroFramework.Controls.MetroButton();
            this.BtnExit = new MetroFramework.Controls.MetroButton();
            this.ErrorText = new MetroFramework.Controls.MetroLabel();
            this.Spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.Register = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(23, 78);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(78, 19);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "User Name:";
            // 
            // UserNameText
            // 
            // 
            // 
            // 
            this.UserNameText.CustomButton.Image = null;
            this.UserNameText.CustomButton.Location = new System.Drawing.Point(373, 1);
            this.UserNameText.CustomButton.Name = "";
            this.UserNameText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UserNameText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserNameText.CustomButton.TabIndex = 1;
            this.UserNameText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserNameText.CustomButton.UseSelectable = true;
            this.UserNameText.CustomButton.Visible = false;
            this.UserNameText.Lines = new string[0];
            this.UserNameText.Location = new System.Drawing.Point(107, 78);
            this.UserNameText.MaxLength = 32767;
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.PasswordChar = '\0';
            this.UserNameText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserNameText.SelectedText = "";
            this.UserNameText.SelectionLength = 0;
            this.UserNameText.SelectionStart = 0;
            this.UserNameText.ShortcutsEnabled = true;
            this.UserNameText.Size = new System.Drawing.Size(395, 23);
            this.UserNameText.TabIndex = 1;
            this.UserNameText.UseSelectable = true;
            this.UserNameText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserNameText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 120);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Password:";
            // 
            // PasswordText
            // 
            // 
            // 
            // 
            this.PasswordText.CustomButton.Image = null;
            this.PasswordText.CustomButton.Location = new System.Drawing.Point(373, 1);
            this.PasswordText.CustomButton.Name = "";
            this.PasswordText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PasswordText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordText.CustomButton.TabIndex = 1;
            this.PasswordText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordText.CustomButton.UseSelectable = true;
            this.PasswordText.CustomButton.Visible = false;
            this.PasswordText.Lines = new string[0];
            this.PasswordText.Location = new System.Drawing.Point(107, 120);
            this.PasswordText.MaxLength = 32767;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordText.SelectedText = "";
            this.PasswordText.SelectionLength = 0;
            this.PasswordText.SelectionStart = 0;
            this.PasswordText.ShortcutsEnabled = true;
            this.PasswordText.Size = new System.Drawing.Size(395, 23);
            this.PasswordText.TabIndex = 3;
            this.PasswordText.UseSelectable = true;
            this.PasswordText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(377, 204);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(125, 50);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseSelectable = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(23, 204);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(125, 50);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseSelectable = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorText.Location = new System.Drawing.Point(23, 168);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(65, 19);
            this.ErrorText.TabIndex = 6;
            this.ErrorText.Text = "Error Text";
            this.ErrorText.UseCustomForeColor = true;
            // 
            // Spinner
            // 
            this.Spinner.Location = new System.Drawing.Point(154, 204);
            this.Spinner.Maximum = 100;
            this.Spinner.Name = "Spinner";
            this.Spinner.Size = new System.Drawing.Size(50, 50);
            this.Spinner.Speed = 2F;
            this.Spinner.Spinning = false;
            this.Spinner.TabIndex = 7;
            this.Spinner.UseSelectable = true;
            this.Spinner.Value = 75;
            this.Spinner.Visible = false;
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(377, 164);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(125, 23);
            this.Register.TabIndex = 8;
            this.Register.Text = "Register New User";
            this.Register.UseSelectable = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 278);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Spinner);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.UserNameText);
            this.Controls.Add(this.UserName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel UserName;
        private MetroFramework.Controls.MetroTextBox UserNameText;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox PasswordText;
        private MetroFramework.Controls.MetroButton BtnLogin;
        private MetroFramework.Controls.MetroButton BtnExit;
        private MetroFramework.Controls.MetroLabel ErrorText;
        private MetroFramework.Controls.MetroProgressSpinner Spinner;
        private MetroFramework.Controls.MetroLink Register;
    }
}