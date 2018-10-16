namespace Todo.Domain.Interface.Base
{
    public interface IBaseService <T>  where T : class, IEntity
    {
    }
}