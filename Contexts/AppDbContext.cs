using Microsoft.EntityFrameworkCore;

namespace EstudoEntityFramework.Contexts;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=localhost,1433;Database=EstudoEFCore;User Id=sa;Password=Root@1234;TrustServerCertificate=True;");
    }
}