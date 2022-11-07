using Microsoft.EntityFrameworkCore;
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

        public async Task<ClienteModel> Adicionar(ClienteModel cliente)
        {
            await _dbContext.Clientes.AddAsync(cliente);
            await _dbContext.SaveChangesAsync();

            return cliente;
        }

        public async Task<bool> Apagar(int id)
        {
            ClienteModel clientePorId = await BuscarPorId(id);
            if (clientePorId == null)
            {
                throw new Exception($"Cliente para o ID: {id} não foi encontrado no banco de dados.");
            }

            _dbContext.Clientes.Remove(clientePorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }


        public async Task<ClienteModel> Atualizar(ClienteModel cliente, int id)
        {
            ClienteModel clientePorId = await BuscarPorId(id);
            if(clientePorId == null)
            {
                throw new Exception($"Cliente para o ID: {id} não foi encontrado no banco de dados.");
            }

            clientePorId.Email = cliente.Email;
            clientePorId.Cpf = cliente.Cpf;
            clientePorId.Data_nascimento = cliente.Data_nascimento;

            _dbContext.Clientes.Update(clientePorId);
            await _dbContext.SaveChangesAsync();

            return clientePorId;
        }

        public async Task<ClienteModel> BuscarPorId(int id)
        {
            return await _dbContext.Clientes.FirstOrDefaultAsync(x => x.Id == id);();
        }

        public async Task<List<ClienteModel>> BuscarTodosClientes()
        {
            return await _dbContext.Clientes.ToListAsync();
        }

    }
}
