using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hotel_api
{
    public class Quarto
    {
        [Key]
        public int Numero { get; set; }
        public string? TipoQuarto { get; set; }
        public int Adaptado { get; set; }
        public int CapacidadeMaxima { get; set; }
        public int CapacidadeOpcional { get; set; }
        public decimal PrecoQuarto { get; set; }
        public decimal PrecoQuartoOpcional { get; set; }

        [ForeignKey("Filial")]
        public int IdFilial { get; set; }
        public Filial? Filial { get; set; }
    }
}