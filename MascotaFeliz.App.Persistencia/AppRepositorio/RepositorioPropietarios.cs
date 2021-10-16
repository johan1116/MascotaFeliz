using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioPropietarios : IRepositorioPropietarios
    {
        public readonly AppContext _appContext;

        public RepositorioPropietarios(AppContext appContext)
        {
            _appContext = appContext;
        }

        PropietarioMascota IRepositorioPropietarios.Add(PropietarioMascota nuevoPropietario)
        {
            var propietario = _appContext.PropietarioMascota.Add(nuevoPropietario);
            _appContext.SaveChanges();
            return propietario.Entity;
        }

        PropietarioMascota IRepositorioPropietarios.Update(PropietarioMascota propietarioActualizado)
        {
            var propietario = _appContext.PropietarioMascota.FirstOrDefault(pr => pr.Id == propietarioActualizado.Id);
            if (propietario != null)
            {
                propietario.Documento = propietarioActualizado.Documento;
                propietario.Nombre = propietarioActualizado.Nombre;
                propietario.Apellidos = propietarioActualizado.Apellidos;
                propietario.Telefono = propietarioActualizado.Telefono;
                propietario.Direccion = propietarioActualizado.Direccion;

                _appContext.SaveChanges();
            }
            return propietario;

        }

        PropietarioMascota IRepositorioPropietarios.GetPropietariomascotaPorId(int idPropietario)
        {
            return _appContext.PropietarioMascota.FirstOrDefault(p => p.Id == idPropietario);
        }

        IEnumerable<PropietarioMascota> IRepositorioPropietarios.GetAll()
        {
            return _appContext.PropietarioMascota;
        }
        
        void IRepositorioPropietarios.DeletePropietario(int idPropietario)
        {
            var propietarioEncontrado = _appContext.PropietarioMascota.FirstOrDefault(md => md.Id == idPropietario);
            if(propietarioEncontrado == null)
            {
                return;
            }
            else
            {
                _appContext.PropietarioMascota.Remove(propietarioEncontrado);
                _appContext.SaveChanges();
            }
        }
    }
}