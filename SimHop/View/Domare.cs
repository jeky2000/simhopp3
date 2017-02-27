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
    public partial class Domare : Form
    {
        public Domare()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //calculate
        private void button2_Click(object sender, EventArgs e)
        {
            Diver d = new Diver();
            Point p = new Point();
            MessageBox.Show(p.Valid(double.Parse(txtjudge1.Text), double.Parse(txtjudge2.Text), double.Parse(txtjudge3.Text),
            double.Parse(txtjudge4.Text), double.Parse(txtjudge5.Text)));
            txtpoint.Text = d.calculatetextbox(double.Parse(txtjudge1.Text), double.Parse(txtjudge2.Text), double.Parse(txtjudge3.Text),
                double.Parse(txtjudge4.Text), double.Parse(txtjudge5.Text), double.Parse(txtdifficulty.Text));

        }

        //save point to diver
        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Diver (FirstName,LastName,Dateofbirth,Dive,Id,Result) VALUES (@FirstName , @LastName, @Dateofbirth, @Dive ,@Id,@Result)", Connection.ActiveCon());
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@FirstName", txtfirstname1.Text);
                cmd.Parameters.AddWithValue("@LastName", txtlastname1.Text);
                cmd.Parameters.AddWithValue("@Dateofbirth", txtdateofbirth1.Text);
                cmd.Parameters.AddWithValue("@dive", txtdive.Text);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.Parameters.AddWithValue("@Result", txtpoint.Text);

                cmd.ExecuteNonQuery();
                SqlDataAdapter diverslist = new SqlDataAdapter("select FirstName,LastName,Dateofbirth,Dive,Result from Diver", Connection.ActiveCon());
                DataTable dt = new DataTable();
                diverslist.Fill(dt);
                dataGridViewdomare.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            SqlDataAdapter diverslist = new SqlDataAdapter("select FirstName,LastName,Dateofbirth,Dive,Result from Diver", Connection.ActiveCon());
            DataTable dt = new DataTable();
            diverslist.Fill(dt);
            dataGridViewdomare.DataSource = dt;
        }

        private void Domare_Load(object sender, EventArgs e)
        {
            //int w = Screen.PrimaryScreen.Bounds.Width;
            //int h = Screen.PrimaryScreen.Bounds.Height;
            //this.Location = new System.Drawing.Point(0, 0);
            //this.Size = new Size(w, h);
        }
    }
}
