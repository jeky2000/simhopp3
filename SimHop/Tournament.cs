using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.XmlConfiguration;


namespace SimHop
{


    [Serializable()]
    public partial class Tournament : ITournament
    {

        private Collection<Diver> _list;
        public Collection<Diver> List
        {
            get { return _list; }
            set { _list = value; }
        }
        //public string Name { get; set; }
        //public string Datum { get; set; }
        //constructor
        public Tournament()
        {
            List = new BindingList<Diver>();
        }

        public void Add(Diver diver)
        {
            _list.Add(diver);
        }


        public void Remove(int index)
        {
            _list.RemoveAt(index);
        }

        public void SaveToFile()
        {
            //Stream stream = new FileStream("divers.xml", FileMode.Create, FileAccess.Write, FileShare.Write);

            //XmlSerializer xs = new XmlSerializer(typeof(Tournament));
            //xs.Serialize(stream, this);
            //stream.Close();

            //sqlcon.Close();

        }

        void ITournament.update()
        {
            Connection.ActiveCon();
        }
        public void update()
        {
            Connection con = new Connection();
            SqlDataAdapter divers = new SqlDataAdapter("select * from Diver", con.ActiveCon());
            DataTable dt = new DataTable();
            divers.Fill(dt);
            dataGridView1.DataSource = dt;

        }


        public void ReadFromFile()
        {
            //retrive data from dáta base

            //Stream stream = new FileStream("divers.xml", FileMode.Open, FileAccess.Read, FileShare.Read);

            //XmlSerializer xs = new XmlSerializer(typeof(Tournament));
            //Tournament tr = (Tournament)xs.Deserialize(stream);

            //_list.Clear();
            //foreach (var diver in tr.List)
            //{
            //    _list.Add(diver);

            //}
            //stream.Close();
        }
    }

}
