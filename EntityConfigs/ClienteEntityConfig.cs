using EstudoEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstudoEntityFramework.EntityConfigs;

//* seta as configurações usando Type Comfiguration

public class ClienteEntityConfig : IEntityTypeConfiguration<ClienteTypeConfiguration>
{
    public void Configure(EntityTypeBuilder<ClienteTypeConfiguration> builder)
    {
        builder.ToTable("clientesTypeConfiguration"); //? define o nome da tabela

        builder.Property(cliente => cliente.Id) //? define a propriedade
            .HasColumnName("id") //? define o nome da coluna
            .HasColumnType("int"); //? define o tipo de dado

        builder.HasKey(cliente => cliente.Id); //? defina a chave primaria

        builder.Property(cliente => cliente.Nome)
            .IsRequired() //? indica que esse campo é obrigatório
            .HasColumnName("nome")
            .HasColumnType("nvarchar(100)");

        builder.Property(cliente => cliente.Cpf)
            .IsRequired()
            .HasColumnName("cpf")
            .HasColumnType("nvarchar(15)");
    }
}