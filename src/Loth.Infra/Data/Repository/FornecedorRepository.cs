using Loth.Business.Models.Fornecedores;
using Loth.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loth.Infra.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(MeuDbContex context) : base(context) { }
        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(p => p.Endereco) //Join
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(p => p.Endereco)
                .Include(p => p.Produtos)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Fornecedor>> ObterTodos()
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(p => p.Endereco)
                .Include(p => p.Produtos).ToListAsync();
        }
        
    }
}
