using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{

    public interface IRepositorioVisitas
    {
        IEnumerable<VisitaDomiciliaria> GetAll();

        VisitaDomiciliaria GetVisitadomiciliariaPorId(int visitadomiciliariaID);
    }
}