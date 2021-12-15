using newsait.Domains;
using System.Collections.Generic;
namespace newsait.Repository
{
    public class SortPetStorage
    {
        private Dictionary<int, SortPet> SortPets { get; } = new Dictionary<int, SortPet>();

        public void Create(SortPet sortPet)
        {
            SortPets.Add(sortPet.SortPetId, sortPet);
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