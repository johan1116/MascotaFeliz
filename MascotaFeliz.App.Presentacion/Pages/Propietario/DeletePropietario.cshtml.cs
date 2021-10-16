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
    public class DeletePropietarioModel : PageModel
    {
        private readonly IRepositorioPropietarios repositorioPropietarios;
        [BindProperty]
        public PropietarioMascota PropietarioMascotas{get;set;}

        public DeletePropietarioModel()
        {
            this.repositorioPropietarios = new RepositorioPropietarios (new MascotaFeliz.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int? propietariomascotasId)
        {
            if (propietariomascotasId.HasValue)
            {
                PropietarioMascotas = repositorioPropietarios.GetPropietariomascotaPorId(propietariomascotasId.Value);
            }
            if (PropietarioMascotas == null)
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
            if (PropietarioMascotas.Id>0)
            {
                repositorioPropietarios.DeletePropietario(PropietarioMascotas.Id);
            }
            else
            {
                repositorioPropietarios.Add(PropietarioMascotas);
            }
            return Page();
        }
    }
}
