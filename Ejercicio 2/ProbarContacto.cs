using System;

namespace Ejercicio_2
{
    class ProbarContacto
    {
        static void Main(string[] args)
        {
            Contacto c = new Contacto();
            c.setContacto("Manuel", "Perez", "8098784875", "Las Americas");
            Console.WriteLine(c.Saludar());
        }
    }

    public class Contacto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public void setContacto(string Nombre, string Apellido, string Telefono, string Direccion)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
        }

        public string Saludar()
        {
            return "Hola, Mi nombre es " + Nombre + " " + Apellido + "\n" +
                    "Telefono: " + Telefono + "\n" +
                    "Direccion: " + Direccion + "";
        }
    }
}
