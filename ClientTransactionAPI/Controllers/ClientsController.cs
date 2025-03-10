using ClientTransactionAPI.DTOs.Response;
using ClientTransactionAPI.Models;
using ClientTransactionAPI.Repositories.Client;
using Microsoft.AspNetCore.Mvc;

namespace ClientTransactionAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientsController(IClientRepository repository) : Controller
{
    [HttpGet("{id:int}")]
    public async Task<ActionResult<ClientResponse?>> Get(int id)
    {
        var client = await repository.Get(client => client.Id == id);
        if (client == null) return NotFound();
        return Ok(client);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Client>?>> GetAll()
    {
        var clients = await repository.GetAll();
        if (clients == null) return NotFound();
        return Ok(clients);
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<Client?>> Delete(int id)
    {
        var clientToDelete = await repository.Get(client => client.Id == id);
        if (clientToDelete == null) return NotFound();
        await repository.Delete(clientToDelete);
        return Ok(clientToDelete);
    }

    [HttpPost]
    public async Task<ActionResult<Client?>> Post([FromBody] Client? client)
    {
        if (client == null) return BadRequest();
        client = await repository.Create(client);
        return CreatedAtAction(nameof(Post), new { id = client.Id }, client);
    }
}