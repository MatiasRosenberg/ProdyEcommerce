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
    public partial class Busqueda_avanzada : Form
    {
        public Busqueda_avanzada()
        {
            InitializeComponent();
        }

        private void Busqueda_avanzada_Load(object sender, EventArgs e)
        {
            comboboxfiltro.Items.Add("Idarticulo");
            comboboxfiltro.Items.Add("Nombre");
        }
    }
}
