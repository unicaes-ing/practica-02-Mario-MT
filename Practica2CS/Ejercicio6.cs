using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2CS
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            DateTime hoy = DateTime.Now, hora = DateTime.Now;
            Console.Write("Hoy es {0} ", hoy.ToString("D"));
            Console.WriteLine("y son las {0}", hora.ToString("hh:mm tt"));
            Console.ReadKey();
        }
    }
}
