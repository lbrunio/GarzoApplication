namespace GarzoApplication.Views
{
    partial class Login
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            signLabel = new Label();
            userLabel = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            passLabel = new Label();
            shwPass = new CheckBox();
            btnLogin = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // signLabel
            // 
            signLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signLabel.AutoSize = true;
            signLabel.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signLabel.ForeColor = Color.FromArgb(0, 125, 255);
            signLabel.Location = new Point(26, 34);
            signLabel.Name = "signLabel";
            signLabel.Size = new Size(102, 37);
            signLabel.TabIndex = 0;
            signLabel.Text = "Sign In";
            // 
            // userLabel
            // 
            userLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userLabel.AutoSize = true;
            userLabel.Location = new Point(26, 116);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(69, 17);
            userLabel.TabIndex = 1;
            userLabel.Text = "Username";
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUser.BackColor = Color.FromArgb(230, 231, 233);
            txtUser.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(26, 136);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(366, 35);
            txtUser.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(26, 216);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(366, 35);
            txtPassword.TabIndex = 3;
            // 
            // passLabel
            // 
            passLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passLabel.AutoSize = true;
            passLabel.Location = new Point(26, 196);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(66, 17);
            passLabel.TabIndex = 4;
            passLabel.Text = "Password";
            // 
            // shwPass
            // 
            shwPass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            shwPass.AutoSize = true;
            shwPass.Cursor = Cursors.Hand;
            shwPass.FlatStyle = FlatStyle.Flat;
            shwPass.Location = new Point(273, 257);
            shwPass.Name = "shwPass";
            shwPass.Size = new Size(119, 21);
            shwPass.TabIndex = 5;
            shwPass.Text = "Show password";
            shwPass.UseVisualStyleBackColor = true;
            shwPass.CheckedChanged += shwPass_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.BackColor = Color.FromArgb(0, 125, 255);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(26, 313);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(366, 35);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnExit.BackColor = Color.White;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.FromArgb(0, 125, 255);
            btnExit.Location = new Point(26, 372);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(366, 35);
            btnExit.TabIndex = 7;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(268, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 50);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(423, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(shwPass);
            Controls.Add(passLabel);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(userLabel);
            Controls.Add(signLabel);
            Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label signLabel;
        private Label userLabel;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label passLabel;
        private CheckBox shwPass;
        private Button btnLogin;
        private Button btnExit;
        private PictureBox pictureBox1;
    }
}