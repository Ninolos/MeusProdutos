using Loth.Business.Models.Fornecedores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loth.Infra.Data.Mappings
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(x => x.Id);

            Property(x => x.Logradouro)
                .IsRequired()
                .HasMaxLength(200);

            Property(x => x.Numero)
                .IsRequired()
                .HasMaxLength(50);

            Property(x => x.Cep)
                .IsRequired()
                .HasMaxLength(8)
                .IsFixedLength();

            Property(x => x.Complemento)
                .HasMaxLength(250);

            Property(x => x.Bairro)
                .IsRequired()
                .HasMaxLength(100);

            Property(x => x.Cidade)
                .IsRequired()
                .HasMaxLength(100);

            Property(x => x.Estado)
                .IsRequired()
                .HasMaxLength(100);            

            ToTable("Enderecos");
        }
    }
}
