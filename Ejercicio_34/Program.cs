using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Colores xColorCamion = new Colores();
            Camion scania = new Camion(12, 2, Colores.Gris, 4, 2500);
            Automovil ford = new Automovil(4, 5, Colores.Azul, 5, 5);
            Moto kawazaky = new Moto(2, 0, Colores.Rojo,7);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            StringBuilder xStr = new StringBuilder();
            xStr.AppendLine("Camion: Scania 1114"); 
            xStr.AppendLine("Cantidad de Ruedas: " + scania.cantidadRuedas);
            xStr.AppendLine("Cantidad de Puertas: " + scania.cantidadPuertas);
            xStr.AppendLine("Color: " + scania.color);
            xStr.AppendLine("Cantidad de Marchas: " + scania.cantidadMarchas);
            xStr.AppendLine("Peso de carga: " + scania.pesoCarga);
            xStr.AppendLine("");
            xStr.AppendLine("");
            xStr.AppendLine("FORD MONDEO 2018");
            xStr.AppendLine("Cantidad de Ruedas: " + ford.cantidadRuedas);
            xStr.AppendLine("Cantidad de Puertas: " + ford.cantidadPuertas);
            xStr.AppendLine("Color: " + ford.color);
            xStr.AppendLine("Cantidad de Marchas: " + ford.cantidadMarchas);
            xStr.AppendLine("Cantidad de Pasajeros: " + ford.cantidadPasajeros);
            xStr.AppendLine("");
            xStr.AppendLine("");
            xStr.AppendLine("KAWAZAKY NINJA 2018");
            xStr.AppendLine("Cantidad de Ruedas: " + kawazaky.cantidadRuedas);
            xStr.AppendLine("Cantidad de Puertas: " + kawazaky.cantidadPuertas);
            xStr.AppendLine("Color: " + kawazaky.color);
            xStr.AppendLine("Cilindradas: " + kawazaky.cilindradas);

            Console.Write(xStr.ToString());
            Console.ReadKey();
        }
    }
}
