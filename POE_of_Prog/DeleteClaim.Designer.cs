namespace POE_of_Prog
{
    partial class DeleteClaim
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
            DeleteClaimIdInput = new TextBox();
            label1 = new Label();
            SubmitDeleteClaimID = new Button();
            ExitBtn = new Button();
            panel1 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DeleteClaimIdInput
            // 
            DeleteClaimIdInput.Location = new Point(579, 125);
            DeleteClaimIdInput.Name = "DeleteClaimIdInput";
            DeleteClaimIdInput.Size = new Size(209, 23);
            DeleteClaimIdInput.TabIndex = 3;
            DeleteClaimIdInput.TextChanged += DeleteClaimIdInput_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(301, 125);
            label1.Name = "label1";
            label1.Size = new Size(245, 25);
            label1.TabIndex = 4;
            label1.Text = "Please enter your Claim ID";
            // 
            // SubmitDeleteClaimID
            // 
            SubmitDeleteClaimID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitDeleteClaimID.Location = new Point(539, 223);
            SubmitDeleteClaimID.Name = "SubmitDeleteClaimID";
            SubmitDeleteClaimID.Size = new Size(75, 34);
            SubmitDeleteClaimID.TabIndex = 5;
            SubmitDeleteClaimID.Text = "Submit";
            SubmitDeleteClaimID.UseVisualStyleBackColor = true;
            SubmitDeleteClaimID.Click += SubmitDeleteClaimID_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitBtn.Location = new Point(104, 404);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(75, 34);
            ExitBtn.TabIndex = 6;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(ExitBtn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 503);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(345, 32);
            label2.Name = "label2";
            label2.Size = new Size(309, 25);
            label2.TabIndex = 8;
            label2.Text = "Are you sure you want to delete ?";
            // 
            // DeleteClaim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(SubmitDeleteClaimID);
            Controls.Add(label1);
            Controls.Add(DeleteClaimIdInput);
            Name = "DeleteClaim";
            Text = "DeleteClaim";
            Load += DeleteClaim_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DeleteClaimIdInput;
        private Label label1;
        private Button SubmitDeleteClaimID;
        private Button ExitBtn;
        private Panel panel1;
        private Label label2;
    }
}