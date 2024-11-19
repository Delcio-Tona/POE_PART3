namespace POE_of_Prog
{
    partial class UpdateClaimForm
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
            Hourlyworked = new TextBox();
            Course = new TextBox();
            Nu_session = new TextBox();
            Rate = new TextBox();
            Claim_type = new TextBox();
            Total_Claim = new TextBox();
            SaveUpdate = new Button();
            Back = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // Hourlyworked
            // 
            Hourlyworked.Location = new Point(392, 74);
            Hourlyworked.Name = "Hourlyworked";
            Hourlyworked.Size = new Size(181, 23);
            Hourlyworked.TabIndex = 8;
            Hourlyworked.TextChanged += Hourlyworked_TextChanged;
            // 
            // Course
            // 
            Course.Location = new Point(392, 121);
            Course.Name = "Course";
            Course.Size = new Size(181, 23);
            Course.TabIndex = 9;
            Course.TextChanged += Course_TextChanged;
            // 
            // Nu_session
            // 
            Nu_session.Location = new Point(392, 175);
            Nu_session.Name = "Nu_session";
            Nu_session.Size = new Size(181, 23);
            Nu_session.TabIndex = 10;
            Nu_session.TextChanged += Nu_session_TextChanged;
            // 
            // Rate
            // 
            Rate.Location = new Point(392, 226);
            Rate.Name = "Rate";
            Rate.Size = new Size(181, 23);
            Rate.TabIndex = 11;
            Rate.TextChanged += Rate_TextChanged;
            // 
            // Claim_type
            // 
            Claim_type.Location = new Point(392, 273);
            Claim_type.Name = "Claim_type";
            Claim_type.Size = new Size(181, 23);
            Claim_type.TabIndex = 12;
            Claim_type.TextChanged += Claim_type_TextChanged;
            // 
            // Total_Claim
            // 
            Total_Claim.Location = new Point(392, 325);
            Total_Claim.Name = "Total_Claim";
            Total_Claim.Size = new Size(181, 23);
            Total_Claim.TabIndex = 13;
            Total_Claim.TextChanged += Total_Claim_TextChanged;
            // 
            // SaveUpdate
            // 
            SaveUpdate.BackColor = SystemColors.ControlDark;
            SaveUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveUpdate.Location = new Point(287, 411);
            SaveUpdate.Name = "SaveUpdate";
            SaveUpdate.Size = new Size(75, 29);
            SaveUpdate.TabIndex = 18;
            SaveUpdate.Text = "Save";
            SaveUpdate.UseVisualStyleBackColor = false;
            SaveUpdate.Click += SaveUpdate_Click;
            // 
            // Back
            // 
            Back.BackColor = SystemColors.ControlDark;
            Back.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.Location = new Point(433, 411);
            Back.Name = "Back";
            Back.Size = new Size(75, 29);
            Back.TabIndex = 19;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(130, 77);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 20;
            label1.Text = "Updated Hourly Worked:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(130, 127);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 21;
            label2.Text = "Updated Course:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(130, 178);
            label3.Name = "label3";
            label3.Size = new Size(199, 20);
            label3.TabIndex = 22;
            label3.Text = "Updated Sessions Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.Location = new Point(130, 229);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 23;
            label4.Text = "Updated Hourly Rate:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.Location = new Point(131, 276);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 24;
            label5.Text = "Updated Claim Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.Location = new Point(132, 327);
            label6.Name = "label6";
            label6.Size = new Size(153, 20);
            label6.TabIndex = 25;
            label6.Text = "Updated Total claim:";
            label6.Click += label6_Click;
            // 
            // UpdateClaimForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(800, 527);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Back);
            Controls.Add(SaveUpdate);
            Controls.Add(Total_Claim);
            Controls.Add(Claim_type);
            Controls.Add(Rate);
            Controls.Add(Nu_session);
            Controls.Add(Course);
            Controls.Add(Hourlyworked);
            ForeColor = SystemColors.ControlLight;
            Name = "UpdateClaimForm";
            Text = "UpdateClaimForm";
            Load += UpdateClaimForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Hourlyworked;
        private TextBox Course;
        private TextBox Nu_session;
        private TextBox Rate;
        private TextBox Claim_type;
        private TextBox Total_Claim;
        private Button SaveUpdate;
        private Button Back;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}