namespace POE_of_Prog
{
    partial class Submit_Claim
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
            Support = new Label();
            label5 = new Label();
            label6 = new Label();
            Hourlyworked = new TextBox();
            Course = new TextBox();
            Nu_session = new TextBox();
            Rate = new TextBox();
            Total_Claim = new TextBox();
            Submit = new Button();
            Calculate = new Button();
            Reset = new Button();
            label7 = new Label();
            Lecturer_ID = new TextBox();
            label8 = new Label();
            Claim_type = new TextBox();
            Back = new Button();
            Upload = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 209);
            label1.Name = "label1";
            label1.Size = new Size(130, 21);
            label1.TabIndex = 0;
            label1.Text = "Hourly Worked:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 127);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 1;
            label2.Text = "Number of Sessions:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 175);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 2;
            label3.Text = "Hourly Rate:";
            label3.Click += label3_Click;
            // 
            // Support
            // 
            Support.AutoSize = true;
            Support.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Support.Location = new Point(122, 323);
            Support.Name = "Support";
            Support.Size = new Size(0, 20);
            Support.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 286);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 4;
            label5.Text = "Total Claim Amount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 88);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 5;
            label6.Text = "Course:";
            // 
            // Hourlyworked
            // 
            Hourlyworked.Location = new Point(280, 207);
            Hourlyworked.Name = "Hourlyworked";
            Hourlyworked.Size = new Size(163, 23);
            Hourlyworked.TabIndex = 6;
            // 
            // Course
            // 
            Course.Location = new Point(281, 83);
            Course.Name = "Course";
            Course.Size = new Size(163, 23);
            Course.TabIndex = 7;
            // 
            // Nu_session
            // 
            Nu_session.Location = new Point(281, 126);
            Nu_session.Name = "Nu_session";
            Nu_session.Size = new Size(163, 23);
            Nu_session.TabIndex = 8;
            // 
            // Rate
            // 
            Rate.Location = new Point(281, 170);
            Rate.Name = "Rate";
            Rate.Size = new Size(163, 23);
            Rate.TabIndex = 9;
            // 
            // Total_Claim
            // 
            Total_Claim.Location = new Point(281, 283);
            Total_Claim.Name = "Total_Claim";
            Total_Claim.Size = new Size(163, 23);
            Total_Claim.TabIndex = 11;
            // 
            // Submit
            // 
            Submit.BackColor = SystemColors.ControlDark;
            Submit.Location = new Point(82, 375);
            Submit.Name = "Submit";
            Submit.Size = new Size(83, 42);
            Submit.TabIndex = 12;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // Calculate
            // 
            Calculate.BackColor = SystemColors.ControlDark;
            Calculate.Location = new Point(206, 375);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(75, 42);
            Calculate.TabIndex = 13;
            Calculate.Text = "Calculation";
            Calculate.UseVisualStyleBackColor = false;
            Calculate.Click += Calculate_Click;
            // 
            // Reset
            // 
            Reset.BackColor = SystemColors.ControlDark;
            Reset.Location = new Point(327, 377);
            Reset.Name = "Reset";
            Reset.Size = new Size(75, 40);
            Reset.TabIndex = 14;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = false;
            Reset.Click += Reset_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(37, 43);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 15;
            label7.Text = "Lecturer ID:";
            // 
            // Lecturer_ID
            // 
            Lecturer_ID.Location = new Point(281, 42);
            Lecturer_ID.Name = "Lecturer_ID";
            Lecturer_ID.Size = new Size(163, 23);
            Lecturer_ID.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(41, 249);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 17;
            label8.Text = "Claim Type:";
            // 
            // Claim_type
            // 
            Claim_type.Location = new Point(281, 246);
            Claim_type.Name = "Claim_type";
            Claim_type.Size = new Size(163, 23);
            Claim_type.TabIndex = 18;
            // 
            // Back
            // 
            Back.BackColor = SystemColors.ControlDark;
            Back.Location = new Point(430, 380);
            Back.Name = "Back";
            Back.Size = new Size(75, 40);
            Back.TabIndex = 19;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Upload
            // 
            Upload.BackColor = SystemColors.ControlDark;
            Upload.ForeColor = SystemColors.ActiveCaptionText;
            Upload.Location = new Point(121, 336);
            Upload.Name = "Upload";
            Upload.Size = new Size(148, 23);
            Upload.TabIndex = 20;
            Upload.Text = "Suportive Document";
            Upload.UseVisualStyleBackColor = false;
            Upload.Click += Upload_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(280, 336);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 23);
            textBox1.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(281, 9);
            label4.Name = "label4";
            label4.Size = new Size(0, 30);
            label4.TabIndex = 22;
            // 
            // Submit_Claim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(647, 450);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(Upload);
            Controls.Add(Back);
            Controls.Add(Claim_type);
            Controls.Add(label8);
            Controls.Add(Lecturer_ID);
            Controls.Add(label7);
            Controls.Add(Reset);
            Controls.Add(Calculate);
            Controls.Add(Submit);
            Controls.Add(Total_Claim);
            Controls.Add(Rate);
            Controls.Add(Nu_session);
            Controls.Add(Course);
            Controls.Add(Hourlyworked);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Support);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLight;
            Name = "Submit_Claim";
            Text = "Submit_Claim";
            Load += Submit_Claim_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label Support;
        private Label label5;
        private Label label6;
        private TextBox Hourlyworked;
        private TextBox Course;
        private TextBox Nu_session;
        private TextBox Rate;
        private TextBox Total_Claim;
        private Button Submit;
        private Button Calculate;
        private Button Reset;
        private Label label7;
        private TextBox Lecturer_ID;
        private Label label8;
        private TextBox Claim_type;
        private Button Back;
        private Button Upload;
        private TextBox textBox1;
        private Label label4;
    }
}