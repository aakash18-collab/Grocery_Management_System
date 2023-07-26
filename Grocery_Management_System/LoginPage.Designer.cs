namespace Grocery_Management_System
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            btnClear = new Button();
            label6 = new Label();
            label5 = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            btnExit = new Button();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Location = new Point(215, 440);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(139, 46);
            btnClear.TabIndex = 25;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button2_Click;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(51, 159);
            label6.Name = "label6";
            label6.Size = new Size(450, 1);
            label6.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(51, 176);
            label5.Name = "label5";
            label5.Size = new Size(202, 33);
            label5.TabIndex = 22;
            label5.Text = "Admin Login";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.ForeColor = SystemColors.ControlText;
            btnLogin.Location = new Point(51, 440);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(158, 46);
            btnLogin.TabIndex = 20;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(51, 392);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '☻';
            txtPassword.Size = new Size(450, 27);
            txtPassword.TabIndex = 19;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(51, 303);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(450, 27);
            txtUsername.TabIndex = 18;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(51, 346);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 17;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(51, 254);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 16;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(181, 5);
            label1.Name = "label1";
            label1.Size = new Size(189, 37);
            label1.TabIndex = 15;
            label1.Text = "GROCERY";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(533, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(491, 481);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(51, 231);
            label4.Name = "label4";
            label4.Size = new Size(450, 1);
            label4.TabIndex = 27;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(360, 440);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(141, 46);
            btnExit.TabIndex = 28;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("PMingLiU-ExtB", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(181, 90);
            label8.Name = "label8";
            label8.Size = new Size(159, 37);
            label8.TabIndex = 29;
            label8.Text = "SYSTEM";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(26, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(149, 151);
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("PMingLiU-ExtB", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(181, 50);
            label9.Name = "label9";
            label9.Size = new Size(277, 37);
            label9.TabIndex = 31;
            label9.Text = "MANAGEMENT";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1035, 497);
            Controls.Add(label9);
            Controls.Add(pictureBox2);
            Controls.Add(label8);
            Controls.Add(btnExit);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(btnClear);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Label label6;
        private Label label5;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private Button btnExit;
        private Label label8;
        private PictureBox pictureBox2;
        private Label label9;
    }
}