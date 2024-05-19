using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Input;

namespace Login
{
    public partial class university : Form
    {
        public university()
        {
            InitializeComponent();
            DisplayUniversity();
            universityDGV.CellClick += universityDGV_CellContentClick;
        }

        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\012sh\\OneDrive\\Documents\\consultantAgencyDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayUniversity()
        {
            Con.Open();

            string Query = "Select * from UniversityTbl"; // EmployeeTbl maybe
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            universityDGV.DataSource = ds.Tables[0];

            Con.Close();
        }

        private void Clear()
        {
            studentNameTb.Text = "";
            uniNameTb.Text = "";
            cgpaTb.Text = "";
            subPerTb.Text = "";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (studentNameTb.Text == "" || uniNameTb.Text == "" ||
                cgpaTb.Text == "" || subPerTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into UniversityTbl (UniName, UniCgpa, StudentName, SubjectPre) values(@UN, @UC, @SN, @Sp)", Con);

                    cmd.Parameters.AddWithValue("@UN", uniNameTb.Text);
                    cmd.Parameters.AddWithValue("@SN", studentNameTb.Text);
                    cmd.Parameters.AddWithValue("@UC", cgpaTb.Text);
                    cmd.Parameters.AddWithValue("@SP", subPerTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("University info Added");

                    Con.Close();
                    DisplayUniversity();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int Key = 0;
        private void universityDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = universityDGV.Rows[e.RowIndex];

                if (selectedRow.Cells.Count >= 5)
                {
                    studentNameTb.Text = selectedRow.Cells[1].Value.ToString();
                    uniNameTb.Text = selectedRow.Cells[2].Value.ToString();
                    cgpaTb.Text = selectedRow.Cells[3].Value.ToString();
                    subPerTb.Text = selectedRow.Cells[4].Value.ToString();

                    if (!string.IsNullOrEmpty(studentNameTb.Text))
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

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (studentNameTb.Text == "" || uniNameTb.Text == "" ||
                cgpaTb.Text == "" || subPerTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update UniversityTbl set UniName=@UN, UniCgpa=@UC, StudentName=@SN, SubjectPre=@Sp where StudentId=@SKey", Con);

                    cmd.Parameters.AddWithValue("@UN", uniNameTb.Text);
                    cmd.Parameters.AddWithValue("@SN", studentNameTb.Text);
                    cmd.Parameters.AddWithValue("@UC", cgpaTb.Text);
                    cmd.Parameters.AddWithValue("@SP", subPerTb.Text);
                    cmd.Parameters.AddWithValue("@SKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("University info Updated");

                    Con.Close();
                    DisplayUniversity();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void deletBtn_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("delete from UniversityTbl where StudentId = @StyKey", Con);

                    cmd.Parameters.AddWithValue("@StyKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted");

                    Con.Close();
                    DisplayUniversity();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            homes obj = new homes();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            employee obj = new employee();
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            embassy obj = new embassy();
            obj.Show();
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
