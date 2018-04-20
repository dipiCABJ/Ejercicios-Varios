using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Ejercicio_31
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;
        
        //CONSTRUCTORES
        private static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
           
        }

        //PROPERTY
        public static int NumeroActual
        {
            get
            {
                numeroActual++;
                return numeroActual;
            }

        }

        //METODOS
        public bool Atender(Cliente cli)
        {
            var xSleep = Stopwatch.StartNew();
            Thread.Sleep(5000);
            xSleep.Stop();
            return true;
        }
        //ENUMERADOS
        public enum Puesto
        {
            Caja1,
            Caja2
        }
    }
}
