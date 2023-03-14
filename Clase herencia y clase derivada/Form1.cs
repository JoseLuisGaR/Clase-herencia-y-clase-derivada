using Clase_herencia_y_clase_derivada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_herencia_y_clase_derivada
{
    public partial class Form1 : Form
    {
        private Azul azul;
        private Rojo rojo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            azul = new Azul();
            rojo = new Rojo();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

            string NewLine = lblResultado.Text;
        }

        private void btnAzul_Click_1(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            azul.SeleccionarColor();
            lblResultado.Text = "El color azul no esta mal" + Environment.NewLine;

            Icolores colores = azul;
            colores.Elegir();
            lblResultado.Text += "para que usaras el color azul?";
        }
        private void btnrojo1_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            rojo.SeleccionarColor();
            lblResultado.Text = "El color Rojo es magnifico, queda bien con todo" + Environment.NewLine;

            Icolores Colores = rojo;
            Colores.Elegir();
            lblResultado.Text += "para que usaras el color Rojo?";
        }
    }

}