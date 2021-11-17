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
