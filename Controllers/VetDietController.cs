using System;
using Microsoft.AspNetCore.Mvc;
using newsait.Domains;
using newsait.Repository;

namespace newsait.Controllers
{
    [ApiController]
    [Route("/vetDiet")]
    public class VetDietController : ControllerBase
    {
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
