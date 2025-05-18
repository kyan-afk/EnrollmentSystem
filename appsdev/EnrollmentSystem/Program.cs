using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new StudentEntry());
            //Application.Run(new SubjectEntryForm());
            //Application.Run(new SubjectScheduleEntry());
            //Application.Run(new StudentEnrollmentEntry());
            Application.Run(new Dashboard());

        }
    }
}
