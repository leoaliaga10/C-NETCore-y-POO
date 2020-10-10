using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using System.Linq;

namespace CoreEscuela.App
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
           
        }
        public void Inicializar()
        {
            Escuela = new Escuela("J. F. KENNEDY", 1953, TiposEscuela.Primaria,
            ciudad: "Cajamarca", pais: "Perú");

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.Cursos)
        {
            foreach (var asignatura in curso.Asignaturas) 
            {
                foreach (var alumno in curso.Alumnos)
                {
                    List<Evaluaciones> evaluaciones = new List<Evaluaciones>();
                    for (int i = 1; i <= 5; i++){
                        Random random = new Random();
                        evaluaciones.Add(new Evaluaciones() { Nombre       = "Parcial " + i, 
                                                            Asignatura   = asignatura, 
                                                            Nota = (float) (5 * random.NextDouble())});
                    }
                    alumno.Evaluaciones = evaluaciones;
                 }
            }
        }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura{Nombre = "Matematica"},
                    new Asignatura{Nombre = "Fisica"},
                    new Asignatura{Nombre = "Castellano"},
                    new Asignatura{Nombre = "Ciencias"},
                    new Asignatura{Nombre = "Ingles"},
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };
            //LINQ 
            var listaAlumnos =  from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                                select new Alumno{ Nombre=$"{n1} {n2} {a1}" };
            
            return listaAlumnos.OrderBy( (al)=> al.UniqueID ).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>()
            {
                                new Curso()
                                {
                                    Nombre="101",
                                    Jornada = TiposJornada.Mañana,
                                },
                                new Curso()
                                {
                                    Nombre="102",
                                    Jornada = TiposJornada.Mañana,
                                },
                                new Curso()
                                {
                                    Nombre="103",
                                    Jornada = TiposJornada.Mañana,
                                },
                                new Curso()
                                {
                                    Nombre="104",
                                    Jornada = TiposJornada.Tarde,
                                },
                                new Curso()
                                {
                                    Nombre="105",
                                    Jornada = TiposJornada.Tarde,
                                }

            };
            Random rnd = new Random();
            
            foreach (var c in Escuela.Cursos)
            {
                int cantRandom = rnd.Next(5,20);
                c.Alumnos = GenerarAlumnosAlAzar(cantRandom);
            }
        }
    }
}
