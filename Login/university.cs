using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class university : Form
    {
        public university()
        {
            InitializeComponent();
            DisplayUniversity();
            universityDGV.CellClick += universityDGV_CellContentClick;
            universityDGV.CellFormatting += universityDGV_CellFormatting;
        }

        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\012sh\\OneDrive\\Documents\\consultantAgencyDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayUniversity()
        {
            Con.Open();

            string Query = "Select * from UniversityTbl";
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
            sscGradeTb.Text = "";
            hscGradeTb.Text = "";
            Key = 0;
        }

        private bool ValidateInput() // Field validation
        {
            if (string.IsNullOrEmpty(studentNameTb.Text))
            {
                MessageBox.Show("Please enter the student name.");
                return false;
            }
            if (!Regex.IsMatch(studentNameTb.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Student name can only contain letters and spaces.");
                return false;
            }
            if (string.IsNullOrEmpty(uniNameTb.Text))
            {
                MessageBox.Show("Please enter the university name.");
                return false;
            }
            if (!Regex.IsMatch(uniNameTb.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("University name can only contain letters and spaces.");
                return false;
            }
            if (!double.TryParse(cgpaTb.Text, out double cgpa) || cgpa < 0 || cgpa > 4)
            {
                MessageBox.Show("Please enter a valid CGPA (0-4).");
                return false;
            }
            if (string.IsNullOrEmpty(subPerTb.Text))
            {
                MessageBox.Show("Please enter a valid subject name.");
                return false;
            }
            if (string.IsNullOrEmpty(sscGradeTb.Text) ||
               !(Regex.IsMatch(sscGradeTb.Text, @"^(A\+|A-|A|B|C|D|F)$", RegexOptions.IgnoreCase)))
            {
                MessageBox.Show("Please enter a valid SSC Grade (A-F).");
                return false;
            }
            if (string.IsNullOrEmpty(hscGradeTb.Text) ||
                !(Regex.IsMatch(hscGradeTb.Text, @"^(A\+|A-|A|B|C|D|F)$", RegexOptions.IgnoreCase)))
            {
                MessageBox.Show("Please enter a valid HSC Grade (A-F).");
                return false;
            }
            return true;
        }

        private double GradeCalculator(string grade)
        {
            switch (grade.ToUpper())
            {
                case "A+":
                    return 5.00;
                case "A":
                    return 4.00;
                case "A-":
                    return 3.50;
                case "B":
                    return 3.00;
                case "C":
                    return 2.00;
                case "D":
                    return 1.00;
                case "F":
                    return 0.00;
                default:
                    return 0.00;
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                string sscGrade = sscGradeTb.Text.ToUpper();
                string hscGrade = hscGradeTb.Text.ToUpper();

                double sscGradePoint = GradeCalculator(sscGrade);
                double hscGradePoint = GradeCalculator(hscGrade);

                double totalGrade = sscGradePoint + hscGradePoint;

                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UniversityTbl (UniName, UniCgpa, StudentName, SubjectPre, sscGrade, hscGrade, TotalGra) values(@UN, @UC, @SN, @SP, @SG, @HG, @TG)", Con);



                cmd.Parameters.AddWithValue("@UN", uniNameTb.Text);
                cmd.Parameters.AddWithValue("@SN", studentNameTb.Text);
                cmd.Parameters.AddWithValue("@UC", cgpaTb.Text);
                cmd.Parameters.AddWithValue("@SP", subPerTb.Text);
                cmd.Parameters.AddWithValue("@SG", sscGrade);
                cmd.Parameters.AddWithValue("@HG", hscGrade);
                cmd.Parameters.AddWithValue("@TG", totalGrade); // totalGrade is double
                cmd.ExecuteNonQuery();
                MessageBox.Show("University info added.");

                Con.Close();
                DisplayUniversity();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    studentNameTb.Text = selectedRow.Cells[3].Value.ToString();
                    uniNameTb.Text = selectedRow.Cells[1].Value.ToString();
                    cgpaTb.Text = selectedRow.Cells[2].Value.ToString();
                    subPerTb.Text = selectedRow.Cells[4].Value.ToString();
                    sscGradeTb.Text = selectedRow.Cells[5].Value.ToString();
                    hscGradeTb.Text = selectedRow.Cells[6].Value.ToString();

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
            if (Key == 0)
            {
                MessageBox.Show("Select an entry to edit.");
                return;
            }
            if (!ValidateInput()) return;

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update UniversityTbl set UniName=@UN, UniCgpa=@UC, StudentName=@SN, SubjectPre=@SP, sscGrade=@SG, hscGrade=@HG, TotalGra=@TG where StudentId=@SKey", Con);

                string sscGrade = sscGradeTb.Text.ToUpper();
                string hscGrade = hscGradeTb.Text.ToUpper();

                double sscGradePoint = GradeCalculator(sscGrade);
                double hscGradePoint = GradeCalculator(hscGrade);

                double totalGrade = sscGradePoint + hscGradePoint;

                cmd.Parameters.AddWithValue("@UN", uniNameTb.Text);
                cmd.Parameters.AddWithValue("@SN", studentNameTb.Text);
                cmd.Parameters.AddWithValue("@UC", cgpaTb.Text);
                cmd.Parameters.AddWithValue("@SP", subPerTb.Text);
                cmd.Parameters.AddWithValue("@SG", sscGrade);
                cmd.Parameters.AddWithValue("@HG", hscGrade);
                cmd.Parameters.AddWithValue("@TG", totalGrade);
                cmd.Parameters.AddWithValue("@SKey", Key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("University info updated.");

                Con.Close();
                DisplayUniversity();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void deletBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select an entry to delete.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\012sh\\OneDrive\\Documents\\consultantAgencyDb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();

                    // Start a transaction to ensure atomicity
                    using (SqlTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            // Delete the selected student
                            using (SqlCommand cmd = new SqlCommand("DELETE FROM UniversityTbl WHERE StudentId = @SKey", con, transaction))
                            {
                                cmd.Parameters.AddWithValue("@SKey", Key);
                                cmd.ExecuteNonQuery();
                            }

                            // Create a temporary table and copy existing data except the deleted row
                            using (SqlCommand cmd = new SqlCommand(@"
                        SELECT ROW_NUMBER() OVER (ORDER BY StudentId) AS NewId, UniName, UniCgpa, StudentName, SubjectPre, sscGrade, hscGrade, TotalGra
                        INTO #TempUniversityTbl
                        FROM UniversityTbl;", con, transaction))
                            {
                                cmd.ExecuteNonQuery();
                            }

                            // Drop the original table
                            using (SqlCommand cmd = new SqlCommand("DROP TABLE UniversityTbl;", con, transaction))
                            {
                                cmd.ExecuteNonQuery();
                            }

                            // Create the original table again with the same schema
                            using (SqlCommand cmd = new SqlCommand(@"
                        CREATE TABLE UniversityTbl (
                            StudentId INT PRIMARY KEY IDENTITY(1,1),
                            UniName NVARCHAR(50),
                            UniCgpa FLOAT,
                            StudentName NVARCHAR(50),
                            SubjectPre NVARCHAR(50),
                            sscGrade NVARCHAR(2),
                            hscGrade NVARCHAR(2),
                            TotalGra FLOAT
                        );", con, transaction))
                            {
                                cmd.ExecuteNonQuery();
                            }

                            // Insert data back from the temporary table
                            using (SqlCommand cmd = new SqlCommand(@"
                        SET IDENTITY_INSERT UniversityTbl ON;

                        INSERT INTO UniversityTbl (StudentId, UniName, UniCgpa, StudentName, SubjectPre, sscGrade, hscGrade, TotalGra)
                        SELECT NewId, UniName, UniCgpa, StudentName, SubjectPre, sscGrade, hscGrade, TotalGra
                        FROM #TempUniversityTbl;

                        SET IDENTITY_INSERT UniversityTbl OFF;", con, transaction))
                            {
                                cmd.ExecuteNonQuery();
                            }

                            // Drop the temporary table
                            using (SqlCommand cmd = new SqlCommand("DROP TABLE #TempUniversityTbl;", con, transaction))
                            {
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            MessageBox.Show("Entry deleted and Student IDs reset.");

                            DisplayUniversity();
                            Clear();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void universityDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.ForeColor = Color.Black;
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

        private void studentNameTb_TextChanged(object sender, EventArgs e)
        {
            //-------------
        }
    }
}
