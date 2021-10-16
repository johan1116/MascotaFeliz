using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;


namespace MascotaFeliz.App.Persistencia
{
    
    public interface IRepositorioVisitas
    {
        IEnumerable<VisitaDomiciliaria> GetAll();

        VisitaDomiciliaria GetVisitadomiciliariaPorId(int idVisitadomiciliaria);

        VisitaDomiciliaria Update (VisitaDomiciliaria visitaActualizada);

        VisitaDomiciliaria Add(VisitaDomiciliaria nuevaVisita);

        void DeleteVisita (int idVisitadomiciliaria);
    }
}