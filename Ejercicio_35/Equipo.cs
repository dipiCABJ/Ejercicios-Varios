using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_35
{
    class Equipo
    {
        //ATRIBUTOS
        private short cantidadJugadores;
        public List<Jugador> jugadores;
        string nombre;

        //CONSTRUCTORES
        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidadJugadores, string nombre) : this()
        {
            this.cantidadJugadores = cantidadJugadores;
            this.nombre = nombre;
        }

        //PROPIEDADES

        //OPERADORES
        public static bool operator +(Equipo e, Jugador j)
        {
            bool agrega = true;
            foreach (Jugador jug in e.jugadores)
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
