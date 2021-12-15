using newsait.Domains;
using System.Collections.Generic;

namespace newsait.Repository
{
    public class SimptomIllStorage
    {
        private Dictionary<int, SimptomIll> SimptomIlls { get; } = new Dictionary<int, SimptomIll>();

        public void Create(SimptomIll simptomIll)
        {
            SimptomIlls.Add(simptomIll.SimptomIllId, simptomIll);
        }

        public SimptomIll Read(int SimptomIllId)
        {
            return SimptomIlls[SimptomIllId];
        }

        public SimptomIll Update(int SimptomIllId, SimptomIll newSimptomIll)
        {
            SimptomIlls[SimptomIllId] = newSimptomIll;
            return SimptomIlls[SimptomIllId];
        }

        public bool Delete(int SimptomIllId)
        {
            return SimptomIlls.Remove(SimptomIllId);
        }
    }
}