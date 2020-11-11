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
                busqueda.ShowDialog();
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
            chkrubros.DataSource = null;
            chkrubros.Items.Clear();
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox2.DataSource = null;
            listBox2.Items.Clear();
            txtarticulo.Focus();
        }

        private void txtarticulo_Leave(object sender, EventArgs e)
        {
            
            if (txtnombre.Text == "")
            {
                F.Llenarproductos(txtnombre, txtdetalles, txttags, chkrubros, txtarticulo, CBPulicar, Cbpvariable, Cbpagrupado, listBox1, listBox2);
                txtarticulo.Enabled = false;
                txtnombre.Enabled = false;
            }
        }
        
        private void txtnombre_Leave(object sender, EventArgs e)
        {
            
            if (txtarticulo.Text == "")
            {
                F.Llenarproductos(txtnombre, txtdetalles, txttags, chkrubros, txtarticulo, CBPulicar, Cbpvariable, Cbpagrupado, listBox1, listBox2);
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

        private void txtarticulo_TextChanged(object sender, EventArgs e)
        {  
            if(txtarticulo.Text == "")
            {
                F.Llenarproductos(txtnombre, txtdetalles, txttags, chkrubros, txtarticulo, CBPulicar, Cbpvariable, Cbpagrupado, listBox1, listBox2);
                txtarticulo.Enabled = false;
                txtnombre.Enabled = false;
            }                
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            F.Llenarproductos(txtnombre, txtdetalles, txttags, chkrubros, txtarticulo, CBPulicar, Cbpvariable, Cbpagrupado, listBox1, listBox2);
            txtarticulo.Enabled = false;
            txtnombre.Enabled = false;
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            F.Grabararticulos(txtarticulo, txttags, txtdetalles, CBPulicar, Cbpagrupado, Cbpvariable, chkrubros, listBox2, listBox1);
            btnlimpiar_Click(null, null);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            F.Cambiolista(listBox1, listBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            F.Cambiolista(listBox1, listBox2);
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);

        }

        List<string> listcollection = new List<string>();
        private void txtlistart_TextChanged(object sender, EventArgs e)
        {
            int index = listBox1.FindString(this.txtlistart.Text);
            if (0 <= index)
            {
                listBox1.SelectedIndex = index;
            }
        }
    }
}
