using System.ComponentModel.DataAnnotations;

namespace hotel_api
{
    public class Filial
    {
        [Key]
        public int IdFilial { get; set; }
        public string? Nome { get; set; }
        public int NumeroQuartosTipoA { get; set; }
        public int NumeroQuartosTipoB { get; set; }
        public int NumeroQuartosTipoC { get; set; }
        public string? Endereco { get; set; }
        public int Estrelas { get; set; }
    }
}
