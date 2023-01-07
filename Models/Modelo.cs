
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estacionamento_entity.Models;

[Table("modelos")]
public record Modelo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get;set; }

    [Required(ErrorMessage = "Nome é obrigatório")]
    [Column("nome", TypeName = "varchar(100)")]
    public string Nome { get;set; } = default!;
    public ICollection<Carro>? Carros { get; set; }
    
    [Required(ErrorMessage = "Marca é obrigatório")]
    [Column("marcaId", TypeName = "int")]
    public int MarcaId { get;set; } = default!;
    public Marca? Marca {get; set;}
}