using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
        public readonly AppContext _appContext;
        
        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext = appContext;
        }

        Veterinario IRepositorioVeterinario.Add(Veterinario nuevoVeterinario)
        {
            var veterinario = _appContext.Veterinario.Add(nuevoVeterinario);
            _appContext.SaveChanges();
            return veterinario.Entity;
        }

        IEnumerable<Veterinario> IRepositorioVeterinario.GetAll()
        {
            return _appContext.Veterinario;
        }

        Veterinario IRepositorioVeterinario. GetVeterinarioPorId(int idVeterinario)
        {
            return _appContext.Veterinario.FirstOrDefault(ve => ve.Id == idVeterinario);
        }

        Veterinario IRepositorioVeterinario.Update(Veterinario veterinarioActualizado)
        {
            var veterinario = _appContext.Veterinario.FirstOrDefault(vr => vr.Id == veterinarioActualizado.Id);
            if (veterinario != null)
            {
                veterinario.Documento = veterinarioActualizado.Documento;
                veterinario.Nombre = veterinarioActualizado.Nombre; 
                veterinario.Apellidos = veterinarioActualizado.Apellidos;
                veterinario.Telefono = veterinarioActualizado.Telefono;
                veterinario.TarjetaProfesional = veterinarioActualizado.TarjetaProfesional;

                _appContext.SaveChanges();
            }
            return veterinario;
        }

        void IRepositorioVeterinario.DeleteVeterinario(int idVeterinario)
        {
            var veterinarioEncontrado = _appContext.Veterinario.FirstOrDefault(vd => vd.Id == idVeterinario);
            if (veterinarioEncontrado == null)
            {
                return;
            }
            else
            {
                _appContext.Veterinario.Remove(veterinarioEncontrado);
                _appContext.SaveChanges();
            }
        }

    }
}
