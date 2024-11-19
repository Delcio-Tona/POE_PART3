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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace POE_of_Prog
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adimi_Registration adimi_Registration = new Adimi_Registration();
            adimi_Registration.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;

            string connectionstring = "Data Source=labG9AEB3\\SQLEXPRESS;Initial Catalog=Contract_Monthly_Claim;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string query = "select* from Admin_ where Username='" + username + "' and Admin_Password='" + password + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            if (dtable.Rows.Count > 0)
            {
                Admin_DashBoard admin_DashBoard = new Admin_DashBoard();
                admin_DashBoard.Show();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Enter the correct username and password");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
