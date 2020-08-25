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
        SqlDataReader dr;

        public void autocompletarid(TextBox cajatexto)
        {
            try
            {
                cmd = new SqlCommand("Select * from articulos", cnn);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    cajatexto.AutoCompleteCustomSource.Add(dr["idarticulo"].ToString());
                }
                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se puede completar:" + ex.ToString());
            }
        }

        public void autocompletarnombre(TextBox cajatexto)
        {
            try
            {
                cmd = new SqlCommand("Select * from articulos", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cajatexto.AutoCompleteCustomSource.Add(dr["nombre"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede completar:" + ex.ToString());
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
    }
}

