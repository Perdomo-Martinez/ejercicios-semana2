using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //todos los productos tendran un impuesto del 15%

            Int32 co = 1, be = 2, za = 3, du = 4, me = 5, num;
            string nom;
            double pre,total,totalf;
            /*1= Comida
            2= Bebidas
            3= Zapatos 
            4= Dulces 
            5=Medicina*/

            Console.WriteLine("Lista de Productos: ");

            Console.WriteLine(" Comida  ");
            Console.WriteLine(" Bebidas  ");
            Console.WriteLine(" Zapatos  ");
            Console.WriteLine(" Dulces ");
            Console.WriteLine(" Medicina ");
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese el nombre del producto :");
            nom = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine(" 1= Comida  ");
            Console.WriteLine(" 2= Bebidas  ");
            Console.WriteLine(" 3= Zapatos  ");
            Console.WriteLine(" 4= Dulces ");
            Console.WriteLine(" 5= Medicina ");
            Console.WriteLine(" ");
            Console.WriteLine("Escriba el Numero de producto: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Escriba el precio del producto: ");
            pre = double.Parse(Console.ReadLine());
            if (num == me)
            {
                Console.WriteLine("El impuesto del producto Mediciana es de 0% ");
                Console.WriteLine("El precio total de su compra es de: " + "$" + pre );
            }
            else
            {
                total = pre * 0.15;
                totalf = pre + total;
                Console.WriteLine("El impuesto del producto " + nom + " es del 15% ");
                Console.WriteLine("El impuesto del producto es: " + "$" + total );
                Console.WriteLine("El precio total de su compra es de: " + "$" + totalf  );

            }
            Console.ReadKey();
        }
        
    }
}
