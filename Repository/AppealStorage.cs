using newsait.Domains;
using System.Collections.Generic;

namespace newsait.Repository
{
    public class AppealStorage
    {
        private Dictionary<int, Appeal> Appeals { get; } = new Dictionary<int, Appeal>();

        public void Create(Appeal appeal)
        {
            Appeals.Add(appeal.AppealId, appeal);
        }

        public Appeal Read(int AppealId)
        {
            return Appeals[AppealId];
        }

        public Appeal Update(int AppealId, Appeal newAppeal)
        {
            Appeals[AppealId] = newAppeal;
            return Appeals[AppealId];
        }

        public bool Delete(int AppealId)
        {
            return Appeals.Remove(AppealId);
        }
    }
}