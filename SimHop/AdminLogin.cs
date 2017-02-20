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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Son Nguyen\Desktop\Git1\SimHop\Simhoppdb.mdf;Integrated Security = True");
            SqlCommand com = new SqlCommand("SELECT * FROM Admin WHERE username =@user and password = @pw", con);
            con.Open();
            com.Parameters.AddWithValue("@user", textBox1.Text);
            com.Parameters.AddWithValue("@pw", textBox2.Text);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows == true)
            {
                Admin ad = new Admin();
                ad.Show();
            }
            else
            {
                MessageBox.Show("Failed");
            }

        }
       
    }
}
