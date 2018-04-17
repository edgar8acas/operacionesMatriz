using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz
{
    public partial class Form1 : Form
    {

        Matriz m = new Matriz(6);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            m.Llenar();
        }

        private void btnLlenarColumnas_Click(object sender, EventArgs e)
        {
            m.LlenarColumnas();
        }

        private void btnLlenarInversa_Click(object sender, EventArgs e)
        {
            m.LlenarInverso();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtPrompt.Text += m.Mostrar();
        }

        private void btnMostrarDP_Click(object sender, EventArgs e)
        {
            txtPrompt.Text += m.MostrarDP();
        }

        private void btnMostrarDS_Click(object sender, EventArgs e)
        {
            txtPrompt.Text += m.MostrarDS();
        }

        private void btnAbajoDP_Click(object sender, EventArgs e)
        {
            txtPrompt.Text += m.AbajoDP();
        }

        private void btnAbajoDS_Click(object sender, EventArgs e)
        {
            txtPrompt.Text += m.ArribaDS();
        }

        private void btnInvertirDP_Click(object sender, EventArgs e)
        {
            txtPrompt.Text += m.InvertirDP();
        }

        private void btnInvertirDS_Click(object sender, EventArgs e)
        {
            txtPrompt.Text += m.InvertirDS();
        }
    }
}
