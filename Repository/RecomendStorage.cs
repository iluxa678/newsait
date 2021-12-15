using newsait.Domains;
using System.Collections.Generic;

namespace newsait.Repository
{
    public class RecomendStorage
    {
        private Dictionary<int, Recomend> Recomends { get; } = new Dictionary<int, Recomend>();

        public void Create(Recomend recomend)
        {
            Recomends.Add(recomend.RecomendId, recomend);
        }

        public Recomend Read(int RecomendId)
        {
            return Recomends[RecomendId];
        }

        public Recomend Update(int RecomendId, Recomend newRecomend)
        {
            Recomends[RecomendId] = newRecomend;
            return Recomends[RecomendId];
        }

        public bool Delete(int RecomendId)
        {
            return Recomends.Remove(RecomendId);
        }
    }
}