using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    

    public interface IRepositorioVeterinario
    {
        IEnumerable<Veterinario> GetAll();

        Veterinario GetVeterinarioPorId(int idVeterinario);

        Veterinario Update (Veterinario veterinarioActualizado);

        Veterinario Add (Veterinario nuevoVeterinario);

        void DeleteVeterinario (int idVeterinario);

    }
}