using EstudoEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstudoEntityFramework.EntityConfigs;

public class ProdutoEntityConfig : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        builder.ToTable("produtos");

        builder.Property(produto => produto.Id)
            .HasColumnName("id");
        builder.HasKey(produto => produto.Id);

        builder.Property(produto => produto.Nome)
            .HasColumnName("nome")
            .HasColumnType("nvarchar(100)")
            .IsRequired();

        builder.Property(produto => produto.Valor)
            .HasColumnName("valor")
            .HasColumnType("decimal(18,2)")
            .IsRequired();

        builder.HasMany(produto => produto.Pedidos)
            .WithMany(pedido => pedido.Produtos)
            .UsingEntity(x => x.ToTable("itensPedido")); //? altera o nome da tabela auxiliar
    }
}