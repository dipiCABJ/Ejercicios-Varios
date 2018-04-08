using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        //Atributos
        private double cantidad;
        private static float cotizRespectoDolar;

        //Metodos
        //public Euro()
        //{

        //}

        public Euro(double cant)
        {
            cantidad = cant;
        }

        public Euro(double cant, float cotiza):this(cant)
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

        public static implicit operator Euro(double d)
        {
            return d;
        }

        public static explicit operator Dolar(Euro e)
        {
            Dolar xDolar = new Dolar(e.GetCantidad() * 1.3642,1F);
            //Console.WriteLine("Casteo de Euro a Dolar");
            //Console.ReadKey();
            return xDolar;
        }

        public static explicit operator Pesos(Euro e)
        {
            Dolar xDol = (Dolar)e;
            //Console.WriteLine("Casteo de Dolar a Peso");
            //Console.ReadKey();
            Pesos xPesos = new Pesos(Math.Round(xDol.GetCantidad() * Pesos.GetCotizacion(),2),Pesos.GetCotizacion());
            //Console.WriteLine("Cantidad Pesos: {0} -- Cotizacion: {1}",xPesos.GetCantidad(),xPesos.);
            return xPesos;
        }

        public static bool operator != (Euro e, Dolar d)
        {
            Euro e1 = (Euro)d;
            bool returnValue = false;
            if (e.GetCantidad() != e1.GetCantidad())
                returnValue = true;
            return returnValue;
        }

        public static bool operator != (Euro e, Pesos p)
        {
            Euro e1 = (Euro)p;
            bool returnValue = false;
            if (e.GetCantidad() != e1.GetCantidad())
                returnValue = true;
            return returnValue;
        }

        public static bool operator != (Euro e1, Euro e2)
        {
            bool returnValue = false;
            if (e1.GetCantidad() != e2.GetCantidad())
                returnValue = true;
            return returnValue;
        }

        public static bool operator == (Euro e, Dolar d)
        {
            Euro e1 = (Euro)d;
            bool returnValue = false;
            if (e.GetCantidad() == e1.GetCantidad())
                returnValue = true;
            return returnValue;
        }

        public static bool operator == (Euro e, Pesos p)
        {
            Euro e1 = (Euro)p;
            bool returnValue = false;
            if (e.GetCantidad() == e1.GetCantidad())
                returnValue = true;
            return returnValue;
        }

        public static bool operator == (Euro e1, Euro e2)
        {
            bool returnValue = false;
            if (e1.GetCantidad() == e2.GetCantidad())
                returnValue = true;
            return returnValue;
        }

        public static Euro operator - (Euro e, Dolar d)
        {
            //Conversion de Dolar a Euro
            Euro e1 = (Euro)d;
            Euro eFinal = new Euro(e.GetCantidad() - e1.GetCantidad(),GetCotizacion());
            return eFinal;
        }

        public static Euro operator - (Euro e, Pesos p)
        {
            //Conversion de Peso a Euro
            Euro e1 = (Euro)p;
            Euro eFinal = new Euro(e.GetCantidad() - e1.GetCantidad(), GetCotizacion());
            return eFinal;
        }

        public static Euro operator + (Euro e, Dolar d)
        {
            //Conversion de Dolar a Euro
            Euro e1 = (Euro)d;
            Euro eFinal = new Euro(e.GetCantidad() + e1.GetCantidad(), GetCotizacion());
            return eFinal;
        }

        public static Euro operator + (Euro e, Pesos p)
        {
            Euro e1 = (Euro)p;
            Euro eFinal = new Euro(e.GetCantidad() + e1.GetCantidad(), GetCotizacion());
            return eFinal;
        }
    }
}
