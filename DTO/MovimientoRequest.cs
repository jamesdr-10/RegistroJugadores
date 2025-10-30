namespace RegistroJugadores;

public record MovimientoRequest(
    int PartidaId,
    string Jugador,
    int PosicionFila,
    int PosicionColumna
);
