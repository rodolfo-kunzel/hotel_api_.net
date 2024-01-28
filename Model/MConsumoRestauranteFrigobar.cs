using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hotel_api
{
    public class ConsumoRestauranteFrigobar
    {
        [Key]
        public int IdConsumo { get; set; }
        public int IdFilial { get; set; }
        public int IdQuarto { get; set; }
        public string? TipoConsumo { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public bool EntregueNoQuarto { get; set; }
        [ForeignKey("Reserva")]
        public int CodigoReserva { get; set; }
        public Reserva? Reserva { get; set; }
    }
}