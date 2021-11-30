using newsait.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace newsait.Repository
{
    public class PositionStorage
    {
        private Dictionary<int, Position> Positions { get; } = new Dictionary<int, Position>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Position position)
        {
            Positions.Add(position.PositionId, position);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Position Read(int PositionId)
        {
            return Positions[PositionId];
        }

        public Position Update(int PositionId, Position newPosition)
        {
            Positions[PositionId] = newPosition;
            return Positions[PositionId];
        }

        public bool Delete(int PositionId)
        {
            return Positions.Remove(PositionId);
        }
    }
}