using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double cen, far;
            Console.WriteLine(" Grados Centigrados a Farenheit");
            Console.WriteLine(" ");
            Console.WriteLine(" Ingrese los grados Centigrados ");
            cen = double.Parse(Console.ReadLine());

            far = cen * 1.8 + 32;
            Console.WriteLine(" ");
            Console.WriteLine(cen +"°" + " Grados Centigrados es igual a : " + far + "°" + " Grados Farenheit");
            Console.ReadKey();
        }
         
    }
              
}
