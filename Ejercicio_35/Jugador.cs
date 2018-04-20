using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_35
{
    class Jugador : Persona
    {
        protected int partidosJugados;
        protected int totalGoles;

        //CONSTRUCTORES
        /*private Jugador()
        {
            this.partidosJugados = 0;
            //this.promedioGoles = 0;
            this.totalGoles = 0;
        }
        */
        public Jugador(long dni, string nombre) : base(dni, nombre)
        {
            //this.Dni = dni;
            //this.Nombre = nombre;
        }

        public Jugador(long dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.PartidosJugados = totalPartidos;
            this.TotalGoles = totalGoles;
        }

        //PROPIEDADES
        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }

            set
            {
                this.partidosJugados = value;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }

            set
            {
                this.totalGoles = value;
            }

        }

        public float PromedioGoles
        {
            get
            {
                float xProm = 0F;
                if (this.partidosJugados != 0)
                    xProm = (float)(this.totalGoles) / (float)(this.partidosJugados);
                return xProm;
            }
        }

        /*public long Dni //HEREDA DE PERSONA
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        */ //HEREDA DE PERSONA
        //METODOS
        public string MostrarDatos()
        {
            StringBuilder xStr = new StringBuilder();
            xStr.Append(base.MostrarDatos());
            xStr.AppendLine("Partidos Jugados: " + this.PartidosJugados);
            xStr.AppendLine("Goles convertidos: " + this.TotalGoles);
            xStr.AppendFormat("Promedio de gol: {0:#,##0.00}", this.PromedioGoles);
            xStr.AppendLine("");
            
            return xStr.ToString();
        }

        /*public float GetPromedioGoles()
        {
            //float xProm = 0 //this.partidosJugados != 0 ? xProm = this.totalGoles / this.partidosJugados : xProm = 0;
            if (this.partidosJugados != 0)
                this.promedioGoles = (float)this.totalGoles / (float)this.partidosJugados;

            return this.promedioGoles;
        }
        */

        //OPERADORES
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return j1.Dni != j2.Dni;
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }
    }
}