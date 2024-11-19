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
    public partial class DeleteClaim : Form
    {
        string connectionstring = "Data Source=labG9AEB3\\SQLEXPRESS;Initial Catalog=Contract_Monthly_Claim;Integrated Security=True;Trust Server Certificate=True";
        public DeleteClaim()
        {
            InitializeComponent();
        }

        private void DeleteClaimIdInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitDeleteClaimID_Click(object sender, EventArgs e)
        {
            string claimId = DeleteClaimIdInput.Text;

            if (String.IsNullOrEmpty(claimId))
            {
                MessageBox.Show("Enter Claim ID");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();

                // Delete referencing records from Approval table
                string query = "DELETE FROM Approval WHERE Claim_ID = @claimId";
                using (SqlCommand cmdDeleteApproval = new SqlCommand(query, conn))
                {
                    cmdDeleteApproval.Parameters.AddWithValue("@claimId", claimId);
                    cmdDeleteApproval.ExecuteNonQuery();
                }

                // Check if claim exists
                query = "SELECT * FROM Claim INNER JOIN Lecturer ON Claim.Lecturer_ID = Lecturer.Lecturer_ID WHERE Claim.Claim_ID = @claimId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@claimId", claimId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string lecturerName = reader["First_Name"].ToString();
                            string lecturerId = reader["Lecturer_ID"].ToString();
                            string course = reader["Course"].ToString();
                            string hourlyRate = reader["Hourly_Rate"].ToString();
                            string hourlyWorked = reader["Hourly_Worked"].ToString();
                            string totalClaim = reader["Total_Claim"].ToString();
                            string sessionNumber = reader["Session_Number"].ToString();
                            string claimType = reader["Claim_Type"].ToString();

                            DialogResult dialogResult = MessageBox.Show(
                                "Are you sure you want to delete the following claim?\n\n" +
                                "Lecturer Name: " + lecturerName + "\n" +
                                "Lecturer ID: " + lecturerId + "\n" +
                                "Claim ID: " + claimId + "\n" +
                                "Course: " + course + "\n" +
                                "Hourly Rate: " + hourlyRate + "\n" +
                                "Hourly Worked: " + hourlyWorked + "\n" +
                                "Total Claim: " + totalClaim + "\n" +
                                "Session Number: " + sessionNumber + "\n" +
                                "Claim Type: " + claimType,
                                "Delete Claim", MessageBoxButtons.YesNo);

                            if (dialogResult == DialogResult.Yes)
                            {
                                conn.Close();
                                conn.Open();

                                query = "DELETE FROM Claim WHERE Claim_ID = @claimId";
                                using (SqlCommand cmdDelete = new SqlCommand(query, conn))
                                {
                                    cmdDelete.Parameters.AddWithValue("@claimId", claimId);
                                    cmdDelete.ExecuteNonQuery();
                                    MessageBox.Show("Claim ID " + claimId + " has been successfully deleted");
                                }

                                // Automatically refresh the page without reloading
                                this.Refresh();
                                DeleteClaimIdInput.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Deletion cancelled");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Claim ID not found");
                        }
                    }
                }
            }
        }
        private void DeleteClaim_Load(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
