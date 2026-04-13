using System;

namespace ConsoleApp2026_Uno
{
    internal static class Helpers
    {
        // Devuelve un mensaje indicando cuál de los dos números es mayor o si son iguales
        public static string CompararMayores(double a, double b)
        {
            if (a > b)
            {
                return $"{a} es mayor que {b}";
            }
            else if (b > a)
            {
                return $"{b} es mayor que {a}";
            }
            else
            {
                return $"Ambos números son iguales: {a}";
            }
        }
    }
}
