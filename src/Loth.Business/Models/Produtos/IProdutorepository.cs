using Loth.Business.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loth.Business.Models.Produtos
{
    public interface IProdutorepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorfornecedor(Guid fornecedorId);
        Task<IEnumerable<Produto>> ObterProdutosFornecedores();
        Task<Produto> ObterProdutoFornecedor(Guid id);
    }
}
