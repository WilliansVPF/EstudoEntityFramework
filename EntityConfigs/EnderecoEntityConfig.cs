using EstudoEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstudoEntityFramework.EntityConfigs;

public class EnderecoEntityConfig : IEntityTypeConfiguration<Endereco>
{
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
                builder.ToTable("enderecos");

                builder.Property(endereco => endereco.Id)
                        .HasColumnName("id")
                        .HasColumnType("int");
                builder.HasKey(cliente => cliente.Id);

                builder.Property(endereco => endereco.Estado)
                        .IsRequired()
                        .HasColumnName("estado")
                        .HasColumnType("nvarchar(2)");

                builder.Property(endereco => endereco.Cidade)
                        .IsRequired()
                        .HasColumnName("cidade")
                        .HasColumnType("nvarchar(100)");

                builder.Property(endereco => endereco.Bairro)
                        .IsRequired()
                        .HasColumnName("bairro")
                        .HasColumnType("nvarchar(100)");

                builder.Property(endereco => endereco.Logradouro)
                        .IsRequired()
                        .HasColumnName("logradouro")
                        .HasColumnType("nvarchar(max)");

                builder.Property(endereco => endereco.Numero)
                        .IsRequired()
                        .HasColumnName("numero")
                        .HasColumnType("nvarchar(10)");

                builder.Property(endereco => endereco.ClienteTypeConfigurationId)
                        .HasColumnName("clienteId")
                        .HasColumnType("int");

                builder.HasOne<ClienteTypeConfiguration>() //? indica com qual classe a modelo esta se relacionando
                        .WithOne(cliente => cliente.Endereco) //? configura um relacionamento 1:1 e passa a propriedade de navegação
                        .HasForeignKey<Endereco>(endereco => endereco.ClienteTypeConfigurationId) //? aponta onde esta a chave estrangeira
                        .OnDelete(DeleteBehavior.Cascade); //? configura a configuração de exclusão. nesse caso, como não faz sentido ter um endereço sem cliente, o registro de endereço ser deletado caso o cliente seja deletado
        }
}