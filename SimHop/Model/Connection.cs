using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace SimHop
{
    public class Connection
    {
        //10.101.2.16
        public static void update()
        {

        }

       //ActiveConection
        public static SqlConnection ActiveCon()
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\abdullah\Desktop\simhop2\MedNyaInterface\SimHop\Simhoppdb.mdf;Integrated Security = True");

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }


    }
}
