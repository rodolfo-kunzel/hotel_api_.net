using System.ComponentModel.DataAnnotations;

namespace hotel_api
{
        public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public string? Nacionalidade { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
    }
}