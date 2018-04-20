using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_32
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            bool a;
            Equipo xTeam = new Equipo(11, "Boca Juniors");
            Jugador j1 = new Jugador(27787032, "Juan Roman Riquelme", 200, 130);
            Jugador j2 = new Jugador(30009216, "Martin Palermo", 200, 230);
            Jugador j3 = new Jugador(53717378, "Mauricio Serna", 200, 130);
            Jugador j4 = new Jugador(29747606, "Guillermo B. Schelotto", 210, 170);
            Jugador j5 = new Jugador(11396335, "Jorge Bermudez", 210, 10);

            a = xTeam + j1;
            a = xTeam + j2;
            a = xTeam + j3;
            a = xTeam + j4;
            a = xTeam + j5;

            Console.WriteLine("Club Atlético Boca Juniors!!");
            foreach (Jugador j in xTeam.jugadores)
            {
                Console.WriteLine(j.MostrarDatos());
            }
            Console.ReadKey();
        }
    }
}
