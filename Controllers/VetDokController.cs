using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace VetDok.Controllers
{
    [ApiController]
    [Route("/vetDok")]
    public class VetDokController : ControllerBase
    {
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
