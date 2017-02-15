using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace SimHop
{
    public class Judge
    {
    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Judge> judges { get; set; } = new List<Judge>();

        public Judge()
        {

        }

        //-----------------
        //public void rate(Point _jump, double _points)
        //{
        //    var rating = Tuple.Create(this, _points);
        //    _jump.judges.Add(rating);
        //}
        public void AddJudge(Judge j)
        {
            judges.Add(j);
        }

        public void removejudge(int index)
        {
            judges.RemoveAt(index);
        }

        //-----------------
    }
    //ctor


}
