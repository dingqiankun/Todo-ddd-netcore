using System;
using Todo.Domain.Interface.Entity;

namespace Todo.Domain.Entity
{
    public class Cliente : ICliente
    {
        public int Id { get ; set ; }
        public string Nome { get ; set ; }
        public string Sobrenome { get ; set ; }
        public string CPF { get ; set ; }
        public int Genero { get ; set ; }
        public DateTime DataNascimento { get ; set ; }
        public int Status { get ; set ; }
    }
}