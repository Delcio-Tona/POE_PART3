namespace POE_of_Prog
{
    partial class Lecturer_DashBoard
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
            Claim = new Button();
            viewClaim = new Button();
            panel2 = new Panel();
            label1 = new Label();
            Logout = new Button();
            TrackingStatus = new Button();
            panel3 = new Panel();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Claim
            // 
            Claim.BackColor = Color.DarkSeaGreen;
            Claim.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Claim.ForeColor = SystemColors.ButtonHighlight;
            Claim.Location = new Point(16, 88);
            Claim.Name = "Claim";
            Claim.Size = new Size(127, 50);
            Claim.TabIndex = 0;
            Claim.Text = "make Claim";
            Claim.UseVisualStyleBackColor = false;
            Claim.Click += Claim_Click;
            // 
            // viewClaim
            // 
            viewClaim.BackColor = Color.SandyBrown;
            viewClaim.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewClaim.ForeColor = SystemColors.ButtonHighlight;
            viewClaim.Location = new Point(16, 157);
            viewClaim.Name = "viewClaim";
            viewClaim.Size = new Size(127, 51);
            viewClaim.TabIndex = 1;
            viewClaim.Text = "View Claims";
            viewClaim.UseVisualStyleBackColor = false;
            viewClaim.Click += viewClaim_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Firebrick;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Logout);
            panel2.Controls.Add(TrackingStatus);
            panel2.Controls.Add(Claim);
            panel2.Controls.Add(viewClaim);
            panel2.Location = new Point(7, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(157, 416);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 4;
            label1.Text = "DashBoard";
            // 
            // Logout
            // 
            Logout.BackColor = Color.DarkOrange;
            Logout.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Logout.ForeColor = SystemColors.ButtonHighlight;
            Logout.Location = new Point(16, 295);
            Logout.Name = "Logout";
            Logout.Size = new Size(124, 42);
            Logout.TabIndex = 3;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = false;
            Logout.Click += Logout_Click;
            // 
            // TrackingStatus
            // 
            TrackingStatus.BackColor = Color.SeaGreen;
            TrackingStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TrackingStatus.ForeColor = SystemColors.ButtonHighlight;
            TrackingStatus.Location = new Point(16, 233);
            TrackingStatus.Name = "TrackingStatus";
            TrackingStatus.Size = new Size(124, 45);
            TrackingStatus.TabIndex = 2;
            TrackingStatus.Text = "TrackingStatus";
            TrackingStatus.UseVisualStyleBackColor = false;
            TrackingStatus.Click += TrackingStatus_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.MenuHighlight;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(7, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(844, 35);
            panel3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 21);
            label2.TabIndex = 0;
            label2.Text = "Lecturer DashBoard";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(170, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(651, 374);
            dataGridView1.TabIndex = 6;
            // 
            // Lecturer_DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(833, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Lecturer_DashBoard";
            Text = "Lecturer_DashBoard";
            Load += Lecturer_DashBoard_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Claim;
        private Button viewClaim;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private Button Logout;
        private Button TrackingStatus;
        private DataGridView dataGridView1;
    }
}