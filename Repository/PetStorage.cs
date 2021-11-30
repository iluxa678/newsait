using newsait.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace newsait.Repository
{
    public class PetStorage
    {
        private Dictionary<int, Pet> Pets { get; } = new Dictionary<int, Pet>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Pet pet)
        {
            Pets.Add(pet.PetId, pet);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Pet Read(int PetId)
        {
            return Pets[PetId];
        }

        public Pet Update(int PetId, Pet newPet)
        {
            Pets[PetId] = newPet;
            return Pets[PetId];
        }

        public bool Delete(int PetId)
        {
            return Pets.Remove(PetId);
        }
    }
}