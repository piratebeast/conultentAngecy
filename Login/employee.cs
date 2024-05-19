using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
            DisplayEmployees();
            employeesDGV.CellClick += employeesDGV_CellContentClick;
        }

        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\012sh\\OneDrive\\Documents\\consultantAgencyDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayEmployees()
        {
            Con.Open();

            string Query = "Select * from Employeetbl"; // EmployeeTbl maybe
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
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

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (empNameTb.Text == "" || empAddressTb.Text == "" ||
                empPhoneTb.Text == "" || empPasswordTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
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
            if (empNameTb.Text == "" || empAddressTb.Text == "" ||
                empPhoneTb.Text == "" || empPasswordTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
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
        }

        private void deletbtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select An Employee");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from EmployeeTbl where EmpNum = @EmpKey", Con);

                    cmd.Parameters.AddWithValue("@EmpKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted");

                    Con.Close();
                    DisplayEmployees();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
    }
}
