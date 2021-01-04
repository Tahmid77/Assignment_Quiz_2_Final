using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Quiz_2_Final
{
    public class Database
    {
        public Books Books { get; set; }
        public Database()
        {
            SqlConnection conn = new SqlConnection(@"Server=DESKTOP-06CPA49\SQLEXPRESS;Integrated Security=true;Database=Library_DB");
            Books = new Books(conn);
        }
    }
}
