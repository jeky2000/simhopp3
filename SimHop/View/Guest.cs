using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SimHop
{
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
        }

        private void btnshowtableguest_Click(object sender, EventArgs e)
        {
            SqlDataAdapter diverslist = new SqlDataAdapter("select FirstName,LastName,Dateofbirth,Dive,Result from Diver", Connection.ActiveCon());
            DataTable dt = new DataTable();
            diverslist.Fill(dt);
            dataGridViewguest.DataSource = dt;
        }
    }
}
