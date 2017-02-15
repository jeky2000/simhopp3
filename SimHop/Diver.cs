using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.ComponentModel;
namespace SimHop
{
    public class Diver : INotifyPropertyChanged, IComparable<Diver>
    {
        public List<Point> hopp = new List<Point>();
        #region Constructor
        //constroctor
        public Diver():this("","","",0)
        {
              
        }
        //public List<Tuple<Judge, double>> judges = new List<Tuple<Judge, double>>();
        //constructor overloaded
        public Diver(string firstname, string lastname, string dateofbirth, int dive)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Dateofbirth = dateofbirth;
            this.Dive = dive;

        }
        public void Hopp()
        {
            Point jump = new Point();
            hopp.Add(jump);
        }
        public string _firstname;

        public event PropertyChangedEventHandler PropertyChanged;

        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs("FirstName"));
            }
        }
        private string _lastname;
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs("LastName"));
            }
        }

        private string _dateofbirth;
        public string Dateofbirth
        {
            get
            {
                return _dateofbirth;
            }
            set
            {
                _dateofbirth = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Dateofbirth"));
            }
        }

        private int _dive;
        public int Dive
        {
            get
            {
                return _dive;
            }
            set
            {
                _dive = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Dive"));
            }
        }
        #endregion


        public int CompareTo(Diver obj)
        {
            int c = this.FirstName.CompareTo(obj.FirstName);
            if (c == 0)
                return this.LastName.CompareTo(obj.LastName);
            else
                return c;
        }
        //public double calculate(Point Hopp)
        //{
        //    int count = 0;
        //    double sumPoint = 0;
        //    double max = 0;
        //    double min = int.MaxValue;
        //    double sum = 0;



        //    foreach (var jump in hopp)
        //    {
        //        foreach (var points in jump.points)
        //        {

        //            sumPoint += points.Item2;
        //            if (points.Item2 < min)
        //                min = points.Item2;

        //            if (points.Item2 > max)
        //                max = points.Item2;



        //            sum = sumPoint - max - min;
        //            count += 1;

        //        }
        //    }




        //    double jumppoint = sum / (count - 2);
        //    return jumppoint;
        //}
        ////-----------------
    }


}
