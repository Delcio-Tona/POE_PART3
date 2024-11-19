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
    public partial class UpdateClaimForm : Form
    {
        public string connectionstring = "Data Source=labG9AEB3\\SQLEXPRESS;Initial Catalog=Contract_Monthly_Claim;Integrated Security=True;Trust Server Certificate=True";
        private int claimId;
        private Admin_DashBoard adminDashboard;
        public UpdateClaimForm(int claimId, Admin_DashBoard adminDashboard)
        {
            InitializeComponent();
            this.claimId = claimId;
            this.adminDashboard = adminDashboard;
            LoadClaimDetails();
        }
        private void LoadClaimDetails()
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();

                // Check if the claim exists
                string checkQuery = "SELECT COUNT(*) FROM Claim WHERE Claim_ID = @claimId";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@claimId", claimId);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Claim not found.");
                        this.Close();
                        return; // Exit the method if claim does not exist
                    }
                }

                // Load the claim details if it exists
                string query = "SELECT Course, Hourly_Rate, Hourly_Worked, Session_Number, Claim_Type, Total_Claim FROM Claim WHERE Claim_ID = @claimId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@claimId", claimId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate text boxes with database data
                            Course.Text = reader["Course"].ToString();
                            Rate.Text = reader["Hourly_Rate"].ToString();
                            Hourlyworked.Text = reader["Hourly_Worked"].ToString();
                            Nu_session.Text = reader["Session_Number"].ToString();
                            Claim_type.Text = reader["Claim_Type"].ToString();
                            Total_Claim.Text = reader["Total_Claim"].ToString();
                        }
                    }
                }
            }
        }


        private void Hourlyworked_TextChanged(object sender, EventArgs e)
        {

        }

        private void Course_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nu_session_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rate_TextChanged(object sender, EventArgs e)
        {

        }

        private void Claim_type_TextChanged(object sender, EventArgs e)
        {

        }

        private void Total_Claim_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                // Update query to save changes to the database
                string query = "UPDATE Claim SET Course = @course, Hourly_Rate = @hourlyRate, Hourly_Worked = @hourlyWorked, Session_Number = @sessionNumber, Claim_Type = @claimType, Total_Claim = @totalClaim WHERE Claim_ID = @claimId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Assign updated values from form fields to SQL parameters
                    cmd.Parameters.AddWithValue("@course", Course.Text);
                    cmd.Parameters.AddWithValue("@hourlyRate", Rate.Text);
                    cmd.Parameters.AddWithValue("@hourlyWorked", Hourlyworked.Text);
                    cmd.Parameters.AddWithValue("@sessionNumber", Nu_session.Text);
                    cmd.Parameters.AddWithValue("@claimType", Claim_type.Text);
                    cmd.Parameters.AddWithValue("@totalClaim", Total_Claim.Text);
                    cmd.Parameters.AddWithValue("@claimId", claimId);

                    cmd.ExecuteNonQuery(); // Execute the update command
                    MessageBox.Show("Claim updated successfully.");
                    this.Close(); // Close form after saving
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            adminDashboard.Show();

        }

        private void UpdateClaimForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
