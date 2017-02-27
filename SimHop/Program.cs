using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimHop
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



            from1 form = new from1();
            
            Admin admin = new Admin();

            Tournament tr = new Tournament();
            PresenterForm pre = new PresenterForm( tr, admin);
            Application.Run(form);



        }
    }
}
