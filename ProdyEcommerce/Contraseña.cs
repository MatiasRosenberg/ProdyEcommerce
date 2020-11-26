using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdyEcommerce
{
    public partial class Contraseña : Form
    {
        string contraseña = "SYNCMASIVA";
        SqlConnection cnn = BaseDatos.DbConnection.getDBConnection();

        public Contraseña()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            string Csql = "SyncProductos";
            if(txtcontraseña.Text == contraseña)
            {
                SqlDataAdapter da = new SqlDataAdapter(Csql,cnn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                MessageBox.Show("Sincronización masiva procesada");
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
                txtcontraseña.Clear();
                txtcontraseña.Focus();
                return;
            }
        }
    }
}
