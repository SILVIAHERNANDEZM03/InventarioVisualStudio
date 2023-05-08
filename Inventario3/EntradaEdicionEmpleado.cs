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

namespace Inventario3
{
    public partial class EntradaEdicionEmpleado : Form
    {
        public EntradaEdicionEmpleado()
        {
            InitializeComponent();
        }
        SqlConnection coneccion = new SqlConnection("server= DESKTOP-AM37ABU\\SQLEXPRESS; database= BDinventario; integrated security=true");

        public void llenar_tabla()
        {
            string consulta = "select * from Entrada";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            gvEntradaEdicionEmpleado.DataSource = dt;
        }

        public void limpiar_campos()
        {
            txt_Cod_Proveedor2Empleado.Clear();
            txt_CodigoProducto2Empleado.Clear();
            txt_CantidadEntrada2Empleado.Clear();
            txt_NombreProducto2Empleado.Clear();
            txt_Presentacion2Empleado.Clear();
            txt_Marca2Empleado.Clear();
            txt_PrecioUnitario2Empleado.Clear();
            txt_Cod_Proveedor2Empleado.Focus();
        }

        private void btn_Mostrar2Empleado_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from Entrada", coneccion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            gvEntradaEdicionEmpleado.DataSource = tabla;
        }

        private void gvEntradaEdicionEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            date_FechaEntrada.Text = gvEntradaEdicionEmpleado.SelectedCells[1].Value.ToString();
            txt_Cod_Proveedor2Empleado.Text = gvEntradaEdicionEmpleado.SelectedCells[2].Value.ToString();
            txt_CodigoProducto2Empleado.Text = gvEntradaEdicionEmpleado.SelectedCells[3].Value.ToString();
            txt_NombreProducto2Empleado.Text = gvEntradaEdicionEmpleado.SelectedCells[4].Value.ToString();
            txt_Marca2Empleado.Text = gvEntradaEdicionEmpleado.SelectedCells[5].Value.ToString();
            txt_Presentacion2Empleado.Text = gvEntradaEdicionEmpleado.SelectedCells[6].Value.ToString();
            txt_CantidadEntrada2Empleado.Text = gvEntradaEdicionEmpleado.SelectedCells[7].Value.ToString();
            txt_PrecioUnitario2Empleado.Text = gvEntradaEdicionEmpleado.SelectedCells[8].Value.ToString();
        }

        private void btnRegresarSalidaEmpleado_Click(object sender, EventArgs e)
        {
            Form EntradaProductoEmpleado = new EntradaProductoEmpleado();
            this.Hide();
            EntradaProductoEmpleado.Show();
        }

        private void btn_EditarEntradaEmpleado_Click(object sender, EventArgs e)
        {
            // Obtener el ID de la entrada seleccionada
            int id = Convert.ToInt32(gvEntradaEdicionEmpleado.SelectedCells[0].Value);

            // Actualizar la entrada en la base de datos
            string query = "UPDATE Entrada SET FechaEntrada = @fechaentrada, CodigoProducto = @codigoProducto, NombreProducto = @nombreProducto, Marca = @marca, Presentacion = @presentacion, Cantidad = @cantidad, PrecioUnitario = @precioUnitario WHERE Cod_Proveedor = @cod_proveedor";

            SqlCommand command = new SqlCommand(query, coneccion);

            command.Parameters.AddWithValue("@fechaentrada", date_FechaEntrada.Value);
            command.Parameters.AddWithValue("@codigoProducto", txt_CodigoProducto2Empleado.Text);
            command.Parameters.AddWithValue("@nombreProducto", txt_NombreProducto2Empleado.Text);
            command.Parameters.AddWithValue("@marca", txt_Marca2Empleado.Text);
            command.Parameters.AddWithValue("@presentacion", txt_Presentacion2Empleado.Text);
            command.Parameters.AddWithValue("@cantidad", txt_CantidadEntrada2Empleado.Text);
            command.Parameters.AddWithValue("@preciounitario", float.Parse(txt_PrecioUnitario2Empleado.Text));
            command.Parameters.AddWithValue("@Cod_Proveedor", txt_Cod_Proveedor2Empleado.Text);

            coneccion.Open();
            command.ExecuteNonQuery();
            coneccion.Close();

            // Actualizar la tabla en el formulario
            llenar_tabla();
            limpiar_campos();
        }

        private void btn_BuscarEmpleado_Click(object sender, EventArgs e)
        {
            if (ValidarBuscarProductosEntrada() == false)
            {
                return;
            }
            string consulta = "SELECT * FROM Entrada WHERE NombreProducto LIKE '%" + txt_BuscarEmpleado.Text + "%'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            gvEntradaEdicionEmpleado.DataSource = dt;
        }
        private bool ValidarBuscarProductosEntrada()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_BuscarEmpleado.Text))
            {
                ErrorProvider.SetError(txt_BuscarEmpleado, "Debe ingresar el nombre del producto que desea buscar");
                txt_BuscarEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_BuscarEmpleado, "");
                return true;
            }
        }

        private void txt_Cod_Proveedor2Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_CodigoProducto2Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_CantidadEntrada2Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_PrecioUnitario2Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_NombreProducto2Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es una letra
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Verificar si la tecla presionada es un signo o un espacio en blanco
                if (!char.IsPunctuation(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true; // Si no es una letra, signo o espacio, ignorar la entrada
                }
            }
        }

        private void txt_Marca2Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es una letra
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Verificar si la tecla presionada es un signo o un espacio en blanco
                if (!char.IsPunctuation(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true; // Si no es una letra, signo o espacio, ignorar la entrada
                }
            }
        }

        private void txt_Presentacion2Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es una letra
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Verificar si la tecla presionada es un signo o un espacio en blanco
                if (!char.IsPunctuation(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true; // Si no es una letra, signo o espacio, ignorar la entrada
                }
            }
        }
    }
}
