using newsait.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace newsait.Repository
{
    public class GenderStorage
    {
        private Dictionary<int, Gender> Genders { get; } = new Dictionary<int, Gender>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Gender gender)
        {
            Genders.Add(gender.GenderId, gender);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Gender Read(int GenderId)
        {
            return Genders[GenderId];
        }

        public Gender Update(int GenderId, Gender newGender)
        {
            Genders[GenderId] = newGender;
            return Genders[GenderId];
        }

        public bool Delete(int GenderId)
        {
            return Genders.Remove(GenderId);
        }
    }
}