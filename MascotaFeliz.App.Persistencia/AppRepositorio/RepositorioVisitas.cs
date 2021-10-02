using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public class RepositorioVisitas : IRepositorioVisitas
    {
        List<VisitaDomiciliaria> visitadomiciliarias;
        public RepositorioVisitas()
        {
            visitadomiciliarias = new List<VisitaDomiciliaria>()
            {
                new VisitaDomiciliaria {Id = 1001526254, FechaHora=new System.DateTime(2021, 8, 13, 8, 30, 52), Temperatura=41, Peso= 5, FRespiratoria=17, FCardiaca=100, EstadoAnimo= EstadoAnimo.Regular , Recomendacion="Mucho reposo e hidratación constante" },
                new VisitaDomiciliaria {Id = 1001526325, FechaHora=new System.DateTime(2021, 8, 24, 10, 40, 20), Temperatura=38, Peso= 7, FRespiratoria=17, FCardiaca=92, EstadoAnimo= EstadoAnimo.Bueno , Recomendacion="Ninguna"},
                new VisitaDomiciliaria {Id = 1001526887, FechaHora=new System.DateTime(2021, 9, 17, 12, 50, 15), Temperatura=41, Peso= 9, FRespiratoria=14, FCardiaca=85, EstadoAnimo= EstadoAnimo.Malo , Recomendacion="Internarlo por una semana para observación"},
                new VisitaDomiciliaria {Id = 1001526967, FechaHora=new System.DateTime(2021, 9, 28, 17, 45, 50), Temperatura=41, Peso= 7, FRespiratoria=16, FCardiaca=96, EstadoAnimo= EstadoAnimo.Bueno , Recomendacion="Ninguna"},
                new VisitaDomiciliaria {Id = 1001526991, FechaHora=new System.DateTime(2021, 10, 1, 22, 15, 45), Temperatura=39, Peso= 6, FRespiratoria=19, FCardiaca=102, EstadoAnimo= EstadoAnimo.Regular , Recomendacion="Suministrar medicamento cada 8 horas"}
            };
        }
        public IEnumerable<VisitaDomiciliaria> GetAll()
        {
            return visitadomiciliarias;
        }
    }
}