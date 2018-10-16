
using Microsoft.EntityFrameworkCore;
using Todo.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Todo.Domain.Interface.Entity;
using JetBrains.Annotations;

namespace Todo.Infrastructure.Data
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions options) : base(options) { 
        }

        public DbSet<Cliente> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Cliente>().ToTable("Clientes").HasKey(c => c.Id);
            base.OnModelCreating(builder);
        }
    }
}