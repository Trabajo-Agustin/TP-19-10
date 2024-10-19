using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoAgustin
{
    abstract class Proyecto
    {
        public string Nombre { get; set; }
        public EstadoActual Estado { get; set; }
        public int CantidadDeDesarrolladores { get; set; }
        public DateTime FechaDeInicio { get; set; }
        public DateTime FechaEstimada { get; set; }


        public  Proyecto(string nombre, EstadoActual estado, int cantidadDeDesarrolladores)
        {
            Nombre = nombre;
            Estado = estado;
            CantidadDeDesarrolladores = cantidadDeDesarrolladores;
            FechaDeInicio = DateTime.Now;
            FechaEstimada = CalcularFechastima();

        }
       public DateTime CalcularFechastima()
        {

        }
        public string ToString()
        {
            return $"{Nombre},{Estado},{CantidadDeDesarrolladores},{FechaDeInicio},{FechaEstimada}";
        }
    }
}
