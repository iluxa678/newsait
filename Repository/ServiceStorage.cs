using newsait.Domains;
using System.Collections.Generic;

namespace newsait.Repository
{
    public class ServiceStorage
    {
        private Dictionary<int, Service> Services { get; } = new Dictionary<int, Service>();

        public void Create(Service service)
        {
            Services.Add(service.ServiceId, service);
        }

        public Service Read(int ServiceId)
        {
            return Services[ServiceId];
        }

        public Service Update(int ServiceId, Service newService)
        {
            Services[ServiceId] = newService;
            return Services[ServiceId];
        }

        public bool Delete(int ServiceId)
        {
            return Services.Remove(ServiceId);
        }
    }
}