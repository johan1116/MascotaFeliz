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
    public class EditVisitaModel : PageModel
    {
        private readonly IRepositorioVisitas repositorioVisitas;
        [BindProperty]
        public VisitaDomiciliaria VisitaDomiciliaria { get; set; }
        public EditVisitaModel()
        {
            this.repositorioVisitas = new RepositorioVisitas (new MascotaFeliz.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? visitadomiciliariaId)
        {
            if (visitadomiciliariaId.HasValue)
            {
                VisitaDomiciliaria = repositorioVisitas.GetVisitadomiciliariaPorId(visitadomiciliariaId.Value);
            }
            else
            {
                VisitaDomiciliaria = new VisitaDomiciliaria();
            }
            if (VisitaDomiciliaria == null)
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
            if (VisitaDomiciliaria.Id>0)
            {
                VisitaDomiciliaria = repositorioVisitas.Update(VisitaDomiciliaria);
            }
            else
            {
                repositorioVisitas.Add(VisitaDomiciliaria);
            }
            return Page();
        }

    }
}
