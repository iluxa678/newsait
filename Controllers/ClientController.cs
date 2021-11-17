using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Client.Controllers
{
    [ApiController]
    [Route("/client")]
    public class ClientController : ControllerBase
    {
        [HttpPost("Reg")]
        public string Reg(string str)
        {
            return str;//регистрация
        }

        [HttpGet("Avtoriz")]
        public string Avtoriz(string str)
        {
            return str;//авторизация
        }

        [HttpPost("AddPet")]
        public string AddPet(string str)
        {
            return str;//добавление животного
        }

        [HttpGet("ViewAppeal")]
        public string ViewAppeal(string str)
        {
            return str;//просмотр обращ.
        }

        [HttpPost("MakeUpApp")]
        public string MakeUpApp(string str)
        {
            return str;//составл. обращ.
        }

        [HttpGet("ViewConclusion")]
        public string ViewConclusion(string str)
        {
            return str;//просмотр заключ.
        }

    }
}
