using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory Card.Data
{
    internal class GameResult
    {
        public static void SaveResult(int PlayerID, string Difficulty,
           string GridSize, string Theme, int Score,
           int TimeTaken, int Attempts, int HintsUsed, bool IsWin)
        {
            using (var con = Database.GetConnection())
            using (var cmd = new SqlCommand("sp_SaveResult", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PlayerID", PlayerID);
                cmd.Parameters.AddWithValue("@Difficulty", Difficulty);
                cmd.Parameters.AddWithValue("@GridSize", GridSize);
                cmd.Parameters.AddWithValue("@Theme", Theme);
                cmd.Parameters.AddWithValue("@Score", Score);
                cmd.Parameters.AddWithValue("@TimeTaken", TimeTaken);
                cmd.Parameters.AddWithValue("@Attempts", Attempts);
                cmd.Parameters.AddWithValue("@HintsUsed", HintsUsed);
                cmd.Parameters.AddWithValue("@IsWin", IsWin ? 1 : 0);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetLeaderboard(string Difficulty)
        {
            using (var con = Database.GetConnection())
            using (var cmd = new SqlCommand("sp_GetLeaderboard", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Difficulty", Difficulty);

                var dt = new DataTable();
                con.Open();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
        }
    }
}
