/*Zachary Miller
 * 12/20/2017
 * assignment 7.3
 * This contains the code for the form and button 
 * InternetAccess.cs
 * Bellevue University
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7._3
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const String copyright = ("Copyright December 2017\n Zachary Miller\n Bellevue University\n ");
            const String caption = ("CopyRight");
            System.Windows.Forms.MessageBox.Show(copyright, caption, MessageBoxButtons.OK);
        }
    }
}
