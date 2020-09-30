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
                    coleccion.Add(Convert.ToString(row["nombre"]));
                }

            return coleccion;

            }

        }

        public void Completarnombe(TextBox cajanombre, TextBox cajaidarticulo)
        {
            cmd = new SqlCommand("Select nombre from articulos where idarticulo='" + cajaidarticulo.Text + "'", cnn);
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

        public void Completarid(TextBox cajanombre, TextBox cajaidarticulo)
        {
            cmd = new SqlCommand("Select idarticulo from articulos where nombre='" + cajanombre.Text + "'", cnn);
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

        public void Llenardatagrid(DataGridView dgv)
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

        public void Llenarcheckbox(CheckedListBox listarubros)
        {
            DataTable dt = new DataTable();

            string consultarubros = "select idRubro, Nombre from rubros order by nombre asc";
            cmd = new SqlCommand(consultarubros, cnn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            listarubros.DataSource = dt;
            listarubros.DisplayMember = "Nombre";
            listarubros.ValueMember = "idRubro";
        }

        public void Checkarticulos(CheckBox checkweb, CheckBox Checkvariable, CheckBox agrupar, TextBox cajaid)
        {
            string Csql = "select isnull(woo_agrupado, 0) agrupado , publicarweb, woo_variable from articulos where idarticulo ='" + cajaid.Text + "'";
            cmd = new SqlCommand(Csql, cnn);
            SqlDataReader read = cmd.ExecuteReader();


            //checkear variable y puvlicar
            if (read.Read() == true)
            {
                checkweb.Checked = Convert.ToBoolean(read["publicarweb"]);
                Checkvariable.Checked = Convert.ToBoolean(read["woo_Variable"]);
                agrupar.Checked = Convert.ToBoolean(read["agrupado"]);
            }
            else
            {
                checkweb.Checked = false;
                Checkvariable.Checked = false;
                agrupar.Checked = false;
            }
        }

        public void Grabararticulos(TextBox idarticulo, TextBox txttags, TextBox txtdetalle, CheckBox CBweb, CheckBox CBgroup, CheckBox CBvariable)
        {
            string cSqldelete = "delete from ecomm_tags  where idarticulo ='" + idarticulo.Text + "'";
            string cSqlinserttags = "insert into ecomm_tags (idarticulo, tags) values("+ "'" + idarticulo.Text + "'" + "," + "'" + txttags.Text + "'" + ")";
            string Csql = "update articulos set woo_detalle=" + "'" + txtdetalle.Text + "'" + ",";
            Csql = Csql + "publicarweb=" + Convert.ToInt16(CBweb.Checked) + ",";
            Csql = Csql + "woo_variable=" + Convert.ToInt16(CBvariable.Checked) + ",";
            Csql = Csql + "woo_agrupado=" + Convert.ToInt16(CBgroup.Checked) + "where idarticulo='" + idarticulo.Text + "'";
            
            try
            {
                //comando para hacer sentencias en sql
                cmd = new SqlCommand(cSqldelete, cnn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(cSqlinserttags, cnn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(Csql, cnn);
                cmd.ExecuteNonQuery();
                cnn.BeginTransaction();
                cmd.Transaction.Commit();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                Console.WriteLine("  Message: {0}", ex.Message);
                try
                {
                    cmd.Transaction.Rollback();
                }
                catch(Exception ex2)
                {
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
            }


            MessageBox.Show("Se grabo correctamente");

        }
    }
}

