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
    public class ListModel : PageModel
    {

        private readonly IRepositorioPropietarios repositorioPropietarios;

        public IEnumerable<PropietarioMascota> PropietarioMascotas { get; set; }

        public ListModel()
        {
            this.repositorioPropietarios = new RepositorioPropietarios (new MascotaFeliz.App.Persistencia.AppContext());
        }

        public void OnGet(string filtroBusqueda)
        {
            PropietarioMascotas = repositorioPropietarios.GetAll();


        }
    }
}

