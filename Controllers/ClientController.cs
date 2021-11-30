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
    [Route("/clienti")]
    public class ClientController : ControllerBase
    {
        [HttpPut]
        public Client Create(Client client)
        {
            Storage.ClientStorage.Create(client);
            return client;
        }

        [HttpGet]
        public Client Read(int clientId)
        {
            return Storage.ClientStorage.Read(clientId);
        }

        [HttpPatch]
        public Client Update(int clientId, Client newClient)
        {
            return Storage.ClientStorage.Update(clientId, newClient);
        }

        [HttpDelete]
        public bool Delete(int clientId)
        {
            return Storage.ClientStorage.Delete(clientId);
        }

        [HttpPost("Reg")]
        public string Reg(string str)
        {
            return str;//регистрация//
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
