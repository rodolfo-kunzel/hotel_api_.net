using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hotel_api
{
    public class FuncionarioCargo
    {
        [Key]
        public int IdCargo { get; set; }
        public string? Descricao { get; set; }
    }
}