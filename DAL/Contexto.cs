using Microsoft.EntityFrameworkCore;

namespace RegistroJugadores;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<Jugadores> Jugadores { get; set; }
}