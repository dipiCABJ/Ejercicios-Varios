using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Negocio
    {
        //ATRIBUTOS
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                if (!(this == value))
                    clientes.Enqueue(value);
            }
        }

        //CONSTRUCTORES
        private Negocio()
        {
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre)
        {

        }

        //OPERADORES
        public static bool operator +(Negocio n, Cliente cli1)
        {
            bool returnValue = false;
            if (!(n == cli1))
            {
                n.Cliente = cli1;
                //n.clientes.Enqueue(cli1);
                returnValue = true;
            }
            return returnValue;
        }

        public static bool operator !=(Negocio n, Cliente cli1)
        {
            bool returnValue = false;
            foreach(Cliente xItem in n.clientes)
            {
                if (xItem != cli1)
                    returnValue = true;
            }
            return returnValue;
        }

        public static bool operator ==(Negocio n, Cliente cli1)
        {
            bool returnValue = false;
            foreach(Cliente xItem in n.clientes)
            {
                if (xItem == cli1)
                    returnValue = true;
            }
            return returnValue;
            /*if (!(n.clientes.Contains(cli1)))
            {
                Cliente = cli1;
                returnValue = true;
            }
            return returnValue;
            */
        }

        public static bool operator ~(Negocio neg)
        {
            
            //bool returnValue = false;
            //if (this.caja.Atender(neg.Cliente))
            //    returnValue = true;
            //return returnValue;
            return neg.caja.Atender(neg.Cliente);
        }


    }
}
