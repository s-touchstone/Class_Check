using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppFunctions;

namespace Class_Check
{
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            DBFunctions Start = new DBFunctions();
            try
            {
                Start.INIT();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error logged!");
                string[] date_time = { SystemInformation.ComputerName, DateTime.Now.ToString(), ex.ToString() };
                System.IO.File.AppendAllLines(@"Errors.log", contents: date_time);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
