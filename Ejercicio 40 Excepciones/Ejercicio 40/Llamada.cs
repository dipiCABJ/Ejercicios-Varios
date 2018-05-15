using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_40
{
    public abstract class Llamada
    {
        #region FIELDS
        protected float _duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion FIELDS

        #region PROPERTIES
        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public abstract float CostoLlamada
        {
            get;
        }
        #endregion PROPERTIES

        #region  METHODS
        public Llamada()
        {

        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
            : this()
        {
            this._duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        protected virtual string Mostrar()
        {
            StringBuilder xStr = new StringBuilder();
            xStr.AppendLine("Duración: " + this.Duracion);
            xStr.AppendLine("Origen: " + this.NroOrigen);
            xStr.AppendLine("Destino: " + this.NroDestino);
            return xStr.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {

            //return llamada1.Duracion.CompareTo(llamada2.Duracion);
            int xReturn = 0;
            if (llamada1.Duracion > llamada2.Duracion)
                xReturn = 1;
            else
                if (llamada1.Duracion < llamada2.Duracion)
                    xReturn = -1;
            return xReturn;
        }
        #endregion METHODS

        #region ENUMERADORES
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
        #endregion ENUMERADORES

        #region OPERADORES
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool xReturn = false;
            if (l1.Equals(l2) && (l1.Duracion == l2.Duracion) && (l1.NroOrigen == l2.NroOrigen) && (l1.NroDestino == l2.NroDestino))
                xReturn = true;
            return xReturn;

        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return (!(l1 == l2));
        }
        #endregion OPERADORES

    }
}
