using newsait.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace newsait.Repository
{
    public class SortPetStorage
    {
        private Dictionary<int, SortPet> SortPets { get; } = new Dictionary<int, SortPet>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(SortPet sortPet)
        {
            SortPets.Add(sortPet.SortPetId, sortPet);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public SortPet Read(int SortPetId)
        {
            return SortPets[SortPetId];
        }

        public SortPet Update(int SortPetId, SortPet newSortPet)
        {
            SortPets[SortPetId] = newSortPet;
            return SortPets[SortPetId];
        }

        public bool Delete(int SortPetId)
        {
            return SortPets.Remove(SortPetId);
        }
    }
}