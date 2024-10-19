using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoAgustin
{
    internal class Proyecto_Desarrollo_Web:Proyecto
    {
        public string Nombre { get; set; }
        public EstadoActual Estado { get; set; }
        public int CantidadDeDesarrolladores { get; set; }
        public DateTime FechaDeInicio { get; set; }
        public DateTime FechaEstimada { get; set; }
        public Tecnologias Tecno { get; set; }


        public Proyecto_Desarrollo_Web(string nombre, EstadoActual estado, int cantidadDeDesarrolladores,Tecnologias tecnologia):base(nombre,estado,cantidadDeDesarrolladores)
        {
            Nombre = nombre;
            Estado = estado;
            CantidadDeDesarrolladores = cantidadDeDesarrolladores;
            FechaDeInicio = DateTime.Now;
            FechaEstimada = DateTime.Now;
            Tecno = tecnologia;
        }
        public string ToString()
        {
            return $"Nombre:{Nombre},Estado:{Estado},N°desarrolladores:{CantidadDeDesarrolladores}," +
                $"Fecha de inicio:{FechaDeInicio},Fecha estimada:{FechaEstimada},Tecnologia:{Tecno}";
        }

    }

}
