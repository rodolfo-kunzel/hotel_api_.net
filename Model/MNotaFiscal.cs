using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hotel_api
{
    public class NotaFiscal
    {
        [Key]
        public int CodigoNota { get; set; }
        public string? TipoPagamento { get; set; }
        public decimal Preco { get; set; }

        [ForeignKey("Reserva")]
        public int CodigoReserva { get; set; }
        public Reserva? Reserva { get; set; }
    }
}