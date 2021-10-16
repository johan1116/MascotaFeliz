using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{


    public interface IRepositorioMascotas
    {
        IEnumerable<Mascota> GetAll();

        Mascota GetMascotaPorId(int idMascota);

        Mascota Update (Mascota mascotaActualizada);

        Mascota Add(Mascota nuevaMascota);

        void DeleteMascota (int idMascota);

    }
}