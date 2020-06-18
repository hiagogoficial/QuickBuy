using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.UsuarioId)
                .IsRequired();

            builder
                .Property(p => p.ItensPedidos)
                .IsRequired();

            builder
                .Property(p => p.FormaPagamentoId)
                .IsRequired();

            builder
                .Property(p => p.NumeroEndereço)
                .IsRequired();

            builder
                .Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(8);

            builder
                .Property(p => p.Cidade)
                .IsRequired();

            builder
                .Property(p => p.DataPedido)
                .IsRequired();

            builder
                .Property(p => p.DataPrevisaoEntrega)
                .IsRequired();

            builder
                .Property(p => p.EndereçoCompleto)
                .IsRequired();

            builder
                .Property(p => p.Estado)
                .IsRequired();
        }
    }
}
