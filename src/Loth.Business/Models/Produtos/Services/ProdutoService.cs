using Loth.Business.Core.Notificacoes;
using Loth.Business.Core.Services;
using Loth.Business.Models.Produtos.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loth.Business.Models.Produtos.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        private readonly IProdutorepository _produtoRepository;

        public ProdutoService(IProdutorepository produtorepository, INotificador notificador) : base(notificador)
        {
            _produtoRepository = produtorepository;
        }

        public async Task Adicionar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _produtoRepository.Adicionar(produto);
        }

        public async Task Atualizar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _produtoRepository.Atualizar(produto);
        }      

        public async Task Remover(Guid id)
        {
            await _produtoRepository.Remover(id);
        }
        public void Dispose()
        {
            _produtoRepository?.Dispose();
        }
    }
}
