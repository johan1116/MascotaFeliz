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
    public class List1Model : PageModel
    {

        private readonly IRepositorioVisitas repositorioVisitas;
        [BindProperty]
        public IEnumerable<VisitaDomiciliaria> VisitaDomiciliaria { get; set; }

        public List1Model()
        {
            this.repositorioVisitas = new RepositorioVisitas (new MascotaFeliz.App.Persistencia.AppContext());
        }

        public void OnGet(string filtroBusqueda)
        {
            VisitaDomiciliaria = repositorioVisitas.GetAll();


        }
    }
}

