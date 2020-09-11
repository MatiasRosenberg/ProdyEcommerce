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
    public partial class ProdyEcommerce : Form
    {

        static string Codigo;
        static string Nombre;

        public ProdyEcommerce(string codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Funciones F = new Funciones();
            txtarticulo.AutoCompleteCustomSource = Funciones.AutoCompleClass.Autocomplete();
            txtarticulo.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtarticulo.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtnombre.AutoCompleteCustomSource = Funciones.AutoCompleClass.Autocompleten();
            txtnombre.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtnombre.AutoCompleteSource = AutoCompleteSource.CustomSource;

            F.llenarcheckbox(chkrubros);

            txtarticulo.Text = Codigo;
            txtnombre.Text = Nombre;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        Busqueda_avanzada busqueda = new Busqueda_avanzada();
        

        private void btnbuscar_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(txtarticulo.Text) == true || string.IsNullOrEmpty(txtnombre.Text) == true)
            {
                busqueda.Show();
                txtarticulo.Enabled = true;
                txtnombre.Enabled = true;
            }
            
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
            btnbuscar.Enabled = true;
        }

        private void txtarticulo_Leave(object sender, EventArgs e)
        {
            Funciones F = new Funciones();
            if (txtnombre.Text == "")
            {
                F.completarnombe(txtnombre, txtarticulo);
                F.Completardetalle(txtdetalles, txtarticulo);
                F.Completartags(txttags, txtarticulo);
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
                F.Completardetalle(txtdetalles, txtarticulo);
                F.Completartags(txttags, txtarticulo);
                txtarticulo.Enabled = false;
                txtnombre.Enabled = false;
            }

        }

        private void txtarticulo_Validated(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtarticulo.Text) == true || string.IsNullOrEmpty(txtnombre.Text) == true)
            {
                txtarticulo.Enabled = false;
            }
            else
            {
                txtarticulo.Enabled = true;
            }

        }

        private void txtnombre_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtarticulo.Text) == true || string.IsNullOrEmpty(txtnombre.Text) == true)
            {
                txtnombre.Enabled = false;
            }
            else
            {
                txtnombre.Enabled = true;
            }
        }

        private void chkrubros_Validated(object sender, EventArgs e)
        {
            
        }
    }
}
