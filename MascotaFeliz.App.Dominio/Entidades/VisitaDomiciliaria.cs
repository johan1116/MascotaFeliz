using System;
namespace MascotaFeliz.App.Dominio
{
    public class VisitaDomiciliaria
    {
        public int Id { get; set; }
        public Veterinario Veterinario { get; set; }
        public Mascota Mascota { get; set; }
        public DateTime FechaHora { get; set; }
        public float Temperatura { get; set; }
        public float Peso { get; set; }
        public float FRespiratoria { get; set; }
        public float FCardiaca { get; set; }
        public EstadoAnimo EstadoAnimo { get; set; }
        public string Recomendacion { get; set; }

    }

}