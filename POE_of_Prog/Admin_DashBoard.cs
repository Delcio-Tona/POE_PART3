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
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace POE_of_Prog
{
    public partial class Admin_DashBoard : Form
    {
        public  DataTable allData;
        public Admin_DashBoard()
        {
            InitializeComponent();
        }

        private void VerifyClaim_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=labG9AEB3\\SQLEXPRESS;Initial Catalog=Contract_Monthly_Claim;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                // Update the query to include HourlyWorked and TotalClaim
                string query = "SELECT Lecturer.First_Name, Lecturer.Lecturer_ID, Claim.Claim_ID, Claim.Course, Claim.Hourly_Rate, Claim.Session_Number, Claim.Claim_Type, Claim.Hourly_Worked, Claim.Total_Claim " +
               "FROM Claim INNER JOIN Lecturer ON Claim.Lecturer_ID = Lecturer.Lecturer_ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
            }
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            string nul1l = "Pending";
            string adminId = ADmin.Text;
            string claim = Claim.Text;
            string connectionstring = "Data Source=labG9AEB3\\SQLEXPRESS;Initial Catalog=Contract_Monthly_Claim;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string query1 = "insert into Approval(Admin_ID,Claim_ID,Decision) values('" + adminId + "','" + claim + "','" + nul1l + "')";
            //query1 = "update Approval set Decision='Pending' where Decision is null";
            //string query = "select* from Approval";
            SqlCommand cmd = new SqlCommand(query1, conn);
            MessageBox.Show("Status has been succesfully saved");
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView2.DataSource = dt;
        }

        private void Status_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=labG9AEB3\\SQLEXPRESS;Initial Catalog=Contract_Monthly_Claim;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string query = "select* from Approval";
            SqlCommand cmd = new SqlCommand(query, conn);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView2.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string approval = Approval_ID.Text;
            if (!String.IsNullOrEmpty(approval))
            {
                string connectionstring = "Data Source=labG9AEB3\\SQLEXPRESS;Initial Catalog=Contract_Monthly_Claim;Integrated Security=True;Trust Server Certificate=True";
                SqlConnection conn = new SqlConnection(connectionstring);
                conn.Open();
                string query = "update Approval set Decision='Approved' where Approval_ID= '" + approval + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView2.DataSource = dt;
                MessageBox.Show("Approval_ID " + approval + " has been succesfully Approved");
            }
            else
            {
                MessageBox.Show("Fill up the Appraval ID field");
            }
        }

        private void reject_Click(object sender, EventArgs e)
        {
            string approval = Approval_ID.Text;
            if (!String.IsNullOrEmpty(approval))
            {
                string connectionstring = "Data Source=labG9AEB3\\SQLEXPRESS;Initial Catalog=Contract_Monthly_Claim;Integrated Security=True;Trust Server Certificate=True";
                SqlConnection conn = new SqlConnection(connectionstring);
                conn.Open();
                string query = "update Approval set Decision='Rejected' where Approval_ID= '" + approval + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView2.DataSource = dt;
                MessageBox.Show("Approval_ID " + approval + " has been Rejected");
            }
            else
            {
                MessageBox.Show("Fill up the Appraval ID field");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteClaim_Click(object sender, EventArgs e)
        {
            DeleteClaim deleteClaimForm = new DeleteClaim();
            deleteClaimForm.ShowDialog();
        }

        private void Admin_DashBoard_Load(object sender, EventArgs e)
        {

        }


        private void updateClaim_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=labG9AEB3\\SQLEXPRESS;Initial Catalog=Contract_Monthly_Claim;Integrated Security=True;Trust Server Certificate=True";

            for (int attempts = 0; attempts < 2; attempts++)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Please Enter the Claim ID you want to update:", "Update Claim", "");

                if (int.TryParse(input, out int claimId))
                {
                    // Check if the Claim ID exists in the database
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT COUNT(*) FROM Claim WHERE Claim_ID = @claimId";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@claimId", claimId);
                            int count = (int)cmd.ExecuteScalar();

                            if (count > 0) // Claim ID found
                            {
                                // Pass 'claimId' and 'this' (the current Admin_DashBoard instance) to UpdateClaimForm
                                UpdateClaimForm updateClaimForm = new UpdateClaimForm(claimId, this);
                                this.Hide(); // Hide Admin_DashBoard while UpdateClaimForm is open
                                updateClaimForm.ShowDialog();
                                VerifyClaim_Click(sender, e); // Refresh claims list after returning
                                this.Show(); // Show Admin_DashBoard after returning from UpdateClaimForm
                                return; // Exit the method after successful update
                            }
                            else
                            {
                                MessageBox.Show("Claim ID not found. Please try again.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric Claim ID.");
                }
            }

            // If two attempts failed, return to Admin Dashboard
            MessageBox.Show("Failed to enter a valid Claim ID after two attempts. Returning to Admin Dashboard.");
            this.Show();
        }

        private void PrintReport_Click(object sender, EventArgs e)
        {
            // Retrieve all data from database
            string connectionstring = "Data Source=labG9AEB3\\SQLEXPRESS;Initial Catalog=Contract_Monthly_Claim;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                string query = @"
            SELECT Lecturer.First_Name, Lecturer.Lecturer_ID, 
                   Claim.Claim_ID, Claim.Course, Claim.Hourly_Rate, 
                   Claim.Session_Number, Claim.Claim_Type, Claim.Hourly_Worked, 
                   Claim.Total_Claim, Approval.Decision
            FROM Lecturer
            LEFT JOIN Claim ON Lecturer.Lecturer_ID = Claim.Lecturer_ID
            LEFT JOIN Approval ON Claim.Claim_ID = Approval.Claim_ID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                allData = new DataTable();
                adapter.Fill(allData);
            }

            // Set up PrintDocument and preview
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDocument,
                Width = 800,
                Height = 600
            };
            printPreviewDialog.ShowDialog();
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            Font rowFont = new Font("Arial", 9);
            int x = 50, y = 50;

            // Print column headers
            foreach (DataColumn column in allData.Columns)
            {
                e.Graphics.DrawString(column.ColumnName, headerFont, Brushes.Black, x, y);
                x += 100; // Adjust column width as necessary
            }

            y += 30; // Move down for the first row
            x = 50;

            // Print each row of data
            foreach (DataRow row in allData.Rows)
            {
                foreach (var cell in row.ItemArray)
                {
                    string cellValue = cell?.ToString() ?? string.Empty;
                    e.Graphics.DrawString(cellValue, rowFont, Brushes.Black, x, y);
                    x += 100; // Adjust column width as necessary
                }
                y += 20; // Move to next row
                x = 50;
            }

            e.HasMorePages = false;
        }
    }
}
