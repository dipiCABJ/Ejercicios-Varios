using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        //Atributos
        private double cantidad;
        private static float cotizRespectoDolar;

        //Metodos Constructores
        //public Dolar()
        //{

        //}

        public Dolar(double cant)
        {
            cantidad = cant;
        }

        public Dolar(double cant, float cotiza): this(cant)
        {
            cotizRespectoDolar = cotiza;
        }

        //Metodos
        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static implicit operator Dolar(double d)
        {
            return d;
        }


        //Operadores
        public static explicit operator Euro(Dolar d)
        {
            Euro xEuro = new Euro(Math.Round(d.GetCantidad() * Euro.GetCotizacion(),2), Euro.GetCotizacion());
            return xEuro;
        }

        public static explicit operator Pesos(Dolar d)
        {
            //Console.WriteLine("Casteo de Dolar a Pesos");
            //Console.ReadKey();
            Pesos xPesos = new Pesos(Math.Round(d.GetCantidad() * Pesos.GetCotizacion(),2),Pesos.GetCotizacion());
            return xPesos;
        }

        public static bool operator != (Dolar d, Euro e)
        {
            //Castear a Dolar
            Dolar d1 = (Dolar)e;
            bool returnValue = false;
            if (d.GetCantidad() != d1.GetCantidad())
                returnValue = true;
            return returnValue;
        }

        public static bool operator != (Dolar d, Pesos p)
        {
            Dolar d1 = (Dolar)p;
            bool returnValue = false;
            if (d.GetCantidad() != d1.GetCantidad())
                returnValue = true;
            return returnValue;
        }

        public static bool operator != (Dolar d1, Dolar d2)
        {
            bool returnValue = false;
            if (d1.GetCantidad() != d2.GetCantidad())
                returnValue = true;
            return returnValue;
        }

        public static bool operator == (Dolar d, Euro e)
        {
            Dolar d1 = (Dolar)e;
            bool returnValue = false;
            if (d.GetCantidad() == d1.GetCantidad())
                returnValue = true;
            return returnValue;
        }

        public static bool operator == (Dolar d, Pesos p)
        {
            Dolar d1 = (Dolar)p;
            bool returnValue = false;
            if (d.GetCantidad() == d1.GetCantidad())
                returnValue = true;
            return returnValue;
        }

        public static bool operator == (Dolar d1, Dolar d2)
        {
            bool returnValue = false;
            if (d1.GetCantidad() == d2.GetCantidad())
                returnValue = true;
            return returnValue;
        }

        public static Dolar operator - (Dolar d, Euro e)
        {
            //Conversion de Euro a Dolar
            Dolar d1 = (Dolar)e;
            Dolar dFinal = new Dolar(d.GetCantidad() - d1.GetCantidad(),GetCotizacion());
            return dFinal;
        }

        public static Dolar operator - (Dolar d, Pesos p)
        {
            //Conversion de Pesos a Dolar
            Dolar d1 = (Dolar)p;
            Dolar dFinal = new Dolar(d.GetCantidad() - d1.GetCantidad(), GetCotizacion());
            return dFinal;
        }

        public static Dolar operator + (Dolar d, Euro e)
        {
            //Conversion de Euro a Dolar
            Dolar d1 = (Dolar)e;
            Dolar dFinal = new Dolar(d.GetCantidad() + d1.GetCantidad(), GetCotizacion());
            return dFinal;
        }

        public static Dolar operator + (Dolar d, Pesos p)
        {
            //Conversion de Pesos a Dolar
            Dolar d1 = (Dolar)p;
            Dolar dFinal = new Dolar(d.GetCantidad() + d1.GetCantidad(), GetCotizacion());
            return dFinal;
        }
    }
}
