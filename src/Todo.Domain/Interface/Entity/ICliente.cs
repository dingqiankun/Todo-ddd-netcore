using System;
using Todo.Domain.Interface.Base;

namespace Todo.Domain.Interface.Entity
{
    public interface ICliente : IEntity
    {
        string Nome { get; set; }
        string Sobrenome { get; set; }
        string CPF { get; set; }
        int Genero { get; set; }
        DateTime DataNascimento  { get; set; }
        int Status { get; set; }
    }
}