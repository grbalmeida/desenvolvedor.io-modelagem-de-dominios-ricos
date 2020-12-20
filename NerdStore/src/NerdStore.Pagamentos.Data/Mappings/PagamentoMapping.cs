using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NerdStore.Pagamentos.Business;

namespace NerdStore.Pagamentos.Data.Mappings
{
    public class PagamentoMapping : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.NomeCartao)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(p => p.NumeroCartao)
                .IsRequired()
                .HasColumnType("varchar(16)");

            builder.Property(p => p.ExpiracaoCartao)
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.Property(p => p.CvvCartao)
                .IsRequired()
                .HasColumnType("varchar(4)");

            // 1 : 1 => Pagamento : Transacao
            builder.HasOne(p => p.Transacao)
                .WithOne(t => t.Pagamento);

            builder.ToTable("Pagamentos");
        }
    }
}
