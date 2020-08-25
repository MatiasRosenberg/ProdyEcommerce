using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdyEcommerce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Funciones F = new Funciones();
            F.autocompletarid(txtarticulo);
            F.autocompletarnombre(txtnombre);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Busqueda_avanzada busqueda = new Busqueda_avanzada();
            busqueda.Show();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtarticulo.Text = "";
            txtdetalles.Text = "";
            txtnombre.Text = "";
            txttags.Text = "";
            chbreservas.Checked = false;
            chbpublicar.Checked = false;
            txtarticulo.Enabled = true;
            txtnombre.Enabled = true;
        }

        private void txtarticulo_Leave(object sender, EventArgs e)
        {
            Funciones F = new Funciones();
            if (txtnombre.Text == "")
            {
                F.completarnombe(txtnombre, txtarticulo);
                txtarticulo.Enabled = false;
                txtnombre.Enabled = false;
            }
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            Funciones F = new Funciones();
            if (txtarticulo.Text == "")
            {
                F.completarid(txtnombre, txtarticulo);
                txtarticulo.Enabled = false;
                txtnombre.Enabled = false;
            }
        }
    }
}
