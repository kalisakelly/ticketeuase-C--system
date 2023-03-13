namespace Ticketeuse
{
    partial class admin_panel
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("SimSun-ExtB", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 311);
            button1.Name = "button1";
            button1.Size = new Size(246, 173);
            button1.TabIndex = 0;
            button1.Text = "Events";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("SimSun", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(401, 311);
            button2.Name = "button2";
            button2.Size = new Size(246, 173);
            button2.TabIndex = 1;
            button2.Text = "Tickets bought";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(613, 29);
            label1.Name = "label1";
            label1.Size = new Size(181, 40);
            label1.TabIndex = 4;
            label1.Text = "Logined as :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(800, 32);
            label2.Name = "label2";
            label2.Size = new Size(96, 37);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(384, 137);
            label3.Name = "label3";
            label3.Size = new Size(318, 45);
            label3.TabIndex = 6;
            label3.Text = "Management board";
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("SimSun-ExtB", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(765, 311);
            button4.Name = "button4";
            button4.Size = new Size(246, 173);
            button4.TabIndex = 7;
            button4.Text = "view all events";
            button4.UseVisualStyleBackColor = false;
            // 
            // admin_panel
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1096, 812);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "admin_panel";
            Text = "admin_panel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button4;
    }
}