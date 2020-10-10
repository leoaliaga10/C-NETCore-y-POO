using System;

namespace CoreEscuela
{
    class Escuela
    {
        public string nombre;
        public string direccion;
        public int fundacion;
        public string ceo;
        public void Timbrar()
        {
            //Console.Beep(2000,3000);
            Console.WriteLine("SALIR A RECREO");
        }
    }
    class Program
    {
        //metodo que se ejecuta al iniciar la aplicacion
        static void Main(string[] args)
        {
            var miEscuela = new Escuela();
            miEscuela.nombre = "Cristo Rey";
            miEscuela.direccion = "Jr. Angamos";
            miEscuela.fundacion = 1953;
            Console.WriteLine("Timbre");
            miEscuela.Timbrar();
            //Console.WriteLine("Hello World!");
        }
    }
}
