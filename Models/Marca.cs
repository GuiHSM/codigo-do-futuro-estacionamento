
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estacionamento_entity.Models;

[Table("marcas")]
public record Marca
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get;set; }

    [Required(ErrorMessage = "Nome é obrigatório")]
    [Column("nome", TypeName = "varchar(100)")]
    public string Nome { get;set; } = default!;
    public ICollection<Marca>? Marcas { get; set; }
}