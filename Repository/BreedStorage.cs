using newsait.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace newsait.Repository
{
    public class BreedStorage
    {
        private Dictionary<int, Breed> Breeds { get; } = new Dictionary<int, Breed>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Breed breed)
        {
            Breeds.Add(breed.BreedId,breed);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Breed Read(int BreedId)
        {
            return Breeds[BreedId];
        }

        public Breed Update(int BreedId, Breed newBreed)
        {
            Breeds[BreedId] = newBreed;
            return Breeds[BreedId];
        }

        public bool Delete(int BreedId)
        {
            return Breeds.Remove(BreedId);
        }
    }
}