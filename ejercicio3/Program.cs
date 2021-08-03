using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, div;
            Console.WriteLine(" Ingrese numeros enteros");
            Console.WriteLine("  ");
            Console.WriteLine(" Escriba el primer numero");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Escriba el segundo numero");
            n2 = double.Parse(Console.ReadLine());
            if (n2 == 0)
            {
                Console.WriteLine(" Error: no se puede dividir entre cero");
            }
            else
            {
                div = n1 / n2; 
                Console.WriteLine(" La division de {0} / {1} = {2}", n1, n2, div);
            }
            Console.ReadKey();

        }
    }
}
     