using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory Card.Data
{
    internal class SavedGame
    {
        public static void SaveGame(int PlayerID, string Difficulty,
            string Theme, string CardMatrix, int TimeTaken,
            int Attempts, int Matches, int Score, int HintsUsed)
        {
            using (var con = Database.GetConnection())
            using (var cmd = new SqlCommand("sp_SaveGame", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PlayerID", PlayerID);
                cmd.Parameters.AddWithValue("@Difficulty", Difficulty);
                cmd.Parameters.AddWithValue("@Theme", Theme);
                cmd.Parameters.AddWithValue("@CardMatrix", CardMatrix);
                cmd.Parameters.AddWithValue("@TimeTaken", TimeTaken);
                cmd.Parameters.AddWithValue("@Attempts", Attempts);
                cmd.Parameters.AddWithValue("@Matches", Matches);
                cmd.Parameters.AddWithValue("@Score", Score);
                cmd.Parameters.AddWithValue("@HintsUsed", HintsUsed);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static DataRow LoadGame(int PlayerID)
        {
            using (var con = Database.GetConnection())
            using (var cmd = new SqlCommand("sp_LoadGame", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PlayerID", PlayerID);

                var dt = new DataTable();
                con.Open();
                dt.Load(cmd.ExecuteReader());

                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
            }
        }

        public static void DeleteSavedGame(int playerID)
        {
            using (var con = Database.GetConnection())
            using (var cmd = new SqlCommand("sp_DeleteSavedGame", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PlayerID", playerID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
