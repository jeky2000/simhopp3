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

            Tournament tr1 = new Tournament();
            Admin admin = new Admin();
            admin.Hide();
            from1 form = new from1(tr1, admin);
            Application.Run(form);

            Tournament tr = new Tournament();
            PresenterForm pre = new PresenterForm(admin, tr);
            Application.Run(admin);



        }
    }
}
