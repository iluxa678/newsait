using newsait.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace newsait.Repository
{
    public class AppealStorage
    {
        private Dictionary<int, Appeal> Appeals { get; } = new Dictionary<int, Appeal>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Appeal appeal)
        {
            Appeals.Add(appeal.AppealId, appeal);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Appeal Read(int appealId)
        {
            return Appeals[appealId];
        }

        public Appeal Update(int AppealId, Appeal newAppeal)
        {
            Appeals[AppealId] = newAppeal;
            return Appeals[AppealId];
        }

        public bool Delete(int AppealId)
        {
            return Appeals.Remove(AppealId);
        }
    }
}