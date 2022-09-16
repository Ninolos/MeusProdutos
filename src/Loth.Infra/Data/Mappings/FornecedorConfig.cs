﻿using Loth.Business.Models.Fornecedores;
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
    public class FornecedorConfig : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorConfig()
        {
            HasKey(x => x.Id);

            Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(200);

            Property(x => x.Documento)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnAnnotation("IX_Documento", new IndexAnnotation(new IndexAttribute { IsUnique = true }));

            HasRequired(x => x.Endereco)
                .WithRequiredPrincipal(e => e.Fornecedor);

            ToTable("Fornecedores");
        }
    }
}