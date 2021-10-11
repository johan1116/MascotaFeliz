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
    public class List1Model : PageModel
    {

        private readonly IRepositorioVisitas repositorioVisitas;
        [BindProperty]
        public IEnumerable<VisitaDomiciliaria> VisitaDomiciliaria { get; set; }

        public List1Model(IRepositorioVisitas repositorioVisitas)
        {
            this.repositorioVisitas = repositorioVisitas;
        }

        public void OnGet()
        {
            VisitaDomiciliaria = repositorioVisitas.GetAll();


        }
    }
}

