using System.Collections.Generic;
using System.Threading.Tasks;
using Todo.Domain.Entity;
using Todo.Domain.Interface.Base;
using Todo.Domain.Interface.Repository;

namespace Todo.Domain.Interface.Service
{
    public interface IClienteService : IBaseService<Cliente>
    {

        int Salvar(Cliente cliente);
        IEnumerable<Cliente> ListarTodos();
        Task<Cliente> ObterPorId(int Id);

    }
}