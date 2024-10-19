using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoAgustin
{
    internal class Proyecto_Desarrollo_Movil:Proyecto
    {
        private string _nombre;
        private EstadoActual _estado;
        private int _cantidadDeDesarrolladores;
        private DateTime _fechaDeInicio;
        private DateTime _fechaEstimada;
        private Plataformas _plataforma;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public EstadoActual Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public int CantidadDeDesarrolladores
        {
            get { return _cantidadDeDesarrolladores; }
            set { _cantidadDeDesarrolladores = value; }
        }
        public DateTime FechaDeInicio
        {
            get { return _fechaDeInicio; }
            set { _fechaDeInicio = value; }
        }
        public DateTime FechaEstimada
        {
            get { return _fechaEstimada; }
            set { _fechaEstimada = value; }
        }
        public Plataformas Plataforma
        {
            get { return _plataforma; }
            set { _plataforma = value; }
        }
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
