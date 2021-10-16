using Microsoft.EntityFrameworkCore;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia 
{
    public class AppContext: DbContext
    {
        public DbSet <Persona> Persona{get;set;}
        public DbSet <Veterinario> Veterinario{get;set;}
        public DbSet <PropietarioMascota> PropietarioMascota{get;set;}
        public DbSet <Mascota> Mascota{get;set;}
        public DbSet <VisitaDomiciliaria> VisitaDomiciliaria{get;set;}
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {       
            if(!optionsBuilder.IsConfigured) 
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =MascotaFelizData");
                //COMENTARIO
                
            }
        }
    }
}        
