using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21_Form
{
    public class Kelvin
    {
        //Atributo
        private double temperatura;

        // Metodo Constructor sobrecargado
        public Kelvin()
        {

        }

        public Kelvin(double xtemp) : this()
        {
            this.temperatura = xtemp;
        }

        public double GetTemperatura()
        {
            return this.temperatura;
        }

        //Metodos con Sobrecarga Operadores
        public static explicit operator Celsius(Kelvin k)
        {
            //(txtGrados.Text - 273.15)
            Celsius centigrados = new Celsius(Math.Round(k.GetTemperatura() - 273.15, 2));
            return centigrados;
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            //(1.8 * txtGrados.Text) - 459.67
            Fahrenheit fahrenheit = new Fahrenheit(Math.Round((1.8 * k.GetTemperatura()) - 459.67, 2));
            return fahrenheit;
        }
    }
}
