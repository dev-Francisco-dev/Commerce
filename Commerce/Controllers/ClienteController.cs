using Microsoft.AspNetCore.Mvc;

namespace Commerce.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {        
        List<string> List = new List<string>();
        [HttpGet]
        public IActionResult get()
        {
            return Ok(List);
        }
        [HttpPost]
        public IActionResult post(string cliente) 
        {
            List.Add(cliente);
            return Ok(cliente);
        }
        [HttpDelete]
        public IActionResult delete(string cliente) 
        { 
            List.Remove(cliente);
            return Ok(cliente);
        }
    }
}