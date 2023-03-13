namespace Ticketeuse
{
    partial class events
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
            dtpDate = new DateTimePicker();
            dtpTime = new TextBox();
            txtLocation = new TextBox();
            txtPerformers = new TextBox();
            savebtn = new Button();
            updatebtn = new Button();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            IDTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            searchbtn = new Button();
            label7 = new Label();
            eventnametxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 16.1249981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(450, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 62);
            label1.TabIndex = 0;
            label1.Text = "Events";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(138, 272);
            label2.Name = "label2";
            label2.Size = new Size(77, 29);
            label2.TabIndex = 1;
            label2.Text = "Date";
            label2.Click += label2_Click;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(388, 266);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(400, 39);
            dtpDate.TabIndex = 5;
            // 
            // dtpTime
            // 
            dtpTime.Location = new Point(406, 351);
            dtpTime.Name = "dtpTime";
            dtpTime.Size = new Size(394, 39);
            dtpTime.TabIndex = 6;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(394, 445);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(394, 39);
            txtLocation.TabIndex = 7;
            // 
            // txtPerformers
            // 
            txtPerformers.Location = new Point(394, 548);
            txtPerformers.Name = "txtPerformers";
            txtPerformers.Size = new Size(394, 39);
            txtPerformers.TabIndex = 8;
            // 
            // savebtn
            // 
            savebtn.Location = new Point(114, 676);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(150, 46);
            savebtn.TabIndex = 9;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.Location = new Point(446, 676);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(150, 46);
            updatebtn.TabIndex = 10;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += updatebtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(765, 676);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 11;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(138, 361);
            label3.Name = "label3";
            label3.Size = new Size(77, 29);
            label3.TabIndex = 12;
            label3.Text = "Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(138, 445);
            label4.Name = "label4";
            label4.Size = new Size(141, 29);
            label4.TabIndex = 13;
            label4.Text = "Location";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(138, 558);
            label5.Name = "label5";
            label5.Size = new Size(141, 29);
            label5.TabIndex = 14;
            label5.Text = "Performs";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(256, 112);
            label6.Name = "label6";
            label6.Size = new Size(100, 32);
            label6.TabIndex = 15;
            label6.Text = "Event id";
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(394, 113);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.PlaceholderText = "Enter id";
            IDTextBox.Size = new Size(109, 39);
            IDTextBox.TabIndex = 16;
            IDTextBox.TextChanged += eventid_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 756);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1192, 300);
            dataGridView1.TabIndex = 18;
            // 
            // searchbtn
            // 
            searchbtn.Location = new Point(565, 105);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(150, 46);
            searchbtn.TabIndex = 19;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SimSun", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(159, 185);
            label7.Name = "label7";
            label7.Size = new Size(77, 29);
            label7.TabIndex = 20;
            label7.Text = "Time";
            // 
            // eventnametxt
            // 
            eventnametxt.Location = new Point(388, 181);
            eventnametxt.Name = "eventnametxt";
            eventnametxt.Size = new Size(394, 39);
            eventnametxt.TabIndex = 21;
            // 
            // events
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1337, 1068);
            Controls.Add(eventnametxt);
            Controls.Add(label7);
            Controls.Add(searchbtn);
            Controls.Add(dataGridView1);
            Controls.Add(IDTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(updatebtn);
            Controls.Add(savebtn);
            Controls.Add(txtPerformers);
            Controls.Add(txtLocation);
            Controls.Add(dtpTime);
            Controls.Add(dtpDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "events";
            Text = "events";
            Load += events_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpDate;
        private TextBox dtpTime;
        private TextBox txtLocation;
        private TextBox txtPerformers;
        private Button savebtn;
        private Button updatebtn;
        private Button button3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox IDTextBox;
        private DataGridView dataGridView1;
        private Button searchbtn;
        private Label label7;
        private TextBox eventnametxt;
    }
}