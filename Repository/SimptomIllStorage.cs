using newsait.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace newsait.Repository
{
    public class SimptomIllStorage
    {
        private Dictionary<int, SimptomIll> SimptomIlls { get; } = new Dictionary<int, SimptomIll>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(SimptomIll simptomIll)
        {
            SimptomIlls.Add(simptomIll.SimptomIllId, simptomIll);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public SimptomIll Read(int SimptomIllId)
        {
            return SimptomIlls[SimptomIllId];
        }

        public SimptomIll Update(int SimptomIllId, SimptomIll newSimptomIll)
        {
            SimptomIlls[SimptomIllId] = newSimptomIll;
            return SimptomIlls[SimptomIllId];
        }

        public bool Delete(int SimptomIllId)
        {
            return SimptomIlls.Remove(SimptomIllId);
        }
    }
}