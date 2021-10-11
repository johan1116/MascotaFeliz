using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public class RepositorioPropietarios : IRepositorioPropietarios
    {
       static  public List<PropietarioMascota> propietariomascotas;
        public RepositorioPropietarios()
        {
            propietariomascotas = new List<PropietarioMascota>()
            {
                new PropietarioMascota {Id = 1,Documento= 1001526481 ,Nombre = "Johan",Apellidos = "Zuluaga",Telefono = "3504024440",Direccion = "Calle 24 # 19-60"},
                new PropietarioMascota {Id = 2,Documento= 1001526459,Nombre = "Shesman",Apellidos = "Murcia",Telefono = "3504024441",Direccion = "Cubarral"},
                new PropietarioMascota {Id = 3,Documento= 1001526895,Nombre = "Paola",Apellidos = "Padilla",Telefono = "3504024442",Direccion = "Carrera 4 Chia"},
                new PropietarioMascota {Id = 4,Documento= 1001526635,Nombre = "Yuliana",Apellidos = "Riveros",Telefono = "302457882",Direccion = "Carrera 1 Buenos Aires"},
                new PropietarioMascota {Id = 5,Documento= 1001526784,Nombre = "Angelo",Apellidos = "López",Telefono = "3507894512",Direccion = "Carrera 17 -68 suba"}

            };
        }

        public PropietarioMascota Add(PropietarioMascota nuevoPropietario)
        {
            nuevoPropietario.Id=propietariomascotas.Max(np => np.Id)+1;
            propietariomascotas.Add(nuevoPropietario);
            return nuevoPropietario;
        }

        public IEnumerable<PropietarioMascota> GetAll()
        {
            return propietariomascotas;
        }

        public PropietarioMascota GetPropietariomascotaPorId(int propietariomascotasID)
        {
            return propietariomascotas.SingleOrDefault(p => p.Id == propietariomascotasID);
        }

        public PropietarioMascota Update(PropietarioMascota propietarioActualizado)
        {
            var propietario = propietariomascotas.SingleOrDefault(pr => pr.Id == propietarioActualizado.Id);
            if (propietario != null)
            {
                propietario.Documento = propietarioActualizado.Documento;
                propietario.Nombre = propietarioActualizado.Nombre;
                propietario.Apellidos = propietarioActualizado.Apellidos;
                propietario.Telefono = propietarioActualizado.Telefono;
                propietario.Direccion = propietarioActualizado.Direccion;
                
            }
            return propietario;
        }
        
    }
}