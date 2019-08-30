using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2CS
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            decimal VDPA, TPA;
            TimeSpan DiasTans;
            DateTime FechaI, FechaD;
            Console.WriteLine("Ingrese la fecha de inicio:");
            FechaI = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de devolución:");
            FechaD = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese el valor a pagar por dia:");
            Console.Write("$"); VDPA = Convert.ToDecimal(Console.ReadLine());
            DiasTans = FechaD - FechaI;
            string Dias = DiasTans.Days.ToString();
            decimal TDias = Convert.ToDecimal(Dias);
            TPA = TDias * VDPA;
            Console.WriteLine("Los dias transcurrridos son :"+  Dias);
            Console.WriteLine("El total a cancelar por su alquiler es: {0}", TPA.ToString("C2"));
            Console.ReadKey();
        }
    }
}