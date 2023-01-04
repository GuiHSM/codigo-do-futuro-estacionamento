using Estacionamento_entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Estacionamento_entity.Contexto;

public class DbContexto : DbContext
{
    public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }
    public DbSet<Cliente> Clientes { get; set; } = default!;
    public DbSet<Carro> Carros { get; set; } = default!;
    public DbSet<Configuracao> Configuracoes { get; set; } = default!;
    public DbSet<Pedido> Pedidos { get; set; } = default!;
    public DbSet<Marca> Marcas { get; set; } = default!;
    public DbSet<Modelo> Modelos { get; set; } = default!;

} 