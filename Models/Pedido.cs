namespace EstudoEntityFramework.Models;

public class Pedido
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime Data { get; set; }

    public int ClienteTypeConfigurationId { get; set; }
    public virtual ClienteTypeConfiguration Cliente { get; set; } = null!; //? propriedade de navegação

    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();

}