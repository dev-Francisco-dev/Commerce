using Commerce.API.Repository;
using Microsoft.AspNetCore.Mvc;
using Commerce.Models.Domain;

namespace Commerce.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _repository;
        public ClienteController(IClienteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult get()
        {
            var clientes = _repository.GetAll();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public IActionResult get(int id)
        {
            var cliente = _repository.Get(id);
            if (cliente == null)
            {
                return NotFound("Não encontrado!");
            }
            return Ok(cliente);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] Cliente  cliente) 
        {
            _repository.Insert(cliente);
            return Ok(cliente);
        }
        [HttpPut("{id}")]

        public IActionResult UpDate([FromBody] Cliente cliente, int id)
        {
            _repository.Update(cliente);
            return Ok ();
        }

        [HttpDelete("{id}")]
        public IActionResult delete(int id) 
        {
            _repository.Delete(id);
            return Ok();
        }
    }
}