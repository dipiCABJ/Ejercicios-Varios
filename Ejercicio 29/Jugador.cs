using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Jugador
    {
        private long dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;
        
        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(long docu, string nombre):this()
        {
            this.dni = docu;
            this.nombre = nombre;
        }

        public Jugador(long dni, string nombre, int totalGoles, int totalPartidos) : this(dni,nombre)
        {
            this.partidosJugados = totalPartidos;
            this.totalGoles = totalGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder xStr = new StringBuilder();
            xStr.AppendLine("D.N.I: " + this.dni);
            xStr.AppendLine("Nombre: " + this.nombre);
            xStr.AppendLine("Partidos Jugados: " + this.partidosJugados);
            xStr.AppendLine("Goles convertidos: " + this.totalGoles);
            xStr.AppendFormat("Promedio de gol: {0:#,##0.00}",GetPromedioGoles());
            xStr.AppendLine("");
            return xStr.ToString();
        }

        public float GetPromedioGoles()
        {
            //float xProm = 0 //this.partidosJugados != 0 ? xProm = this.totalGoles / this.partidosJugados : xProm = 0;
            if (this.partidosJugados != 0)
                this.promedioGoles = (float)this.totalGoles / (float)this.partidosJugados;

            return this.promedioGoles; 
        }

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
