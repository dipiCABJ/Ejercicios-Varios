using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_32
{
    class Jugador
    {

        //ATRIBUTOS
        private long dni;
        private string nombre;
        private int partidosJugados;
        //private float promedioGoles;
        private int totalGoles;

        //CONSTRUCTORES
        private Jugador()
        {
            this.partidosJugados = 0;
            //this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(long docu, string nombre) : this()
        {
            this.Dni = docu;
            this.Nombre = nombre;
        }

        public Jugador(long dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.partidosJugados = totalPartidos;
            this.totalGoles = totalGoles;
        }

        //PROPIEDADES
        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
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

        public long Dni
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

        //METODOS
        public string MostrarDatos()
        {
            StringBuilder xStr = new StringBuilder();
            xStr.AppendLine("D.N.I: " + this.Dni);
            xStr.AppendLine("Nombre: " + this.Nombre);
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
            return j1.dni != j2.dni;
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }
}
}
