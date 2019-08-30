using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2CS
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            int numcel;
            TimeSpan Ttrans;
            DateTime horaI, horaF;
            decimal Vmin, VPLL;
            Console.WriteLine("Ingrese su número de telefono:");
            numcel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese la hora de inicio de la llamada:");
            horaI = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese la hora de finalización:");
            horaF = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese el valor por minuto:");
            Console.Write("$"); Vmin = Convert.ToDecimal(Console.ReadLine());
            Ttrans = horaF - horaI;
            string horat = Ttrans.Minutes.ToString();
            decimal MT = Convert.ToDecimal(horat);
            VPLL = MT * Vmin;
            Console.WriteLine("los minutos transcurridos fueron: "+ horat);
            Console.WriteLine("El total a pagar por su llamada es: {0}", VPLL.ToString("C2"));
            Console.ReadKey();
        }
    }
}
