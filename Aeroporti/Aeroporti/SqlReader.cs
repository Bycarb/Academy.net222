using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Aeroporti
{
    public class SqlReader
    {
        const string sqlConnectionString = "data source=ACADEMYNETPD07\\SQLEXPRESS;" +
                            "database = Aeroporti;" +
                            "Integrated Security = true;" +
                            "Connection timeout = 3600;";
        public static List<Volo> GetVoloFromDepCity(string depCity)
        {
            var list = new List<Volo>();
            using (SqlConnection conn = new SqlConnection(sqlConnectionString))
            {
                conn.Open();
                string query = "SELECT idVolo, GiornoSett, CittàPart, OraPart, CittàArr, OraArr, v.TipoAereo, NumPasseggeri, QtaMerci " +
                    "FROM Volo v JOIN Aereo a ON a.TipoAereo = v.TipoAereo " +
                    "WHERE CittàPart = @depCity ";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@depCity", depCity);//valida l'imput per evitare sql injection
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Volo volo = new Volo()
                        {
                            IdVolo = reader["idVolo"].ToString(),
                            GiornoSettimana = reader["GiornoSett"].ToString(),
                            CittàPartenza = reader["CittàPart"].ToString(),
                            CittàArrivo = reader["CittàArr"].ToString(),
                            OraPart = DateTime.Parse(reader["OraPart"].ToString()),
                            OraArr = DateTime.Parse(reader["OraArr"].ToString()),
                            TipoAereo = reader["TipoAereo"].ToString(),
                            NumPasseggeri = int.Parse(reader["NumPasseggeri"].ToString()),
                            QtaMerci = int.Parse(reader["QtaMerci"].ToString())
                        };
                        list.Add(volo);
                    }
                }
                
            }
            return list;
        }
        

    }
}
