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
    public partial class EntradaProductoEmpleado : Form
    {
        public EntradaProductoEmpleado()
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
            gvEntradaEmpleado.DataSource = dt;
        }

        public void limpiar_campos()
        {
            txt_Cod_ProveedorEmpleado.Clear();
            txt_CodigoProductoEmpleado.Clear();
            txt_CantidadEntradaEmpleado.Clear();
            txt_NombreProductoEmpleado.Clear();
            txt_PresentacionEmpleado.Clear();
            txt_MarcaEmpleado.Clear();
            txt_PrecioUnitarioEmpleado.Clear();
            txt_Cod_ProveedorEmpleado.Focus();
        }

        private void btnRegresarSalida_Click(object sender, EventArgs e)
        {
            Form Menu2Empleado = new Menu2Empleado();
            this.Hide();
            Menu2Empleado.Show();
        }

        private void btn_AgregarEmpleado_Click(object sender, EventArgs e)
        {
            if (ValidarCod_Proveedor() == false)
            {
                return;
            }
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
            string query = "INSERT INTO Entrada(FechaEntrada,Cod_Proveedor,CodigoProducto,NombreProducto,Marca,Presentacion, Cantidad, PrecioUnitario) VALUES(@fechaentrada,@cod_proveedor,@codigoproducto,@nombreproducto,@marca,@presentacion, @cantidad,@preciounitario)";
            coneccion.Open();
            SqlCommand comando = new SqlCommand(query, coneccion);
            comando.Parameters.AddWithValue("@fechaentrada", date_FechaEntrada.Text);
            comando.Parameters.AddWithValue("@cod_proveedor", txt_Cod_ProveedorEmpleado.Text);
            comando.Parameters.AddWithValue("@codigoproducto", txt_CodigoProductoEmpleado.Text);
            comando.Parameters.AddWithValue("@nombreproducto", txt_NombreProductoEmpleado.Text);
            comando.Parameters.AddWithValue("@marca", txt_MarcaEmpleado.Text);
            comando.Parameters.AddWithValue("@presentacion", txt_PresentacionEmpleado.Text);
            comando.Parameters.AddWithValue("@cantidad", txt_CantidadEntradaEmpleado.Text);
            comando.Parameters.AddWithValue("@preciounitario", txt_PrecioUnitarioEmpleado.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Agregado correctamente");
            llenar_tabla();
            limpiar_campos();
            coneccion.Close();
        }
        private bool ValidarPrecioUnitario()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_PrecioUnitarioEmpleado.Text))
            {
                ErrorProvider.SetError(txt_PrecioUnitarioEmpleado, "Debe ingresar el precio del producto");
                txt_PrecioUnitarioEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_PrecioUnitarioEmpleado, "");
                return true;
            }
        }

        private bool ValidarCantidad()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_CantidadEntradaEmpleado.Text))
            {
                ErrorProvider.SetError(txt_CantidadEntradaEmpleado, "Debe ingresar la cantidad de productos que ingreso al inventario del producto");
                txt_CantidadEntradaEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_CantidadEntradaEmpleado, "");
                return true;
            }
        }

        private bool ValidarPresentacion()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_PresentacionEmpleado.Text))
            {
                ErrorProvider.SetError(txt_PresentacionEmpleado, "Debe ingresar la presentación del producto");
                txt_PresentacionEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_PresentacionEmpleado, "");
                return true;
            }
        }

        private bool ValidarMarca()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_MarcaEmpleado.Text))
            {
                ErrorProvider.SetError(txt_MarcaEmpleado, "Debe ingresar la marca del producto");
                txt_MarcaEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_MarcaEmpleado, "");
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
            if (string.IsNullOrEmpty(txt_CodigoProductoEmpleado.Text))
            {
                ErrorProvider.SetError(txt_CodigoProductoEmpleado, "Debe ingresar el codigo del producto");
                txt_CodigoProductoEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_CodigoProductoEmpleado, "");
                return true;
            }
        }

        private bool ValidarCod_Proveedor()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_Cod_ProveedorEmpleado.Text))
            {
                ErrorProvider.SetError(txt_Cod_ProveedorEmpleado, "Debe ingresar el codigo del proveedor");
                txt_Cod_ProveedorEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_Cod_ProveedorEmpleado, "");
                return true;
            }
        }

        private void txt_Cod_ProveedorEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_CodigoProductoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_CantidadEntradaEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_PrecioUnitarioEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_MarcaEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_PresentacionEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnEditarDatosEmpleado_Click(object sender, EventArgs e)
        {
            Form EntradaEdicionEmpleado = new EntradaEdicionEmpleado();
            this.Hide();
            EntradaEdicionEmpleado.Show();
        }

        private void btn_MostrarEmpleado_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from Entrada", coneccion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            gvEntradaEmpleado.DataSource = tabla;
        }

        private void gvEntradaEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            date_FechaEntrada.Text = gvEntradaEmpleado.SelectedCells[1].Value.ToString();
            txt_Cod_ProveedorEmpleado.Text = gvEntradaEmpleado.SelectedCells[2].Value.ToString();
            txt_CodigoProductoEmpleado.Text = gvEntradaEmpleado.SelectedCells[3].Value.ToString();
            txt_NombreProductoEmpleado.Text = gvEntradaEmpleado.SelectedCells[4].Value.ToString();
            txt_MarcaEmpleado.Text = gvEntradaEmpleado.SelectedCells[5].Value.ToString();
            txt_PresentacionEmpleado.Text = gvEntradaEmpleado.SelectedCells[6].Value.ToString();
            txt_CantidadEntradaEmpleado.Text = gvEntradaEmpleado.SelectedCells[7].Value.ToString();
            txt_PrecioUnitarioEmpleado.Text = gvEntradaEmpleado.SelectedCells[8].Value.ToString();
        }
    }
}
