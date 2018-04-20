using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Equipo
    {
        //ATRIBUTOS
        private short cantidadJugadores;
        public List<Jugador> jugadores;
        string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidadJugadores, string nombre):this()
        {
            this.cantidadJugadores = cantidadJugadores;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool agrega = true;
            /*if((e.jugadores.Count < e.cantidadJugadores) && ((e.jugadores.Contains(j))))
            {
                e.jugadores.Add(j);
                agrego = true;
            }
            */
            foreach(Jugador jug in e.jugadores)
            {
                if (jug == j)
                {
                    agrega = false;
                    break;
                }
            }
            if (agrega && e.jugadores.Count < e.cantidadJugadores)
            {
                e.jugadores.Add(j);
            }
            return agrega;
        }
    }
}
