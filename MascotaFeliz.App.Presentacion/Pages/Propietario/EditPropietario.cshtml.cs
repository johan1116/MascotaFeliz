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
    public class EditPropietarioModel : PageModel
    {
        private readonly IRepositorioPropietarios repositorioPropietarios;
        [BindProperty]
        public PropietarioMascota PropietarioMascotas { get; set; }

        public EditPropietarioModel(IRepositorioPropietarios repositorioPropietarios)
        {
            this.repositorioPropietarios = repositorioPropietarios;
        }
        public IActionResult OnGet(int? propietariomascotasId)
        {
            if (propietariomascotasId.HasValue)
            {
                PropietarioMascotas = repositorioPropietarios.GetPropietariomascotaPorId(propietariomascotasId.Value);
            }
            else
            {
                PropietarioMascotas = new PropietarioMascota();
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
            if (PropietarioMascotas.Id>0)
            {
                PropietarioMascotas = repositorioPropietarios.Update(PropietarioMascotas);
            }
            else
            {
                repositorioPropietarios.Add(PropietarioMascotas);
            }
            return Page();
        }


    }
}
