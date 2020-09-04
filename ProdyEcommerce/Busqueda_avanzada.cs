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
    public partial class Busqueda_avanzada : Form
    {
        public Busqueda_avanzada()
        {
            InitializeComponent();

        }
        Funciones F = new Funciones();
        private void Busqueda_avanzada_Load(object sender, EventArgs e)
        {
            comboboxfiltro.Items.Add("Codigo");
            comboboxfiltro.Items.Add("Nombre");

            
            F.llenardatagrid(dgvarticulos);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            
        }
        
        private void dgvarticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form1 F1 = new Form1();

            DataGridViewRow rellenar = dgvarticulos.Rows[e.RowIndex];

            F1.txtarticulo.Text = rellenar.Cells["Codigo"].Value.ToString();
            F1.txtnombre.Text = rellenar.Cells["Nombre"].Value.ToString();
            Hide();
        }
    }
}
