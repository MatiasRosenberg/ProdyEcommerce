﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdyEcommerce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Funciones F = new Funciones();
            txtarticulo.AutoCompleteCustomSource = Funciones.AutoCompleClass.Autocomplete();
            txtarticulo.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtarticulo.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtnombre.AutoCompleteCustomSource = Funciones.AutoCompleClass.Autocompleten();
            txtnombre.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtnombre.AutoCompleteSource = AutoCompleteSource.CustomSource;

            F.llenarcheckbox(chkrubros);


        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Busqueda_avanzada busqueda = new Busqueda_avanzada();

            if(string.IsNullOrEmpty(txtarticulo.Text) == true || string.IsNullOrEmpty(txtnombre.Text) == true)
            {
                busqueda.Show();
            }
            
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtarticulo.Text = "";
            txtdetalles.Text = "";
            txtnombre.Text = "";
            txttags.Text = "";
            chbreservas.Checked = false;
            chbpublicar.Checked = false;
            txtarticulo.Enabled = true;
            txtnombre.Enabled = true;
            btnbuscar.Enabled = true;
        }

        private void txtarticulo_Leave(object sender, EventArgs e)
        {
            Funciones F = new Funciones();
            if (txtnombre.Text == "")
            {
                F.completarnombe(txtnombre, txtarticulo);
                F.Completardetalle(txtdetalles, txtarticulo);
                F.Completartags(txttags, txtarticulo);
                txtarticulo.Enabled = false;
                txtnombre.Enabled = false;
            }
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            Funciones F = new Funciones();
            if (txtarticulo.Text == "")
            {
                F.completarid(txtnombre, txtarticulo);
                F.Completardetalle(txtdetalles, txtarticulo);
                F.Completartags(txttags, txtarticulo);
                txtarticulo.Enabled = false;
                txtnombre.Enabled = false;
            }

        }

        private void txtarticulo_Validated(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtarticulo.Text) == true || string.IsNullOrEmpty(txtnombre.Text) == true)
            {
                btnbuscar.Enabled = true;
            }
            else
            {
                btnbuscar.Enabled = false;
            }

        }

        private void txtnombre_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtarticulo.Text) == true || string.IsNullOrEmpty(txtnombre.Text) == true)
            {
                btnbuscar.Enabled = true;
            }
            else
            {
                btnbuscar.Enabled = false;
            }
        }
    }
}
