using newsait.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace newsait.Repository
{
    public class RecomendStorage
    {
        private Dictionary<int, Recomend> Recomends { get; } = new Dictionary<int, Recomend>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Recomend recomend)
        {
            Recomends.Add(recomend.RecomendId, recomend);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Recomend Read(int RecomendId)
        {
            return Recomends[RecomendId];
        }

        public Recomend Update(int RecomendId, Recomend newRecomend)
        {
            Recomends[RecomendId] = newRecomend;
            return Recomends[RecomendId];
        }

        public bool Delete(int RecomendId)
        {
            return Recomends.Remove(RecomendId);
        }
    }
}