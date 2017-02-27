using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Threading;


namespace SimHop
{
    public partial class Admin : Form, IAdmin
    {
        public Admin()
        {
            InitializeComponent();
        }
        private int _row = -1;
        public event DelegateAdd EventAdd = null;

        public event DelegateUpdate EventUpdate = null;
        public event DelegateDelete EventDelete = null;
        public event DelegateSave EventSave = null;
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (this.EventAdd != null)
                this.EventAdd();
        }
        void IAdmin.AddToDiverList(Collection<Diver> diver)
        {

            this.dataGridView1.DataSource = diver;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            this._row = e.RowIndex;
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            //foreach(DataGridViewRow item in this.dataGridView1.SelectedRows)
            //{
            //    dataGridView1.Rows.RemoveAt(item.Index);
            //}

            //if (this._row != -1)
            //    if (this.EventDelete != null)
            //        this.EventDelete(this._row);
            //this._row = 1;

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Diver WHERE FirstName = '" + txtfirstname.Text + "'", Connection.ActiveCon());


                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        void SetDiverList(Collection<Diver> divers)
        {

            this.dataGridView1.DataSource = divers;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (this.EventSave != null)
                this.EventSave();

            SqlCommand cmd = new SqlCommand("INSERT INTO Diver (Id,FirstName,LastName,Dateofbirth,Dive,Result) VALUES (@Id,@FirstName , @LastName, @Dateofbirth, @Dive , @Result)", Connection.ActiveCon());
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@Id", txtId.Text);
            cmd.Parameters.AddWithValue("@FirstName", txtfirstname.Text);
            cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
            cmd.Parameters.AddWithValue("@Dateofbirth", txtdataofbirht.Text);
            cmd.Parameters.AddWithValue("@dive", txtdive.Text);
          
            cmd.Parameters.AddWithValue("@Result", txtPoint.Text);

            cmd.ExecuteNonQuery();

        }

        private void btnread_Click(object sender, EventArgs e)
        {

            try
            {
                SqlDataAdapter diverslist = new SqlDataAdapter("select * from Diver", Connection.ActiveCon());
                DataTable dt = new DataTable();
                diverslist.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        //btnupdate
        private void button1_Click(object sender, EventArgs e)
        {

            //Connection con = new Connection();
            //SqlDataAdapter divers = new SqlDataAdapter("select * from Diver", con.ActiveCon());
            //DataTable dt = new DataTable();
            //divers.Fill(dt);
            //dataGridView1.DataSource = dt;


        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnserver_Click(object sender, EventArgs e)
        {
            //when the button is clicked we start threading
            //we can do it with out thread just call the method
            Thread tcpServerRunThread = new Thread(new ThreadStart(TcpServerRun));
            tcpServerRunThread.Start();
        }

        private void TcpServerRun()//i parametern upp there
        {
            //here we handle the connection with new threading
            //looking for any ipadress, port= client should know the port it is a particular nummber
            TcpListener tcpListener = new TcpListener(IPAddress.Any, 9058);
            tcpListener.Start();//here it will find the connection
            updateUI("Listening");
            while (true)
            {
                //here we go in connecctio / accsessed
                TcpClient client = tcpListener.AcceptTcpClient();
                updateUI("Connected");
                Thread tcpHandlerThread = new Thread(new ParameterizedThreadStart(TcpHandler));//this is a tthread but we can pass parameter
                tcpHandlerThread.Start(client);//here we pass the prameter whichis client
            }
        }
        private void TcpHandler(object client)//we pass upther

        {
            TcpClient mClient = (TcpClient)client;
            NetworkStream stream = mClient.GetStream();
            //we read the message form client
            byte[] message = new byte[1024];
            stream.Read(message, 0, message.Length);
            stream.Write(message, 0, message.Length);
            updateUI("new message" + Encoding.ASCII.GetString(message));
            stream.Close();
            mClient.Close();   


            

        }
        private void updateUI(string s)
        {
            Func<int> del = delegate ()
            {
                txtservername.AppendText(s + System.Environment.NewLine);
                return 0;
            };
            Invoke(del);


        }
    }
}
