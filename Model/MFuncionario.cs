using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hotel_api
{
    
public class Funcionario
{
    [Key]
    public int IdFuncionario { get; set; }
    public string? TipoFuncionario { get; set; }
    public string? Nome { get; set; }

    [ForeignKey("FuncionarioCargo")]
    public int IdCargo { get; set; }
    public FuncionarioCargo? FuncionarioCargo { get; set; }
}
}