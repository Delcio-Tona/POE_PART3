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
            label2 = new Label();
            SuspendLayout();
            // 
            // DeleteClaimIdInput
            // 
            DeleteClaimIdInput.Location = new Point(392, 125);
            DeleteClaimIdInput.Name = "DeleteClaimIdInput";
            DeleteClaimIdInput.Size = new Size(209, 23);
            DeleteClaimIdInput.TabIndex = 3;
            DeleteClaimIdInput.TextChanged += DeleteClaimIdInput_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 121);
            label1.Name = "label1";
            label1.Size = new Size(247, 25);
            label1.TabIndex = 4;
            label1.Text = "Please enter your claim ID:";
            // 
            // SubmitDeleteClaimID
            // 
            SubmitDeleteClaimID.BackColor = SystemColors.ControlDark;
            SubmitDeleteClaimID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitDeleteClaimID.Location = new Point(347, 179);
            SubmitDeleteClaimID.Name = "SubmitDeleteClaimID";
            SubmitDeleteClaimID.Size = new Size(75, 34);
            SubmitDeleteClaimID.TabIndex = 5;
            SubmitDeleteClaimID.Text = "Submit";
            SubmitDeleteClaimID.UseVisualStyleBackColor = false;
            SubmitDeleteClaimID.Click += SubmitDeleteClaimID_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = SystemColors.ControlDark;
            ExitBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitBtn.Location = new Point(53, 373);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(75, 34);
            ExitBtn.TabIndex = 6;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(245, 22);
            label2.Name = "label2";
            label2.Size = new Size(301, 25);
            label2.TabIndex = 8;
            label2.Text = "Do you want to delete the claim?";
            // 
            // DeleteClaim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitBtn);
            Controls.Add(label2);
            Controls.Add(SubmitDeleteClaimID);
            Controls.Add(label1);
            Controls.Add(DeleteClaimIdInput);
            ForeColor = SystemColors.ControlLight;
            Name = "DeleteClaim";
            Text = "DeleteClaim";
            Load += DeleteClaim_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DeleteClaimIdInput;
        private Label label1;
        private Button SubmitDeleteClaimID;
        private Button ExitBtn;
        private Label label2;
    }
}