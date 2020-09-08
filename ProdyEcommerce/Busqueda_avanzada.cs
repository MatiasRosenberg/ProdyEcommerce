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
        SqlConnection cnn = BaseDatos.DbConnection.getDBConnection();
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;

        Funciones F = new Funciones();
        private void Busqueda_avanzada_Load(object sender, EventArgs e)
        {
            comboboxfiltro.Items.Add("Codigo");
            comboboxfiltro.Items.Add("Nombre");

            
            F.llenardatagrid(dgvarticulos);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (comboboxfiltro.SelectedIndex == 0)
            {
                cmd = new SqlCommand("Select idarticulo as Codigo, Nombre from articulos where idarticulo like('" + txtbusqueda.Text + "%')", cnn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvarticulos.DataSource = dt;
            }
            if (comboboxfiltro.SelectedIndex == 1)
            {
                cmd = new SqlCommand("Select idarticulo as Codigo, Nombre from articulos where Nombre like('" + txtbusqueda.Text + "%')", cnn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvarticulos.DataSource = dt;
            }
        }
        
        private void dgvarticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdyEcommerce Prody = new ProdyEcommerce();

            DataGridViewRow rellenar = dgvarticulos.Rows[e.RowIndex];

            Prody.txtnombre.Text = dgvarticulos.CurrentRow.Cells["nombre"].Value.ToString();
            Prody.txtarticulo.Text = dgvarticulos.CurrentRow.Cells["Codigo"].Value.ToString();
        }
    }
}
