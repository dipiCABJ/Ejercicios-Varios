using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_21_Form
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
        }

        private void Conversor_Load(object sender, EventArgs e)
        {

        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            if (txtF.Text == "")
                MessageBox.Show("Ingrese un valor en el cuadro de texto!!");
            else
            {
                Fahrenheit f = new Fahrenheit(Convert.ToDouble(txtF.Text));
                Celsius c = (Celsius)f;
                Kelvin k = (Kelvin)f;
                txtFAF.Text = Convert.ToString(f.GetTemperatura());
                txtFAC.Text = Convert.ToString(c.GetTemperatura());
                txtFAK.Text = Convert.ToString(k.GetTemperatura());
            }
        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            if (txtC.Text == "")
                MessageBox.Show("Ingrese un valor en el cuadro de texto!!");
            else
            {
                Celsius c = new Celsius(Convert.ToDouble(txtC.Text));
                Fahrenheit f = (Fahrenheit)c;
                Kelvin k = (Kelvin)c;
                txtCAF.Text = Convert.ToString(f.GetTemperatura());
                txtCAC.Text = Convert.ToString(c.GetTemperatura());
                txtCAK.Text = Convert.ToString(k.GetTemperatura());
            }
        }

        private void btnKelvin_Click(object sender, EventArgs e)
        {
            if (txtK.Text == "")
                MessageBox.Show("Ingrese un valor en el cuadro de texto!!");
            else
            {
                Kelvin k = new Kelvin(Convert.ToDouble(txtK.Text));
                Fahrenheit f = (Fahrenheit)k;
                Celsius c = (Celsius)k;
                txtKAF.Text = Convert.ToString(f.GetTemperatura());
                txtKAC.Text = Convert.ToString(c.GetTemperatura());
                txtKAK.Text = Convert.ToString(k.GetTemperatura());
            }
        }
    }
}
