namespace POE_of_Prog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            label6 = new Label();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label7 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(483, 260);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 1;
            label2.Text = "Login as Lecturer";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(765, 256);
            button1.Name = "button1";
            button1.Size = new Size(100, 29);
            button1.TabIndex = 2;
            button1.Text = "Click here to start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(444, 222);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 3;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(765, 193);
            button2.Name = "button2";
            button2.Size = new Size(100, 27);
            button2.TabIndex = 4;
            button2.Text = "Click here";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 381);
            label6.Name = "label6";
            label6.Size = new Size(302, 20);
            label6.TabIndex = 7;
            label6.Text = "Don't have an Create Account as Lecture ?";
            label6.Click += label6_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(318, 377);
            button3.Name = "button3";
            button3.Size = new Size(86, 28);
            button3.TabIndex = 8;
            button3.Text = "Create ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(793, 26);
            button4.Name = "button4";
            button4.Size = new Size(101, 27);
            button4.TabIndex = 9;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(-6, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 430);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 206);
            label1.Name = "label1";
            label1.Size = new Size(291, 25);
            label1.TabIndex = 2;
            label1.Text = "Contract Monthly Claim System";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(404, 179);
            label7.Name = "label7";
            label7.Size = new Size(326, 25);
            label7.TabIndex = 11;
            label7.Text = "Login as Programme coordinators";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(404, 204);
            label4.Name = "label4";
            label4.Size = new Size(306, 25);
            label4.TabIndex = 12;
            label4.Text = "Login as Academic Manager/Hr";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(968, 424);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label3);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Welcome";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button button1;
        private Label label3;
        private Button button2;
        private Label label6;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Label label1;
        private Label label7;
        private Label label4;
    }
}
