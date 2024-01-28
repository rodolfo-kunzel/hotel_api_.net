using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hotel_api
{
    public class ServicoLavanderia
    {
        [Key]
        public int IdServico { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        [ForeignKey("Reserva")]
        public int CodigoReserva { get; set; }
        public Reserva? Reserva { get; set; }
    }
}