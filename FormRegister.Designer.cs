namespace Praktikum_PBO_Winform
{
    partial class FormRegister
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
            BtnShowPassword = new Button();
            LoginLink = new LinkLabel();
            label1 = new Label();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            pictureBox1 = new PictureBox();
            BtnRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnShowPassword
            // 
            BtnShowPassword.BackgroundImage = Properties.Resources.eye_on;
            BtnShowPassword.BackgroundImageLayout = ImageLayout.Zoom;
            BtnShowPassword.Location = new Point(861, 393);
            BtnShowPassword.Name = "BtnShowPassword";
            BtnShowPassword.Size = new Size(41, 43);
            BtnShowPassword.TabIndex = 19;
            BtnShowPassword.Text = " ";
            BtnShowPassword.UseVisualStyleBackColor = true;
            BtnShowPassword.Click += BtnShowPassword_Click;
            // 
            // LoginLink
            // 
            LoginLink.AutoSize = true;
            LoginLink.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginLink.Location = new Point(816, 646);
            LoginLink.Name = "LoginLink";
            LoginLink.Size = new Size(51, 23);
            LoginLink.TabIndex = 18;
            LoginLink.TabStop = true;
            LoginLink.Text = "Login";
            LoginLink.LinkClicked += LoginLink_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(633, 646);
            label1.Name = "label1";
            label1.Size = new Size(177, 23);
            label1.TabIndex = 17;
            label1.Text = "Sudah memiliki akun?";
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.ForeColor = Color.Black;
            tbPassword.Location = new Point(581, 402);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(267, 22);
            tbPassword.TabIndex = 14;
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.ForeColor = Color.Black;
            tbUsername.Location = new Point(581, 288);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(321, 22);
            tbUsername.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Frame_9;
            pictureBox1.Location = new Point(516, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(452, 536);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // BtnRegister
            // 
            BtnRegister.BackColor = Color.Gold;
            BtnRegister.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegister.ForeColor = SystemColors.ControlText;
            BtnRegister.Location = new Point(563, 499);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(361, 69);
            BtnRegister.TabIndex = 20;
            BtnRegister.Text = "Register";
            BtnRegister.UseVisualStyleBackColor = false;
            BtnRegister.Click += BtnRegister_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1484, 761);
            Controls.Add(BtnRegister);
            Controls.Add(BtnShowPassword);
            Controls.Add(LoginLink);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(pictureBox1);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnShowPassword;
        private LinkLabel LoginLink;
        private Label label1;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private PictureBox pictureBox1;
        private Button BtnRegister;
    }
}