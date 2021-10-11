using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MascotaFeliz.App.Presentacion.Pages
{
    public class DetailsMascotaModel : PageModel
    {
        private readonly IRepositorioMascotas repositorioMascota;

        public  Mascota Mascota { get; set; }

        public DetailsMascotaModel(IRepositorioMascotas repositorioMascota)
        {
            this.repositorioMascota = repositorioMascota;
        }

        public IActionResult OnGet(int mascotaId)
        {
            Mascota = repositorioMascota.GetMascotaPorId(mascotaId);
            if (Mascota == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }
    }
}
