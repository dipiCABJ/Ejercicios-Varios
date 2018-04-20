using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Moto : VehiculoTerrestre
    {
        short cantidadRuedas;
        short cantidadPuertas;
        Colores color;
        public int cilindradas;

        public Moto(short cantR, short cantP, Colores col, int cantCilindros) : base(cantR, cantP, col)
        {
            this.cilindradas = cantCilindros;
        }
    }
}
