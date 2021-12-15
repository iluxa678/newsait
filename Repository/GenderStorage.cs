using newsait.Domains;
using System.Collections.Generic;

namespace newsait.Repository
{
    public class GenderStorage
    {
        private Dictionary<int, Gender> Genders { get; } = new Dictionary<int, Gender>();

        public void Create(Gender gender)
        {
            Genders.Add(gender.GenderId, gender);
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