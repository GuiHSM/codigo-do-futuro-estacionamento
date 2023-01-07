
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

    [Required(ErrorMessage = "Modelo é obrigatório")]
    [Column("modeloId", TypeName = "int")]
    public int ModeloId { get;set; } = default!;
    public Modelo? Modelo {get; set;}
    public ICollection<Pedido>? Pedidos { get; set; }
}