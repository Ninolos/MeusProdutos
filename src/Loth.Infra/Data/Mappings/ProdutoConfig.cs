using Loth.Business.Models.Fornecedores;
using Loth.Business.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loth.Infra.Data.Mappings
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            HasKey(x => x.Id);

            Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(200);

            Property(x => x.Descricao)
                .IsRequired()
                .HasMaxLength(1000);

            Property(x => x.Imagem)
                .IsRequired()
                .HasMaxLength(100);

            HasRequired(p => p.Fornecedor)
                .WithMany(f => f.Produtos)
                .HasForeignKey(p => p.FornecedorId);
                   
            ToTable("Produtos");
        }
    }
}
