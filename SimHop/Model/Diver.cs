using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace SimHop
{
    public class Diver : INotifyPropertyChanged, IComparable<Diver>
    {
        public List<Point> hopp = new List<Point>();
        #region Constructor
        //constroctor
        public Diver() : this("", "", "", 0, 0)
        {

        }
        //public List<Tuple<Judge, double>> judges = new List<Tuple<Judge, double>>();
        //constructor overloaded
        public Diver(string firstname, string lastname, string dateofbirth, int dive, int result)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Dateofbirth = dateofbirth;
            this.Dive = dive;
            this.Result = result;

        }
        //_--------------------
        public void Hopp()
        {
            Point jump = new Point();
            hopp.Add(jump);
        }
        //_--------------------
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
        private int _result;
        public int Result
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Result"));
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
        public string calculatetextbox(double judge1, double judge2, double judge3, double judge4, double judge5, double judge6)
        {
            int count = 0;
            double sumPoint = 0;
            double max = 0;
            double min = int.MaxValue;
            double sum = 0;
            double jumppoint = 0;


            if (true)
            {

                double[] array = { judge1, judge2, judge3, judge4, judge5, judge6 };
                for (int i = 0; i < 5; i++)
                {
                    sumPoint += array[i];
                    if (array[i] < min)
                        min = array[i];

                    if (array[i] > max)
                        max = array[i];
                    sum = sumPoint - max - min;
                    count += 1;


                }
                jumppoint = (sum / (count - 2)) * array[5] * 3;

                return jumppoint.ToString();

            }

        }
        public void test(double judge1, double judge2, double judge3, double judge4, double judge5, double judge6)
        {
            double x;
            double y;
            double z;
            double q;
            double w;
            double v;
            x = judge1;
            y = judge2;
            z = judge3;
            q = judge4;
            w = judge5;
            v = judge6;
            ////-----------------
        }

    }
    }
