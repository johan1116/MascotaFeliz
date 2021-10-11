using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    

    public interface IRepositorioPropietarios
    {
        IEnumerable<PropietarioMascota> GetAll();

        PropietarioMascota GetPropietariomascotaPorId(int propietariomascotasID);

        PropietarioMascota Update (PropietarioMascota propietarioActualizado);

        PropietarioMascota Add(PropietarioMascota nuevoPropietario);

    }
}