using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public partial class dashBoard : Form
    {
        private CircularProgressBar progressBar;
        private ComboBox statusComboBox;

        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\012sh\\OneDrive\\Documents\\consultantAgencyDb.mdf;Integrated Security=True;Connect Timeout=30");

        public dashBoard()
        {
            InitializeComponent();
            InitializeCircularProgressBar();
            LoadEmbassyData();
        }

        private void InitializeCircularProgressBar()
        {
            // Initialize the Circular Progress Bar
            progressBar = new CircularProgressBar
            {
                ProgressColor = Color.Blue,
                BackColor = Color.Gray,
                LineWidth = 10,
                Size = new Size(200, 200),
                Location = new Point(this.ClientSize.Width - 220, 50), // Positioned on the right
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            this.Controls.Add(progressBar);

            // Initialize the ComboBox
            statusComboBox = new ComboBox
            {
                Location = new Point(this.ClientSize.Width - 220, 260),
                Width = 200,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            statusComboBox.Items.AddRange(new string[] { "Pending", "Accepted", "Rejected" });
            statusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            this.Controls.Add(statusComboBox);
        }

        private void LoadEmbassyData()
        {
            try
            {
                Con.Open();
                string query = "SELECT EmbWorkPro, COUNT(*) AS Count FROM EmbassyTbl GROUP BY EmbWorkPro";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader reader = cmd.ExecuteReader();

                int total = 0;
                Dictionary<string, int> statusCounts = new Dictionary<string, int>
                {
                    { "pending", 0 },
                    { "accepted", 0 },
                    { "rejected", 0 }
                };

                while (reader.Read())
                {
                    string status = reader["EmbWorkPro"].ToString().Trim().ToLower();
                    int count = Convert.ToInt32(reader["Count"]);

                    if (statusCounts.ContainsKey(status))
                    {
                        statusCounts[status] = count;
                    }

                    total += count;
                }

                reader.Close();
                Con.Close();

                // Store the status counts and total in the Tag property of the ComboBox for later use
                statusComboBox.Tag = new { Total = total, StatusCounts = statusCounts };

                // Update the progress bar with total cases
                progressBar.TotalCases = total;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tag = statusComboBox.Tag as dynamic;
            if (tag == null)
            {
                MessageBox.Show("No data loaded");
                return;
            }

            int total = tag.Total;
            var statusCounts = tag.StatusCounts as Dictionary<string, int>;

            string selectedStatus = statusComboBox.SelectedItem.ToString().ToLower();
            int count = statusCounts[selectedStatus];

            // Calculate percentage
            int percentage = (total == 0) ? 0 : (count * 100) / total;

            // Update progress bar
            progressBar.ProgressValue = percentage;

            // Optionally update the progress bar color based on the selected status
            switch (selectedStatus)
            {
                case "pending":
                    progressBar.ProgressColor = Color.Yellow;
                    break;
                case "accepted":
                    progressBar.ProgressColor = Color.Green;
                    break;
                case "rejected":
                    progressBar.ProgressColor = Color.Red;
                    break;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            embassy obj = new embassy();
            obj.Show();
            this.Hide();
        }
    }
}
