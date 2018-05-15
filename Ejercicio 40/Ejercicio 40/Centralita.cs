using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_40
{
    public class Centralita
    {
        #region FIELDS
        protected string razonSocial;
        private List<Llamada> listaDeLlamadas;
        #endregion FIELDS

        #region PROPERTIES
        public float GananciasPorLocal
        {
            get
            {
                //Mandar solo tipollamada
                //float xGanLoc = 0F;
                //foreach (Llamada xItem in this.Llamadas)
                //{
                //    xGanLoc += this.CalcularGanancia(Llamada.TipoLlamada.Local);
                //}
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                /*loat xGanProv = 0F;
                foreach (Llamada xItem in this.Llamadas)
                {
                    xGanProv += this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
                }
                 * */
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciaTotal
        {
            get
            {
                /*float xGanTot = 0F;
                foreach (Llamada xItem in this.Llamadas)
                {
                    xGanTot += this.CalcularGanancia(Llamada.TipoLlamada.Todas);
                }
                */
                //this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        #endregion PROPERTIES

        #region METHODS
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string razonSocial)
            : this()
        {
            this.razonSocial = razonSocial;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float xCosto = 0F;
            foreach (Llamada xItem in this.Llamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (xItem is Local)
                            xCosto += ((Local)xItem).CostoLlamada;
                        break;

                    case Llamada.TipoLlamada.Provincial:
                        if (xItem is Provincial)
                            xCosto += ((Provincial)xItem).CostoLlamada;
                        break;

                    default:
                        if (xItem is Local)
                            xCosto += ((Local)xItem).CostoLlamada;
                        if (xItem is Provincial)
                            xCosto += ((Provincial)xItem).CostoLlamada;
                        break;
                }
            }
            return xCosto;
            /*switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    foreach (Llamada xItem in this.Llamadas)
                    {
                        if (xItem is Local)
                            xCosto += ((Local)xItem).CostoLlamada;
                    }
                    break;

                case Llamada.TipoLlamada.Provincial:
                    foreach (Llamada xItem in this.Llamadas)
                    {
                        if (xItem is Provincial)
                            xCosto += ((Provincial)xItem).CostoLlamada;
                    }
                    break;
            }*/
            /*foreach (Llamada xItem in this.Llamadas)
            {
                if (tipo == Llamada.TipoLlamada.Local)
                    xCosto += ((Local)xItem).CostoLlamada;
                else
                {
                    if (tipo == Llamada.TipoLlamada.Provincial)
                        xCosto += ((Provincial)xItem).CostoLlamada;
                    else
                        xCosto += ((Local)xItem).CostoLlamada + ((Provincial)xItem).CostoLlamada;   
                }
            }
            //foreach aca
            /*if (tipo == Llamada.TipoLlamada.Local)
                xCosto = CostoLlamada;
            if (tipo == Llamada.TipoLlamada.Provincial)
                xCosto = Provincial.CostoLlamada;
            if (tipo == Llamada.TipoLlamada.Todas)
                xCosto = Local.CostoLlamada + Provincial.CostoLlamada;
             */
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        protected string Mostrar()
        {
            //Llamada aux = new Llamada();
            StringBuilder xStr = new StringBuilder();
            //xStr.AppendLine(Mostrar());
            xStr.AppendLine("Central: " + this.razonSocial);
            foreach (Llamada xItem in this.Llamadas)
            {
                if (xItem is Local)
                    xStr.AppendLine(((Local)xItem).ToString());
                else
                {
                    if (xItem is Provincial)
                        xStr.AppendLine(((Provincial)xItem).ToString());
                }

            }
            xStr.AppendLine("");
            xStr.AppendLine("Ganancias por Local: " + this.GananciasPorLocal);
            xStr.AppendLine("Ganancias por Provincial: " + this.GananciasPorProvincial);
            xStr.AppendLine("Ganancia Total: " + this.GananciaTotal);
            return xStr.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            //Agregar Llamada
            this.Llamadas.Add(nuevaLlamada);
        }
        #endregion METHODS

        #region OPERADORES
        public static bool operator ==(Centralita c, Llamada l1)
        {
            bool xReturn = false;
            foreach (Llamada xItem in c.Llamadas)
            {
                if (xItem == l1)
                {
                    xReturn = true;
                    break;
                }
            }
            return xReturn;
        }

        public static bool operator !=(Centralita c, Llamada l1)
        {
            return (!(c == l1));
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            //Centralita center = new Centralita("dipi Center");
            if (c != nuevaLlamada)
                c.AgregarLlamada(nuevaLlamada);

            //Lanzar la Excepcion aqui!!!

            //center = c;
            return c;
        }
        #endregion OPERADORES
    }
}

