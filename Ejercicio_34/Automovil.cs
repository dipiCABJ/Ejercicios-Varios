using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Automovil : VehiculoTerrestre
    {
        short cantidadRuedas;
        short cantidadPuertas;
        Colores color;
        public short cantidadMarchas;
        public int cantidadPasajeros;

        public Automovil(short cantidadR, short cantidadP, Colores col, short cantidadM, int pasajeros):base(cantidadR, cantidadP, col)
        {
            this.cantidadMarchas = cantidadM;
            this.cantidadPasajeros = pasajeros;
        }
    }
}
