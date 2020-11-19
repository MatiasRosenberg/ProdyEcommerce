using System;
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
    public partial class Jerarquia_de_rubros : Form
    {
        public Jerarquia_de_rubros()
        {
            InitializeComponent();
        }

        private void btnbuscarrubro_Click(object sender, EventArgs e)
        {
            Busqueda_rubros B = new Busqueda_rubros();
            B.ShowDialog();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
