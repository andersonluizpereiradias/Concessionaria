using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellCar.Cliente.Model.Models;

namespace SellCar.Cliente.Repository.Mapping
{
    public class ProfissaoMap : IEntityTypeConfiguration<ProfissaoModel>
    {
        public void Configure(EntityTypeBuilder<ProfissaoModel> builder)
        {
            builder.ToTable("profissao");
            
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasColumnName("descricao")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(x => x.TipoProfissaoId)
                .HasColumnName("tipo_profissao_id")
                .IsRequired();

            builder.HasOne(x => x.TipoProfissao)
                .WithMany(y => y.Profissoes)
                .HasForeignKey(z => z.TipoProfissaoId);

        }
    }
}
