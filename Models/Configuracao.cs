
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estacionamento_entity.Models;

[Table("configuracoes")]
public record Configuracao
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get;set; }

    [Required(ErrorMessage = "Dias de locação é obrigatório")]
    [Column("diasDeLocacao", TypeName = "int")]
    public int DiasDeLocacao { get;set; } = default!;

}