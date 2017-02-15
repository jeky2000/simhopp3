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

namespace SimHop
{
   
    
    public partial class from1 : Form 
    {
        //private int _row = -1;
        public from1()
        {
            InitializeComponent();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin ad = new Admin();
            ad.Show();

        }

        private void btnguest_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
        }

        private void btnjudge_Click(object sender, EventArgs e)
        {
            Domare d = new Domare();
            d.Show();
        }

        //private void btnadd_Click(object sender, EventArgs e)
        //{
        //    if (this.EventAdd != null)
        //        this.EventAdd();
        //}
        //void IForm.AddToDiverList(Collection<Diver> diver)
        //{
        //    this.dataGridView1.DataSource = diver;
        //}
        //public event DelegateAdd EventAdd = null;
        //public event DelegareRead EventRead =  null;
        // public event DelegateDelete EventDelete =  null;
        //public event DelegateSave EventSave = null;

        //private void btndelete_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnsave_Click(object sender, EventArgs e)
        //{
        //    if (this.EventSave != null)
        //        this.EventSave();
        //}

        //private void btnread_Click(object sender, EventArgs e)
        //{
        //    if (this.EventRead != null)
        //        this.EventRead();
        //}

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    this._row = e.RowIndex;
        //}
    }
}
