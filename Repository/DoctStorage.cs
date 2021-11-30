using newsait.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace newsait.Repository
{
    public class DoctStorage
    {
        private Dictionary<int, Doct> Docts { get; } = new Dictionary<int, Doct>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Doct doct)
        {
            Docts.Add(doct.DoctId, doct);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Doct Read(int DoctId)
        {
            return Docts[DoctId];
        }

        public Doct Update(int DoctId, Doct newDoct)
        {
            Docts[DoctId] = newDoct;
            return Docts[DoctId];
        }

        public bool Delete(int DoctId)
        {
            return Docts.Remove(DoctId);
        }
    }
}