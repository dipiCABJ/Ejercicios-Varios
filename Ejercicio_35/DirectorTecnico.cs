using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_35
{
    class DirectorTecnico : Persona
    {
        protected DateTime fechaNacimiento;

        //CONSTRUCTORES
        private DirectorTecnico(long dni, string nombre) : base(dni, nombre)
        {

        }

        public DirectorTecnico(long dni, string nombre, DateTime fechaNac) : this(dni, nombre)
        {
            this.fechaNacimiento = fechaNac;
        }

        //PROPIEDADES
        public DateTime FechaNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }

            set
            {
                this.fechaNacimiento = value;
            }
        }

        //METODOS
        public string MostrarDatos()
        {
            StringBuilder xStr = new StringBuilder();
            xStr.Append(base.MostrarDatos());
            xStr.AppendLine("Fecha de Nacimiento: " + this.fechaNacimiento);
            return xStr.ToString(); 
        }
        

        //OPERADORES
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return dt1.Dni != dt2.Dni;
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return dt1.Dni == dt2.Dni;
        }
    }
}
