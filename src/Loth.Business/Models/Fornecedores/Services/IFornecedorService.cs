using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loth.Business.Models.Fornecedores.Services
{
    public interface IFornecedorService : IDisposable
    {
        //apenas para alteraçoes na Entidade, obter dados é só no Repository
        Task Adicionar(Fornecedor fornecedor);
        Task Atualizar(Fornecedor fornecedor);
        Task Remover(Guid id);

        Task AtualizarEndereco(Endereco endereco);
    }
}
