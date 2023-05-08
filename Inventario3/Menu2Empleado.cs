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
    public partial class Menu2Empleado : Form
    {
        public Menu2Empleado()
        {
            InitializeComponent();
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

        private void btn_Entrada_Click(object sender, EventArgs e)
        {
            Form EntradaProductoEmpleado = new EntradaProductoEmpleado();
            this.Hide();
            EntradaProductoEmpleado.Show();
        }

        private void btn_Salida_Click(object sender, EventArgs e)
        {
            Form SalidaProductosEmpleado = new SalidaProductosEmpleado();
            this.Hide();
            SalidaProductosEmpleado.Show();
        }

        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            Form ProveedoresEmpleados = new ProveedoresEmpleados();
            this.Hide();
            ProveedoresEmpleados.Show();
        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            Form StockProductosEmpleados = new StockProductosEmpleados();
            this.Hide();
            StockProductosEmpleados.Show();
        }
    }
}
