using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using Travell.Models;
using Travell.Repositorios;
using Travell.Repositorios.Interface;

namespace Travell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly IClienteRepositorio _clienteRepositorio;
        public ClienteController(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<ClienteModel>>> BuscarTodosClientes()
        {
            List<ClienteModel> clientes = await _clienteRepositorio.BuscarTodosClientes();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<ClienteModel>>> BuscarPorId(int id)
        {
            List<ClienteModel> cliente = await _clienteRepositorio.BuscarPorId();
            return Ok(cliente);
        }

        [HttpPost]
        public async Task<ActionResult<ClienteModel>> Cadastrar([FromBody]) ClienteModel cliente)
            {
               ClienteModel cliente = await _clienteRepositorio.Adicionar(clienteModel);

            return Ok(cliente);

            }

    [HttpPut("{id}")]
    public async Task<ActionResult<ClienteModel>> Atualizar([FromBody]) ClienteModel cliente, int id)
            {
                clienteModel.Id = id
               ClienteModel cliente = await _clienteRepositorio.Atualizar(clienteModel);

            return Ok(cliente);

}

[HttpDelete("{id}")]

public async Task<ActionResult<ClienteModel>> Apagar(int id)
          {
               bool apagado = await _clienteRepositorio.Apagar(id);

    return Ok(cliente);


}
}
}