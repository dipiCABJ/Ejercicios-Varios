using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Camion : VehiculoTerrestre
    {
        short cantidadRuedas;
        short cantidadPuertas;
        Colores color;
        public short cantidadMarchas;
        public int pesoCarga;

        public Camion(short cantRuedas, short cantPuertas, Colores col, short cantMarchas, int peso):base(cantRuedas,cantPuertas,col)
        {
            this.cantidadMarchas = cantMarchas;
            this.pesoCarga = peso;
        }
    }
}
