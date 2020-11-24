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
            Busqueda_rubros B = new Busqueda_rubros();
            B.ShowDialog();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtidrubro_Leave(object sender, EventArgs e)
        {
            F.LLenarJerarquiaderubros(checkedListBox1, txtidrubro);
        }

        private void txtidrubro_TextChanged(object sender, EventArgs e)
        {
            F.LLenarJerarquiaderubros(checkedListBox1, txtidrubro);
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            F.Grabarjerarquia(checkedListBox1, txtidrubro);
        }
    }
}
