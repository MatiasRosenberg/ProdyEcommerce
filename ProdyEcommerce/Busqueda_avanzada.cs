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



        Funciones F = new Funciones();
        private void Busqueda_avanzada_Load(object sender, EventArgs e)
        {
            comboboxfiltro.Items.Add("Codigo");
            comboboxfiltro.Items.Add("Nombre");



            F.Llenardatagrid(dgvarticulos);
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


                txtbusqueda.AutoCompleteCustomSource = Funciones.AutoCompleClass.Autocompleteidarticulo();
                txtbusqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtbusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;

            }
            if (comboboxfiltro.SelectedIndex == 1)
            {
                cmd = new SqlCommand("Select idarticulo as Codigo, Nombre from articulos where Nombre like('" + txtbusqueda.Text + "%')", cnn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvarticulos.DataSource = dt;

                txtbusqueda.AutoCompleteCustomSource = Funciones.AutoCompleClass.Autocompletenombre();
                txtbusqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtbusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void dgvarticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                
                Productos P = Application.OpenForms.OfType<Productos>().SingleOrDefault();
                P.txtarticulo.Text = dgvarticulos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                P.txtnombre.Text = dgvarticulos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                this.Hide();
            }
        }

        private void Busqueda_avanzada_FormClosed(object sender, FormClosedEventArgs e)
        {
            comboboxfiltro.Items.Clear();
        }
    }
}
