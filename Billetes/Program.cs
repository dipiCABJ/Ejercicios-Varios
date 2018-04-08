using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Pesos xPesosE = new Pesos(28.65D, 21F);
            Pesos xPesosD = new Pesos(45D, 21F);
            Euro xEuro = new Euro(1D, 0.7330F);
            Euro xEuro2 = new Euro(2D, 0.7330F);
            Dolar xDolar = new Dolar(2D, 1F);
            Dolar xDolar2 = new Dolar(2.7286D, 1F);

            Dolar restaD = xDolar2 - xEuro;
            Dolar restaE = xDolar - xPesosD; 
            //bool xresult = xPesosE != xEuro;

            //xEuro = (Pesos)xEuro;
            //xDolar = (Pesos)xDolar;
            //xPesosE = (Pesos)xEuro;
            //xPesosD = (Pesos)xDolar;



            //Console.WriteLine("{0} Euros equivalen a {1} Pesos", xEuro.GetCantidad(), Math.Round(xPesosE.GetCantidad(),2));
            //Console.WriteLine("{0} Dólares equivalen a {1} Pesos",xDolar.GetCantidad() ,Math.Round(xPesosD.GetCantidad(),2));
            Console.WriteLine("{0} Dolares - {1} Euros es??: ${2}", xDolar2.GetCantidad(), xEuro.GetCantidad(),restaD.GetCantidad()); //1,3643 Dolares
            Console.WriteLine("{0} Dolares - {1} Pesos es??: ${2}", xDolar.GetCantidad(), xPesosD.GetCantidad(), restaE.GetCantidad()); //-0,14 Dolares
            //Console.WriteLine("{0} Dolares es Igual a {1} Dolares??: {2}", xDolar.GetCantidad(), xEuro2.GetCantidad(), xDolar == xDolar2);
            Console.ReadKey();
        }
    }
}
