using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace MascotaFeliz.App.Presentacion.Pages
{
    public class ListMascotaModel : PageModel

    {  
        private readonly IRepositorioMascotas repositorioMascota;

        public IEnumerable<Mascota> Mascotas{get;set;}

        public ListMascotaModel()
        {
            this.repositorioMascota = new RepositorioMascota (new MascotaFeliz.App.Persistencia.AppContext());
        }

        public void OnGet(string filtroBusqueda)
        {
            Mascotas = repositorioMascota.GetAll();
        }
    }
}
