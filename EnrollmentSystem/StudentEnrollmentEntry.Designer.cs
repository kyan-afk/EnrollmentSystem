namespace EnrollmentSystem
{
    partial class StudentEnrollmentEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IdNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CourseTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EDPCodeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EncodedByTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalUnitsTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SubjectChoosedDataGridView = new System.Windows.Forms.DataGridView();
            this.EDPCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectChoosedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IdNumberTextBox
            // 
            this.IdNumberTextBox.Location = new System.Drawing.Point(117, 104);
            this.IdNumberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IdNumberTextBox.Multiline = true;
            this.IdNumberTextBox.Name = "IdNumberTextBox";
            this.IdNumberTextBox.Size = new System.Drawing.Size(173, 28);
            this.IdNumberTextBox.TabIndex = 16;
            this.IdNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdNumberTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Number";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(117, 143);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(173, 28);
            this.NameTextBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name";
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(117, 218);
            this.YearTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.YearTextBox.Multiline = true;
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(173, 28);
            this.YearTextBox.TabIndex = 21;
            this.YearTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Year";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CourseTextBox
            // 
            this.CourseTextBox.Location = new System.Drawing.Point(117, 181);
            this.CourseTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CourseTextBox.Multiline = true;
            this.CourseTextBox.Name = "CourseTextBox";
            this.CourseTextBox.Size = new System.Drawing.Size(173, 28);
            this.CourseTextBox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(43, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Course";
            // 
            // EDPCodeTextBox
            // 
            this.EDPCodeTextBox.Location = new System.Drawing.Point(117, 255);
            this.EDPCodeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EDPCodeTextBox.Multiline = true;
            this.EDPCodeTextBox.Name = "EDPCodeTextBox";
            this.EDPCodeTextBox.Size = new System.Drawing.Size(173, 28);
            this.EDPCodeTextBox.TabIndex = 25;
            this.EDPCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EDPCodeTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "EDP Code";
            // 
            // EncodedByTextBox
            // 
            this.EncodedByTextBox.Location = new System.Drawing.Point(117, 475);
            this.EncodedByTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EncodedByTextBox.Multiline = true;
            this.EncodedByTextBox.Name = "EncodedByTextBox";
            this.EncodedByTextBox.Size = new System.Drawing.Size(173, 28);
            this.EncodedByTextBox.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 482);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Incoded By";
            // 
            // TotalUnitsTextBox
            // 
            this.TotalUnitsTextBox.Location = new System.Drawing.Point(665, 476);
            this.TotalUnitsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TotalUnitsTextBox.Multiline = true;
            this.TotalUnitsTextBox.Name = "TotalUnitsTextBox";
            this.TotalUnitsTextBox.Size = new System.Drawing.Size(55, 28);
            this.TotalUnitsTextBox.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(577, 482);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Total Units";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(329, 482);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 21);
            this.label9.TabIndex = 30;
            this.label9.Text = "Date";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker.Location = new System.Drawing.Point(375, 478);
            this.DateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(190, 26);
            this.DateTimePicker.TabIndex = 31;
            // 
            // SubjectChoosedDataGridView
            // 
            this.SubjectChoosedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectChoosedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDPCodeColumn,
            this.SubjectCodeColumn,
            this.StartTimeColumn,
            this.EndTimeColumn,
            this.DaysColumn,
            this.RoomColumn,
            this.UnitsColumn});
            this.SubjectChoosedDataGridView.Location = new System.Drawing.Point(117, 298);
            this.SubjectChoosedDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubjectChoosedDataGridView.Name = "SubjectChoosedDataGridView";
            this.SubjectChoosedDataGridView.RowHeadersVisible = false;
            this.SubjectChoosedDataGridView.RowHeadersWidth = 51;
            this.SubjectChoosedDataGridView.RowTemplate.Height = 24;
            this.SubjectChoosedDataGridView.Size = new System.Drawing.Size(609, 162);
            this.SubjectChoosedDataGridView.TabIndex = 32;
            // 
            // EDPCodeColumn
            // 
            this.EDPCodeColumn.HeaderText = "EDP Code";
            this.EDPCodeColumn.MinimumWidth = 6;
            this.EDPCodeColumn.Name = "EDPCodeColumn";
            this.EDPCodeColumn.ReadOnly = true;
            this.EDPCodeColumn.Width = 125;
            // 
            // SubjectCodeColumn
            // 
            this.SubjectCodeColumn.HeaderText = "Subject Code";
            this.SubjectCodeColumn.MinimumWidth = 6;
            this.SubjectCodeColumn.Name = "SubjectCodeColumn";
            this.SubjectCodeColumn.ReadOnly = true;
            this.SubjectCodeColumn.Width = 125;
            // 
            // StartTimeColumn
            // 
            this.StartTimeColumn.HeaderText = "Start Time";
            this.StartTimeColumn.MinimumWidth = 6;
            this.StartTimeColumn.Name = "StartTimeColumn";
            this.StartTimeColumn.ReadOnly = true;
            this.StartTimeColumn.Width = 125;
            // 
            // EndTimeColumn
            // 
            this.EndTimeColumn.HeaderText = "End Time";
            this.EndTimeColumn.MinimumWidth = 6;
            this.EndTimeColumn.Name = "EndTimeColumn";
            this.EndTimeColumn.ReadOnly = true;
            this.EndTimeColumn.Width = 125;
            // 
            // DaysColumn
            // 
            this.DaysColumn.HeaderText = "Days";
            this.DaysColumn.MinimumWidth = 6;
            this.DaysColumn.Name = "DaysColumn";
            this.DaysColumn.ReadOnly = true;
            this.DaysColumn.Width = 125;
            // 
            // RoomColumn
            // 
            this.RoomColumn.HeaderText = "Room";
            this.RoomColumn.MinimumWidth = 6;
            this.RoomColumn.Name = "RoomColumn";
            this.RoomColumn.ReadOnly = true;
            this.RoomColumn.Width = 125;
            // 
            // UnitsColumn
            // 
            this.UnitsColumn.HeaderText = "Units";
            this.UnitsColumn.MinimumWidth = 6;
            this.UnitsColumn.Name = "UnitsColumn";
            this.UnitsColumn.ReadOnly = true;
            this.UnitsColumn.Width = 125;
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(642, 246);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(78, 27);
            this.CancelButton.TabIndex = 34;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSize = true;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(537, 246);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(78, 27);
            this.SaveButton.TabIndex = 33;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(250, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(310, 36);
            this.label8.TabIndex = 17;
            this.label8.Text = "Student Enrollment Entry";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EnrollmentSystem.Properties.Resources.pngtree_black_and_yellow_wavy_halftone_blank_background_vector_image_13367892;
            this.pictureBox1.Location = new System.Drawing.Point(-74, -242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(928, 881);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(251, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 5);
            this.panel1.TabIndex = 36;
            // 
            // StudentEnrollmentEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(801, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SubjectChoosedDataGridView);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TotalUnitsTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EncodedByTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EDPCodeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CourseTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentEnrollmentEntry";
            this.Text = "StudentEnrollmentEntry";
            ((System.ComponentModel.ISupportInitialize)(this.SubjectChoosedDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox IdNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CourseTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EDPCodeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EncodedByTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotalUnitsTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.DataGridView SubjectChoosedDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDPCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsColumn;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}