using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia.AppRepositorios
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
       static public List<Veterinario> veterinarios;
        public RepositorioVeterinario()
        {
            veterinarios = new List<Veterinario>()
            {
                new Veterinario {Id = 1,Documento= 1001526521 ,Nombre = "Simon",Apellidos = "Zuluaga",Telefono = "3504024487",TarjetaProfesional="2525VMF"},
                new Veterinario {Id = 2,Documento= 1001526365,Nombre = "Juan",Apellidos = "Murcia",Telefono = "3504024485",TarjetaProfesional="1415VMF"},
                new Veterinario {Id = 3,Documento= 1001526415,Nombre = "Andrea",Apellidos = "Padilla",Telefono = "3504024496",TarjetaProfesional="3652VMF"},
                new Veterinario {Id = 4,Documento= 1001526748,Nombre = "Natalia",Apellidos = "Riveros",Telefono = "302457847",TarjetaProfesional="9854VMF"},
                new Veterinario {Id = 5,Documento= 1001526352,Nombre = "Manuel",Apellidos = "López",Telefono = "3507894532",TarjetaProfesional="1528VMF"}

            };
        }
        

        IEnumerable<Veterinario> IRepositorioVeterinario.GetAll()
        {
            return veterinarios;
        }
        public Veterinario GetVeterinarioPorId(int veterinarioID)
        {
            return veterinarios.SingleOrDefault(ve => ve.Id == veterinarioID);
        }
    }
}