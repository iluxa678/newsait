using newsait.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace newsait.Repository
{
    public class ConclusionStorage
    {
        private Dictionary<int, Conclusion> Conclusions { get; } = new Dictionary<int, Conclusion>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Conclusion conclusion)
        {
            Conclusions.Add(conclusion.ConclusionId, conclusion);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Conclusion Read(int ConclusionId)
        {
            return Conclusions[ConclusionId];
        }

        public Conclusion Update(int ConclusionId, Conclusion newConclusion)
        {
            Conclusions[ConclusionId] = newConclusion;
            return Conclusions[ConclusionId];
        }

        public bool Delete(int ConclusionId)
        {
            return Conclusions.Remove(ConclusionId);
        }
    }
}