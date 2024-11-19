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
    public partial class Submit_Claim : Form
    {
        public Submit_Claim()
        {
            InitializeComponent();
            Calculate.Click += Calculate_Click;
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string hourlyworked = Hourlyworked.Text;
            string course = Course.Text;
            string nu_session = Nu_session.Text;
            string rate = Rate.Text;
            string lecturer_ID = Lecturer_ID.Text;
            string claim_type = Claim_type.Text;
            string total_Claim = Total_Claim.Text;
            string supportive_document = textBox1.Text;

            // Validation
            if (string.IsNullOrEmpty(hourlyworked) ||
                string.IsNullOrEmpty(course) ||
                string.IsNullOrEmpty(nu_session) ||
                string.IsNullOrEmpty(rate) ||
                string.IsNullOrEmpty(lecturer_ID) ||
                string.IsNullOrEmpty(claim_type) ||
                string.IsNullOrEmpty(total_Claim))
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }
            if (supportive_document.Length >= 500)
            {
                MessageBox.Show("Supportive document is too long!");
                return;
            }

            // Database connection
            string connectionstring = "Data Source=labG9AEB3\\SQLEXPRESS;Initial Catalog=Contract_Monthly_Claim;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string query = "Insert into Claim(Course, Session_Number, Hourly_Rate, Hourly_Worked, Claim_Type, Supportive_Document, Lecturer_ID, Total_Claim) Values(@course, @nu_session, @rate, @hourly_worked, @claim_type, @supportive_document, @lecturer_ID, @total_claim)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@course", course);
                    cmd.Parameters.AddWithValue("@nu_session", nu_session);
                    cmd.Parameters.AddWithValue("@rate", rate);
                    cmd.Parameters.AddWithValue("@hourly_worked", hourlyworked);
                    cmd.Parameters.AddWithValue("@claim_type", claim_type);
                    cmd.Parameters.AddWithValue("@supportive_document", supportive_document);
                    cmd.Parameters.AddWithValue("@lecturer_ID", lecturer_ID);
                    cmd.Parameters.AddWithValue("@total_claim", total_Claim);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Claim successfully sent!");
            Lecturer_DashBoard lecturer_DashBoard = new Lecturer_DashBoard();
            lecturer_DashBoard.Show();
        }

        private void Submit_Claim_Load(object sender, EventArgs e)
        {
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PDF Files|.pdf|Word Files|.doc;.docx|All Files|.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Hourlyworked.Text = "";
            Course.Text = "";
            Nu_session.Text = "";
            Rate.Text = "";
            Lecturer_ID.Text = "";
            Claim_type.Text = "";
            Total_Claim.Text = "";
            textBox1.Text = "";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Lecturer_DashBoard lecturer_DashBoard = new Lecturer_DashBoard();
            lecturer_DashBoard.Show();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            // Ensure valid input for hours worked and rate
            if (decimal.TryParse(Hourlyworked.Text, out decimal hoursWorked) && decimal.TryParse(Rate.Text, out decimal hourlyRate))
            {
                // Calculate total claim
                decimal totalClaim = hoursWorked * hourlyRate;
                Total_Claim.Text = totalClaim.ToString("F2");
            }
            else
            {
                MessageBox.Show("OPPS !!! Please enter valid numbers for hours worked and rate.");
            }
        }

        private void Hourlyworked_TextChanged(object sender, EventArgs e)
        {
        }
    }
}