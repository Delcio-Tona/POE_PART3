namespace POE_of_Prog
{
    partial class Admin_Login
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
            Username = new TextBox();
            Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Login = new Button();
            button2 = new Button();
            label3 = new Label();
            Back = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.Location = new Point(380, 112);
            Username.Name = "Username";
            Username.Size = new Size(202, 23);
            Username.TabIndex = 0;
            // 
            // Password
            // 
            Password.Location = new Point(380, 161);
            Password.Name = "Password";
            Password.Size = new Size(202, 23);
            Password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(206, 98);
            label1.Name = "label1";
            label1.Size = new Size(153, 37);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(206, 161);
            label2.Name = "label2";
            label2.Size = new Size(146, 37);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // Login
            // 
            Login.BackColor = SystemColors.ControlDark;
            Login.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = SystemColors.ButtonHighlight;
            Login.Location = new Point(240, 237);
            Login.Name = "Login";
            Login.Size = new Size(75, 39);
            Login.TabIndex = 4;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(388, 233);
            button2.Name = "button2";
            button2.Size = new Size(194, 43);
            button2.TabIndex = 5;
            button2.Text = "Create Account";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(334, 29);
            label3.Name = "label3";
            label3.Size = new Size(139, 25);
            label3.TabIndex = 6;
            label3.Text = "ADMIN LOGIN";
            // 
            // Back
            // 
            Back.BackColor = SystemColors.ControlDark;
            Back.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.Location = new Point(35, 388);
            Back.Name = "Back";
            Back.Size = new Size(89, 29);
            Back.TabIndex = 7;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Admin_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(Back);
            Controls.Add(button2);
            Controls.Add(Login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Password);
            Controls.Add(Username);
            ForeColor = SystemColors.ControlLight;
            Name = "Admin_Login";
            Text = "Admin_Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Username;
        private TextBox Password;
        private Label label1;
        private Label label2;
        private Button Login;
        private Button button2;
        private Label label3;
        private Button Back;
    }
}