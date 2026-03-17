using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory Card.Data
{
    internal class Player
    {
        public static object Instance { get; internal set; }

        public static int LoginOrCreate(string PlayerName)
        {
            using (var con = Database.GetConnection())
            using (var cmd = new SqlCommand("sp_LoginOrCreate", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PlayerName", PlayerName);

                var outParam = new SqlParameter("@PlayerID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outParam);

                con.Open();
                cmd.ExecuteNonQuery();

                return (int)outParam.Value;
            }
        }
    }
}
