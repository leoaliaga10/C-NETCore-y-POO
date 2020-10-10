using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using CoreEscuela.App;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.writeTitle("Bienvenidos a la Escuela");
            ImprimirCursosEscuela(engine.Escuela);
        }
        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.writeTitle("Cursos de la Escuela");
            Printer.DibujarLinea(24);
            if (escuela != null){
                if (escuela?.Cursos == null){ // este signo de interrogacion significa que si escula es null ya no verifica cursos asiendo la linea 42 innecesaria
                    return; 
                }
                else{
                    WriteLine(escuela.Nombre);
                    foreach (var curso in escuela.Cursos)
                    {
                        Console.WriteLine($"Nombre Curso: {curso.Nombre}, ID: {curso.UniqueID}");
                        foreach (var asignatura in curso.Asignaturas)
                        {
                            Console.WriteLine($"Nombre Asignatura: {asignatura.Nombre}, IDA: {asignatura.UniqueID}");
                        }
                    }
                }
            }
        }
    }
}
