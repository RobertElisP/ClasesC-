using System;

namespace Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            persona m = new persona();
            m.Cedula = "20145478745-1";
            m.Nombre = "Juan";
            m.Apellido = "Miranda";
            m.Edad = 20;
            Console.WriteLine(m.MostrarDato());
            Console.WriteLine("-----------------------------");
            Profesor p = new Profesor();
            p.Cedula = "001-0000000-1";
            p.Nombre = "Raul";
            p.Apellido = "Zapata";
            p.Edad = 40;
            p.Sueldo =20000;
            Console.WriteLine(p.ImprimirSueldo());




        }
    }

    public class persona {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public string MostrarDato() {

            return "Hola, Mi nombre es " + Nombre + " " + Apellido + "\n" +
                    "Cedula: " + Cedula + "\n" +
                    "Edad: " + Edad + "";
        }
    }

    public class Profesor:persona {
        public decimal Sueldo { get; set; }

        public string ImprimirSueldo() {

            return "Hola, Soy el Profesor " + Nombre + " " + Apellido + "\n" +
                    "Cedula: " + Cedula + "\n" +
                    "Edad: " + Edad + "\n" +
                    "Sueldo: " + Sueldo + ""; 
        }
    }

   

}
