using newsait.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace newsait.Repository
{
    public class StatusStorage
    {
        private Dictionary<int, Status> Statuss { get; } = new Dictionary<int, Status>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Status status)
        {
            Statuss.Add(status.StatusId, status);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Status Read(int StatusId)
        {
            return Statuss[StatusId];
        }

        public Status Update(int StatusId, Status newStatus)
        {
            Statuss[StatusId] = newStatus;
            return Statuss[StatusId];
        }

        public bool Delete(int StatusId)
        {
            return Statuss.Remove(StatusId);
        }
    }
}