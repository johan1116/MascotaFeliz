using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;


namespace MascotaFeliz.App.Persistencia
{

    public class RepositorioVisitas : IRepositorioVisitas

    {
        public readonly AppContext _appContext;
        
        public RepositorioVisitas(AppContext appContext)
        {
            _appContext = appContext;
        }

        VisitaDomiciliaria IRepositorioVisitas.Add(VisitaDomiciliaria nuevaVisita)
        {
            var visita = _appContext.VisitaDomiciliaria.Add(nuevaVisita);
            _appContext.SaveChanges();
            return visita.Entity;
        }

        public IEnumerable<VisitaDomiciliaria> GetAll()
        {
            return _appContext.VisitaDomiciliaria;
        }
        VisitaDomiciliaria IRepositorioVisitas. GetVisitadomiciliariaPorId(int idVisitadomiciliaria)
        {
            return _appContext.VisitaDomiciliaria.FirstOrDefault(v => v.Id == idVisitadomiciliaria);
        }

        VisitaDomiciliaria IRepositorioVisitas.Update(VisitaDomiciliaria visitaActualizada)
        {
            var visita = _appContext.VisitaDomiciliaria.FirstOrDefault(r => r.Id == visitaActualizada.Id);
            if (visita != null)
            {
                visita.FechaHora = visitaActualizada.FechaHora;
                visita.Temperatura = visitaActualizada.Temperatura;
                visita.Peso = visitaActualizada.Peso;
                visita.FRespiratoria = visitaActualizada.FRespiratoria;
                visita.FCardiaca = visitaActualizada.FCardiaca;
                visita.EstadoAnimo = visitaActualizada.EstadoAnimo;
                visita.Recomendacion = visitaActualizada.Recomendacion;

                _appContext.SaveChanges();
            }
            return visita;
        }

        void IRepositorioVisitas.DeleteVisita(int idVisitadomiciliaria)
        {
            var visitaEncontrada = _appContext.VisitaDomiciliaria.FirstOrDefault(vde => vde.Id == idVisitadomiciliaria);
            if (visitaEncontrada == null)
            {
                return;
            }
            else
            {
                _appContext.VisitaDomiciliaria.Remove(visitaEncontrada);
                _appContext.SaveChanges();
            }

        }
       
    }
}