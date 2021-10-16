using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MascotaFeliz.App.Presentacion.Pages
{
    public class DetailsMascotaModel : PageModel
    {
        private readonly IRepositorioMascotas repositorioMascota;

        public  Mascota Mascota { get; set; }

        public DetailsMascotaModel()
        {
            this.repositorioMascota = new RepositorioMascota (new MascotaFeliz.App.Persistencia.AppContext());
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
