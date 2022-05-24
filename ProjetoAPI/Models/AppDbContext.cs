using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoAPI.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DbContext"){ }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}