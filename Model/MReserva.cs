using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hotel_api
{
    
    public class Reserva
    {
        [Key]
        public int CodigoReserva { get; set; }
        public DateTime DtEntrada { get; set; }
        public DateTime DtSaida { get; set; }

        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        public Cliente? Cliente { get; set; }

        [ForeignKey("Funcionario")]
        public int IdFuncionario { get; set; }
        public Funcionario? Funcionario { get; set; }

        [ForeignKey("Filial")]
        public int IdFilial { get; set; }
        public Filial? Filial { get; set; }
        [ForeignKey("Quarto")]
        public int idQuarto { get; set; }
        public Quarto? Quarto { get; set; }
    }
}