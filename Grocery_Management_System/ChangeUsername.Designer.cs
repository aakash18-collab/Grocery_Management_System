namespace Grocery_Management_System
{
    partial class ChangeUsername
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeUsername));
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOldUsername = new System.Windows.Forms.TextBox();
            this.btnChangeUsername = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChangeUsername = new System.Windows.Forms.TextBox();
            this.txtConfirmUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(107, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(581, 1);
            this.label9.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Serifa BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(272, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 35);
            this.label2.TabIndex = 42;
            this.label2.Text = "Change Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Old Username";
            // 
            // txtOldUsername
            // 
            this.txtOldUsername.Location = new System.Drawing.Point(357, 160);
            this.txtOldUsername.Name = "txtOldUsername";
            this.txtOldUsername.Size = new System.Drawing.Size(283, 27);
            this.txtOldUsername.TabIndex = 46;
            // 
            // btnChangeUsername
            // 
            this.btnChangeUsername.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnChangeUsername.Location = new System.Drawing.Point(501, 317);
            this.btnChangeUsername.Name = "btnChangeUsername";
            this.btnChangeUsername.Size = new System.Drawing.Size(139, 36);
            this.btnChangeUsername.TabIndex = 49;
            this.btnChangeUsername.Text = "Change Username";
            this.btnChangeUsername.UseVisualStyleBackColor = false;
            this.btnChangeUsername.Click += new System.EventHandler(this.btnChangeUsername_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "New Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Confirm Username";
            // 
            // txtChangeUsername
            // 
            this.txtChangeUsername.Location = new System.Drawing.Point(357, 213);
            this.txtChangeUsername.Name = "txtChangeUsername";
            this.txtChangeUsername.Size = new System.Drawing.Size(283, 27);
            this.txtChangeUsername.TabIndex = 52;
            // 
            // txtConfirmUsername
            // 
            this.txtConfirmUsername.Location = new System.Drawing.Point(357, 272);
            this.txtConfirmUsername.Name = "txtConfirmUsername";
            this.txtConfirmUsername.Size = new System.Drawing.Size(283, 27);
            this.txtConfirmUsername.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(107, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(581, 1);
            this.label5.TabIndex = 54;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClear.Location = new System.Drawing.Point(357, 317);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 36);
            this.btnClear.TabIndex = 55;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ChangeUsername
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 414);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtConfirmUsername);
            this.Controls.Add(this.txtChangeUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeUsername);
            this.Controls.Add(this.txtOldUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeUsername";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Username";
            this.Load += new System.EventHandler(this.ChangeUsername_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label9;
        private Label label2;
        private Label label3;
        private TextBox txtOldUsername;
        private Button btnChangeUsername;
        private Label label1;
        private Label label4;
        private TextBox txtChangeUsername;
        private TextBox txtConfirmUsername;
        private Label label5;
        private Button btnClear;
    }
}