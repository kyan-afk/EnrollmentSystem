using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStudentEntry_Click(object sender, EventArgs e)
        {
            this.Hide();
            var studentEntryForm = new StudentEntry();
            studentEntryForm.FormClosed += (s, args) => this.Show();
            studentEntryForm.Show();
        }

        private void btnSubjectEntry_Click(object sender, EventArgs e)
        {
            this.Hide();
            var subjectEntryForm = new SubjectEntryForm();
            subjectEntryForm.FormClosed += (s, args) => this.Show();
            subjectEntryForm.Show();
        }

        private void btnSubjectSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            var subjectScheduleForm = new SubjectScheduleEntry();
            subjectScheduleForm.FormClosed += (s, args) => this.Show();
            subjectScheduleForm.Show();
        }

        private void btnStudentEnrollment_Click(object sender, EventArgs e)
        {
            this.Hide();
            var studentEnrollmentForm = new StudentEnrollmentEntry();
            studentEnrollmentForm.FormClosed += (s, args) => this.Show();
            studentEnrollmentForm.Show();
        }
    }
}
