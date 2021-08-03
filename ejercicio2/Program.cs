using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0, n2 = 0, s = 0, r = 0, a2 = 0;
            Console.WriteLine("Ingrese numeros enteros");
            Console.WriteLine(" ");
            Console.WriteLine("Escriba el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el segundo numero");
            n2 = int.Parse(Console.ReadLine());
            s = n1 + n2;
            r = n1 - n2;
            a2 = (n1 * 2) - n2;
            Console.WriteLine("La suma de {0} + {1} = {2}", n1, n2, s);
            Console.WriteLine("La resta de {0} - {1} = {2}", n1, n2, r);
            Console.WriteLine("La operacion de {0}*2 - {1} = {2}", n1, n2, a2);
            Console.ReadKey();
        }
    }
}
