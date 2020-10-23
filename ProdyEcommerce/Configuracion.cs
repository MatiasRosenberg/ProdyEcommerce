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
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        Funciones F = new Funciones();
        private void Configuracion_Load(object sender, EventArgs e)
        {
            F.Llenarconfiguracion(cbpublicar, cbvendedor, cbstock, cbmoneda, chbreserva, txtimagen);
        }

        private void Btngrabar_Click_1(object sender, EventArgs e)
        {
            F.Grabarconfiguracion(cbpublicar, cbvendedor, cbstock, cbmoneda, chbreserva, txtimagen);
            this.Close();
        }

        private void Btnsalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
