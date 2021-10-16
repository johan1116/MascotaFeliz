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
    public class DetailsVisitaModel : PageModel
    {
        private readonly IRepositorioVisitas repositorioVisitas;

        public VisitaDomiciliaria VisitaDomiciliaria { get; set; }
        public DetailsVisitaModel()
        {
            this.repositorioVisitas = new RepositorioVisitas ( new MascotaFeliz.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int visitadomiciliariaId)
        {
            VisitaDomiciliaria = repositorioVisitas.GetVisitadomiciliariaPorId(visitadomiciliariaId);
            if (VisitaDomiciliaria == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

    }
}
