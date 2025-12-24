using API.Models;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ClientsController(ApplicationDbContext context)
        {
            this.context = context;
        }


        //watch minute 12 if need to select id in url i didnt add that method yet

        [HttpGet]
        public List<Client> GetClients()
        {
            return context.Clients.ToList();
        }

        [HttpPost]
        public IActionResult CreateClient(ClientDto clientDto)
        {
            var Client = new Client
            {

                Name = clientDto.Name,
                Department = clientDto.Department ?? "",
                Phone = clientDto.Phone ?? "",
            };


            context.Clients.Add(Client);

            context.SaveChanges();

            return Ok(Client);
        }

        [HttpPut("{id}")]
        public IActionResult EditClient(int id, ClientDto clientDto)
        {
            var client = context.Clients.Find(id);

            if (client == null)
            {
                return NotFound();
            }

            client.Name = clientDto.Name;
            client.Department = clientDto.Department ?? "";
            client.Phone = clientDto.Phone ?? "";

            
            context.SaveChanges();

            return Ok(client);
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteClient(int id)
        {
            var client = context.Clients.Find(id);
            if (client == null)
            {
                return NotFound();
            }

            context.Clients.Remove(client);
            context.SaveChanges();

            return Ok();
        }

    }
}
