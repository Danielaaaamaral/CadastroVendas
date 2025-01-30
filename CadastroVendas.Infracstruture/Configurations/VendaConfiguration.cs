using CadastroVendas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVendas.Infracstruture.Configurations
{
    public class VendaConfiguration : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.ClienteId)
                .IsRequired();
            builder.Property(x => x.ProdutoId)
               .IsRequired();
            builder.Property(x => x.DtaVenda)
              .IsRequired();

            builder.HasOne(c => c.Cliente)
                .WithMany(t => t.Vendas)
                .HasForeignKey(c => c.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.Produto)
               .WithMany(t => t.Vendas)
               .HasForeignKey(c => c.ProdutoId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(c => c.ProdutoId);
            builder.HasIndex(c => c.ClienteId);



        }
    }
}
