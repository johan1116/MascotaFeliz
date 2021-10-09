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
    public class EditVisitaModel : PageModel
    {
        private readonly IRepositorioVisitas repositorioVisitas;
        [BindProperty]
        public VisitaDomiciliaria VisitaDomiciliaria { get; set; }
        public EditVisitaModel(IRepositorioVisitas repositorioVisitas)
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
