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
        private bool insideCheckEveryOther;

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
        
        public void Llenar(TextBox cajanombre, TextBox cajadetalle, TextBox cajatags, CheckedListBox listarubros, TextBox cajaidarticulo)
        {
            cmd = new SqlCommand("Select nombre, idarticulo, WOO_DETALLE  from articulos where idarticulo='" + cajaidarticulo.Text + "'", cnn);
            SqlDataReader read = cmd.ExecuteReader();
            cmd = new SqlCommand("Select TAGS from ecomm_tags where idarticulo='" + cajaidarticulo.Text + "'", cnn);
            SqlDataReader read1 = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            string consultarubros = "select idRubro, Nombre from rubros order by nombre asc";
            cmd = new SqlCommand(consultarubros, cnn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            listarubros.DataSource = dt;
            listarubros.DisplayMember = "Nombre";
            listarubros.ValueMember = "idRubro";


            string Csql = "select idarticulo, idrubro from rubrosarticulos where idarticulo ='" + cajaidarticulo.Text + "'";
            cmd = new SqlCommand(Csql, cnn);
            SqlDataReader read2= cmd.ExecuteReader();




            if (read2.HasRows)
            {
                while (read2.Read())
                {
                    for (int i = 0; i < listarubros.Items.Count -1; i++)
                    {
                        if (read2.GetString(i) == read2["idRubro"].ToString())
                        {
                            listarubros.SetItemChecked(i, true);
                        }
                        
                    }
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            read2.Close();




            //articulo, nombre
            if (read.Read() == true)
            {
                cajanombre.Text = read["nombre"].ToString();
            }
            else
            {
                cajanombre.Text = "";
            }

            

            //woo_dedtalle
            if (read.Read() == true)
            {
                cajadetalle.Text = read["WOO_DETALLE"].ToString();
            }
            else
            {
                cajadetalle.Text = "";
            }

            //tags
            if (read1.Read() == true)
            {
                cajatags.Text = read1["TAGS"].ToString();
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
            string Csql = "update articulos set WOO_DETALLE='" + "'" + txtdetalle.Text + "'" + ",";
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

