
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
<<<<<<< HEAD:MascotaFeliz.App.Presentacion/Pages/Mascota/ListMascota.cshtml.cs
    {
       
=======
    {  
        private readonly IRepositorioMascotas repositorioMascota;

        public IEnumerable<Mascota> Mascotas{get;set;}

        public ListMascotaModel(IRepositorioMascotas repositorioMascota)
        {
            this.repositorioMascota = repositorioMascota;
        }
>>>>>>> 495f089109b65c874ab4a0ebedf181eb825fb033:MascotaFeliz.App.Presentacion/Pages/CMascota/ListMascota.cshtml.cs

        public void OnGet()
        {
           


        }
    }
}
