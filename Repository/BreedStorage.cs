using newsait.Domains;
using System.Collections.Generic;

namespace newsait.Repository
{
    public class BreedStorage
    {
        private Dictionary<int, Breed> Breeds { get; } = new Dictionary<int, Breed>();

        public void Create(Breed breed)
        {
            Breeds.Add(breed.BreedId,breed);
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