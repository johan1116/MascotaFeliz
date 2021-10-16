using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    

    public interface IRepositorioPropietarios
    {
        IEnumerable<PropietarioMascota> GetAll();

        PropietarioMascota GetPropietariomascotaPorId(int idPropietario);

        PropietarioMascota Update (PropietarioMascota propietarioActualizado);

        PropietarioMascota Add(PropietarioMascota nuevoPropietario);

        void DeletePropietario(int idPropietario);

    }
}