using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NerdStore.Vendas.Domain;

namespace NerdStore.Vendas.Data.Mappings
{
    public class PedidoItemMapping : IEntityTypeConfiguration<PedidoItem>
    {
        public void Configure(EntityTypeBuilder<PedidoItem> builder)
        {
            builder.HasKey(pi => pi.Id);

            builder.Property(pi => pi.ProdutoNome)
                .IsRequired()
                .HasColumnType("varchar(250)");

            // 1 : N => Pedido : PedidoItens
            builder.HasOne(pi => pi.Pedido)
                .WithMany(p => p.PedidoItens);

            builder.ToTable("PedidoItens");
        }
    }
}
