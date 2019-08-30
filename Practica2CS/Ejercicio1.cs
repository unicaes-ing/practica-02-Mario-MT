using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2CS
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            nombre = nombre.Replace("a", "#");
            nombre = nombre.Replace("e", "%");
            nombre = nombre.Replace("i", "$");
            nombre = nombre.Replace("o", "?");
            nombre = nombre.Replace("u", "*");
            nombre = nombre.Replace("A", "#");
            nombre = nombre.Replace("E", "%");
            nombre = nombre.Replace("I", "$");
            nombre = nombre.Replace("O", "?");
            nombre = nombre.Replace("U", "*");
            nombre = nombre.Replace("á", "#");
            nombre = nombre.Replace("é", "%");
            nombre = nombre.Replace("í", "$");
            nombre = nombre.Replace("ó", "?");
            nombre = nombre.Replace("ú", "*");
            nombre = nombre.Replace("Á", "#");
            nombre = nombre.Replace("É", "%");
            nombre = nombre.Replace("Í", "$");
            nombre = nombre.Replace("Ó", "?");
            nombre = nombre.Replace("Ú", "*");
            Console.WriteLine("");
            Console.WriteLine(" su nombre es: "+ nombre);
            Console.ReadKey();
        }
    }
}
