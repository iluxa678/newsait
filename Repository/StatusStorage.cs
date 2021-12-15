using newsait.Domains;
using System.Collections.Generic;

namespace newsait.Repository
{
    public class StatusStorage
    {
        private Dictionary<int, Status> Statuss { get; } = new Dictionary<int, Status>();

        public void Create(Status status)
        {
            Statuss.Add(status.StatusId, status);
        }

        public Status Read(int StatusId)
        {
            return Statuss[StatusId];
        }

        public Status Update(int StatusId, Status newStatus)
        {
            Statuss[StatusId] = newStatus;
            return Statuss[StatusId];
        }

        public bool Delete(int StatusId)
        {
            return Statuss.Remove(StatusId);
        }
    }
}