using System;

namespace Ejercicio_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            int i;
            bool a;
            //Instancio Equipo
            Equipo xTeam = new Equipo(11, "Boca Juniors");

            //Instancio Jugadores
            Jugador j1 = new Jugador(27787032, "Oscar Cordoba", 200, 5);
            Jugador j2 = new Jugador(30009216, "Hugo Ibarra", 150, 30);
            Jugador j3 = new Jugador(11396335, "Jorge Bermudez", 210, 10);
            Jugador j4 = new Jugador(11392335, "Walter Samuel", 190, 10);
            Jugador j5 = new Jugador(11396995, "JRodolfo arruabarrena", 140, 10);
            Jugador j6 = new Jugador(30089216, "Sebastian Battaglia", 190, 30);
            Jugador j7 = new Jugador(53717378, "Mauricio Serna", 200, 7);
            Jugador j8 = new Jugador(30039216, "Diego Cagna", 200, 205);
            Jugador j9 = new Jugador(27783032, "Juan Roman Riquelme", 200, 130);
            Jugador j10 = new Jugador(29747606, "Guillermo B. Schelotto", 210, 170);
            Jugador j11 = new Jugador(30409216, "Martin Palermo", 200, 230);

            //Instancio DT
            DirectorTecnico dt = new DirectorTecnico(14236517, "Carlos Bianchi", DateTime.Parse("26/04/1949"));

            a = xTeam + j1;
            a = xTeam + j2;
            a = xTeam + j3;
            a = xTeam + j4;
            a = xTeam + j5;
            a = xTeam + j6;
            a = xTeam + j7;
            a = xTeam + j8;
            a = xTeam + j9;
            a = xTeam + j10;
            a = xTeam + j11;

            Console.WriteLine("Club Atlético Boca Juniors!!\n");
            foreach (Jugador j in xTeam.jugadores)
            {
                Console.WriteLine(j.MostrarDatos());
            }

            Console.WriteLine("DT: "+ dt.MostrarDatos());
            Console.ReadKey();
        }
    }
}
