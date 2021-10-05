using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace VetDiet.Controllers
{
    [ApiController]
    [Route("/vetDiet")]
    public class VetDietController : ControllerBase
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
