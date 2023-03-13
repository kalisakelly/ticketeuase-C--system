namespace Ticketeuse
{
    partial class signup
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            usernametxt = new TextBox();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("SimSun", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(246, 65);
            label1.Name = "label1";
            label1.Size = new Size(732, 43);
            label1.TabIndex = 0;
            label1.Text = "Register yourself in ticketeuse";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 388);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 292);
            label3.Name = "label3";
            label3.Size = new Size(173, 32);
            label3.TabIndex = 2;
            label3.Text = "Phone number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 192);
            label4.Name = "label4";
            label4.Size = new Size(121, 32);
            label4.TabIndex = 3;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(133, 480);
            label5.Name = "label5";
            label5.Size = new Size(206, 32);
            label5.TabIndex = 4;
            label5.Text = "Confirm password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(538, 799);
            label6.Name = "label6";
            label6.Size = new Size(78, 32);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // usernametxt
            // 
            usernametxt.BackColor = SystemColors.WindowFrame;
            usernametxt.ForeColor = Color.White;
            usernametxt.Location = new Point(415, 185);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(605, 39);
            usernametxt.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.WindowFrame;
            txtPhone.ForeColor = Color.White;
            txtPhone.Location = new Point(415, 292);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(605, 39);
            txtPhone.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.WindowFrame;
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(415, 385);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(605, 39);
            txtPassword.TabIndex = 8;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = SystemColors.WindowFrame;
            txtConfirmPassword.ForeColor = Color.White;
            txtConfirmPassword.Location = new Point(415, 473);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(605, 39);
            txtConfirmPassword.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(294, 636);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 10;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(665, 636);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 11;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1151, 906);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtPhone);
            Controls.Add(usernametxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "signup";
            Text = "Signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox usernametxt;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button button1;
        private Button button2;
    }
}