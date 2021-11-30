using newsait.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace newsait.Repository
{
    public class DiagStorage
    {
        private Dictionary<int, Diag> Diags { get; } = new Dictionary<int, Diag>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Diag diag)
        {
            Diags.Add(diag.DiagId, diag);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Diag Read(int DiagId)
        {
            return Diags[DiagId];
        }

        public Diag Update(int DiagId, Diag newDiag)
        {
            Diags[DiagId] = newDiag;
            return Diags[DiagId];
        }

        public bool Delete(int DiagId)
        {
            return Diags.Remove(DiagId);
        }
    }
}