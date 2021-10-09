
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Persistencia.AppRepositorios;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Presentacion.Pages
{
    public class ListVeterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;

        public IEnumerable<Veterinario> Veterinarios { get; set; }

        public ListVeterinarioModel(IRepositorioVeterinario repositorioVeterinario)
        {
            this.repositorioVeterinario = repositorioVeterinario;
        }

        public void OnGet()
        {
            Veterinarios = repositorioVeterinario.GetAll();
        } 
    }
}
