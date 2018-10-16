using System.Linq;
using System.Threading.Tasks;
using Todo.Domain.Entity;
using Todo.Domain.Enum;
using Todo.Domain.Interface.Repository;
using Todo.Infrastructure.Data;

namespace Todo.Infrastructure.Repository
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {

        public ClienteRepository(TodoDbContext dbContext): base(dbContext) { }

        public async void MudarStatus(int Id, StatusCliente statusCliente)
        {
            var item = this._dbContext.Set<Cliente>().Where(i => i.Id == Id).FirstOrDefault();
            
            item.Status = (int) statusCliente;
            this._dbContext.Set<Cliente>().Update(item);
            await this._dbContext.SaveChangesAsync();

        }
    }
}