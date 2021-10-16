
using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascotas
    {
        public readonly AppContext _appContext;

        public RepositorioMascota(AppContext appContext)
        {
            _appContext = appContext;
        }

        Mascota IRepositorioMascotas.Add(Mascota nuevaMascota)
        {
            var mascota = _appContext.Mascota.Add(nuevaMascota);
            _appContext.SaveChanges();
            return mascota.Entity;
        }

        Mascota IRepositorioMascotas.Update(Mascota mascotaActualizada)
        {
            var mascota = _appContext.Mascota.FirstOrDefault(mr => mr.Id == mascotaActualizada.Id);
            if (mascota != null)
            {
                
                mascota.NombreMascota = mascotaActualizada.NombreMascota;
                mascota.Caracteristicas = mascotaActualizada.Caracteristicas;
                mascota.PropietarioMascota = mascotaActualizada.PropietarioMascota;
                mascota.TipoMascota = mascotaActualizada.TipoMascota;

                _appContext.SaveChanges();
            }
            return mascota;

        }

        Mascota IRepositorioMascotas.GetMascotaPorId(int idMascota)
        {
            return _appContext.Mascota.FirstOrDefault(m => m.Id == idMascota);
        }

        IEnumerable<Mascota> IRepositorioMascotas.GetAll()
        {
            return _appContext.Mascota;
        }

        void IRepositorioMascotas.DeleteMascota(int idMascota)
        {
            var mascotaEncontrada = _appContext.Mascota.FirstOrDefault(md => md.Id == idMascota);
            if (mascotaEncontrada == null)
            {
                return;
            }
            else
            {
                _appContext.Mascota.Remove(mascotaEncontrada);
                _appContext.SaveChanges();
            }
        }
    }
}