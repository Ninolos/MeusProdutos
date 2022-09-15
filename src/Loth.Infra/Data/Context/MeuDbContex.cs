using Loth.Business.Models.Fornecedores;
using Loth.Business.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loth.Infra.Data.Context
{
    public class MeuDbContex : DbContext
    {
        public MeuDbContex() : base("DefaultConnection")
        {}

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
