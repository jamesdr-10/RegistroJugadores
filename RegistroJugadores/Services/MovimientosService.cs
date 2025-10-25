using Microsoft.EntityFrameworkCore;
using RegistroJugadores.DAL;
using RegistroJugadores.Models;

namespace RegistroJugadores.Services;

public class MovimientosService(IDbContextFactory<Contexto> DbFactory)
{

    private async Task<bool> Existe(int movimientoId)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Movimientos.AnyAsync(m => m.MovimientoId == movimientoId);
    }

    private async Task<bool> Insertar(Movimientos movimiento)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.Add(movimiento);
        return await contexto.SaveChangesAsync() > 0;
    }

    private async Task<bool> Modificar(Movimientos movimiento)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.Update(movimiento);
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Guardar(Movimientos movimiento)
    {
        if (!await Existe(movimiento.MovimientoId))
        {
            return await Insertar(movimiento);
        }
        else
        {
            return await Modificar(movimiento);
        }
    }
}