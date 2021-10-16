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
    public class DeleteMascotaModel : PageModel
    {
        private readonly IRepositorioMascotas repositorioMascota;
        [BindProperty]
        public  Mascota Mascota { get; set; }

        public DeleteMascotaModel()
        {
            this.repositorioMascota = new RepositorioMascota(new MascotaFeliz.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int? mascotaId)
        {
            if (mascotaId.HasValue)
            {
                Mascota = repositorioMascota.GetMascotaPorId(mascotaId.Value);
            }
            
            if (Mascota == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Mascota.Id>0)
            {
                repositorioMascota.DeleteMascota(Mascota.Id);
            }
            else
            {
                repositorioMascota.Add(Mascota);
            }
            return Page();
        }
    }
}
