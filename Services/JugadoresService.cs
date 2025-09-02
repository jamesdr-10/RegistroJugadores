using Microsoft.EntityFrameworkCore;

namespace RegistroJugadores;

public class JugadoresService(IDbContextFactory<Contexto> DbFactory)
{
    private async Task<bool> Existe(int jugadorId)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Jugadores.AnyAsync(j => j.JugadorId == jugadorId);
    }



}
