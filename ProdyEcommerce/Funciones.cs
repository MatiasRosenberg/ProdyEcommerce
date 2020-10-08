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

        public void Llenar(TextBox cajanombre, TextBox cajadetalle, TextBox cajatags, CheckedListBox listarubros, TextBox cajaidarticulo, CheckBox checkweb, CheckBox Checkvariable, CheckBox agrupar)
        {
            cmd = new SqlCommand("Select nombre, idarticulo, WOO_DETALLE  from articulos where idarticulo='" + cajaidarticulo.Text + "'", cnn);
            SqlDataReader read = cmd.ExecuteReader();
            cmd = new SqlCommand("Select TAGS from ecomm_tags where idarticulo='" + cajaidarticulo.Text + "'", cnn);
            SqlDataReader read1 = cmd.ExecuteReader();

            //dtrubros
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
            SqlDataReader read2 = cmd.ExecuteReader();

            string CsqlCheck = "select isnull(woo_agrupado, 0) agrupado , publicarweb, woo_variable from articulos where idarticulo ='" + cajaidarticulo.Text + "'";
            cmd = new SqlCommand(CsqlCheck, cnn);
            SqlDataReader read3 = cmd.ExecuteReader();

            //recorrer checklistbox
            if (read2.HasRows)
            {
                while (read2.Read())
                {

                    /* Con esta logica, se obtiene el valor y el nombre de cada elemento del checklistbox */
                    for (int i = 0; i < listarubros.Items.Count; i++)
                    {

                        DataRowView r = (DataRowView)listarubros.Items[i];
                        string val = (r[listarubros.ValueMember]).ToString();
                        string dis = (r[listarubros.DisplayMember]).ToString();
                        r = null;
                        if (read2["Idrubro"].ToString() == val)
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


            //Nombre, woo_detalle
            if (read.Read() == true)
            {
                cajanombre.Text = read["nombre"].ToString();
                cajadetalle.Text = read["WOO_DETALLE"].ToString();
            }
            else
            {
                cajanombre.Text = "";
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

            //checkboxs
            if (read3.Read() == true)
            {
                checkweb.Checked = Convert.ToBoolean(read3["publicarweb"]);
                Checkvariable.Checked = Convert.ToBoolean(read3["woo_Variable"]);
                agrupar.Checked = Convert.ToBoolean(read3["agrupado"]);
            }
            else
            {
                checkweb.Checked = false;
                Checkvariable.Checked = false;
                agrupar.Checked = false;
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

            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar la tabla" + ex.ToString());
            }
        }

        public void Grabararticulos(TextBox idarticulo, TextBox txttags, TextBox txtdetalle, CheckBox CBweb, CheckBox CBgroup, CheckBox CBvariable, CheckedListBox listarubros)
        {
            string cSqldelete = "delete from ecomm_tags  where idarticulo ='" + idarticulo.Text + "'";
            string cSqlinserttags = "insert into ecomm_tags (idarticulo, tags) values("+ "'" + idarticulo.Text + "'" + "," + "'" + txttags.Text + "'" + ")";
            string Csql = "update articulos set WOO_DETALLE='" + txtdetalle.Text + "'" + ",";
            Csql = Csql + "publicarweb=" + Convert.ToInt16(CBweb.Checked) + ",";
            Csql = Csql + "woo_variable=" + Convert.ToInt16(CBvariable.Checked) + ",";
            Csql = Csql + "woo_agrupado=" + Convert.ToInt16(CBgroup.Checked) + "where idarticulo='" + idarticulo.Text + "'";                  
            string Csqlrubros = "select idarticulo, idrubro from rubrosarticulos where idarticulo ='" + idarticulo.Text + "'";
            cmd = new SqlCommand(Csqlrubros, cnn);
            SqlDataReader read = cmd.ExecuteReader();

            if (read.HasRows)
            {
                while (read.Read())
                {

                    /* Con esta logica, se obtiene el valor y el nombre de cada elemento del checklistbox */
                    for (int i = 0; i < listarubros.Items.Count; i++)
                    {
                        
                        DataRowView r = (DataRowView)listarubros.Items[i];
                        string val = (r[listarubros.ValueMember]).ToString();
                        string dis = (r[listarubros.DisplayMember]).ToString();
                        r = null;
                        string Csqldrubros = "delete from rubrosarticulos where idarticulo='" + idarticulo.Text + "'" + "and idrubro='" + val + "'";
                        if (listarubros.GetItemCheckState(i) == CheckState.Checked)
                        {
                            
                            cmd = new SqlCommand(Csqldrubros, cnn);
                            cmd.ExecuteNonQuery();
                            string Csqlirubros = "insert into rubrosarticulos (idarticulo, idrubro) values(" + "'" + idarticulo.Text + "'" + "," + "'" + val + "'" + ")";
                            cmd = new SqlCommand(Csqlirubros, cnn);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            cmd = new SqlCommand(Csqldrubros, cnn);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            read.Close();

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

