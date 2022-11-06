using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travell.Models;

namespace Travell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<ClienteModel>> BuscarTodosClientes()
        {
            return Ok();
        }
    }
}
