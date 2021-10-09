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
    public class EditVeterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;

        public Veterinario Veterinario {get;set;}

        public EditVeterinarioModel(IRepositorioVeterinario repositorioVeterinario)
        {
            this.repositorioVeterinario = repositorioVeterinario;
        }

        public IActionResult OnGet(int veterinarioId)
        {
            Veterinario = repositorioVeterinario.GetVeterinarioPorId(veterinarioId);
            if(Veterinario == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}
