
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estacionamento_entity.Models;

[Table("clientes")]
public record Cliente
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get;set; }

    [Required(ErrorMessage = "Nome é obrigatório")]
    [Column("nome", TypeName = "varchar(100)")]
    public string Nome { get;set; } = default!;

    [Column("email", TypeName = "varchar(150)")]
    public string? Email { get;set; }

    [Column("telefone", TypeName = "varchar(11)")]
    public string? Telefone { get;set; }

    [Column("endereco", TypeName = "text")]
    public string? Endereco { get;set; }
    public ICollection<Pedido>? Pedidos { get; set; }
}