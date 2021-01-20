using System.Data.SqlClient;
using DBToolBox;

namespace DBHelper
{
    class Program
    {
        static void Main()
        {
            string connectionString = "Data Source=WMS262;Initial Catalog=TestDB;Integrated Security=true";

            SqlConnection cnn = new SqlConnection(connectionString);

        }
    }
}