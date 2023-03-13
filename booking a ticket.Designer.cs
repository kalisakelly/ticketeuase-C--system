namespace Ticketeuse
{
    partial class booking_a_ticket
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
            label7 = new Label();
            label8 = new Label();
            nametxt = new TextBox();
            phonetxt = new TextBox();
            emailtxt = new TextBox();
            paymentcombbox = new ComboBox();
            eventbox = new ComboBox();
            label9 = new Label();
            numbertxt = new TextBox();
            label10 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            comboBox3 = new ComboBox();
            label11 = new Label();
            ticketscombobox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(463, 86);
            label1.Name = "label1";
            label1.Size = new Size(280, 45);
            label1.TabIndex = 0;
            label1.Text = "Book your ticket";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InfoText;
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(593, 36);
            label2.Name = "label2";
            label2.Size = new Size(168, 32);
            label2.TabIndex = 1;
            label2.Text = "Logined in as :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(795, 36);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 149);
            label4.Name = "label4";
            label4.Size = new Size(74, 32);
            label4.TabIndex = 3;
            label4.Text = "name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(115, 236);
            label5.Name = "label5";
            label5.Size = new Size(82, 32);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(116, 455);
            label6.Name = "label6";
            label6.Size = new Size(73, 32);
            label6.TabIndex = 5;
            label6.Text = "Event";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(115, 381);
            label7.Name = "label7";
            label7.Size = new Size(175, 32);
            label7.TabIndex = 6;
            label7.Text = "Payment mode";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(118, 309);
            label8.Name = "label8";
            label8.Size = new Size(71, 32);
            label8.TabIndex = 7;
            label8.Text = "Email";
            // 
            // nametxt
            // 
            nametxt.BackColor = SystemColors.Info;
            nametxt.Location = new Point(339, 149);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(520, 39);
            nametxt.TabIndex = 8;
            // 
            // phonetxt
            // 
            phonetxt.BackColor = SystemColors.Info;
            phonetxt.Location = new Point(339, 218);
            phonetxt.Name = "phonetxt";
            phonetxt.Size = new Size(520, 39);
            phonetxt.TabIndex = 9;
            // 
            // emailtxt
            // 
            emailtxt.BackColor = SystemColors.Info;
            emailtxt.Location = new Point(339, 292);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(520, 39);
            emailtxt.TabIndex = 10;
            // 
            // paymentcombbox
            // 
            paymentcombbox.BackColor = SystemColors.Info;
            paymentcombbox.FormattingEnabled = true;
            paymentcombbox.Items.AddRange(new object[] { "credit card", "Paypal", "mobile money", "airtel money" });
            paymentcombbox.Location = new Point(339, 358);
            paymentcombbox.Name = "paymentcombbox";
            paymentcombbox.Size = new Size(520, 40);
            paymentcombbox.TabIndex = 11;
            paymentcombbox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // eventbox
            // 
            eventbox.BackColor = SystemColors.Info;
            eventbox.FormattingEnabled = true;
            eventbox.Location = new Point(339, 455);
            eventbox.Name = "eventbox";
            eventbox.Size = new Size(520, 40);
            eventbox.TabIndex = 12;
            eventbox.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(103, 622);
            label9.Name = "label9";
            label9.Size = new Size(135, 32);
            label9.TabIndex = 13;
            label9.Text = "No of seats";
            // 
            // numbertxt
            // 
            numbertxt.BackColor = SystemColors.Info;
            numbertxt.Location = new Point(353, 615);
            numbertxt.Name = "numbertxt";
            numbertxt.Size = new Size(520, 39);
            numbertxt.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(103, 698);
            label10.Name = "label10";
            label10.Size = new Size(137, 32);
            label10.TabIndex = 15;
            label10.Text = "Parking slot";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(103, 856);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 17;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(393, 856);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 18;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(734, 856);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 19;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // comboBox3
            // 
            comboBox3.AutoCompleteCustomSource.AddRange(new string[] { "slot1", "slot2", "slot3", "slot4" });
            comboBox3.BackColor = SystemColors.Info;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "slot1", "slot2", "slot3", "slot4" });
            comboBox3.Location = new Point(337, 690);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(536, 40);
            comboBox3.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(116, 544);
            label11.Name = "label11";
            label11.Size = new Size(87, 32);
            label11.TabIndex = 20;
            label11.Text = "Tickets";
            // 
            // ticketscombobox
            // 
            ticketscombobox.FormattingEnabled = true;
            ticketscombobox.Items.AddRange(new object[] { "5000", "10000", "15000" });
            ticketscombobox.Location = new Point(328, 536);
            ticketscombobox.Name = "ticketscombobox";
            ticketscombobox.Size = new Size(512, 40);
            ticketscombobox.TabIndex = 21;
            ticketscombobox.SelectedIndexChanged += ticketscombobox_SelectedIndexChanged;
            // 
            // booking_a_ticket
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1101, 1022);
            Controls.Add(ticketscombobox);
            Controls.Add(label11);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(label10);
            Controls.Add(numbertxt);
            Controls.Add(label9);
            Controls.Add(eventbox);
            Controls.Add(paymentcombbox);
            Controls.Add(emailtxt);
            Controls.Add(phonetxt);
            Controls.Add(nametxt);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "booking_a_ticket";
            Text = "booking_a_ticket";
            Load += booking_a_ticket_Load;
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
        private Label label7;
        private Label label8;
        private TextBox nametxt;
        private TextBox phonetxt;
        private TextBox emailtxt;
        private ComboBox paymentcombbox;
        private ComboBox eventbox;
        private Label label9;
        private TextBox numbertxt;
        private Label label10;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox comboBox3;
        private Label label11;
        private ComboBox ticketscombobox;
    }
}