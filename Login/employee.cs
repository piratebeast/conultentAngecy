using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Login
{
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
            DisplayEmployees();
            employeesDGV.CellClick += employeesDGV_CellContentClick;
            employeesDGV.CellFormatting += employeesDGV_CellFormatting;
        }

        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\012sh\\OneDrive\\Documents\\consultantAgencyDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayEmployees(string phoneSearch = "")
        {
            Con.Open();

            string Query = "Select * from EmployeeTbl";
            if (!string.IsNullOrEmpty(phoneSearch))
            {
                Query += " WHERE EmpPhone LIKE @PhoneSearch";
            }

            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            if (!string.IsNullOrEmpty(phoneSearch))
            {
                sda.SelectCommand.Parameters.AddWithValue("@PhoneSearch", "%" + phoneSearch + "%");
            }

            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            employeesDGV.DataSource = ds.Tables[0];

            Con.Close();
        }

        private void Clear()
        {
            empNameTb.Text = "";
            empAddressTb.Text = "";
            empPhoneTb.Text = "";
            empPasswordTb.Text = "";
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(empNameTb.Text))
            {
                MessageBox.Show("Please Enter a valid Employee name.");
                return false;
            }
            if (string.IsNullOrEmpty(empPasswordTb.Text))
            {
                MessageBox.Show("Enter a password.");
                return false;
            }
            if (string.IsNullOrEmpty(empPhoneTb.Text) ||
                !int.TryParse(empPhoneTb.Text, out int num) || num < 0)
            {
                MessageBox.Show("Please enter a valid phone number.");
                return false;
            }
            if (string.IsNullOrEmpty(empAddressTb.Text))
            {
                MessageBox.Show("Please Enter a valid Address.");
                return false;
            }
            return true;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into EmployeeTbl (EmpName, EmpAdd, EmpPhone, EmpPass) values(@EN, @EA, @EP, @EPa)", Con);

                cmd.Parameters.AddWithValue("@EN", empNameTb.Text);
                cmd.Parameters.AddWithValue("@EA", empAddressTb.Text);
                cmd.Parameters.AddWithValue("@EP", empPhoneTb.Text);
                cmd.Parameters.AddWithValue("@EPa", empPasswordTb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Added");

                Con.Close();
                DisplayEmployees();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int Key = 0;

        private void employeesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = employeesDGV.Rows[e.RowIndex];

                if (selectedRow.Cells.Count >= 5)
                {
                    empNameTb.Text = selectedRow.Cells[1].Value.ToString();
                    empAddressTb.Text = selectedRow.Cells[2].Value.ToString();
                    empPhoneTb.Text = selectedRow.Cells[3].Value.ToString();
                    empPasswordTb.Text = selectedRow.Cells[4].Value.ToString();

                    if (!string.IsNullOrEmpty(empNameTb.Text))
                    {
                        Key = Convert.ToInt32(selectedRow.Cells[0].Value);
                    }
                }
                else
                {
                    MessageBox.Show("The selected row does not have the expected number of cells.");
                }
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select an entry to edit.");
                return;
            }
            if (!ValidateInput()) return;
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update EmployeeTbl set EmpName=@EN, EmpAdd=@EA, EmpPhone=@EP, EmpPass=@EPa where EmpNum=@EKey", Con);

                cmd.Parameters.AddWithValue("@EN", empNameTb.Text);
                cmd.Parameters.AddWithValue("@EA", empAddressTb.Text);
                cmd.Parameters.AddWithValue("@EP", empPhoneTb.Text);
                cmd.Parameters.AddWithValue("@EPa", empPasswordTb.Text);
                cmd.Parameters.AddWithValue("@EKey", Key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Updated");

                Con.Close();
                DisplayEmployees();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletbtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select an entry to del ete.");
                return;
            }

            try
            {
                Con.Open();

                // Delete the selected employee
                using (SqlCommand cmd = new SqlCommand("DELETE FROM EmployeeTbl WHERE EmpNum = @EmpKey", Con))
                {
                    cmd.Parameters.AddWithValue("@EmpKey", Key);
                    cmd.ExecuteNonQuery();
                }

                // Create a temporary table and copy existing data except the deleted row
                using (SqlCommand cmd = new SqlCommand(@"
            SELECT ROW_NUMBER() OVER (ORDER BY EmpNum) AS NewId, EmpName, EmpAdd, EmpPhone, EmpPass
            INTO #TempEmployeeTbl
            FROM EmployeeTbl;", Con))
                {
                    cmd.ExecuteNonQuery();
                }

                // Drop the original table
                using (SqlCommand cmd = new SqlCommand("DROP TABLE EmployeeTbl;", Con))
                {
                    cmd.ExecuteNonQuery();
                }

                // Create the original table again with the same schema
                using (SqlCommand cmd = new SqlCommand(@"
            CREATE TABLE EmployeeTbl (
                EmpNum INT PRIMARY KEY IDENTITY(1,1),
                EmpName NVARCHAR(50),
                EmpAdd NVARCHAR(100),
                EmpPhone NVARCHAR(15),
                EmpPass NVARCHAR(50)
            );", Con))
                {
                    cmd.ExecuteNonQuery();
                }

                // Insert data back from the temporary table
                using (SqlCommand cmd = new SqlCommand(@"
            SET IDENTITY_INSERT EmployeeTbl ON;

            INSERT INTO EmployeeTbl (EmpNum, EmpName, EmpAdd, EmpPhone, EmpPass)
            SELECT NewId, EmpName, EmpAdd, EmpPhone, EmpPass
            FROM #TempEmployeeTbl;

            SET IDENTITY_INSERT EmployeeTbl OFF;", Con))
                {
                    cmd.ExecuteNonQuery();
                }

                // Drop the temporary table
                using (SqlCommand cmd = new SqlCommand("DROP TABLE #TempEmployeeTbl;", Con))
                {
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Employee deleted and IDs reset.");

                DisplayEmployees();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void employeesDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            university obj = new university();
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            embassy obj = new embassy();
            obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            homes homes = new homes();
            homes.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            dashBoard obj = new dashBoard();
            obj.Show();
            this.Hide();
        }

        private void phoneSearchTb_TextChanged(object sender, EventArgs e)
        {
            DisplayEmployees(phoneSearchTb.Text);
        }
    }
}
