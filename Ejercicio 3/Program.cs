using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseC C = new ClaseC();
            
        }
    }
    public class ClaseA
    {
        public ClaseA(){
            Console.WriteLine("Hola, Soy Clase A");
        }
    }
    public class ClaseB : ClaseA
    {
        public ClaseB(){
            Console.WriteLine("Hola, Soy Clase B");
        }
    }
    public class ClaseC : ClaseB
    {
        public ClaseC(){
            Console.WriteLine("Hola, Soy Clase C");
        }
    }
}
