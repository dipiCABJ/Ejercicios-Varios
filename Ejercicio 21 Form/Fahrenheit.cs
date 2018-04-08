using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21_Form
{
    public class Fahrenheit
    {
        //Atributo
        private double temperatura;

        // Metodo Constructor sobrecargado
        public Fahrenheit()
        {

        }

        public Fahrenheit(double xtemp) : this()
        {
            this.temperatura = xtemp;
        }

        public double GetTemperatura()
        {
            return this.temperatura;
        }

        //Metodos con Sobrecarga Operadores
        public static explicit operator Celsius(Fahrenheit f)
        {
            //(txtGrados.Text - 32) / 1.8
            Celsius centigrados = new Celsius(Math.Round((f.GetTemperatura() - 32) / 1.8, 2));
            return centigrados;
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            //(txtGrados.Text + 459.67) / 1.8
            Kelvin kelvin = new Kelvin(Math.Round((f.GetTemperatura() + 459.67) / 1.8, 2));
            return kelvin;
        }
    }
}
