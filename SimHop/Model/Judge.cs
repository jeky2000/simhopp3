using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;

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

        #region rate
        public void rate(Point _jump, double _points)
        {
            var rating = Tuple.Create(this, _points);
            _jump.judges.Add(rating);
        }
        #endregion
        #region add
        public void AddJudge(Judge j)
        {
            judges.Add(j);
        }
        #endregion
        #region remove
        public void removejudge(int index)
        {
            judges.RemoveAt(index);
        }
        #endregion

    }
    //ctor


}
