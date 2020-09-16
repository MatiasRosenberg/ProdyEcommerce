using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ProdyEcommerce
{
    class Funciones
    {
        SqlConnection cnn = BaseDatos.DbConnection.getDBConnection();
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;


        public static class AutoCompleClass
        {
            public static DataTable Datos()
            {
                DataTable dt = new DataTable();

                SqlConnection cnn = BaseDatos.DbConnection.getDBConnection();
                string sql = "select idarticulo, nombre from articulos";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                return dt;

            }


            public static AutoCompleteStringCollection Autocomplete()
            {
                DataTable dt = Datos();

                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["idarticulo"]));
            }

            return coleccion;

            }

            public static AutoCompleteStringCollection Autocompleten()
            {
                DataTable dt = Datos();

                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                foreach (DataRow row in dt.Rows)
                {
                    coleccion.Add(Convert.ToString(row["nombre"]));
                }

                return coleccion;

            }

        }

        public void completarnombe(TextBox cajanombre, TextBox cajaidarticulo)
        {
            cmd = new SqlCommand("Select * from articulos where idarticulo='" + cajaidarticulo.Text + "'", cnn);
            SqlDataReader read = cmd.ExecuteReader();
            
            if(read.Read() == true)
            {
                cajanombre.Text = read["nombre"].ToString();
            }
            else
            {
                cajanombre.Text = "";
            }
        }

        public void completarid(TextBox cajanombre, TextBox cajaidarticulo)
        {
            cmd = new SqlCommand("Select * from articulos where nombre='" + cajanombre.Text + "'", cnn);
            SqlDataReader read = cmd.ExecuteReader();

            if (read.Read() == true)
            {
                cajaidarticulo.Text = read["idarticulo"].ToString();
            }
            else
            {
                cajaidarticulo.Text = "";
            }
        }

        public void Completardetalle(TextBox cajadetalle, TextBox cajaidarticulo)
        {
            cmd = new SqlCommand("Select WOO_DETALLE from articulos where idarticulo='" + cajaidarticulo.Text + "'", cnn);
            SqlDataReader read = cmd.ExecuteReader();

            if (read.Read() == true)
            {
                cajadetalle.Text = read["WOO_DETALLE"].ToString();
            }
            else
            {
                cajadetalle.Text = "";
            }
        }

        public void Completartags(TextBox cajatags, TextBox cajaidarticulo)
        {
            cmd = new SqlCommand("Select TAGS from ecomm_tags where idarticulo='" + cajaidarticulo.Text + "'", cnn);
            SqlDataReader read = cmd.ExecuteReader();

            if (read.Read() == true)
            {
                cajatags.Text = read["TAGS"].ToString();
            }
            else
            {
                cajatags.Text = "";
            }
        }

        public void llenardatagrid(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select idarticulo as Codigo, Nombre from articulos", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }

            catch(Exception ex)
            {
                MessageBox.Show("no se pudo llenar la tabla" + ex.ToString());
            }
        }

        public void llenarcheckbox(CheckedListBox listarubros)
        {
            DataTable dt = new DataTable();

            string consultarubros = "select * from rubros order by nombre asc";
            cmd = new SqlCommand(consultarubros, cnn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            listarubros.DataSource = dt;
            listarubros.DisplayMember = "Nombre";
        }
    }
}

