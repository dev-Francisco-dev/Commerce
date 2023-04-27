using Commerce.API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Commerce.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _repository;
        public ClienteController(IClienteRepository repository)
        {
            _repository= repository;
        }
        
        [HttpGet]
        public IActionResult get()
        {
            var clientes = _repository.GetAll();
            return Ok(clientes);
        }
        [HttpPost]
        public IActionResult Insert(string cliente) 
        {
            
            return Ok();
        }
        [HttpDelete]
        public IActionResult delete(string cliente) 
        { 
            
            return Ok();
        }
    }
}