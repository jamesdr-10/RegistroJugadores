using System.Text.Json.Serialization;
public record PartidaResponse(
    int PartidaId,
    int Jugador1Id,
    int? Jugador2Id
);
