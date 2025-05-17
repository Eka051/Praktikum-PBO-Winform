namespace Praktikum_PBO_Winform
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbUsername = new TextBox();
            pictureBox1 = new PictureBox();
            tbPassword = new TextBox();
            label1 = new Label();
            RegisterLink = new LinkLabel();
            BtnShowPassword = new Button();
            BtnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.ForeColor = Color.Black;
            tbUsername.Location = new Point(581, 335);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(321, 22);
            tbUsername.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Frame_8;
            pictureBox1.Location = new Point(516, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(452, 536);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.ForeColor = Color.Black;
            tbPassword.Location = new Point(581, 449);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(267, 22);
            tbPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(605, 693);
            label1.Name = "label1";
            label1.Size = new Size(177, 23);
            label1.TabIndex = 10;
            label1.Text = "Belum memiliki akun?";
            // 
            // RegisterLink
            // 
            RegisterLink.AutoSize = true;
            RegisterLink.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterLink.Location = new Point(788, 693);
            RegisterLink.Name = "RegisterLink";
            RegisterLink.Size = new Size(72, 23);
            RegisterLink.TabIndex = 11;
            RegisterLink.TabStop = true;
            RegisterLink.Text = "Register";
            RegisterLink.LinkClicked += RegisterLink_LinkClicked;
            // 
            // BtnShowPassword
            // 
            BtnShowPassword.BackgroundImage = Properties.Resources.eye_on;
            BtnShowPassword.BackgroundImageLayout = ImageLayout.Zoom;
            BtnShowPassword.Location = new Point(861, 440);
            BtnShowPassword.Name = "BtnShowPassword";
            BtnShowPassword.Size = new Size(41, 43);
            BtnShowPassword.TabIndex = 12;
            BtnShowPassword.Text = " ";
            BtnShowPassword.UseVisualStyleBackColor = true;
            BtnShowPassword.Click += BtnShowPassword_Click_1;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.Gold;
            BtnLogin.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = SystemColors.ControlText;
            BtnLogin.Location = new Point(562, 545);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(361, 69);
            BtnLogin.TabIndex = 3;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1484, 761);
            Controls.Add(BtnLogin);
            Controls.Add(BtnShowPassword);
            Controls.Add(RegisterLink);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(pictureBox1);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUsername;
        private PictureBox pictureBox1;
        private TextBox tbPassword;
        private Label label1;
        private LinkLabel RegisterLink;
        private Button BtnShowPassword;
        private Button BtnLogin;
    }
}
