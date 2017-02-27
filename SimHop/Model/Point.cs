using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SimHop
{

    [Serializable]
    public class Point :Diver, INotifyPropertyChanged, IComparable<Point>
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //constructor
        public List<Tuple<Judge, double>> judges = new List<Tuple<Judge, double>>();
        public List<Point> points = new List<Point>();
        public Point()
        {
            
        }
       // public List<Tpl> judges = new List<Tpl>();

        // public int id { get; set; }

        public Point(double points)
        {
            this.Points = points;
        }

        public string Valid(double judge1, double judge2, double judge3, double judge4, double judge5)
        {

            double[] point = { judge1, judge2, judge3, judge4, judge5 };
            for (int i = 0; i < 5; i++)
            {
                if (point[i] >= 0.0 && point[i] <= 10.0 && point[i] % 0.5 == 0.0)
                {
                }
                else
                {
                    return "invalid";
                }
            }
            return "Sucessful";
        }
        public void test(double judge1, double judge2, double judge3, double judge4, double judge5, double judge6)
        {
            double x;
            double y;
            double z;
            double q;
            double w;
            
            x = judge1;
            y = judge2;
            z = judge3;
            q = judge4;
            w = judge5;
            
            ////-----------------
        }


        private double _points;
        public double Points
        {
            get
            {
                return _points;
            }
            set
            {
                _points = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Points"));
            }
        }
        public int CompareTo(Point obj)
        {
            return (int)(this._points*10 - obj._points*10);
        }
        //-----------------  
        
    }

}
