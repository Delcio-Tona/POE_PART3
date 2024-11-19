using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE_of_Prog
{
    public partial class LoginLecturere : Form
    {
        public LoginLecturere()
        {
            InitializeComponent();
            string password = Password.Text;

            //  Password.PasswordChar = '*';

            // Add the TextBox to the form
            //  this.Controls.Add(Password);
        }

        private void LoginLecturere_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;

            string connectionstring = "Data Source=labG9AEB3\\SQLEXPRESS;Initial Catalog=Contract_Monthly_Claim;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string query = "select* from Lecturer where Username='" + username + "' and Lecturer_Password='" + password + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            if (dtable.Rows.Count > 0)
            {
                Lecturer_DashBoard lecturer_DashBoard = new Lecturer_DashBoard();
                lecturer_DashBoard.ShowDialog();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Enter the correct username and password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Username.Text = "";
            Password.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           this.Close();

        }
    }
}
