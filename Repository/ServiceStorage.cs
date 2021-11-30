using newsait.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace newsait.Repository
{
    public class ServiceStorage
    {
        private Dictionary<int, Service> Services { get; } = new Dictionary<int, Service>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Service service)
        {
            Services.Add(service.ServiceId, service);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Service Read(int ServiceId)
        {
            return Services[ServiceId];
        }

        public Service Update(int ServiceId, Service newService)
        {
            Services[ServiceId] = newService;
            return Services[ServiceId];
        }

        public bool Delete(int ServiceId)
        {
            return Services.Remove(ServiceId);
        }
    }
}