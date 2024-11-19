using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace POE_of_Prog
{
    public partial class Adimi_Registration : Form
    {
        public Adimi_Registration()
        {
            InitializeComponent();
        }

        private void sutmit_Click(object sender, EventArgs e)
        {
            string name = Firstname.Text;
            string lastname = Lastname.Text;
            string address = Address.Text;
            string email = Email.Text;
            string phone = Phone.Text;
            string username = Username.Text;
            string password = Password.Text;

            if (name == "")
            {
                MessageBox.Show("insert the  Firstname field!");
            }
            if (lastname == "")
            {
                MessageBox.Show("insert the  lastname field!");
            }

            if (address == "")
            {
                MessageBox.Show("insert the  address field!");
            }

            if (email == "")
            {
                MessageBox.Show("insert the  email field!");
            }

            if (phone == "")
            {
                MessageBox.Show("insert the  phone field!");
            }

            if (username == "")
            {
                MessageBox.Show("insert the  username field!");
            }

            if (password == "")
            {
                MessageBox.Show("insert the  password field!");
            }

            if (!Regex.IsMatch(name, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Admin name should contain only letters and spaces.");
            }

            if (!Regex.IsMatch(lastname, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Admin Lastname should contain only letters and spaces.");
            }
            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"))
            {
                MessageBox.Show("Email should be real Email!.");
            }

            if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$"))
            {
                MessageBox.Show("Password must At least have one lowercase letter, At least one uppercase letter,At least one digi,At least one special character");
            }

            if (Regex.IsMatch(name, @"^[A-Za-z\s]+$") && Regex.IsMatch(lastname, @"^[A-Za-z\s]+$") && !String.IsNullOrEmpty(address) && Regex.IsMatch(email, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$") && !String.IsNullOrEmpty(phone) && !String.IsNullOrEmpty(username) && Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$"))
            {
                MessageBox.Show("Well done!");
                string connectionstring = "Data Source=labG9AEB3\\SQLEXPRESS;Initial Catalog=Contract_Monthly_Claim;Integrated Security=True;Trust Server Certificate=True";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "Insert into Admin_(First_Name,LastName,Admin_Address,Email,Phone,Username,Admin_Password)Values('" + name + "','" + lastname + "','" + address + "','" + email + "','" + phone + "','" + username + "','" + password + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registration successfully saved");
                Admin_DashBoard admin_DashBoard = new Admin_DashBoard();
                admin_DashBoard.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
