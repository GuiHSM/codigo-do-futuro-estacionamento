
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estacionamento_entity.Models;

[Table("carros")]
public record Carro
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get;set; }

    [Required(ErrorMessage = "Nome é obrigatório")]
    [Column("nome", TypeName = "varchar(100)")]
    public string Nome { get;set; } = default!;

    [Required(ErrorMessage = "Marca é obrigatório")]
    [Column("marca", TypeName = "int")]
    public int Marca { get;set; } = default!;

    [Required(ErrorMessage = "Modelo é obrigatório")]
    [Column("modelo", TypeName = "int")]
    public int Modelo { get;set; } = default!;
}