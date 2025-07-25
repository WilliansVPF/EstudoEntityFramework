using System.Text;

namespace EstudoEntityFramework.Models;

//* configurando a classe usando IEntityTypeConfiguration (DbContext)

public class ClienteTypeConfiguration
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;

    public Endereco Endereco { get; set; } = null!; //? propriedade de navegação para poder acessar endereço pela classe cliente

    public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>(); //? propriedade de navegação para pedido. Como é um relacionamento 1:N, sera uma coleção de pedidos
}