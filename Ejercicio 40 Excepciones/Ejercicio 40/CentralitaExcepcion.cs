using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_40
{
    public class CentralitaExcepcion : Exception
    {
        #region Atributos
        private string nombreClase;
        private string nombreMetodo; 
        #endregion atributos

        public Exception ExcepcionInterna
        {
            get 
            {
                return this;
            }
        }

        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }

        public CentralitaExcepcion(string mensaje, string clase, string metodo):this(mensaje, clase, metodo, null)
        {
            
        }

        public CentralitaExcepcion(string mensaje, string clase, string metodo, Exception innerExcepcion):base(mensaje,innerExcepcion)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
    }
}
