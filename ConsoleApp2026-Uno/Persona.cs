using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp2026_Uno
{
    internal class Persona
    {
        public int DNI { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }

        public string Datos()
        {
            string retorno = "";
            retorno = "Los datos son: " + DNI + " " + Apellido + " " + Nombre;
            return retorno;
        }
    }
}
