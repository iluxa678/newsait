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
       [HttpPut("Moderat")]
        public string Moderat(string str)
        {
            return str;//модерация
        }

        [HttpPut("Diag")]
        public string Diag(string str)
        {
            return str;//диагноз
        }

        [HttpPut("Ill")]
        public string Ill(string str)
        {
            return str;//заболевания
        }

        [HttpPut("Symptom")]
        public string Symptom(string str)
        {
            return str;//симптомы
        }

        [HttpPut("Recommend")]
        public string Recommend(string str)
        {
            return str;//рекоммендации
        }

        [HttpPut("Heal")]
        public string Heal(string str)
        {
            return str;//метод. леч.
        }

        [HttpPut("Service")]
        public string Service(string str)
        {
            return str;//услуги врач.
        }

        [HttpPut("Status")]
        public string Status(string str)
        {
            return str;//статус обращ.
        }

    }
}
