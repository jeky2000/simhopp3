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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        //btnlogin
        private void button1_Click(object sender, EventArgs e)
        {

            Connection con = new Connection();
            SqlCommand com = new SqlCommand("SELECT * FROM Admin WHERE username =@user and password = @pw", Connection.ActiveCon());
          
            com.Parameters.AddWithValue("@user", textBox1.Text);
            com.Parameters.AddWithValue("@pw", textBox2.Text);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows == true)//==1
            {
              
                Admin ad = new Admin();
                ad.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed","Aleart",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
