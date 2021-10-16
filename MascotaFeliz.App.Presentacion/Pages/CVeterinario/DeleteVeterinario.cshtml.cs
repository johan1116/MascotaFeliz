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
    public class DeleteVeterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;
        [BindProperty]
        public Veterinario Veterinario { get; set; }

        public DeleteVeterinarioModel()
        {
            this.repositorioVeterinario = new RepositorioVeterinario (new MascotaFeliz.App.Persistencia.AppContext()) ;
        }

        public IActionResult OnGet(int? veterinarioId)
        {
            if (veterinarioId.HasValue)
            {
                Veterinario = repositorioVeterinario.GetVeterinarioPorId(veterinarioId.Value);
            }
           
            if (Veterinario == null)
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
            if (Veterinario.Id>0)
            {
                repositorioVeterinario.DeleteVeterinario(Veterinario.Id);
            }
            else
            {
                repositorioVeterinario.Add(Veterinario);
            }
            return Page();
        }
    }
}
