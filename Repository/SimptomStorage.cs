using newsait.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace newsait.Repository
{
    public class SimptomStorage
    {
        private Dictionary<int, Simptom> Simptoms { get; } = new Dictionary<int, Simptom>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Simptom simptom)
        {
            Simptoms.Add(simptom.SimptomId, simptom);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Simptom Read(int SimptomId)
        {
            return Simptoms[SimptomId];
        }

        public Simptom Update(int SimptomId, Simptom newSimptom)
        {
            Simptoms[SimptomId] = newSimptom;
            return Simptoms[SimptomId];
        }

        public bool Delete(int SimptomId)
        {
            return Simptoms.Remove(SimptomId);
        }
    }
}