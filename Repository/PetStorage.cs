using newsait.Domains;
using System.Collections.Generic;

namespace newsait.Repository
{
    public class PetStorage
    {
        private Dictionary<int, Pet> Pets { get; } = new Dictionary<int, Pet>();

        public void Create(Pet pet)
        {
            Pets.Add(pet.PetId, pet);
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