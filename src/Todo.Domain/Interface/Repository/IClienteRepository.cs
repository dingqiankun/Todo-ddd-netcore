using Todo.Domain.Entity;
using Todo.Domain.Enum;
using Todo.Domain.Interface.Base;

namespace Todo.Domain.Interface.Repository
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
         void MudarStatus(int Id, StatusCliente statusCliente);
    }
}