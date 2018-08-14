using System;
using System.Collections.Generic;
using System.Linq;
/*Zachary Miller
 * 12/20/2017
 * assignment 7.3
 * The purpose of this program is display a form with an about button that will display a copyright message when clicked
 * InternetAccess.cs
 * Bellevue University
 */
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7._3
{
    static class About
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AboutForm());
        }
    }
}
