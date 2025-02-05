using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2025_I_P1_EJERCICIO4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //ESTRUCTURAS DE DECISION
            //IF ELSE
            //SOLICITAR EL PROMEDIO DE UN ALUMNO Y MOSTRARA UN MENSAJE DE APROBADO SI EL PROMEDIO
            //ES MAYOR O IGUAL A 65
            //CASO CONTRARIO MOSTRAR UN MENSAJE CON LA LEYENDA REPROBADO.
            double promedio;
            Console.WriteLine("Ingrese el promedio del alumno: ");
            promedio = double.Parse(Console.ReadLine());
            //== igual
            //>= mayor o igual
            //<= menor o igual
            //!= distinto
            if (promedio >= 65)
                Console.WriteLine($"El Alumno Aprobo con un promedio de {promedio}");
            else
                Console.WriteLine($"El Alumno Reprobo con un promedio de {promedio}");

            //HAGA UN PROGRAMA EN DONDE SOLICITE UNA CLAVE Y SI LA CLAVE ES PI MUESTRE UN MENSAJE DE BIENVENIDO,
            //CASO CONTRARIO MUESTRE UN MENSAJE DE INCORRECTO.
            string clave;
            Console.WriteLine("Ingrese la clave: ");
            clave = Console.ReadLine();
            if (clave == "PI")
                Console.WriteLine("Bienvenido al Sistema");
            else
                Console.WriteLine("Clave Incorrecta");

            Console.ReadLine();
        }
    }
}
