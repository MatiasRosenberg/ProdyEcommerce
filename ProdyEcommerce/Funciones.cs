﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.Data.OleDb;

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

            public static AutoCompleteStringCollection Autocompleteidarticulo()
            {
                DataTable dt = Datos();

                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                foreach (DataRow row in dt.Rows)
                {
                    coleccion.Add(Convert.ToString(row["idarticulo"]));
                }

                return coleccion;

            }

            public static AutoCompleteStringCollection Autocompletenombre()
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

        public void Llenarproductos(TextBox cajanombre, TextBox cajadetalle, TextBox cajatags, CheckedListBox listarubros, TextBox cajaidarticulo, CheckBox checkweb, CheckBox Checkvariable, CheckBox agrupar, ListBox lista1, ListBox lista2)
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

            DataTable dtlista2 = new DataTable();
            string Csqllista = "select ARTICULOSJERARQUIAS.IDARTICULO as idarticulo, Articulos.Nombre as nombre from ARTICULOSJERARQUIAS left join articulos on ARTICULOSJERARQUIAS.IDARTICULO = Articulos.IdArticulo where ARTICULOSJERARQUIAS.IDARTICULOFATHER ='" + cajaidarticulo.Text + "'";
            cmd = new SqlCommand(Csqllista, cnn);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            da2.Fill(dtlista2);

            DataTable dtlista1 = new DataTable();
            string Csqllist = "select idarticulo, Nombre from articulos order by Nombre asc";
            cmd = new SqlCommand(Csqllist, cnn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dtlista1);

            //Llenar listbox1 y listbox2
            lista1.DataSource = dtlista1;
            lista1.DisplayMember = "Nombre";
            lista1.ValueMember = dtlista1.Columns[0].ColumnName;

            
            lista2.DataSource = dtlista2;
            lista2.DisplayMember = "nombre";
            lista2.ValueMember = "idarticulo";




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

        public void Grabararticulos(TextBox idarticulo, TextBox txttags, TextBox txtdetalle, CheckBox CBweb, CheckBox CBgroup, CheckBox CBvariable, CheckedListBox listarubros, ListBox lista2, ListBox lista1)
        {
            string cSqldelete = "delete from ecomm_tags  where idarticulo ='" + idarticulo.Text + "'";
            string cSqlinserttags = "insert into ecomm_tags (idarticulo, tags) values("+ "'" + idarticulo.Text + "'" + "," + "'" + txttags.Text + "'" + ")";
            string Csql = "update articulos set WOO_DETALLE='" + txtdetalle.Text + "'" + ",";
            Csql = Csql + "publicarweb=" + Convert.ToInt16(CBweb.Checked) + ",";
            Csql = Csql + "woo_variable=" + Convert.ToInt16(CBvariable.Checked) + ",";
            Csql = Csql + "woo_agrupado=" + Convert.ToInt16(CBgroup.Checked) + "where idarticulo='" + idarticulo.Text + "'";                  
            string Csqlrubros = "select idarticulo, idrubro from rubrosarticulos where idarticulo ='" + idarticulo.Text + "'";
            string Csqllistaartd = "delete from ARTICULOSJERARQUIAS where IDARTICULOFATHER='" + idarticulo.Text + "'";
            


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
                cmd = new SqlCommand(Csqllistaartd, cnn);
                cmd.ExecuteNonQuery();
                for (int i = 0; i < lista2.Items.Count; i++)
                {
                    string Cadena = lista2.Items[i].ToString();
                    int nLargo = Cadena.Length;
                    int cValor = Cadena.IndexOf('?') + 1;
                    string id = Cadena.Substring(cValor, nLargo - cValor);

                    string Csqllistaarti = "insert into ARTICULOSJERARQUIAS (idarticulo, idarticulofather) values(" + "'" + id +"'" + "," + "'" + idarticulo.Text + "'" + ")";
                    cmd = new SqlCommand(Csqllistaarti, cnn);
                    cmd.ExecuteNonQuery();
                }

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

        public void Llenarconfiguracion(ComboBox cblista, ComboBox cbvendedor, ComboBox cbstock, ComboBox cbmoneda, CheckBox Chbox, TextBox imagen)
        {
            string Csqllista = "select * from listas";
            string Csqlvendedor = "select * from vendedores";
            string Csqldeposito = "select * from depositos";
            string Csqlmoneda = "select * from monedas";
            string Csqlconfiguracion = "select * from configuracion";
            
            cmd = new SqlCommand(Csqlconfiguracion, cnn);
            SqlDataReader Rconfiguracion = cmd.ExecuteReader();
            //lista
            da = new SqlDataAdapter(Csqllista, cnn);
            dt = new DataTable();
            da.Fill(dt);
            //vendedor
            da = new SqlDataAdapter(Csqlvendedor, cnn);
            DataTable vendedor = new DataTable();
            da.Fill(vendedor);
            //stock
            da = new SqlDataAdapter(Csqldeposito, cnn);
            DataTable stock = new DataTable();
            da.Fill(stock);
            //moneda
            da = new SqlDataAdapter(Csqlmoneda, cnn);
            DataTable moneda = new DataTable();
            da.Fill(moneda);

            try
            {
                
                //Llenar listas
                cblista.DisplayMember = "Nombre";
                cblista.ValueMember = "idLista";
                cblista.DataSource = dt;
                //Llenar vendedor
                cbvendedor.DisplayMember = "Nombre";
                cbvendedor.ValueMember = "idVendedor";
                cbvendedor.DataSource = vendedor;
                //Llenar deposito
                cbstock.DisplayMember = "Nombre";
                cbstock.ValueMember = "idDeposito";
                cbstock.DataSource = stock;
                //Llenar moneda
                cbmoneda.DisplayMember = "Nombre";
                cbmoneda.ValueMember = "idMoneda";
                cbmoneda.DataSource = moneda;
                //Llenar checkbox y tomar value config
                if (Rconfiguracion.Read() == true)
                {
                    Chbox.Checked = Convert.ToBoolean(Rconfiguracion["WOO_BACKORDER"]);
                    imagen.Text = Rconfiguracion["WOO_IMAGES"].ToString();
                    cblista.SelectedValue = (string)Rconfiguracion["SHOPPRICELIST"];
                    cbvendedor.SelectedValue = (string)Rconfiguracion["SHOPSELLER"];
                    cbstock.SelectedValue = (string)Rconfiguracion["SHOPSTOCKID"];
                    cbmoneda.SelectedValue = (string)Rconfiguracion["SHOPIDMONEDA"];
                }
                else
                {
                    Chbox.Checked = false;
                    imagen.Text = Rconfiguracion["WOO_IMAGES"].ToString();
                    cblista.SelectedValue = (string)Rconfiguracion["SHOPPRICELIST"];
                    cbvendedor.SelectedValue = (string)Rconfiguracion["SHOPSELLER"];
                    cbstock.SelectedValue = (string)Rconfiguracion["SHOPSTOCKID"];
                    cbmoneda.SelectedValue = (string)Rconfiguracion["SHOPIDMONEDA"];
                }
                Rconfiguracion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }     
        }

        public void Grabarconfiguracion(ComboBox cblista, ComboBox cbvendedor, ComboBox cbstock, ComboBox cbmoneda, CheckBox Chbox, TextBox imagen)
        {
            string Csqlcombobox = "update configuracion set SHOPPRICELIST ='" + cblista.SelectedValue.ToString() + "'" + "," ;
            Csqlcombobox = Csqlcombobox + "SHOPSELLER='" + cbvendedor.SelectedValue.ToString() + "'" + "," ;
            Csqlcombobox = Csqlcombobox + "SHOPSTOCKID='" + cbstock.SelectedValue.ToString() + "'" + "," ;
            Csqlcombobox = Csqlcombobox + "SHOPIDMONEDA='" + cbmoneda.SelectedValue.ToString()+ "'" + "," ;
            Csqlcombobox = Csqlcombobox + "WOO_BACKORDER=" + Convert.ToInt16(Chbox.Checked) + "," ;
            Csqlcombobox = Csqlcombobox + "WOO_IMAGES='" + imagen.Text + "'" + "from configuracion";

            try
            {
                cmd = new SqlCommand(Csqlcombobox, cnn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("Se grabo con exito");
        }


        public void Cambiolista(ListBox Lista1, ListBox Lista2)
        {
            bool sihay = false;


            try
            {
                foreach(var item in Lista2.Items)
                {
                    if(item.ToString().Contains(Lista1.Text))
                    {
                        sihay = true;
                    }
                }
                if(sihay)
                {
                    MessageBox.Show("Este articulo ya fue ingresado");
                }
                else
                {
                    Lista2.DataSource = null;
                    for (int i = 0; i < Lista1.Items.Count; i++)
                    {

                        DataRowView r = (DataRowView)Lista1.Items[i];
                        string val = (r[Lista1.ValueMember]).ToString();
                        string dis = (r[Lista1.DisplayMember]).ToString();
                        if(Lista1.SelectedValue.ToString() == val)
                        {
                            Lista2.Items.Add(Lista1.Text +""+"?"+""+ Lista1.SelectedValue.ToString().Trim());
                        }
                    }
                    
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

