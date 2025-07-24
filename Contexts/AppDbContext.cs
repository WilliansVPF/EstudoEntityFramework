using EstudoEntityFramework.EntityConfigs;
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

    protected override void OnModelCreating(ModelBuilder builder) //? chama a classe de configuração usando IEntityTypeConfiguration
    {
        builder.ApplyConfiguration<ClienteTypeConfiguration>(new ClienteEntityConfig()); 
    }
}