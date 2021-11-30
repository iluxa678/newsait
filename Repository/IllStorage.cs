using newsait.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace newsait.Repository
{
    public class IllStorage
    {
        private Dictionary<int, Ill> Ills { get; } = new Dictionary<int, Ill>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Ill ill)
        {
            Ills.Add(ill.IllId, ill);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Ill Read(int IllId)
        {
            return Ills[IllId];
        }

        public Ill Update(int IllId, Ill newIll)
        {
            Ills[IllId] = newIll;
            return Ills[IllId];
        }

        public bool Delete(int IllId)
        {
            return Ills.Remove(IllId);
        }
    }
}