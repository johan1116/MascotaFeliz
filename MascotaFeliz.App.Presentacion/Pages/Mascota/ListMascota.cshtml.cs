using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MascotaFeliz.App.Presentacion.Pages
{
    public class ListMascotaModel : PageModel
    {
        private readonly IRepositorioMascotas repositorioMascota;

        public IEnumerable<Mascota> Mascotas{get;set;}

        public ListMascotaModel(IRepositorioMascotas repositorioMascota)
        {
            this.repositorioMascota = repositorioMascota;
        }

        public void OnGet()
        {
            Mascotas = repositorioMascota.GetAll();


        }
    }
}
