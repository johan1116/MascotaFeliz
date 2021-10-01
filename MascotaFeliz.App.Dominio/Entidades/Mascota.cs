using System;

namespace MascotaFeliz.App.Dominio
{
    public class Mascota
    {
        public int Id { get; set; }
        public string NombreMascota { get; set; }
        public string Caracteristicas { get; set; }
        public PropietarioMascota PropietarioMascota { get; set; }
        public TipoMascota TipoMascota { get; set; }
    }
}