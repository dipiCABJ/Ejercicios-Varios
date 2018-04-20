using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Cliente
    {
        //ATRIBUTOS
        private int numero;
        private string nombre;

        //PROPIEDADES
        public string Nombre
        {
            get 
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }
        }

        //CONSTRUCTORES
        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero,string nombre):this(numero)
        {
            this.nombre = nombre;
        }

        //OPERADORE
        public static bool operator != (Cliente cli1, Cliente cli2)
        {
            bool returnValue = false;
            if (cli1.numero != cli2.numero)
                returnValue = true;
            return returnValue;
        }

        public static bool operator ==(Cliente cli1, Cliente cli2)
        {
            bool returnValue = false;
            if (cli1.numero == cli2.numero)
                returnValue = true;
            return returnValue;
        }
    }
}
