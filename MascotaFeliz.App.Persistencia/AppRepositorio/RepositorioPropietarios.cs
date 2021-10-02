using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public class RepositorioPropietarios : IRepositorioPropietarios
    {
        List<PropietarioMascota> propietariomascotas;
        public RepositorioPropietarios()
        {
            propietariomascotas = new List<PropietarioMascota>()
            {
                new PropietarioMascota {Id=0,Nombre = "Nombre",Apellidos = "Apellidos",Telefono = "Telefono",Direccion = "Direccion"},
                new PropietarioMascota {Id = 1001526481,Nombre = "Johan",Apellidos = "Zuluaga",Telefono = "3504024440",Direccion = "Calle 24 # 19-60"},
                new PropietarioMascota {Id = 1001526482,Nombre = "Shesman",Apellidos = "Murcia",Telefono = "3504024441",Direccion = "Cubarral"},
                new PropietarioMascota {Id = 1001526483,Nombre = "Paola",Apellidos = "Padilla",Telefono = "3504024442",Direccion = "Carrera 4 Chia"},
                new PropietarioMascota {Id = 1010189577,Nombre = "Yuliana",Apellidos = "Riveros",Telefono = "302457882",Direccion = "Carrera 1 Buenos Aires"},
                new PropietarioMascota {Id = 1001526483,Nombre = "Angelo",Apellidos = "López",Telefono = "3507894512",Direccion = "Carrera 17 -68 suba"}


            };
        }
        public IEnumerable<PropietarioMascota> GetAll()
        {
            return propietariomascotas;
        }
    }
}