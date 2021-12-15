using newsait.Domains;
using System.Collections.Generic;

namespace newsait.Repository
{
    public class SimptomStorage
    {
        private Dictionary<int, Simptom> Simptoms { get; } = new Dictionary<int, Simptom>();

        public void Create(Simptom simptom)
        {
            Simptoms.Add(simptom.SimptomId, simptom);
        }

        public Simptom Read(int SimptomId)
        {
            return Simptoms[SimptomId];
        }

        public Simptom Update(int SimptomId, Simptom newSimptom)
        {
            Simptoms[SimptomId] = newSimptom;
            return Simptoms[SimptomId];
        }

        public bool Delete(int SimptomId)
        {
            return Simptoms.Remove(SimptomId);
        }
    }
}