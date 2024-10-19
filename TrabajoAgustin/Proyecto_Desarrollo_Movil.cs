using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoAgustin
{
    internal class Proyecto_Desarrollo_Movil:Proyecto
    {
        public string Nombre { get; set; }
        public EstadoActual Estado { get; set; }
        public int CantidadDeDesarrolladores { get; set; }
        public DateTime FechaDeInicio { get; set; }
        public DateTime FechaEstimada { get; set; }
        public Plataformas Plataforma { get; set; }


        public Proyecto_Desarrollo_Movil(string nombre, EstadoActual estado, int cantidadDeDesarrolladores, Plataformas plataforma) : base(nombre, estado, cantidadDeDesarrolladores)
        {
            Nombre = nombre;
            Estado = estado;
            CantidadDeDesarrolladores = cantidadDeDesarrolladores;
            FechaDeInicio = DateTime.Now;
            FechaEstimada = DateTime.Now;
            Plataforma = plataforma;
        }
        public string ToString()
        {
            return $"{Nombre},{Estado},{CantidadDeDesarrolladores},{FechaDeInicio},{FechaEstimada},{Plataforma}";
        }


    }
}
