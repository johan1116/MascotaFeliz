
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public class RepositorioMascota : IRepositorioMascotas
    {
        static public List<Mascota> mascotas;
        public RepositorioMascota()
        {
            mascotas = new List<Mascota>()
            {/*
                new Mascota {Id = 1,NombreMascota="Pulgas",Caracteristicas="muy pulgoso",PropietarioMascota=RepositorioPropietarios.propietariomascotas[0],TipoMascota=TipoMascota.Canino},
                new Mascota {Id = 2,NombreMascota="Firulais",Caracteristicas="muy limpio",PropietarioMascota=RepositorioPropietarios.propietariomascotas[1],TipoMascota=TipoMascota.Felino},
                new Mascota {Id = 3,NombreMascota="Dante",Caracteristicas="negro con manchas cafes",PropietarioMascota=RepositorioPropietarios.propietariomascotas[2],TipoMascota=TipoMascota.Felino},
                new Mascota {Id = 4,NombreMascota="Coco",Caracteristicas="cafe con blanco",PropietarioMascota=RepositorioPropietarios.propietariomascotas[3],TipoMascota=TipoMascota.Canino},
                new Mascota {Id = 5,NombreMascota="canario",Caracteristicas="plumas verdes y azules",PropietarioMascota=RepositorioPropietarios.propietariomascotas[4],TipoMascota=TipoMascota.Otras}*/
                
                new Mascota {Id = 1,NombreMascota="Pulgas",Caracteristicas="muy pulgoso",TipoMascota=TipoMascota.Canino},
                new Mascota {Id = 2,NombreMascota="Firulais",Caracteristicas="muy limpio",TipoMascota=TipoMascota.Felino},
                new Mascota {Id = 3,NombreMascota="Dante",Caracteristicas="negro con manchas cafes",TipoMascota=TipoMascota.Felino},
                new Mascota {Id = 4,NombreMascota="Coco",Caracteristicas="cafe con blanco",TipoMascota=TipoMascota.Canino},
                new Mascota {Id = 5,NombreMascota="canario",Caracteristicas="plumas verdes y azules",TipoMascota=TipoMascota.Otras},
            };
        }

        public IEnumerable<Mascota> GetAll()
        {
            return mascotas;
        }

        public Mascota GetMascotaPorId(int mascotaID)
        {
            return mascotas.SingleOrDefault(m => m.Id == mascotaID);
        }
    }
}