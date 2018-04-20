using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Ejercicio_27_Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant = 0, aux, length = 20;
            Queue<int> numeros = new Queue<int>();

            while (cant < length)
            {
                Random xRnd = new Random();
                var xSleep = Stopwatch.StartNew();
                Thread.Sleep(1000);
                xSleep.Stop();
                aux = xRnd.Next(-1000, 1000);
                if (aux != 0)
                {
                    numeros.Enqueue(aux);
                    cant++;
                }
            }

            //MUESTRO LA LISTA ORIGINAL
            Console.WriteLine("Muestro la lista original");
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            //MUESTRO LISTA DESCENDENTE
            Console.WriteLine("Muestro la lista en orden descendente");
            foreach (int i in numeros)
            {
                if (i > 0)
                    Console.WriteLine(i);
            }
            Console.ReadKey();

            //MUESTRO LISTA ASCENDENTE
            Console.WriteLine("Muestro la lista en orden ascendente");
            foreach (int i in numeros)
            {
                if (i < 0)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
