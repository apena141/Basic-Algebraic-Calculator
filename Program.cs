using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
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
            Application.Run(new SimpleCalculator());
            //Form form = new myFirstForm();
            // SHOW() Does not stop the main thread
            //form.Show();

            // ShowDialog() will stop the main thread but wont be accessible by other parts of the program
            //form.ShowDialog();
            //MessageBox.Show("Hello, windows form!");

            //BEST WAY TO IMPLEMENT IS 
            //form.Text = "Hello, using Application.run!";
            //Application.Run(form);
        }
    }
}
