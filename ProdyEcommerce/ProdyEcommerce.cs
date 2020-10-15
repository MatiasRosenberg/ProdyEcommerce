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
    public partial class Prodyecommerce : Form
    {
        public Prodyecommerce()
        {
            InitializeComponent();
        }

        private void Btnproductos_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();

            p.Show();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnconfiguracion_Click(object sender, EventArgs e)
        {
            Configuracion C = new Configuracion();

            C.Show();
        }
    }
}
