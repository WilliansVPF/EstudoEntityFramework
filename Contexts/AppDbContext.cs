using EstudoEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EstudoEntityFramework.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<ClienteDataAnnotation> ClienteDataAnnotations => Set<ClienteDataAnnotation>(); //? indica para o contexto as classes que representam as tabelas
    public DbSet<ClienteTypeConfiguration> ClienteTypeConfigurations => Set<ClienteTypeConfiguration>();
    protected override void OnConfiguring(DbContextOptionsBuilder options) //? configuração de conexão
    {
        options.UseSqlServer("Server=localhost,1433;Database=EstudoEFCore;User Id=sa;Password=Root@1234;TrustServerCertificate=True;"); //? string de conexão
    }

    protected override void OnModelCreating(ModelBuilder builder) //? configura classe usando IEntityTypeConfiguration
    {
        builder.Entity<ClienteTypeConfiguration>()
            .ToTable("clientes"); //*define o nome da tabela

        builder.Entity<ClienteTypeConfiguration>()
            .Property(cliente => cliente.Id) //* define a propriedade
            .HasColumnName("id") //* define o nome da coluna
            .HasColumnType("int"); //* define o tipo de dado

        builder.Entity<ClienteTypeConfiguration>()
            .HasKey(cliente => cliente.Id); //* defina a chave primaria

        builder.Entity<ClienteTypeConfiguration>()
            .Property(cliente => cliente.Nome)
            .IsRequired() //? indica que esse campo é obrigatório
            .HasColumnName("nome")
            .HasColumnType("nvarchar(100)");

        builder.Entity<ClienteTypeConfiguration>()
            .Property(cliente => cliente.Cpf)
            .IsRequired()
            .HasColumnName("cpf")
            .HasColumnType("nvarchar(15)");
    }
}