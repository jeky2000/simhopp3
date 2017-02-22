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
    public partial class JudgeLogin : Form
    {
        public JudgeLogin()
        {
            InitializeComponent();
        }
        //button judge
        private void button1_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlCommand com = new SqlCommand("SELECT * FROM Judges WHERE username =@user and password = @pw", con.ActiveCon());
            
            com.Parameters.AddWithValue("@user", textBox1.Text);
            com.Parameters.AddWithValue("@pw", textBox2.Text);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows == true)
            {
                Domare d = new Domare();
                d.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password or username is invalid", "Aleart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void JudgeLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
