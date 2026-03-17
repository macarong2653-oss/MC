using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory Card.Data
{
    internal class Database
    {
        private static readonly string ConnectionString =
            @"Server=haidag09;Database=Memory Card;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (var con = GetConnection())
                {
                    con.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        internal static int LoginOrCreate(string name)
        {
            throw new NotImplementedException();
        }
    }
}
