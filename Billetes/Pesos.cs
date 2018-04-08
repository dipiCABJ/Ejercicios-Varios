using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        //Atributos
        private double cantidad;
        private static float cotizRespectoDolar;

        //Metodos
        //public Pesos()
        //{
         
        //}

        public Pesos(double cant)
        {
            cantidad = cant;
        }

        public Pesos(double cant, float cotiza):this(cant)
        {
            cotizRespectoDolar = cotiza;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static implicit operator Pesos(double d)
        {
            return d;
        }

        public static explicit operator Euro(Pesos p)
        {
            //Console.WriteLine("Casteo de Pesos a Euro");
            //Console.ReadKey();
            Dolar d1 = (Dolar)p;
            Euro xEuro = new Euro(Math.Round(d1.GetCantidad() * Euro.GetCotizacion(),2), Euro.GetCotizacion());
            return xEuro; //(Euro)p;
        }

        public static explicit operator Dolar(Pesos p)
        {
            //Console.WriteLine("Casteo de Pesos a Dolar");
            //Console.ReadKey();
            Dolar xDolar = new Dolar(Math.Round((p.GetCantidad() / GetCotizacion()),4), Dolar.GetCotizacion());
            return xDolar; //(Euro)p;
        }

        public static bool operator != (Pesos p, Dolar d)
        {
            Pesos p1 = (Pesos)d;
            bool returnValue = false;
            //Console.WriteLine("Holaaa");
            //Console.ReadKey();
            if (p.GetCantidad() != p1.GetCantidad())
                returnValue = true;
            return returnValue;
        }

        public static bool operator != (Pesos p, Euro e)
        {
            bool returnValue = false;
            Pesos p1 = (Pesos)e;
            if (p.GetCantidad() != p1.GetCantidad())
                returnValue = true;
            return returnValue;
        }

        public static bool operator != (Pesos p1, Pesos p2)
        {
            bool returnValue = false;
            if (p1.GetCantidad() != p2.GetCantidad())
                returnValue = true;
            return returnValue;
        }

        public static bool operator == (Pesos p, Dolar d)
        {
            Pesos p1 = (Pesos)d;
            bool returnValue = false;
            //Console.WriteLine("Holaaa");
            //Console.ReadKey();
            if (p.GetCantidad() == p1.GetCantidad())
                returnValue = true;
            return returnValue;
        }

        public static bool operator == (Pesos p, Euro e)
        {
            bool returnValue = false;
            Pesos p1 = (Pesos)e;
            if (p.GetCantidad() == p1.GetCantidad())
                returnValue = true;
            return returnValue;
        }

        public static bool operator == (Pesos p1, Pesos p2)
        {
            bool returnValue = false;
            if (p1.GetCantidad() == p2.GetCantidad())
                returnValue = true;
            return returnValue;
        }

        public static Pesos operator - (Pesos p, Dolar d)
        {
            //Conversion de Euro a Dolar(¡)
            Pesos p1 = (Pesos)d;
            Pesos pFinal = new Pesos(p.GetCantidad() - p1.GetCantidad(), GetCotizacion());
            return pFinal;
        }

        public static Pesos operator - (Pesos p, Euro e)
        {
            Pesos p1 = (Pesos)e;
            Pesos pFinal = new Pesos(p.GetCantidad() - p1.GetCantidad(), GetCotizacion());
            return pFinal;
        }

        public static Pesos operator + (Pesos p, Dolar d)
        {
            Pesos p1 = (Pesos)d;
            Pesos pFinal = new Pesos(p.GetCantidad() + p1.GetCantidad(), GetCotizacion());
            return pFinal;
        }

        public static Pesos operator + (Pesos p, Euro e)
        {
            Pesos p1 = (Pesos)e;
            Pesos pFinal = new Pesos(p.GetCantidad() + p1.GetCantidad(), GetCotizacion());
            return pFinal;
        }
    }
}
