using Microsoft.AspNetCore.Mvc;
using newsait.Domains;
using newsait.Repository;

namespace newsait.Controllers
{
    [ApiController]
    [Route("/clienti")]
    public class ClientController : ControllerBase
    {
        [HttpPut("Registration")]
        public Client Create(Client client)
        {
            Storage.ClientStorage.Create(client);
            return client;
        }

        [HttpGet("Avtorization")]
        public Client Read(int clientId)
        {
            return Storage.ClientStorage.Read(clientId);
        }

        [HttpPut("AddPet")]
        public Pet Create(Pet pet)
        {
            Storage.PetStorage.Create(pet);
            return pet;
        }

        [HttpGet("ChoisePet")]
        public Pet Read3(int PetId)
        {
            return Storage.PetStorage.Read(PetId);
        }

        [HttpGet("ViewAppeal")]
        public Appeal Read1(int appealId)
        {
            return Storage.AppealStorage.Read(appealId);
        }

        [HttpGet("ViewConclusion")]
        public Conclusion Read2(int conclusionId)
        {
            return Storage.ConclusionStorage.Read(conclusionId);
        }

        [HttpPut("CreatedAppeal")]
        public Appeal Create1(Appeal appeal)
        {
            Storage.AppealStorage.Create(appeal);
            return appeal;
        }

    }
}
