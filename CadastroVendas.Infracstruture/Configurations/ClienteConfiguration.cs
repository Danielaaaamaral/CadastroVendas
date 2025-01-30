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
    public class ClienteConfiguration :IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder) {
        
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .IsRequired();


        }
    }
}
