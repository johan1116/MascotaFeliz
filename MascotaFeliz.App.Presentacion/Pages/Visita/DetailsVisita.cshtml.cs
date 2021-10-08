using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MascotaFeliz.App.Persistencia.AppRepositorios;
using MascotaFeliz.App.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MascotaFeliz.App.Presentacion.Pages
{
    public class DetailsVisitaModel : PageModel
    {
        private readonly IRepositorioVisitas repositorioVisitas;

        public VisitaDomiciliaria VisitaDomiciliaria { get; set; }
        public DetailsVisitaModel(IRepositorioVisitas repositorioVisitas)
        {
            this.repositorioVisitas = repositorioVisitas;
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
