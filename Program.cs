using System;

namespace Estudiante
{
    public class Program  
    {
        public static void Main(string[] args)
        {
            Estudiante[] listadoEstudiantes = new Estudiante [7];
            int cont = 0;
            while (cont <5 )
            {
                //ingreso de datos personales
                Console.WriteLine("Ingrese su Nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("Ingrese su Edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Ingrese su Carnet: ");
                string carnet = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("Indique si esta solvente: ");
                bool solvente = Boolean.Parse(Console.ReadLine());
                Console.WriteLine("");

                //ingreso de notas del curso
                Console.WriteLine("Bienvenido al curso de Programación");
                Console.WriteLine("Ingrese nota del primer parcial: ");
                int nota1 = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Ingrese nota del segundo parcial: ");
                int nota2 = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Ingrese nota del parcial final : ");
                int nota3 = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                //instancia estudiantes 
                Estudiante estudiantes = new  Estudiante(nombre, edad, carnet, solvente, nota1, nota2, nota3);
                listadoEstudiantes[cont] = estudiantes;
                cont ++;
            }
            Console.WriteLine("");
            Console.WriteLine("──────LISTADO─────");
            Console.WriteLine("");
            for(int est = 0; est < 5; est ++)
            {
                //resultados impresos en una lista 
                Estudiante estudiantes = listadoEstudiantes[est];
                Console.WriteLine("Nombre del Estudiante: " + estudiantes.nombre);
                Console.WriteLine("Carnet del Estudiante: " + estudiantes.carnet);
                Console.WriteLine("El estudiante esta solvente: " + estudiantes.solvente);
                Console.WriteLine("su nota del primer parcial es: " + estudiantes.nota1);
                Console.WriteLine("su nota del segundo parcial es: " + estudiantes.nota2);
                Console.WriteLine("su nota del parcial final es: " + estudiantes.nota3);
                Console.WriteLine("su nota del final es de: " + (estudiantes.nota1 + estudiantes.nota2 + estudiantes.nota3));
                Console.WriteLine("");
            }
        }
    }
}

