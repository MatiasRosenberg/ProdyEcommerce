using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdyEcommerce
{
    public partial class Productos : Form
    {

        Funciones F = new Funciones();
        SqlConnection cnn = BaseDatos.DbConnection.getDBConnection();
        public Productos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Funciones F = new Funciones();
            txtarticulo.AutoCompleteCustomSource = Funciones.AutoCompleClass.Autocomplete();
            txtarticulo.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtarticulo.AutoCompleteSource = AutoCompleteSource.CustomSource;

            F.Llenarcheckbox(chkrubros, txtarticulo);           
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
            Cbpagrupado.Checked = false;
            CBPulicar.Checked = false;
            txtarticulo.Enabled = true;
            txtnombre.Enabled = true;
            btnbuscar.Enabled = true;
            txtarticulo.Focus();
        }

        private void txtarticulo_Leave(object sender, EventArgs e)
        {
            
            if (txtnombre.Text == "")
            {
                F.Completarnombe(txtnombre, txtarticulo);
                F.Completardetalle(txtdetalles, txtarticulo);
                F.Completartags(txttags, txtarticulo);
                txtarticulo.Enabled = false;
                txtnombre.Enabled = false;
                F.Checkarticulos(CBPulicar, Cbpvariable, Cbpagrupado, txtarticulo);
            }
        }
        
        private void txtnombre_Leave(object sender, EventArgs e)
        {
            
            if (txtarticulo.Text == "")
            {
                F.Completarid(txtnombre, txtarticulo);
                F.Completardetalle(txtdetalles, txtarticulo);
                F.Completartags(txttags, txtarticulo);
                txtarticulo.Enabled = false;
                txtnombre.Enabled = false;
                F.Checkarticulos(CBPulicar, Cbpvariable, Cbpagrupado, txtarticulo);
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

        private void txtarticulo_TextChanged(object sender, EventArgs e)
        {  
            if(txtarticulo.Text == "")
            {
                F.Completarnombe(txtnombre, txtarticulo);
                F.Completardetalle(txtdetalles, txtarticulo);
                F.Completartags(txttags, txtarticulo);
                txtarticulo.Enabled = false;
                txtnombre.Enabled = false;
                F.Checkarticulos(CBPulicar, Cbpvariable, Cbpagrupado, txtarticulo);
            }                
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            F.Completarid(txtnombre, txtarticulo);
            F.Completardetalle(txtdetalles, txtarticulo);
            F.Completartags(txttags, txtarticulo);
            txtarticulo.Enabled = false;
            txtnombre.Enabled = false;
            F.Checkarticulos(CBPulicar, Cbpvariable, Cbpagrupado, txtarticulo);
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            F.Grabararticulos(txtarticulo, txttags, txtdetalles, CBPulicar, Cbpagrupado, Cbpvariable);
            btnlimpiar_Click(null, null);

        }
    }
}
