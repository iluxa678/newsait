using newsait.Domains;
using System.Collections.Generic;

namespace newsait.Repository
{
    public class DoctStorage
    {
        private Dictionary<int, Doct> Docts { get; } = new Dictionary<int, Doct>();

        public void Create(Doct doct)
        {
            Docts.Add(doct.DoctId, doct);
        }

        public Doct Read(int DoctId)
        {
            return Docts[DoctId];
        }

        public Doct Update(int DoctId, Doct newDoct)
        {
            Docts[DoctId] = newDoct;
            return Docts[DoctId];
        }

        public bool Delete(int DoctId)
        {
            return Docts.Remove(DoctId);
        }
    }
}