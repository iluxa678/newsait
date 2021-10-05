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
        [HttpGet("Appeal")]
        public string Information(string str)
        {
            return str;
        }

        [HttpPost("Conclusion")]
        public string Makinп(string str)
        {
            return str;
        }

        [HttpPost("Make")]
        public string Evaluation(string str)
        {
            return str;
        }


    }
}
