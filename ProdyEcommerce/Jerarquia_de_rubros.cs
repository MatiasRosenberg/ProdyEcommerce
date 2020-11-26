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
    public partial class Jerarquia_de_rubros : Form
    {
        Funciones F = new Funciones();
        SqlConnection cnn = BaseDatos.DbConnection.getDBConnection();

        public Jerarquia_de_rubros()
        {
            InitializeComponent();
        }

        private void btnbuscarrubro_Click(object sender, EventArgs e)
        {
            button1_Click(null, null);
            Busqueda_rubros B = new Busqueda_rubros();
            B.ShowDialog();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtidrubro_Leave(object sender, EventArgs e)
        {
            F.LLenarJerarquiaderubros(chkrubros, txtidrubro);
        }

        private void txtidrubro_TextChanged(object sender, EventArgs e)
        {
            F.LLenarJerarquiaderubros(chkrubros, txtidrubro);
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            F.Grabarjerarquia(chkrubros, txtidrubro);
            button1_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtidrubro.Text = "";
            txtnombrerubro.Text = "";
            chkrubros.DataSource = null;
            chkrubros.Items.Clear();
            txtidrubro.Focus();
        }
    }
}
