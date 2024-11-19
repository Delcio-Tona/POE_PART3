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
    public partial class Lecturer_DashBoard : Form
    {
        public Lecturer_DashBoard()
        {
            InitializeComponent();
        }

        private void Lecturer_DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void Claim_Click(object sender, EventArgs e)
        {
            Submit_Claim submit_Claim = new Submit_Claim();
            submit_Claim.Show();
        }

        private void viewClaim_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=labG9AEB3\\SQLEXPRESS;Initial Catalog=Contract_Monthly_Claim;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string query = "select Lecturer.First_Name,Lecturer.Lecturer_ID,Claim.Claim_ID,Claim.Course,Claim.Hourly_Rate,Claim.Session_NUmber,Claim.Claim_Type from Claim inner join Lecturer on Claim.Lecturer_ID=Lecturer.Lecturer_ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void TrackingStatus_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=labG9AEB3\\SQLEXPRESS;Initial Catalog=Contract_Monthly_Claim;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string query = "select Approval_ID,Claim_ID,Decision from Approval";
            SqlCommand cmd = new SqlCommand(query, conn);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
