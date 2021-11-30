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

        [HttpPut("Review")]
        public string Review(string str)
        {
            return str;//рассмотрение
        }

        [HttpPost("MakeUpConcl")]
        public string MakeUpConcl(string str)
        {
            return str;//сост. заключ.
        }

        [HttpPost("SelectServDok")]
        public string SelectServDok(string str)
        {
            return str;//выбор услуги док.
        }

        [HttpPost("AddIllDok")]
        public string AddIllDok(string str)
        {
            return str;//добав. заболев. док.
        }
    }
}
