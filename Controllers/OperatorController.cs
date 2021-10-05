using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Operator.Controllers
{
    [ApiController]
    [Route("/operator")]
    public class OperatorController : ControllerBase
    {
        [HttpGet("Appeal")]
        public string Information(string str)
        {
            return str;
        }

        [HttpPost("Choice")]
        public string Makinп(string str)
        {
            return str;
        }

        [HttpGet("Conclusion")]
        public string Evaluation(string str)
        {
            return str;
        }

        [HttpPost("Notification")]
        public string Price(string str)
        {
            return str;
        }

    }
}
