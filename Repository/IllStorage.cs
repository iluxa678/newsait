using newsait.Domains;
using System.Collections.Generic;

namespace newsait.Repository
{
    public class IllStorage
    {
        private Dictionary<int, Ill> Ills { get; } = new Dictionary<int, Ill>();

        public void Create(Ill ill)
        {
            Ills.Add(ill.IllId, ill);
        }

        public Ill Read(int IllId)
        {
            return Ills[IllId];
        }

        public Ill Update(int IllId, Ill newIll)
        {
            Ills[IllId] = newIll;
            return Ills[IllId];
        }

        public bool Delete(int IllId)
        {
            return Ills.Remove(IllId);
        }
    }
}