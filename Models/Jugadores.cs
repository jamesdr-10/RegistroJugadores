﻿using System.ComponentModel.DataAnnotations;

namespace RegistroJugadores.Models;

public class Jugadores
{
    [Key]
    public int JugadorId { get; set; }

    [Required(ErrorMessage = "El nombre no puede estar vacío.")]
    public string Nombres { get; set; } = null!;

    public int Victorias { get; set; } = 0;

    public int Empates { get; set; } = 0;

    public int Derrotas { get; set; } = 0;
}
