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
    public partial class SalidaEdicionEmpleado : Form
    {
        public SalidaEdicionEmpleado()
        {
            InitializeComponent();
        }
        SqlConnection coneccion = new SqlConnection("server= DESKTOP-AM37ABU\\SQLEXPRESS; database= BDinventario; integrated security=true");

        public void llenar_tabla()
        {
            string consulta = "select * from Salida";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            gvSalida3Empleado.DataSource = dt;
        }

        public void limpiar_campos()
        {
            txt_CodigoProducto3Empleado.Clear();
            txt_NombreProducto3Empleado.Clear();
            txt_Marca3Empleado.Clear();
            txt_Presentacion3Empleado.Clear();
            txt_CantidadSalida3Empleado.Clear();
            txt_PrecioUnitarioSalida3Empleado.Clear();
            txt_codigoProveedorSalida3Empleado.Clear();
            txt_CodigoProducto3Empleado.Focus();
        }

        private void btn_EditarEntrada3Empleado_Click(object sender, EventArgs e)
        {
            coneccion.Open();
            // Actualizar la entrada en la base de datos
            string query = "UPDATE Salida SET FechaSalida = @fechasalida, NombreProducto = @nombreproducto, Marca = @marca, Presentacion = @presentacion, Cantidad = @cantidad, PrecioUnitario = @preciounitario, Cod_Proveedor=@cod_proveedor WHERE CodigoProducto = @codigoproducto";

            SqlCommand command = new SqlCommand(query, coneccion);

            command.Parameters.AddWithValue("@fechasalida", date_FechaSalida.Value);
            command.Parameters.AddWithValue("@nombreproducto", txt_NombreProducto3Empleado.Text);
            command.Parameters.AddWithValue("@marca", txt_Marca3Empleado.Text);
            command.Parameters.AddWithValue("@presentacion", txt_Presentacion3Empleado.Text);
            command.Parameters.AddWithValue("@cantidad", txt_CantidadSalida3Empleado.Text);
            command.Parameters.AddWithValue("@preciounitario", float.Parse(txt_PrecioUnitarioSalida3Empleado.Text));
            command.Parameters.AddWithValue("@cod_proveedor", txt_codigoProveedorSalida3Empleado.Text);
            command.Parameters.AddWithValue("@CodigoProducto", txt_CodigoProducto3Empleado.Text);
            command.ExecuteNonQuery();
            coneccion.Close();
            llenar_tabla();
            limpiar_campos();
        }

        private void btn_Mostrar3Empleado_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from Salida", coneccion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            gvSalida3Empleado.DataSource = tabla;
        }

        private void gvSalida3Empleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            date_FechaSalida.Text = gvSalida3Empleado.SelectedCells[1].Value.ToString();
            txt_CodigoProducto3Empleado.Text = gvSalida3Empleado.SelectedCells[2].Value.ToString();
            txt_NombreProducto3Empleado.Text = gvSalida3Empleado.SelectedCells[3].Value.ToString();
            txt_Marca3Empleado.Text = gvSalida3Empleado.SelectedCells[4].Value.ToString();
            txt_Presentacion3Empleado.Text = gvSalida3Empleado.SelectedCells[5].Value.ToString();
            txt_CantidadSalida3Empleado.Text = gvSalida3Empleado.SelectedCells[6].Value.ToString();
            txt_PrecioUnitarioSalida3Empleado.Text = gvSalida3Empleado.SelectedCells[7].Value.ToString();
            txt_codigoProveedorSalida3Empleado.Text = gvSalida3Empleado.SelectedCells[8].Value.ToString();
        }

        private void btnRegresarSalidaEmpleado_Click(object sender, EventArgs e)
        {
            Form SalidaProductosEmpleado = new SalidaProductosEmpleado();
            this.Hide();
            SalidaProductosEmpleado.Show();
        }

        private void btn_Buscar3Empleado_Click(object sender, EventArgs e)
        {
            if (ValidarBuscarProductosSalida() == false)
            {
                return;
            }
            string consulta = "SELECT * FROM Salida WHERE NombreProducto LIKE '%" + txt_Buscar3Empleado.Text + "%'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            gvSalida3Empleado.DataSource = dt;
        }
        private bool ValidarBuscarProductosSalida()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_Buscar3Empleado.Text))
            {
                ErrorProvider.SetError(txt_Buscar3Empleado, "Debe ingresar el nombre del producto que desea buscar");
                txt_Buscar3Empleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_Buscar3Empleado, "");
                return true;
            }
        }

        private void txt_CodigoProducto3Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_CantidadSalida3Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_PrecioUnitarioSalida3Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_codigoProveedorSalida3Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_NombreProducto3Empleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Marca3Empleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Presentacion3Empleado_KeyPress(object sender, KeyPressEventArgs e)
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
