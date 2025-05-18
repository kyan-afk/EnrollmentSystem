namespace EnrollmentSystem
{
    partial class Dashboard
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStudentEntry = new System.Windows.Forms.Button();
            this.btnSubjectEntry = new System.Windows.Forms.Button();
            this.btnSubjectSchedule = new System.Windows.Forms.Button();
            this.btnStudentEnrollment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(313, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 36);
            this.label8.TabIndex = 15;
            this.label8.Text = "Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EnrollmentSystem.Properties.Resources.pngtree_black_and_yellow_wavy_halftone_blank_background_vector_image_13367892;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(317, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 5);
            this.panel1.TabIndex = 21;
            // 
            // btnStudentEntry
            // 
            this.btnStudentEntry.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnStudentEntry.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentEntry.ForeColor = System.Drawing.Color.White;
            this.btnStudentEntry.Location = new System.Drawing.Point(97, 166);
            this.btnStudentEntry.Name = "btnStudentEntry";
            this.btnStudentEntry.Size = new System.Drawing.Size(124, 109);
            this.btnStudentEntry.TabIndex = 22;
            this.btnStudentEntry.Text = "Student Entry";
            this.btnStudentEntry.UseVisualStyleBackColor = false;
            this.btnStudentEntry.Click += new System.EventHandler(this.btnStudentEntry_Click);
            // 
            // btnSubjectEntry
            // 
            this.btnSubjectEntry.BackColor = System.Drawing.Color.Black;
            this.btnSubjectEntry.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjectEntry.ForeColor = System.Drawing.Color.White;
            this.btnSubjectEntry.Location = new System.Drawing.Point(258, 166);
            this.btnSubjectEntry.Name = "btnSubjectEntry";
            this.btnSubjectEntry.Size = new System.Drawing.Size(124, 109);
            this.btnSubjectEntry.TabIndex = 23;
            this.btnSubjectEntry.Text = "Subject Entry";
            this.btnSubjectEntry.UseVisualStyleBackColor = false;
            this.btnSubjectEntry.Click += new System.EventHandler(this.btnSubjectEntry_Click);
            // 
            // btnSubjectSchedule
            // 
            this.btnSubjectSchedule.BackColor = System.Drawing.Color.Black;
            this.btnSubjectSchedule.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjectSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSubjectSchedule.Location = new System.Drawing.Point(426, 166);
            this.btnSubjectSchedule.Name = "btnSubjectSchedule";
            this.btnSubjectSchedule.Size = new System.Drawing.Size(124, 109);
            this.btnSubjectSchedule.TabIndex = 24;
            this.btnSubjectSchedule.Text = "Schedule Entry";
            this.btnSubjectSchedule.UseVisualStyleBackColor = false;
            this.btnSubjectSchedule.Click += new System.EventHandler(this.btnSubjectSchedule_Click);
            // 
            // btnStudentEnrollment
            // 
            this.btnStudentEnrollment.BackColor = System.Drawing.Color.Black;
            this.btnStudentEnrollment.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentEnrollment.ForeColor = System.Drawing.Color.White;
            this.btnStudentEnrollment.Location = new System.Drawing.Point(584, 166);
            this.btnStudentEnrollment.Name = "btnStudentEnrollment";
            this.btnStudentEnrollment.Size = new System.Drawing.Size(119, 109);
            this.btnStudentEnrollment.TabIndex = 25;
            this.btnStudentEnrollment.Text = "Enrollment";
            this.btnStudentEnrollment.UseVisualStyleBackColor = false;
            this.btnStudentEnrollment.Click += new System.EventHandler(this.btnStudentEnrollment_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStudentEnrollment);
            this.Controls.Add(this.btnSubjectSchedule);
            this.Controls.Add(this.btnSubjectEntry);
            this.Controls.Add(this.btnStudentEntry);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStudentEnrollment;
        private System.Windows.Forms.Button btnSubjectSchedule;
        private System.Windows.Forms.Button btnSubjectEntry;
        private System.Windows.Forms.Button btnStudentEntry;
    }
}