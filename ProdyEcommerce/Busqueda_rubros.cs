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
    public partial class Busqueda_rubros : Form
    {
        Funciones F = new Funciones();
        SqlConnection cnn = BaseDatos.DbConnection.getDBConnection();
        SqlCommand cmd;
        public Busqueda_rubros()
        {
            InitializeComponent();
        }

        private void Busqueda_rubros_Load(object sender, EventArgs e)
        {
            F.LLenardatagridr(dgvrubros);

            comboboxfiltro.Items.Add("Codigo");
            comboboxfiltro.Items.Add("Nombre");
            comboboxfiltro.SelectedIndex = 1;

        }

        private void dgvrubros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {

                Jerarquia_de_rubros J = Application.OpenForms.OfType<Jerarquia_de_rubros>().SingleOrDefault();
                J.txtidrubro.Text = dgvrubros.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                J.txtnombrerubro.Text = dgvrubros.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                this.Hide();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (comboboxfiltro.SelectedIndex == 0)
            {
                cmd = new SqlCommand("Select idrubro as Codigo, Nombre from rubros where idrubro like('" + txtbusqueda.Text + "%')", cnn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvrubros.DataSource = dt;

            }
            if (comboboxfiltro.SelectedIndex == 1)
            {
                cmd = new SqlCommand("Select idrubro as Codigo, Nombre from rubros where Nombre like('" + txtbusqueda.Text + "%')", cnn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvrubros.DataSource = dt;

            }
        }

        private void Busqueda_rubros_FormClosed(object sender, FormClosedEventArgs e)
        {
            comboboxfiltro.Items.Clear();
        }
    }
}
