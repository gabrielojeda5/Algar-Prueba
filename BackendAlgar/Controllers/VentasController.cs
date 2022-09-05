using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendAlgar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    { // POST api/<Productos>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
