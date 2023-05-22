using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true){
            //    Console.Write("Ingrese un numero: ");
            //    int num = 0;
            //    try
            //    {
            //        num = Convert.ToInt32(Console.ReadLine());
            //    }
            //    catch
            //    {
            //        Console.WriteLine("El caracter ingresado no es valido");
            //        break;
            //    }

            //    if (analizarNumero.analizarPrimo(num))
            //        Console.WriteLine("El numero es primo");
            //    else
            //        Console.WriteLine("El numero no es primo");
            //}
            int cant = 0;
            for (int i = 9_999; i < 100_000; i++) 
            {
                if (analizarNumero.analizarPrimo(i))
                {
                    cant++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Cantidad de primos: " + cant);
        }
    }
}

