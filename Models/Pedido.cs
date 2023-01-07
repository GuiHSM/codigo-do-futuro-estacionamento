
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
    [Column("clienteId", TypeName = "int")]
    public int ClienteId { get;set; } = default!;
    public Cliente? Cliente {get; set;}
    
    [Required(ErrorMessage = "Carro é obrigatório")]
    [Column("carroId", TypeName = "int")]
    public int CarroId { get;set; } = default!;
    public Carro? Carro {get; set;}

    [Required(ErrorMessage = "Data Locacao é obrigatório")]
    [Column("DataLocacao", TypeName = "date")]
    public DateTime DataLocacao { get;set; } = default!;

    [Required(ErrorMessage = "Data Entrega é obrigatório")]
    [Column("DataEntrega", TypeName = "date")]
    public DateTime DataEntrega { get;set; } = default!;

}