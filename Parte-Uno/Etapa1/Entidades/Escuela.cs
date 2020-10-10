using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        public string UniqueID { get; private set; } = Guid.NewGuid().ToString();
        string nombre;
        //ENCAPSULAR en una propiedad
        public string Nombre{
            get{return nombre;}
            set {nombre = value.ToUpper();}
        }
        //Lo mismo pero en la forma corta
        public int AnoDeCreacion{get;set;}

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela{get; set;}
        public List<Curso> Cursos{get; set;}

        //CONSTRUCTOR es un metodo mas basico de una clase
        //public Escuela(string nombre, int ano)
        //{
            //this quiere decir que es miembro de la clase
          //  this.nombre=nombre;
          //  AnoDeCreacion=ano;
        //}
         public Escuela(string nombre, int ano)=> (Nombre,AnoDeCreacion)=(nombre,ano);

        public Escuela(string nombre, int ano, 
        TiposEscuela tipos, string pais="", 
        string ciudad="")
        {
            //Asiganaciones
            (Nombre,AnoDeCreacion)=(nombre,ano);
            Pais = pais;
            Ciudad = ciudad;
        }

        

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} \n Pais: {Pais}, {System.Environment.NewLine}Ciudad: {Ciudad}";
        }
    }
}
