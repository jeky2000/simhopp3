using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SimHop
{
    [Serializable()]
    public class Tpl
    {
        public Judge Judge { get; set; }
        public double Point { get; set; }
    }

    [Serializable]
    public class Point : INotifyPropertyChanged, IComparable<Point>
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
      
        public Boolean Valid()
        {
            if (Points > 0.0 && Points <= 10.0 && Points % 0.5 == 0.0)
            { 
                return true;
            }
            else
            {
                return false;
            }
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
