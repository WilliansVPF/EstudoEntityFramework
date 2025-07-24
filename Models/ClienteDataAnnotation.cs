using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstudoEntityFramework.Models;

//* configurando a classe usando Data Annotations

[Table("clientesDataAnnotation")] //? nomeia a tabela. Caso não seja indicado um nome, a tabela tera o mesmo nome da classe no plural (Cliente = Clientes)
public class ClienteDataAnnotation
{
    [Key] //? Indica que essa propriedade representa uma chave primaria. Por padrão, propriedades com nome Id ou NomeDaClasseId, são definidas automaticamente como primarias
    [Column("id")] //? Define um nome para a coluna. Caso não seja definido, a coluna tera o nome da propriedade
    public int Id { get; set; }

    [Column("nome")]
    [MaxLength(100)] //? Define quantidade maxima de caracters. Pode ser usado para validação
    public string Nome { get; set; } = string.Empty;

    [Column("cpf" , TypeName = "nvarchar(15)")] //? TypeName define qual vai ser o tipo do dado
    public string Cpf { get; set; } = string.Empty;
}