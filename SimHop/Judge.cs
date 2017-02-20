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
        //sdfghj
        //ölskdjfölaksdföj
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Judge> judges { get; set; } = new List<Judge>();
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Son Nguyen\Desktop\Git1\SimHop\Simhoppdb.mdf;Integrated Security = True");
        SqlCommand add = new SqlCommand();

        public Judge()
        {

        }

     
        public void rate(Point _jump, double _points)
        {
            var rating = Tuple.Create(this, _points);
            _jump.judges.Add(rating);
        }
        public void AddJudge(Judge j)
        {
            judges.Add(j);
        }

        public void removejudge(int index)
        {
            judges.RemoveAt(index);
        }

  
    }
    //ctor


}
