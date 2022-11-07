using Travell.Models;

namespace Travell.Repositorios.Interface
{
    public class IClienteRepositorio
    {
        Task<List<ClienteModel>> BuscarTodosClientes();
        Task<ClienteModel> BuscarPorId(int id);
        Task<ClienteModel> Adicionar(ClienteModel cliente);

        Task<ClienteModel> Atualizar(ClienteModel cliente, int id)

        task<bool> Apagar(int id);

    }
}
