namespace POE_of_Prog
{
    partial class Registration
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
            Firstname = new TextBox();
            Lastname = new TextBox();
            Address = new TextBox();
            Email = new TextBox();
            Phone = new TextBox();
            Username = new TextBox();
            Password = new TextBox();
            Submit = new Button();
            cancel = new Button();
            Back = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 109);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 146);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Surname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 176);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Address:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 213);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 251);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 4;
            label5.Text = "Phone Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(46, 288);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 5;
            label6.Text = "Username:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(48, 327);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 6;
            label7.Text = "Password:";
            // 
            // Firstname
            // 
            Firstname.Location = new Point(224, 106);
            Firstname.Name = "Firstname";
            Firstname.Size = new Size(167, 23);
            Firstname.TabIndex = 7;
            // 
            // Lastname
            // 
            Lastname.Location = new Point(224, 143);
            Lastname.Name = "Lastname";
            Lastname.Size = new Size(167, 23);
            Lastname.TabIndex = 8;
            // 
            // Address
            // 
            Address.Location = new Point(225, 176);
            Address.Name = "Address";
            Address.Size = new Size(166, 23);
            Address.TabIndex = 9;
            Address.TextChanged += textBox3_TextChanged;
            // 
            // Email
            // 
            Email.Location = new Point(224, 210);
            Email.Name = "Email";
            Email.Size = new Size(167, 23);
            Email.TabIndex = 10;
            // 
            // Phone
            // 
            Phone.Location = new Point(224, 248);
            Phone.Name = "Phone";
            Phone.Size = new Size(167, 23);
            Phone.TabIndex = 11;
            // 
            // Username
            // 
            Username.Location = new Point(224, 285);
            Username.Name = "Username";
            Username.Size = new Size(167, 23);
            Username.TabIndex = 12;
            Username.TextChanged += Username_TextChanged;
            // 
            // Password
            // 
            Password.Location = new Point(224, 324);
            Password.Name = "Password";
            Password.Size = new Size(167, 23);
            Password.TabIndex = 13;
            // 
            // Submit
            // 
            Submit.BackColor = SystemColors.ControlDark;
            Submit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Submit.ForeColor = SystemColors.ControlLightLight;
            Submit.Location = new Point(224, 384);
            Submit.Name = "Submit";
            Submit.Size = new Size(75, 29);
            Submit.TabIndex = 17;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // cancel
            // 
            cancel.BackColor = SystemColors.ControlDark;
            cancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancel.Location = new Point(327, 384);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 29);
            cancel.TabIndex = 18;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = false;
            cancel.Click += cancel_Click;
            // 
            // Back
            // 
            Back.BackColor = SystemColors.ControlDark;
            Back.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.Location = new Point(33, 434);
            Back.Name = "Back";
            Back.Size = new Size(79, 29);
            Back.TabIndex = 19;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(206, 28);
            label8.Name = "label8";
            label8.Size = new Size(142, 25);
            label8.TabIndex = 20;
            label8.Text = "REGISTRATION";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(585, 475);
            Controls.Add(label8);
            Controls.Add(Back);
            Controls.Add(cancel);
            Controls.Add(Submit);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(Phone);
            Controls.Add(Email);
            Controls.Add(Address);
            Controls.Add(Lastname);
            Controls.Add(Firstname);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLight;
            Name = "Registration";
            Text = "Registration";
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
        private TextBox Firstname;
        private TextBox Lastname;
        private TextBox Address;
        private TextBox Email;
        private TextBox Phone;
        private TextBox Username;
        private TextBox Password;
        private Button Submit;
        private Button cancel;
        private Button Back;
        private Label label8;
    }
}