using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace MascotaFeliz.App.Presentacion.Pages
{
    public class ListVeterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;

        public IEnumerable<Veterinario> Veterinarios { get; set; }

        public ListVeterinarioModel()
        {
            this.repositorioVeterinario = new RepositorioVeterinario (new MascotaFeliz.App.Persistencia.AppContext());
        }

        public void OnGet(string filtroBusqueda)
        {
            Veterinarios = repositorioVeterinario.GetAll();
        } 
    }
}

