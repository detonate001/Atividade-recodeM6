using Travell.Data;
using Travell.Models;
using Travell.Repositorios.Interface;

namespace Travell.Repositorios
{
    public class ClienteRepositorio : IClienteRepositorio
    {

        private readonly TravelDbContext _dbContext;
        public ClienteRepositorio(TravelDbContext travelDbContext)
        {
            _dbContext = travelDbContext;
        }

        public Task<ClienteModel> Adicionar(ClienteModel cliente)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Apagar(int id)
        {
            throw new NotImplementedException();
        }
        public Task<ClienteModel> Atualizar(ClienteModel cliente, int id)
        {
            throw new NotImplementedException();
        }
        public Task<ClienteModel> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }
        public Task<List<ClienteModel>> BuscarTodosUsuarios()
        {
            throw new NotImplementedException();
        }

    }
}
