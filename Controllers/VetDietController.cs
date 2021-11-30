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
    [Route("/vetDiet")]
    public class VetDietController : ControllerBase
    {
        [HttpPut]
        public Doct Create(Doct doct)
        {
            Storage.DoctStorage.Create(doct);
            return doct;
        }

        [HttpGet]
        public Doct Read(int DoctId)
        {
            return Storage.DoctStorage.Read(DoctId);
        }

        [HttpPatch]
        public Doct Update(int DoctId, Doct newDoct)
        {
            return Storage.DoctStorage.Update(DoctId, newDoct);
        }

        [HttpDelete]
        public bool Delete(int DoctId)
        {
            return Storage.DoctStorage.Delete(DoctId);
        }
        [HttpPost("AddIllDiet")]
        public string AddIllDiet(string str)
        {
            return str;//добав. заболев. диет.
        }

        [HttpPost("SelectServDiet")]
        public string SelectServDiet(string str)
        {
            return str;//выбор услуги диет
        }

    }
}
