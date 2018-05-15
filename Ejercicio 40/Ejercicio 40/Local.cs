using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_40
{
    public class Local : Llamada
    {
        protected float _costo;

        //PROPERTIES
        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        //METHODS
        public Local(Llamada llamada1, float costo)
            : this(llamada1.Duracion, llamada1.NroDestino, llamada1.NroOrigen, costo)
        {

        }

        public Local(float duracion, string destino, string origen, float costo)
            : base(duracion, destino, origen)
        {
            this._costo = costo;
        }

        private float CalcularCosto()
        {
            return base.Duracion * this._costo;
        }

        protected override string Mostrar()
        {
            StringBuilder xStr = new StringBuilder();
            xStr.Append(base.Mostrar());
            xStr.AppendLine("Costo: " + this.CostoLlamada);
            return xStr.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            //bool esLocal = false;
            //if (obj is Local)
            //    esLocal = true;
            return (obj is Local);
        }
    }
}
