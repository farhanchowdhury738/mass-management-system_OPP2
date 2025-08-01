using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScholarsNest.Model;

namespace ScholarsNest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new View.StudentDeshboard("taimoor.aslam@example.com"));
            //Application.Run(new View.PremiumStudent("zain.ali@example.com"));
            Application.Run(new View.Welcome());


        }
    }
}
