using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_35
{
    class Persona
    {
        protected long dni;
        protected string nombre;

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

        public string MostrarDatos()
        {
            StringBuilder xStr = new StringBuilder();
            xStr.AppendLine("D.N.I: " + this.Dni);
            xStr.AppendLine("Nombre: " + this.Nombre);
            /*xStr.AppendLine("Partidos Jugados: " + this.PartidosJugados);
            xStr.AppendLine("Goles convertidos: " + this.TotalGoles);
            xStr.AppendFormat("Promedio de gol: {0:#,##0.00}", this.PromedioGoles);
            xStr.AppendLine("");
            return xStr.ToString();
            */
            return xStr.ToString();
        }

        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }

        public Persona(long dni, string nombre):this(nombre)
        {
            this.Dni = dni;
        }
    }
}
