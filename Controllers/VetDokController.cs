using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using newsait.Domains;
using newsait.Repository;

namespace newsait.Controllers
{
    [ApiController]
    [Route("/vetDok")]
    public class VetDokController : ControllerBase
    {
        [HttpPatch("Consideration")]
        public Appeal Update(int AppealId, Appeal newAppeal)
        {
            return Storage.AppealStorage.Update(AppealId, newAppeal);
        }

        [HttpGet("ChoiceStatus")]
        public Status Read2(int StatusId)
        {
            return Storage.StatusStorage.Read(StatusId);
        }

        [HttpPut("CreateConclusion")]
        public Conclusion Create(Conclusion conclusion)
        {
            Storage.ConclusionStorage.Create(conclusion);
            return conclusion;
        }

        [HttpGet("ChoiceService")]
        public Service Read(int ServiceId)
        {
            return Storage.ServiceStorage.Read(ServiceId);
        }

        [HttpGet("ChoiceIll")]
        public Ill Read1(int IllId)
        {
            return Storage.IllStorage.Read(IllId);
        }

        [HttpPatch("CompleteConclusion")]
        public Conclusion Update2(int ConclusionId, Conclusion newConclusion)
        {
            return Storage.ConclusionStorage.Update(ConclusionId, newConclusion);
        }
    }
}
