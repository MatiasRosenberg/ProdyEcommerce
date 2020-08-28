﻿using System;
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
    }
}

