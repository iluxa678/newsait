using newsait.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace newsait.Repository
{
    public class OperatorStorage
    {
        private Dictionary<int, Operator> Operators { get; } = new Dictionary<int, Operator>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Operator _operator)
        {
            Operators.Add(_operator.OperatorId, _operator);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Operator Read(int OperatorId)
        {
            return Operators[OperatorId];
        }

        public Operator Update(int OperatorId, Operator newOperator)
        {
            Operators[OperatorId] = newOperator;
            return Operators[OperatorId];
        }

        public bool Delete(int OperatorId)
        {
            return Operators.Remove(OperatorId);
        }
    }
}