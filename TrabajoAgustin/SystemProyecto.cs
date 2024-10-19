using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoAgustin
{
    static public class SystemProyecto
    {
        static List<Proyecto_Desarrollo_Movil> Desarrollo_Movil = new();
        static List<Proyecto_Desarrollo_Web> Desarrollo_Web = new();
        static List<Proyecto> proyectos = new();
        static readonly string DesarrolloWeb = "Desarrollo_Web.txt";
        static readonly string DesarrolloMovil = "Desarrollo_Movil.txt";
        static void CrearProyecto_Web()
        {
            Console.WriteLine("ingrese el nombre del proyecto");
            string Nombre = Console.ReadLine();
            Console.WriteLine("ingrese el estado del proyecto\n" +
                "1.PLanificacion\n" +
                "2.En Desarrollo\n" +
                "3.En Prueba\n" +
                "4.Completado\n" +
                "5.Cancelado\n");
            int Opcion = int.Parse(Console.ReadLine());
            EstadoActual elegirEstado = (EstadoActual)Opcion;
            Console.WriteLine("ingrese la cantidad de desarrolladores");
            int CantidadDeDesarrolladores = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la tecnologia que se usara en ele proyecto\n" +
                "1.React\n" +
                "2.Angular\n" +
                "3.Vue.Js");
            int Tecnologia = int.Parse(Console.ReadLine());
            Tecnologias tecno = (Tecnologias)Tecnologia;
            Proyecto_Desarrollo_Web desarrolloWEb = new Proyecto_Desarrollo_Web(Nombre, elegirEstado, CantidadDeDesarrolladores, tecno);
            Desarrollo_Web.Add(desarrolloWEb);

        }
        static void CrearProyecto_Mobil()
        {
            Console.WriteLine("ingrese el nombre del proyecto");
            string Nombre = Console.ReadLine();
            Console.WriteLine("ingrese el estado del proyecto\n" +
                "1.PLanificacion\n" +
                "2.En Desarrollo\n" +
                "3.En Prueba\n" +
                "4.Completado\n" +
                "5.Cancelado\n");
            int Opcion = int.Parse(Console.ReadLine());
            EstadoActual elegirEstado = (EstadoActual)Opcion;
            Console.WriteLine("ingrese la cantidad de desarrolladores");
            int CantidadDeDesarrolladores = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la tecnologia que se usara en ele proyecto\n" +
                "1.Ios\n" +
                "2.Android\n" +
                "3.Windows Phone");
            int Plataforma = int.Parse(Console.ReadLine());
            Plataformas tecno = (Plataformas)Plataforma;
            Proyecto_Desarrollo_Movil desarrolloMovil = new Proyecto_Desarrollo_Movil(Nombre, elegirEstado, CantidadDeDesarrolladores, tecno);
            Desarrollo_Movil.Add(desarrolloMovil);
        }
        public static void GuardarProyectosmovil()
        {
            using (StreamWriter writer = new StreamWriter(DesarrolloMovil))
            {
                foreach (var Proyecto in Desarrollo_Movil)
                {
                    writer.WriteLine($"{Proyecto.Nombre},{Proyecto.Plataforma},{Proyecto.CantidadDeDesarrolladores},{Proyecto.Estado},{Proyecto.FechaDeInicio},{Proyecto.FechaEstimada}");
                }
            }
            Console.WriteLine("Proyecto Movile  guardado correctamente");
        } 
        public static void GuardarProyectoWeb()
        {
            using (StreamWriter writer = new StreamWriter(DesarrolloWeb))
            {
                foreach (var Proyecto in Desarrollo_Web)
                {
                    writer.WriteLine($"{Proyecto.Nombre},{Proyecto.Tecno},{Proyecto.CantidadDeDesarrolladores},{Proyecto.Estado},{Proyecto.FechaDeInicio},{Proyecto.FechaEstimada}");
                }
            }
            Console.WriteLine("Proyecto Movile  guardado correctamente");
        }
    }
}
