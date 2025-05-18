using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//data set , data table , data rule
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EnrollmentSystem
{
    public partial class SubjectEntryForm : Form
    {
        public SubjectEntryForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            OfferingComboBox.Items.Add("1 - First Semester");
            OfferingComboBox.Items.Add("2 - Second Semester");
            CategoryComboBox.Items.Add("Lecture");
            CategoryComboBox.Items.Add("Labratory");
            CourseCodeComboBox.Items.Add("BSIT");
            CourseCodeComboBox.Items.Add("BSIS");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
    
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\SQLDatabaseEnrollmentSystemm.mdf;Integrated Security=True;Connect Timeout=30";

            SqlConnection subjectConnection = new SqlConnection(connectionString);
            string sql = "SELECT * FROM [dbo].[SUBJECTFILE]";

            SqlDataAdapter subjectAdapter = new SqlDataAdapter(sql, subjectConnection);
            SqlCommandBuilder studentBuilder = new SqlCommandBuilder(subjectAdapter);

            DataSet subjectDataSet = new DataSet();
            subjectAdapter.Fill(subjectDataSet, "SubjectFile");

            DataColumn[] keys = new DataColumn[2];

            keys[0] = subjectDataSet.Tables["SUBJECTFILE"].Columns["SFSUBJCODE"];
            keys[1] = subjectDataSet.Tables["SUBJECTFILE"].Columns["SFSUBJCOURSECODE"];

            subjectDataSet.Tables["SUBJECTFILE"].PrimaryKey = keys;
           
            String[] valuesToSearch = new  String[2];
            valuesToSearch[0] = SubjectCodeTextBox.Text;
            valuesToSearch[1] = CourseCodeComboBox.Text;

            DataRow findRow = subjectDataSet.Tables["SUBJECTFILE"].Rows.Find(valuesToSearch);
            if (SubjectCodeTextBox.Text.Equals("") ||
                DescriptionTextBox.Text.Equals("") ||
                UnitsTextBox.Text.Equals("") ||
                OfferingComboBox.SelectedItem == null ||
                CategoryComboBox.SelectedItem == null ||
                CourseCodeComboBox.SelectedItem == null ||
                CurriculumYearTextBox.Text.Equals(""))
            {
                MessageBox.Show("FILL UP THE REMAINING FIELDS", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (!int.TryParse(UnitsTextBox.Text, out int Units)) // Must be integer
            {
                MessageBox.Show("Units must be an integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (findRow == null)
            {
                DataRow thisRow = subjectDataSet.Tables["SUBJECTFILE"].NewRow();

                thisRow["SFSUBJCODE"] = SubjectCodeTextBox.Text;
                thisRow["SFSUBJDESC"] = DescriptionTextBox.Text;
                thisRow["SFSUBJUNITS"] = Convert.ToInt16(UnitsTextBox.Text);
                thisRow["SFSUBJREGOFRNG"] = OfferingComboBox.Text.Substring(0, 1);
                thisRow["SFSUBJCATEGORY"] = CategoryComboBox.Text.Substring(0, 3);
                thisRow["SFSUBJSTATUS"] = "AC";
                thisRow["SFSUBJCOURSECODE"] = CourseCodeComboBox.Text;
                thisRow["SFSUBJCURRCODE"] = CurriculumYearTextBox.Text;

                    if (!string.IsNullOrWhiteSpace(RequisiteSubjectTextBox.Text))
                    {
                        SqlConnection ReqConnection = new SqlConnection(connectionString);
                        string sqlRequisite = "SELECT * FROM SUBJECTPREQFILE";
                        SqlDataAdapter RequisiteAdapter = new SqlDataAdapter(sqlRequisite, ReqConnection);
                        SqlCommandBuilder RequisiteBuilder = new SqlCommandBuilder(RequisiteAdapter);

                        DataSet RequisiteDataSet = new DataSet();
                        RequisiteAdapter.Fill(RequisiteDataSet, "SubjectPreqFile");

                        DataColumn[] Reqkeys = new DataColumn[2];

                        Reqkeys[0] = RequisiteDataSet.Tables["SUBJECTPREQFILE"].Columns["SUBJCODE"];
                        Reqkeys[1] = RequisiteDataSet.Tables["SUBJECTPREQFILE"].Columns["SUBJPRECODE"];
                        RequisiteDataSet.Tables["SUBJECTPREQFILE"].PrimaryKey = Reqkeys;

                        String[] valuesToSearch2 = new string[2];
                        valuesToSearch2[0] = SubjectCodeTextBox.Text;
                        valuesToSearch2[1] = RequisiteSubjectTextBox.Text;
                        DataRow findRow2 = RequisiteDataSet.Tables["SUBJECTPREQFILE"].Rows.Find(valuesToSearch2);

                        if (RequisiteSubjectTextBox.Text.Equals(""))
                        {
                            MessageBox.Show("Missing Subject Code", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else if (!PreRequisiteRadioButton.Checked && !CoRequisiteRadioButton.Checked)
                        {
                            MessageBox.Show("Please select a category (Pre-requisite or Co-requisite).", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        else if (SubjectDataGridView.Rows[0].Cells["SubjectCodeColumn"].Value == null)
                        {
                            MessageBox.Show("Subject list is empty. Please add subjects before proceeding.", "Empty Grid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else if (SubjectRequisiteExists(RequisiteSubjectTextBox.Text, CourseCodeComboBox.Text, RequisiteDataSet.Tables["SUBJECTPREQFILE"]))
                        {
                            MessageBox.Show("This prerequisite entry already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }


                        try
                        {
                            if (findRow2 == null)
                            {
                                DataRow ReqRow = RequisiteDataSet.Tables["SUBJECTPREQFILE"].NewRow();
                                ReqRow["SUBJCODE"] = SubjectCodeTextBox.Text;
                                ReqRow["SUBJPRECODE"] = RequisiteSubjectTextBox.Text;

                                if (PreRequisiteRadioButton.Checked)
                                    ReqRow["SUBJCATEGORY"] = "PR";
                                else if (CoRequisiteRadioButton.Checked)
                                    ReqRow["SUBJCATEGORY"] = "CR";

                                RequisiteDataSet.Tables["SUBJECTPREQFILE"].Rows.Add(ReqRow);
                                RequisiteAdapter.Update(RequisiteDataSet, "SUBJECTPREQFILE");

                                MessageBox.Show("Entries Recorded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Reset UI
                                RequisiteSubjectTextBox.Clear();
                                SubjectDataGridView.Rows.Clear();
                                PreRequisiteRadioButton.Checked = false;
                                CoRequisiteRadioButton.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("Duplicate subject + prerequisite combination.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while saving: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    subjectDataSet.Tables["SUBJECTFILE"].Rows.Add(thisRow);
                    subjectAdapter.Update(subjectDataSet, "SUBJECTFILE");

                    MessageBox.Show("Entries Recorded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Duplicate Entry", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool SubjectRequisiteExists(string subjectCode, string prereqCode, DataTable prereqTable)
        {
            foreach (DataRow row in prereqTable.Rows)
            {
                if (row.RowState != DataRowState.Deleted &&
                    row["SUBJCODE"].ToString() == subjectCode &&
                    row["SUBJPRECODE"].ToString() == prereqCode)
                {
                    return true;
                }
            }
            return false;
        }


        private void RequisiteSubjectTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\SQLDatabaseEnrollmentSystemm.mdf;Integrated Security=True;Connect Timeout=30";

                SqlConnection subjectConnection = new SqlConnection(connectionString);
                subjectConnection.Open();

                string commandText = "SELECT * FROM [dbo].[SUBJECTFILE]";
                SqlCommand subjectCommand = subjectConnection.CreateCommand();
                subjectCommand.CommandText = commandText;

                SqlDataReader subjectReader = subjectCommand.ExecuteReader();

                bool flag = false;
                while (subjectReader.Read())
                {
                    if (subjectReader["SFSUBJCODE"].ToString().Trim() == RequisiteSubjectTextBox.Text.Trim())
                    {
                        flag = true;
                        SubjectDataGridView.Rows[0].Cells["SubjectCodeColumn"].Value = subjectReader["SFSUBJCODE"].ToString();
                        SubjectDataGridView.Rows[0].Cells["DescriptionColumn"].Value = subjectReader["SFSUBJDESC"].ToString();
                        SubjectDataGridView.Rows[0].Cells["UnitsColumn"].Value = subjectReader["SFSUBJUNITS"].ToString();

                      /*  if (PreRequisiteRadioButton.Checked)
                        {
                            SubjectDataGridView.Rows[0].Cells["CoPreColumn"].Value = "Pre-Requisite";
                        }
                        else if (CoRequisiteRadioButton.Checked)
                        {
                            SubjectDataGridView.Rows[0].Cells["CoPreColumn"].Value = "Co-Requisite";
                        }*/
                    }
                        else
                            continue;

                }
                    if (flag == false)
                    {
                        MessageBox.Show("Subject Not Found");
                    }

            }
                

        }


        

        private void SubjectDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
           

        }
        public void ClearFields()
        {
            SubjectCodeTextBox.Clear();
            DescriptionTextBox.Clear();
            UnitsTextBox.Clear();
            OfferingComboBox.SelectedItem = null;
            CategoryComboBox.SelectedItem = null;
            CourseCodeComboBox.SelectedItem = null;
            CurriculumYearTextBox.Clear();
        }

        private void CourseCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PreRequisiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PreRequisiteRadioButton.Checked && SubjectDataGridView.Rows.Count > 0)
            {
                SubjectDataGridView.Rows[0].Cells["CoPreColumn"].Value = "Pre-Requisite";
            }

        }

        private void CoRequisiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CoRequisiteRadioButton.Checked && SubjectDataGridView.Rows.Count > 0)
            {
                SubjectDataGridView.Rows[0].Cells["CoPreColumn"].Value = "Co-Requisite";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
