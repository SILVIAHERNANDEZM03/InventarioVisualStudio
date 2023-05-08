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
    public partial class SalidaProductosAdmin : Form
    {
        public SalidaProductosAdmin()
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
            gvSalida.DataSource = dt;
        }

        public void limpiar_campos()
        {
            txt_CodigoProducto2.Clear();
            txt_NombreProducto.Clear();
            txt_Marca2.Clear();
            txt_Presentacion2.Clear();
            txt_CantidadSalida.Clear();
            txt_PrecioUnitarioSalida.Clear();
            txt_codigoProveedorSalida.Clear();
            txt_CodigoProducto2.Focus();
        }

        private void SalidaProductosAdmin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDinventarioDataSet.Salida' Puede moverla o quitarla según sea necesario.
            this.salidaTableAdapter.Fill(this.bDinventarioDataSet.Salida);

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
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
            comando.Parameters.AddWithValue("@codigoproducto", txt_CodigoProducto2.Text);
            comando.Parameters.AddWithValue("@nombreproducto", txt_NombreProducto.Text);
            comando.Parameters.AddWithValue("@marca", txt_Marca2.Text);
            comando.Parameters.AddWithValue("@presentacion", txt_Presentacion2.Text);
            comando.Parameters.AddWithValue("@cantidad", txt_CantidadSalida.Text);
            comando.Parameters.AddWithValue("@preciounitario", txt_PrecioUnitarioSalida.Text);
            comando.Parameters.AddWithValue("@cod_proveedor", txt_codigoProveedorSalida.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Agregado correctamente");
            llenar_tabla();
            limpiar_campos();
            coneccion.Close();
        }

        private bool ValidarCod_Proveedor()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_codigoProveedorSalida.Text))
            {
                ErrorProvider.SetError(txt_codigoProveedorSalida, "Debe ingresar el codigo del proveedor");
                txt_codigoProveedorSalida.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_codigoProveedorSalida, "");
                return true;
            }
        }

        private bool ValidarPrecioUnitario()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_PrecioUnitarioSalida.Text))
            {
                ErrorProvider.SetError(txt_PrecioUnitarioSalida, "Debe ingresar el precio del producto");
                txt_PrecioUnitarioSalida.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_PrecioUnitarioSalida, "");
                return true;
            }
        }

        private bool ValidarCantidad()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_CantidadSalida.Text))
            {
                ErrorProvider.SetError(txt_CantidadSalida, "Debe ingresar la cantidad de productos que salieron del inventario");
                txt_CantidadSalida.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_CantidadSalida, "");
                return true;
            }
        }

        private bool ValidarPresentacion()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_Presentacion2.Text))
            {
                ErrorProvider.SetError(txt_Presentacion2, "Debe ingresar la presentación del producto");
                txt_Presentacion2.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_Presentacion2, "");
                return true;
            }
        }

        private bool ValidarMarca()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_Marca2.Text))
            {
                ErrorProvider.SetError(txt_Marca2, "Debe ingresar la marca del producto");
                txt_Marca2.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_Marca2, "");
                return true;
            }
        }

        private bool ValidarNombreProducto()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_NombreProducto.Text))
            {
                ErrorProvider.SetError(txt_NombreProducto, "Debe ingresar el nombre del producto");
                txt_NombreProducto.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_NombreProducto, "");
                return true;
            }
        }

        private bool ValidarCodigoProducto()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_CodigoProducto2.Text))
            {
                ErrorProvider.SetError(txt_CodigoProducto2, "Debe ingresar el codigo del producto");
                txt_CodigoProducto2.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_CodigoProducto2, "");
                return true;
            }
        }

        private void btnRegresarSalida_Click(object sender, EventArgs e)
        {
            Form Menu2Admin  = new Menu2Admin();
            this.Hide();
            Menu2Admin.Show();
        }

        private void txt_NombreProducto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Marca2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Presentacion2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_CodigoProducto2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_CantidadSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_PrecioUnitarioSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_codigoProveedorSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void btnEditarDatosSalida_Click(object sender, EventArgs e)
        {
            Form SalidaEdicionAdmin = new SalidaEdicionAdmin();
            this.Hide();
            SalidaEdicionAdmin.Show();
        }
    }
}
