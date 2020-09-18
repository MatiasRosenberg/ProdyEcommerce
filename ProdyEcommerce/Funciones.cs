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

        public void Check(CheckBox checkweb, CheckBox Checkvariable, CheckBox agrupar, CheckBox Checkreserva, TextBox cajaid)
        {
            cmd = new SqlCommand("select * from articulos where idarticulo ='" + cajaid.Text + "'", cnn);
            SqlDataReader read = cmd.ExecuteReader();
            cmd = new SqlCommand("select isnull(woo_agrupado, 0) from articulos where idarticulo ='" + cajaid.Text + "'", cnn);
            SqlDataReader read1 = cmd.ExecuteReader();
            cmd = new SqlCommand("select woo_backorder from configuracion where woo_backorder = '1'", cnn);
            SqlDataReader read2 = cmd.ExecuteReader();


            //checkear configuracion
            if (read2.Read() == true)
            {
                Checkreserva.Checked = true;
            }
            else
            {
                Checkreserva.Checked = false;
            }

            //checkear agrupado
            if (read1.Read() == true)
            {
                agrupar.Checked = false;
            }
            else
            {
                agrupar.Checked = true;
            }

            //checkear variable y puvlicar
            if (read.Read() == true)
            {
                checkweb.Checked = Convert.ToBoolean(read["publicarweb"]);
                Checkvariable.Checked = Convert.ToBoolean(read["woo_Variable"]);
            }
            else
            {
                checkweb.Checked = false;
                Checkvariable.Checked = false;
            }
        }

        public void grabartags(TextBox idarticulo, TextBox txttags)
        {
           
            string salida = "";
            string cSqldelete = "delete from ecomm_tags  where idarticulo ='" + idarticulo.Text + "'";
            string cSqlinsert = "insert into ecomm_tags (idarticulo, tags) values("+ "'" + idarticulo.Text + "'" + "," + "'" + txttags.Text + "'" + ")";
            try
            {
                //comando para hacer sentencias en sql
                cmd = new SqlCommand(cSqldelete, cnn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(cSqlinsert, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los tags se guardaron correctamente");

            }
            catch (Exception ex)
            {
                salida = "No se pudo ejecutar: " + ex.ToString();
            }
            
        }

        public void grabardetalles(TextBox idarticulo, TextBox txtdetalle)
        {

            string salida = "";
            string cSqlinsert = "update Articulos set WOO_DETALLE = " + "'"+txtdetalle.Text+"'"+ " from articulos where idarticulo ='" + idarticulo.Text + "'";
            try
            {
                //comando para hacer sentencias en sql
                cmd = new SqlCommand(cSqlinsert, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los detalles se guardaron correctamente");

            }
            catch (Exception ex)
            {
                salida = "No se pudo ejecutar: " + ex.ToString();
            }
        }

        public void grabarpweb(CheckBox CB, TextBox idarticulo)
        {
            string cSqlweb0 = "update Articulos set publicarweb = 0 from articulos where idarticulo ='" + idarticulo.Text + "'";
            string cSqlweb1 = "update Articulos set publicarweb = 1 from articulos where idarticulo ='" + idarticulo.Text + "'";
            string salida = "";

            if (CB.Checked == true)
            {
                try
                {
                    //comando para hacer sentencias en sql
                    cmd = new SqlCommand(cSqlweb1, cnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("La publicacion web se guardo correctamente");

                }
                catch (Exception ex)
                {
                    salida = "No se pudo ejecutar: " + ex.ToString();
                }

            }
            else
            {
                try
                {
                    //comando para hacer sentencias en sql
                    cmd = new SqlCommand(cSqlweb0, cnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("La publicacion web se guardo correctamente");

                }
                catch (Exception ex)
                {
                    salida = "No se pudo ejecutar: " + ex.ToString();
                }
            }
        }

        public void grabaragrupado(CheckBox CB, TextBox idarticulo)
        {
            string cSqlweb0 = "update Articulos set publicarweb = 0 from articulos where idarticulo ='" + idarticulo.Text + "'";
            string cSqlweb1 = "update Articulos set publicarweb = 1 from articulos where idarticulo ='" + idarticulo.Text + "'";
            string salida = "";

            if (CB.Checked == true)
            {
                try
                {
                    //comando para hacer sentencias en sql
                    cmd = new SqlCommand(cSqlweb1, cnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("La publicacion web se guardo correctamente");

                }
                catch (Exception ex)
                {
                    salida = "No se pudo ejecutar: " + ex.ToString();
                }

            }
            else
            {
                try
                {
                    //comando para hacer sentencias en sql
                    cmd = new SqlCommand(cSqlweb0, cnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("La publicacion web se guardo correctamente");

                }
                catch (Exception ex)
                {
                    salida = "No se pudo ejecutar: " + ex.ToString();
                }
            }
        }

        public void grabarpreserva(CheckBox CB)
        {
            string cSqlreserva0 = "update configuracion set woo_backorder = 0 from configuracion";
            string cSqlreserva1 = "update configuracion set woo_backorder = 1 from configuracion";
            string salida = "";

            if (CB.Checked == true)
            {
                try
                {
                    //comando para hacer sentencias en sql
                    cmd = new SqlCommand(cSqlreserva1, cnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("La reserva se guardo correctamente");

                }
                catch (Exception ex)
                {
                    salida = "No se pudo ejecutar: " + ex.ToString();
                }

            }
            else
            {
                try
                {
                    //comando para hacer sentencias en sql
                    cmd = new SqlCommand(cSqlreserva0, cnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("La reserva se guardo correctamente");

                }
                catch (Exception ex)
                {
                    salida = "No se pudo ejecutar: " + ex.ToString();
                }
            }
        }

        public void grabarpvariable(CheckBox CB, TextBox idarticulo)
        {
            string cSqlvariable0 = "update articulos set woo_variable = 0 from articulos where idarticulo ='" + idarticulo.Text + "'";
            string cSqlvariable1 = "update articulos set woo_variable = 1 from articulos where idarticulo ='" + idarticulo.Text + "'";
            string salida = "";

            if (CB.Checked == true)
            {
                try
                {
                    //comando para hacer sentencias en sql
                    cmd = new SqlCommand(cSqlvariable1, cnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("La variable se guardo correctamente");

                }
                catch (Exception ex)
                {
                    salida = "No se pudo ejecutar: " + ex.ToString();
                }

            }
            else
            {
                try
                {
                    //comando para hacer sentencias en sql
                    cmd = new SqlCommand(cSqlvariable0, cnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("La variable se guardo correctamente");

                }
                catch (Exception ex)
                {
                    salida = "No se pudo ejecutar: " + ex.ToString();
                }
            }
        }


    }
}

