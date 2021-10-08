using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    

    public interface IRepositorioVeterinario
    {
        IEnumerable<Veterinario> GetAll();

        

    }
}