using newsait.Domains;
using System.Collections.Generic;

namespace newsait.Repository
{
    public class MetodStorage
    {
        private Dictionary<int, Metod> Metods { get; } = new Dictionary<int, Metod>();

        public void Create(Metod metod)
        {
            Metods.Add(metod.MetodId, metod);
        }

        public Metod Read(int MetodId)
        {
            return Metods[MetodId];
        }

        public Metod Update(int MetodId, Metod newMetod)
        {
            Metods[MetodId] = newMetod;
            return Metods[MetodId];
        }

        public bool Delete(int MetodId)
        {
            return Metods.Remove(MetodId);
        }
    }
}