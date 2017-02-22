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


namespace SimHop
{
    public partial class Admin : Form, IForm
    {
        public Admin()
        {
            InitializeComponent();
        }
        private int _row = -1;
        public event DelegateAdd EventAdd = null;
     
        public event DelegareRead EventRead =  null;
        public event DelegateDelete EventDelete =  null;
        public event DelegateSave EventSave = null;
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (this.EventAdd != null)
                 this.EventAdd();
        }
        void IForm.AddToDiverList(Collection<Diver> diver)
        {
            this.dataGridView1.DataSource = diver;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            this._row = e.RowIndex;
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }

            //if (this._row != -1)
            //    if (this.EventDelete != null)
            //        this.EventDelete(this._row);
            //this._row = 1;


        }
        void SetDiverList(Collection<Diver> divers)
        {
            this.dataGridView1.DataSource = divers;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (this.EventSave != null)
                this.EventSave();
            
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            if (this.EventRead != null)
                this.EventRead();

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
    }
}
