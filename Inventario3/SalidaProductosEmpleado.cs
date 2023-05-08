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
    public partial class SalidaProductosEmpleado : Form
    {
        public SalidaProductosEmpleado()
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
            gvSalidaEmpleado.DataSource = dt;
        }

        public void limpiar_campos()
        {
            txt_CodigoProducto2Empleado.Clear();
            txt_NombreProductoEmpleado.Clear();
            txt_Marca2Empleado.Clear();
            txt_Presentacion2Empleado.Clear();
            txt_CantidadSalidaEmpleado.Clear();
            txt_PrecioUnitarioSalidaEmpleado.Clear();
            txt_codigoProveedorSalidaEmpleado.Clear();
            txt_CodigoProducto2Empleado.Focus();
        }

        private void btnRegresarSalidaEmpleado_Click(object sender, EventArgs e)
        {
            Form Menu2Empleado = new Menu2Empleado();
            this.Hide();
            Menu2Empleado.Show();
        }

        private void verificarStock()
        {
            string codigoProducto = txt_CodigoProducto2Empleado.Text;
            int cantidad;
            if (!int.TryParse(txt_CantidadSalidaEmpleado.Text, out cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero", "Error de formato");
                return;
            }

            // Obtener la cantidad actual de productos en el inventario
            string query = "SELECT Cantidad FROM Stock WHERE CodigoProducto=@codigoproducto";
            SqlCommand comando = new SqlCommand(query, coneccion);
            comando.Parameters.AddWithValue("@codigoproducto", codigoProducto);
            coneccion.Open();
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                int cantidadActual;
                if (int.TryParse(reader["Cantidad"].ToString(), out cantidadActual))
                {
                    // Verificar si se hace un descuento y solo quedan 5 productos
                    if (cantidadActual - cantidad == 5)
                    {
                        string mensaje = "Solo quedan 5 productos en el inventario de " + txt_NombreProductoEmpleado.Text;
                        MessageBox.Show(mensaje, "Alerta de inventario");
                    }
                }
                else
                {
                    MessageBox.Show("Error al obtener la cantidad actual de productos en el inventario", "Error de conversión");
                }
            }
            else
            {
                MessageBox.Show("El producto no existe en el inventario", "Error de búsqueda");
            }
            coneccion.Close();
        }

        private void btn_AgregarEmpleado_Click(object sender, EventArgs e)
        {
            if (ValidarCodigoProducto() == false)
            {
                return;
            }
            if (ValidarNombreProducto() == false)
            {
                return;
            }
            if (ValidarMarca() == false)
            {
                return;
            }
            if (ValidarPresentacion() == false)
            {
                return;
            }
            if (ValidarCantidad() == false)
            {
                return;
            }
            if (ValidarPrecioUnitario() == false)
            {
                return;
            }
            if (ValidarCod_Proveedor() == false)
            {
                return;
            }
            string query = "INSERT INTO Salida(FechaSalida,CodigoProducto,NombreProducto,Marca,Presentacion,Cantidad,PrecioUnitario,Cod_Proveedor) VALUES(@fechasalida,@codigoproducto,@nombreproducto,@marca,@presentacion, @cantidad,@preciounitario,@cod_proveedor)";
            coneccion.Open();
            SqlCommand comando = new SqlCommand(query, coneccion);
            comando.Parameters.AddWithValue("@fechasalida", date_FechaSalida.Text);
            comando.Parameters.AddWithValue("@codigoproducto", txt_CodigoProducto2Empleado.Text);
            comando.Parameters.AddWithValue("@nombreproducto", txt_NombreProductoEmpleado.Text);
            comando.Parameters.AddWithValue("@marca", txt_Marca2Empleado.Text);
            comando.Parameters.AddWithValue("@presentacion", txt_Presentacion2Empleado.Text);
            comando.Parameters.AddWithValue("@cantidad", txt_CantidadSalidaEmpleado.Text);
            comando.Parameters.AddWithValue("@preciounitario", txt_PrecioUnitarioSalidaEmpleado.Text);
            comando.Parameters.AddWithValue("@cod_proveedor", txt_codigoProveedorSalidaEmpleado.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Agregado correctamente");
            llenar_tabla();
            limpiar_campos();
            // Verificar stock y mostrar alerta si es necesario
            verificarStock();
            coneccion.Close();
        }
        private bool ValidarCod_Proveedor()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_codigoProveedorSalidaEmpleado.Text))
            {
                ErrorProvider.SetError(txt_codigoProveedorSalidaEmpleado, "Debe ingresar el codigo del proveedor");
                txt_codigoProveedorSalidaEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_codigoProveedorSalidaEmpleado, "");
                return true;
            }
        }

        private bool ValidarPrecioUnitario()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_PrecioUnitarioSalidaEmpleado.Text))
            {
                ErrorProvider.SetError(txt_PrecioUnitarioSalidaEmpleado, "Debe ingresar el precio del producto");
                txt_PrecioUnitarioSalidaEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_PrecioUnitarioSalidaEmpleado, "");
                return true;
            }
        }

        private bool ValidarCantidad()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_CantidadSalidaEmpleado.Text))
            {
                ErrorProvider.SetError(txt_CantidadSalidaEmpleado, "Debe ingresar la cantidad de productos que salieron del inventario");
                txt_CantidadSalidaEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_CantidadSalidaEmpleado, "");
                return true;
            }
        }

        private bool ValidarPresentacion()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_Presentacion2Empleado.Text))
            {
                ErrorProvider.SetError(txt_Presentacion2Empleado, "Debe ingresar la presentación del producto");
                txt_Presentacion2Empleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_Presentacion2Empleado, "");
                return true;
            }
        }

        private bool ValidarMarca()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_Marca2Empleado.Text))
            {
                ErrorProvider.SetError(txt_Marca2Empleado, "Debe ingresar la marca del producto");
                txt_Marca2Empleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_Marca2Empleado, "");
                return true;
            }
        }

        private bool ValidarNombreProducto()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_NombreProductoEmpleado.Text))
            {
                ErrorProvider.SetError(txt_NombreProductoEmpleado, "Debe ingresar el nombre del producto");
                txt_NombreProductoEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_NombreProductoEmpleado, "");
                return true;
            }
        }

        private bool ValidarCodigoProducto()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_CodigoProducto2Empleado.Text))
            {
                ErrorProvider.SetError(txt_CodigoProducto2Empleado, "Debe ingresar el codigo del producto");
                txt_CodigoProducto2Empleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_CodigoProducto2Empleado, "");
                return true;
            }
        }

        private void txt_CodigoProducto2Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_CantidadSalidaEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_PrecioUnitarioSalidaEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_codigoProveedorSalidaEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_NombreProductoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnEditarDatosSalidaEmpleado_Click(object sender, EventArgs e)
        {
            Form SalidaEdicionEmpleado = new SalidaEdicionEmpleado();
            this.Hide();
            SalidaEdicionEmpleado.Show();
        }

        private void btn_Mostrar3Empleado2_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from Salida", coneccion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            gvSalidaEmpleado.DataSource = tabla;
        }

        private void gvSalidaEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            date_FechaSalida.Text = gvSalidaEmpleado.SelectedCells[1].Value.ToString();
            txt_CodigoProducto2Empleado.Text = gvSalidaEmpleado.SelectedCells[2].Value.ToString();
            txt_NombreProductoEmpleado.Text = gvSalidaEmpleado.SelectedCells[3].Value.ToString();
            txt_Marca2Empleado.Text = gvSalidaEmpleado.SelectedCells[4].Value.ToString();
            txt_Presentacion2Empleado.Text = gvSalidaEmpleado.SelectedCells[5].Value.ToString();
            txt_CantidadSalidaEmpleado.Text = gvSalidaEmpleado.SelectedCells[6].Value.ToString();
            txt_PrecioUnitarioSalidaEmpleado.Text = gvSalidaEmpleado.SelectedCells[7].Value.ToString();
            txt_codigoProveedorSalidaEmpleado.Text = gvSalidaEmpleado.SelectedCells[8].Value.ToString();
        }
    }
}
