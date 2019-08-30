using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2CS
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            string Nproduc;
            int cantidad;
            decimal precio, subtotal, iva, vpagar;
            Console.Write("Ingrese el nombre del producto a comprar :");
            Nproduc = Console.ReadLine();
            Console.WriteLine("¿Cuantos productos comprará?");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el precio por producto");
            Console.Write("$"); precio = Convert.ToDecimal(Console.ReadLine());
            subtotal = cantidad * precio;
            iva = subtotal * 0.13m;
            vpagar = subtotal + iva;
            Console.WriteLine("Subtotal----------{0}", subtotal.ToString("C2"));
            Console.WriteLine("IVA---------------{0}", iva.ToString("C2"));
            Console.WriteLine("El valo a pagar---{0}", vpagar.ToString("C2"));
            Console.ReadKey();
        }
    }
}
