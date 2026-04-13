using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2026_Uno
{
    internal class Alumno:Persona
    {
        public required string Email{ get; set; }
        public int Legajo { get; set; }
        public string? Materia { get; set; } 


        public string Datos()
        {
            string retorno = "";
            retorno = base.Datos() + " " + Legajo + " " + Materia;
            return retorno;
        }
    }
}
