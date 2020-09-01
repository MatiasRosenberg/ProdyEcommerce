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

        private void Busqueda_avanzada_Load(object sender, EventArgs e)
        {
            comboboxfiltro.Items.Add("codigo");
            comboboxfiltro.Items.Add("Nombre");

            Funciones F = new Funciones();
            F.llenardatagrid(dgvarticulos);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            //if(comboboxfiltro.SelectedIndex == 1)
            //{
            //    try
            //    {
            //        DataSet ds;

            //        string cmd = "select * from articulos where nombre like ('%" + txtbusqueda.Text.Trim() + "%')";

            //    }
            //}
        }

        private void dgvarticulos_SelectionChanged(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
           
            var row = (sender as DataGridView).CurrentRow;
            
            F1.txtarticulo.Text = row.Cells[0].Value.ToString();
        }
    }
}
