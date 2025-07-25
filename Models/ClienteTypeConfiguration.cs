namespace EstudoEntityFramework.Models;

//* configurando a classe usando IEntityTypeConfiguration (DbContext)

public class ClienteTypeConfiguration
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;

    public Endereco Endereco { get; set; } = null!; //? propriedade de navegação para poder acessar endereço pela classe cliente
}