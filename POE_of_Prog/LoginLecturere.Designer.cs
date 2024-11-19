namespace POE_of_Prog
{
    partial class LoginLecturere
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
            Username = new TextBox();
            Password = new TextBox();
            Submit = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 94);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 153);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // Username
            // 
            Username.Location = new Point(261, 94);
            Username.Name = "Username";
            Username.Size = new Size(184, 23);
            Username.TabIndex = 2;
            // 
            // Password
            // 
            Password.Location = new Point(261, 155);
            Password.Name = "Password";
            Password.Size = new Size(184, 23);
            Password.TabIndex = 3;
            // 
            // Submit
            // 
            Submit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Submit.Location = new Point(252, 224);
            Submit.Name = "Submit";
            Submit.Size = new Size(75, 34);
            Submit.TabIndex = 4;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(370, 224);
            button2.Name = "button2";
            button2.Size = new Size(75, 34);
            button2.TabIndex = 5;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(78, 336);
            button3.Name = "button3";
            button3.Size = new Size(75, 29);
            button3.TabIndex = 6;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(261, 34);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 7;
            label3.Text = "Login";
            // 
            // LoginLecturere
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(610, 450);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Submit);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginLecturere";
            Text = "LoginLecturer";
            Load += LoginLecturere_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Username;
        private TextBox Password;
        private Button Submit;
        private Button button2;
        private Button button3;
        private Label label3;
    }
}