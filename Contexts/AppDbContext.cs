using EstudoEntityFramework.EntityConfigs;
using EstudoEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EstudoEntityFramework.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<ClienteDataAnnotation> ClienteDataAnnotations => Set<ClienteDataAnnotation>(); //TODO indica para o contexto as classes que representam as tabelas
    public DbSet<ClienteTypeConfiguration> ClienteTypeConfigurations => Set<ClienteTypeConfiguration>();
    public DbSet<Endereco> Enderecos => Set<Endereco>(); //TODO como a tabela de cliente ja faz referencia a endereço, não é obrigatorio essa declaração, porem, para fazer busca direto na tabela de endereço, é necessaria essa declaração
    public DbSet<Pedido> Pedidos => Set<Pedido>();
    public DbSet<Produto> Produtos => Set<Produto>();
    protected override void OnConfiguring(DbContextOptionsBuilder options) //? configuração de conexão
    {
        options
            .UseLazyLoadingProxies() //? configuração para usar o Lazy loading
            .UseSqlServer("Server=localhost,1433;Database=EstudoEFCore;User Id=sa;Password=Root@1234;TrustServerCertificate=True;"); //? string de conexão
    }

    protected override void OnModelCreating(ModelBuilder builder) //? chama a classe de configuração usando IEntityTypeConfiguration
    {
        builder.ApplyConfiguration<ClienteTypeConfiguration>(new ClienteEntityConfig());
        builder.ApplyConfiguration<Endereco>(new EnderecoEntityConfig());
        builder.ApplyConfiguration<Pedido>(new PedidoEntityConfig());
        builder.ApplyConfiguration<Produto>(new ProdutoEntityConfig());
    }
}