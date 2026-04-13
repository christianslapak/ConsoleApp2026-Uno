//Console.WriteLine("Hello, World!");
using ConsoleApp2026_Uno;

Persona p = new Persona();

p.DNI = 34908610;
p.Nombre = "Alejandro";
p.Apellido = "Alvarez";

Console.WriteLine(p.Datos());
Console.ReadKey();


Alumno a = new Alumno();
a.DNI = 41109152;
a.Nombre = "Martina";
a.Apellido = "Vazquez";
a.Legajo = 302058;
a.Materia = "Bases de Datos";

Console.WriteLine(a.Datos());
Console.ReadKey();


