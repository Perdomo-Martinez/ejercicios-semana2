using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double pri, se, ter, a, b, c, nf;

            Console.WriteLine("Calcular nota de Estudiante");
            Console.WriteLine("Ingrese la primer nota del estudiante equivalente a 30%");
            pri = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota del estudiante equivalente a 35%");
            se = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota del estudiante equivalente a 25%");
            ter = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Notas ingresadas: ");
            Console.WriteLine("Primer nota : "+ pri );
            Console.WriteLine("Segunda nota : " + se);
            Console.WriteLine("Tercer nota : " + ter);

            a = pri * 0.30;
            b = se * 0.35;
            c = ter * 0.25;
            Console.WriteLine(" ");
            Console.WriteLine("Notas con el porcentaje aplicado ");
            Console.WriteLine("Primer nota: "+ a);
            Console.WriteLine("Segunda nota: "+ b);
            Console.WriteLine("Tercer nota: "+ c);

            nf = a + b + c;

            Console.WriteLine(" ");
            Console.WriteLine("Nota Final : ");
            Console.Write("La nota final es  : " + nf);
            Console.ReadKey();

        }
        
          
    }
}
 