using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario3
{
    public partial class Admin : Form
    {
        public Admin(string nombre)
        {
            InitializeComponent();
            lblmensajeAdmin.Text = nombre;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form Form1 = new Form1();
                this.Hide();
                Form1.Show();
            }
        }

        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            Form proveedores = new proveedores();
            this.Hide();
            proveedores.Show();
        }

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            Form RegistroEmpleados = new RegistroEmpleados();
            this.Hide();
            RegistroEmpleados.Show();
        }

        private void btn_Entrada_Click(object sender, EventArgs e)
        {
            Form EntradaProductosAdmin = new EntradaProductosAdmin();
            this.Hide();
            EntradaProductosAdmin.Show();
        }

        private void btn_Salida_Click(object sender, EventArgs e)
        {
            Form SalidaProductosAdmin = new SalidaProductosAdmin();
            this.Hide();
            SalidaProductosAdmin.Show();
        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            Form StockProductosAdmin = new StockProductosAdmin();
            this.Hide();
            StockProductosAdmin.Show();
        }
    }
}
