namespace RegistroJugadores;

public record PartidaResponse(
    int PartidaId,
    int Jugador1Id,
    int? Jugador2Id
);
