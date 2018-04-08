using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21_Form
{
    public class Celsius
    {
        //Atributo
        private double temperatura;

        // Metodo Constructor sobrecargado
        public Celsius()
        {

        }

        public Celsius(double xtemp) : this()
        {
            this.temperatura = xtemp;
        }

        public double GetTemperatura()
        {
            return this.temperatura;
        }

        //Metodos con Sobrecarga Operadores
        public static explicit operator Fahrenheit(Celsius c)
        {
            //(1.8 * txtGrados.Text) + 32
            Fahrenheit fahrenheit = new Fahrenheit(Math.Round((1.8 * c.GetTemperatura()) + 32, 2));
            return fahrenheit;
        }

        public static explicit operator Kelvin(Celsius c)
        {
            //(txtGrados.Text + 273.15)
            Kelvin kelvin = new Kelvin(Math.Round(c.GetTemperatura() + 273.15, 2));
            return kelvin;
        }

        // Sobrecarga de Operadores !=
        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            Celsius c1 = (Celsius)f;
            bool returnValue = false;
            if (c.GetTemperatura() != c1.GetTemperatura())
                returnValue = true;
            return returnValue;
        }

        public static bool operator !=(Celsius c, Kelvin k)
        {
            Celsius c1 = (Celsius)k;
            bool returnValue = false;
            if (c.GetTemperatura() != c1.GetTemperatura())
                returnValue = true;
            return returnValue;
        }

        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            Celsius c1 = (Celsius)f;
            bool returnValue = false;
            if (c.GetTemperatura() == c1.GetTemperatura())
                returnValue = true;
            return returnValue;
        }

        public static bool operator ==(Celsius c, Kelvin k)
        {
            Celsius c1 = (Celsius)k;
            bool returnValue = false;
            if (c.GetTemperatura() == c1.GetTemperatura())
                returnValue = true;
            return returnValue;
        }
    }
}
