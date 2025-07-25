using EstudoEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstudoEntityFramework.EntityConfigs;

public class PedidoEntityConfig : IEntityTypeConfiguration<Pedido>
{
    public void Configure(EntityTypeBuilder<Pedido> builder)
    {
        builder.ToTable("pedido");

        builder.Property(pedido => pedido.Id)
            .HasColumnName("id");
        builder.HasKey(pedido => pedido.Id);

        builder.Property(pedido => pedido.Descricao)
            .HasColumnName("descricao")
            .HasColumnType("nvarchar(max)")
            .IsRequired();

        builder.Property(pedido => pedido.Data)
            .HasColumnName("data")
            .HasColumnType("datetime2")
            .IsRequired();

        builder.HasOne(cliente => cliente.Cliente)
            .WithMany(cliente => cliente.Pedidos) //? configura um relacionamento 1:N
            .HasForeignKey(pedido => pedido.ClienteTypeConfigurationId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}