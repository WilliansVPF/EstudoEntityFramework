namespace EstudoEntityFramework.Models;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public decimal Valor { get; set; }

    public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
