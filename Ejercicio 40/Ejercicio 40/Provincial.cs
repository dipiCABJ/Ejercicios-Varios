using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_40
{
    public class Provincial : Llamada
    {
        #region FIELDS
        protected Franja _franjaHoraria;
        #endregion FIELDS

        #region PROPERTIES
        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        #endregion PROPERTIES

        #region METHODS
        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this._franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            float xCosto;
            if (this._franjaHoraria == Franja.Franja_1)
                xCosto = this.Duracion * 0.99F;
            else
            {
                if (this._franjaHoraria == Franja.Franja_2)
                    xCosto = this.Duracion * 1.25F;
                else
                    xCosto = this.Duracion * 0.66F;
            }
            return xCosto;
        }

        protected override string Mostrar()
        {
            StringBuilder xStr = new StringBuilder();
            xStr.Append(base.Mostrar());
            xStr.AppendLine("Franja Horaria: " + this._franjaHoraria);
            xStr.AppendLine("Costo: " + this.CostoLlamada);
            return xStr.ToString();
        }

        public override bool Equals(object obj)
        {
            //bool esProvincial = false;
            //if (obj is Provincial)
            //    esProvincial = true;
            return (obj is Provincial);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion METHODS

        #region ENUMERADORES
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        #endregion ENUMERADORES
    }
}
