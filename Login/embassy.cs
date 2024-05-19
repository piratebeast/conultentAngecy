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
using System.Windows.Input;


namespace Login
{
    public partial class embassy : Form
    {
        public embassy()
        {
            InitializeComponent();
            DisplayEmbassy();
            embassyDGV.CellClick += embassyDGV_CellContentClick;
        }

        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\012sh\\OneDrive\\Documents\\consultantAgencyDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayEmbassy()
        {
            Con.Open();

            string Query = "Select * from EmbassyTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            embassyDGV.DataSource = ds.Tables[0];

            Con.Close();
        }

        private void Clear()
        {
            studentNameTb.Text = "";
            passportNumTb.Text = "";
            conInfoTb.Text = "";
            policeRepTb.Text = "";
            workPrgCb.SelectedIndex = 0;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (studentNameTb.Text == "" || passportNumTb.Text == "" ||
                conInfoTb.Text == "" || policeRepTb.Text == "" || workPrgCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO EmbassyTbl (EmbName, EmbPortNum, EmbCon, EmbPoliceRep, EmbWorkPro) VALUES (@EN, @EPN, @EC, @EPR, @EWP)", Con);

                    cmd.Parameters.AddWithValue("@EN", studentNameTb.Text);
                    cmd.Parameters.AddWithValue("@EPN", passportNumTb.Text);
                    cmd.Parameters.AddWithValue("@EC", conInfoTb.Text);
                    cmd.Parameters.AddWithValue("@EPR", policeRepTb.Text);
                    cmd.Parameters.AddWithValue("@EWP", workPrgCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Embassy Info Added");

                    Con.Close();
                    DisplayEmbassy();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int Key = 0;
        private void embassyDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = embassyDGV.Rows[e.RowIndex];

                if (selectedRow.Cells.Count >= 5)
                {
                    studentNameTb.Text = selectedRow.Cells[1].Value.ToString();
                    passportNumTb.Text = selectedRow.Cells[2].Value.ToString();
                    conInfoTb.Text = selectedRow.Cells[3].Value.ToString();
                    policeRepTb.Text = selectedRow.Cells[4].Value.ToString();
                    workPrgCb.Text = selectedRow.Cells[5].Value.ToString();

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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (studentNameTb.Text == "" || passportNumTb.Text == "" ||
                conInfoTb.Text == "" || policeRepTb.Text == "" || workPrgCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update EmbassyTbl set EmbName=@EN, EmbPortNum=@EPN, EmbCon=@EC, EmbPoliceRep=@EPR, EmbWorkPro=@EWP where EmbId=@EKey", Con);

                    cmd.Parameters.AddWithValue("@EN", studentNameTb.Text);
                    cmd.Parameters.AddWithValue("@EPN", passportNumTb.Text);
                    cmd.Parameters.AddWithValue("@EC", conInfoTb.Text);
                    cmd.Parameters.AddWithValue("@EPR", policeRepTb.Text);
                    cmd.Parameters.AddWithValue("@EWP", workPrgCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Embassy Info Updated");

                    Con.Close();
                    DisplayEmbassy();
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
            if (studentNameTb.Text == "" || passportNumTb.Text == "" ||
                conInfoTb.Text == "" || policeRepTb.Text == "" || workPrgCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from EmbassyTbl where EmbId=@EIDKey", Con);

                    cmd.Parameters.AddWithValue("@EIDKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Embassy Info Deleted");

                    Con.Close();
                    DisplayEmbassy();
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
            university obj = new university();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            homes obj = new homes();
            obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            employee obj = new employee();
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
