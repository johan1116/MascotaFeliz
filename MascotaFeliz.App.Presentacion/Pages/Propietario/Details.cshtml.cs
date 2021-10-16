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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioPropietarios repositorioPropietarios;

        public PropietarioMascota PropietarioMascotas{get;set;}

        public DetailsModel()
        {
            this.repositorioPropietarios = new RepositorioPropietarios (new MascotaFeliz.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int propietariomascotasId)
        {
            PropietarioMascotas = repositorioPropietarios.GetPropietariomascotaPorId(propietariomascotasId);
            if (PropietarioMascotas == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
    
        }
    }
}

