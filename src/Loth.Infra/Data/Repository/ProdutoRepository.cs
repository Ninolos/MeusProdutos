using Loth.Business.Models.Fornecedores;
using Loth.Business.Models.Produtos;
using Loth.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loth.Infra.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutorepository
    {
        public ProdutoRepository(MeuDbContex context) : base(context){ }
        public async Task<Produto> ObterProdutoFornecedor(Guid id)
        {
            return await Db.Produtos.AsNoTracking()
                .Include(p => p.Fornecedor)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Produto>> ObterProdutosFornecedores()
        {
            return await Db.Produtos.AsNoTracking()
               .Include(p => p.Fornecedor)
               .OrderBy(p => p.Nome)
               .ToListAsync();
        }

        public async Task<IEnumerable<Produto>> ObterProdutosPorfornecedor(Guid fornecedorId)
        {
            return await Buscar(p => p.FornecedorId == fornecedorId);
        }
    }
        
}
