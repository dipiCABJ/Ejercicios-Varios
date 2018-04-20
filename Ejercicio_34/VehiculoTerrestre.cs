using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class VehiculoTerrestre
    {
        //Todos los atributos en comun entre las 3
        public short cantidadRuedas;
        public short cantidadPuertas;
        public Colores color;

        public VehiculoTerrestre(short cantR, short cantP, Colores col)
        {
            this.cantidadRuedas = cantR;
            this.cantidadPuertas = cantP;
            this.color = col;
        }

    }
}
