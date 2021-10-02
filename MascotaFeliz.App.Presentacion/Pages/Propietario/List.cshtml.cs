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
    public class ListModel : PageModel
    {

        private readonly IRepositorioPropietarios repositorioPropietarios;

        public IEnumerable<PropietarioMascota> PropietarioMascotas { get; set; }

        public ListModel(IRepositorioPropietarios repositorioPropietarios)
        {
            this.repositorioPropietarios = repositorioPropietarios;
        }

        public void OnGet()
        {
            PropietarioMascotas = repositorioPropietarios.GetAll();


        }
    }
}
