namespace Ticketeuse
{
    partial class login
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
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            txtUsername = new TextBox();
            button1 = new Button();
            label5 = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("SimSun-ExtB", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(277, 27);
            label1.Name = "label1";
            label1.Size = new Size(686, 43);
            label1.TabIndex = 0;
            label1.Text = "Login your ticketeuse account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Location = new Point(106, 226);
            label2.Name = "label2";
            label2.Size = new Size(121, 32);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(467, 110);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Blue;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.ActiveCaption;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(106, 511);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(298, 32);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "First time using Ticketeuse";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Gray;
            txtUsername.Location = new Point(354, 223);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(628, 39);
            txtUsername.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Location = new Point(526, 444);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Location = new Point(115, 321);
            label5.Name = "label5";
            label5.Size = new Size(111, 32);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Gray;
            txtPassword.Location = new Point(354, 314);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(628, 39);
            txtPassword.TabIndex = 9;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1189, 605);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(txtUsername);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "login";
            Text = "Login";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private LinkLabel linkLabel1;
        private TextBox txtUsername;
        private Button button1;
        private Label label5;
        private TextBox txtPassword;
    }
}