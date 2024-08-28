using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellCar.Cliente.Model.Models;

namespace SellCar.Cliente.Repository.Mapping
{
    public class TipoProfissaoMap : IEntityTypeConfiguration<TipoProfissaoModel>
    {
        public void Configure(EntityTypeBuilder<TipoProfissaoModel> builder)
        {
            builder.ToTable("tipo_profissao");

            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Id)
                .HasColumnName("id")
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasColumnName("descricao")
                .HasMaxLength(30)
                .IsRequired();            

        }
    }
}
