using newsait.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace newsait.Repository
{
    public class MetodStorage
    {
        private Dictionary<int, Metod> Metods { get; } = new Dictionary<int, Metod>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Metod metod)
        {
            Metods.Add(metod.MetodId, metod);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Metod Read(int MetodId)
        {
            return Metods[MetodId];
        }

        public Metod Update(int MetodId, Metod newMetod)
        {
            Metods[MetodId] = newMetod;
            return Metods[MetodId];
        }

        public bool Delete(int MetodId)
        {
            return Metods.Remove(MetodId);
        }
    }
}