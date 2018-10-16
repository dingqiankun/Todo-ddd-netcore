using System.Collections.Generic;
using System.Threading.Tasks;
using Todo.Domain.Entity;
using Todo.Domain.Interface.Repository;
using Todo.Domain.Interface.Service;

namespace Todo.Domain.Service
{
    public class ClienteService : IClienteService
    {
        IClienteRepository _clienteRepository { get; set; }
        
        public ClienteService(IClienteRepository repository){
            _clienteRepository = repository;
        }

        public IEnumerable<Cliente> ListarTodos()
        {
            return _clienteRepository.GetAll();
        }

        public async Task<Cliente> ObterPorId(int Id)
        {
            return  await _clienteRepository.GetById( Id );
        }

        public int Salvar(Cliente cliente)
        {
            return 0;
        }
    }
}