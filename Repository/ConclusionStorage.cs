using newsait.Domains;
using System.Collections.Generic;

namespace newsait.Repository
{
    public class ConclusionStorage
    {
        private Dictionary<int, Conclusion> Conclusions { get; } = new Dictionary<int, Conclusion>();

        public void Create(Conclusion conclusion)
        {
            Conclusions.Add(conclusion.ConclusionId, conclusion);
        }

        public Conclusion Read(int ConclusionId)
        {
            return Conclusions[ConclusionId];
        }

        public Conclusion Update(int ConclusionId, Conclusion newConclusion)
        {
            Conclusions[ConclusionId] = newConclusion;
            return Conclusions[ConclusionId];
        }

        public bool Delete(int ConclusionId)
        {
            return Conclusions.Remove(ConclusionId);
        }
    }
}