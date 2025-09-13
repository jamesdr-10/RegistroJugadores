using RegistroJugadores.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroJugadores;

public class Partidas
{
    [Key]
    public int PartidaId { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Debe de elegir un Jugador 1.")]
    public int Jugador1Id { get; set; }
    public int? Jugador2Id { get; set; }

    [Required]
    [StringLength(20)]
    public string EstadoPartida { get; set; }

    public int? GanadorId { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Debe de elegir el turno de un jugador.")]
    public int TurnoJugadorId { get; set; }

    public DateTime FechaInicio { get; set; } = DateTime.UtcNow;
    public DateTime? FechaFin { get; set; }

    //Propiedades de navegación
    [ForeignKey(nameof(Jugador1Id))]
    public virtual Jugadores Jugador1 { get; set; }

    [ForeignKey(nameof(Jugador2Id))]
    public virtual Jugadores Jugador2 { get; set; }

    [ForeignKey(nameof(GanadorId))]
    public virtual Jugadores Ganador { get; set; }

    [ForeignKey(nameof(TurnoJugadorId))]
    public virtual Jugadores TurnoJugador { get; set; }
}