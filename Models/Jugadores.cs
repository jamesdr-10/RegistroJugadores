using System.ComponentModel.DataAnnotations;

namespace RegistroJugadores.Models;

public class Jugadores
{
    [Key]
    public int JugadorId { get; set; }

    [Required(ErrorMessage = "El nombre no puede estar vacío")]
    public string Nombre { get; set; } = null!;

    [Range(0, int.MaxValue, ErrorMessage = "La cantidad de partidas jugadas debe ser mayor o igual que cero")]
    public int PartidasJugadas { get; set; }
}