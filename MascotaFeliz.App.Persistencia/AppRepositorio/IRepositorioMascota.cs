using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    

    public interface IRepositorioMascotas
    {
        IEnumerable<Mascota> GetAll();

        Mascota GetMascotaPorId(int mascotaID);

        Mascota Update (Mascota mascotaActualizada);

        Mascota Add(Mascota nuevaMascota);

    }
}