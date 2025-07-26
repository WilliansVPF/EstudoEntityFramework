namespace EstudoEntityFramework.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Estado { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Logradouro { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;

        public int ClienteTypeConfigurationId { get; set; }

        public override string ToString()
        {
            return $"{Estado} - {Cidade} - {Bairro}";
        }
	}
}