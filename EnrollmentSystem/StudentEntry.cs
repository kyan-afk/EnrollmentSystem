﻿using System;
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
    public partial class StudentEntry : Form
    {
        
        public StudentEntry()
        {
            InitializeComponent();

            RemarksComboBox.Items.Add("Shiftee");
            RemarksComboBox.Items.Add("Transferee");
            RemarksComboBox.Items.Add("New");
            RemarksComboBox.Items.Add("Old");
            RemarksComboBox.Items.Add("Cross-Ennrollee");
            RemarksComboBox.Items.Add("Returnee");


        }

        public void ClearFields()
        {
            IdNumberTextBox.Clear();
            LastNameTextBox.Clear();
            FirstNameTextBox.Clear();
            MiddleInitialTextBox.Clear();
            CourseTextBox.Clear();
            YearTextBox.Clear();
            RemarksComboBox.SelectedItem = null;
        }   


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool IdNumberExists(string idNumber, DataTable studentTable)
        {
            foreach (DataRow row in studentTable.Rows)
            {
                if (row.RowState != DataRowState.Deleted && row["STFSTUDID"].ToString() == idNumber)
                {
                    return true;
                }
            }
            return false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\SQLDatabaseEnrollmentSystemm.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection myConnection = new SqlConnection(connectionString);

            String sql = "SELECT * FROM [dbo].[STUDENTFILE]";

            SqlDataAdapter thisAdapter = new SqlDataAdapter(sql, myConnection);

            SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);

            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "StudentFile");

            DataRow thisRow = thisDataSet.Tables["StudentFile"].NewRow();



            if (IdNumberTextBox.Text.Equals("") ||
            LastNameTextBox.Text.Equals("") ||
            FirstNameTextBox.Text.Equals("") ||
            MiddleInitialTextBox.Text.Equals("") ||
            CourseTextBox.Text.Equals("") ||
            YearTextBox.Text.Equals("") ||
            RemarksComboBox.SelectedItem == null)
            {
                MessageBox.Show("FILL UP THE REMAINING FIELDS", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!int.TryParse(IdNumberTextBox.Text, out int idNumber)) // Must be integer
            {
                MessageBox.Show("ID Number must be an integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(FirstNameTextBox.Text, @"^[A-Za-z]+(?: [A-Za-z]+)?$"))
            {
                MessageBox.Show("Please enter a valid first name.", "Invalid First Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(MiddleInitialTextBox.Text, @"^[A-Za-z]$"))
            {
                MessageBox.Show("Please enter only one letter for your middle name.", "Invalid Middle Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(LastNameTextBox.Text, @"^[A-Za-z]+(?: [A-Za-z]+)?$"))
            {
                MessageBox.Show("Please enter a valid last name.", "Invalid Last Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(CourseTextBox.Text, @"^[A-Za-z]{3,4}$"))
            {
                MessageBox.Show("Please enter a valid course acronym (3–4 letters).", "Invalid Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(YearTextBox.Text, @"^[1-4]$")) // Only 1, 2, 3, or 4
            {
                MessageBox.Show("Please enter a valid year (1-4).", "Invalid Year", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (IdNumberExists(IdNumberTextBox.Text, thisDataSet.Tables["StudentFile"])) //Checks oif ID number is duplicate
            {
                MessageBox.Show("ID Number already exists. Please enter a unique ID.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearFields();
                IdNumberTextBox.Focus();
                return;
            }

            // Save to database — ONLY after passing all validations
            try
            {
                thisRow["STFSTUDID"] = Convert.ToInt64(IdNumberTextBox.Text);
                thisRow["STFSTUDLNAME"] = LastNameTextBox.Text;
                thisRow["STFSTUDFNAME"] = FirstNameTextBox.Text;
                thisRow["STFSTUDMNAME"] = MiddleInitialTextBox.Text;
                thisRow["STFSTUDCOURSE"] = CourseTextBox.Text;
                thisRow["STFSTUDYEAR"] = Convert.ToInt64(YearTextBox.Text);
                thisRow["STFSTUDREMARKS"] = RemarksComboBox.SelectedItem.ToString();
                //thisRow["STFSTUDSTATUS"] = "AC";

                thisDataSet.Tables["StudentFile"].Rows.Add(thisRow);
                thisAdapter.Update(thisDataSet, "StudentFile");

                MessageBox.Show("Entries Recorded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // --- Cancel Button Click Event ---
        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}

