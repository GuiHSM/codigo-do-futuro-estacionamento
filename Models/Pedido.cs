
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estacionamento_entity.Models;

[Table("pedidos")]
public record Pedido
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get;set; }

    [Required(ErrorMessage = "Id cliente é obrigatório")]
    [Column("IdCliente", TypeName = "int")]
    public int IdCliente { get;set; } = default!;
    
    [Required(ErrorMessage = "Carro é obrigatório")]
    [Column("Carro", TypeName = "int")]
    public int Carro { get;set; } = default!;

    [Required(ErrorMessage = "Data Locacao é obrigatório")]
    [Column("DataLocacao", TypeName = "date")]
    public DateOnly DataLocacao { get;set; } = default!;

    [Required(ErrorMessage = "Data Entrega é obrigatório")]
    [Column("DataEntrega", TypeName = "date")]
    public DateOnly DataEntrega { get;set; } = default!;

}