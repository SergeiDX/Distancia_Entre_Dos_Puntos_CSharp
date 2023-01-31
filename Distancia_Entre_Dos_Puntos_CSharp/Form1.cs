using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distancia_Entre_Dos_Puntos_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Operaciones Operacion = new Operaciones();
            double resul = Operacion.Operacion(double.Parse(txtX2.Text), double.Parse(txtX1.Text), double.Parse(txtY2.Text), double.Parse(txtY1.Text));
            txtResul.Text = resul.ToString();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            txtX1.Clear();
            txtY1.Clear();
            txtX2.Clear();
            txtY2.Clear();
            txtResul.Clear();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
