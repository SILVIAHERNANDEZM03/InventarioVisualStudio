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
    public partial class ProveedoresEmpleados : Form
    {
        public ProveedoresEmpleados()
        {
            InitializeComponent();
        }
        SqlConnection coneccion = new SqlConnection("server= DESKTOP-AM37ABU\\SQLEXPRESS; database= BDinventario; integrated security=true");

        public void llenar_tabla()
        {
            string consulta = "select * from Proveedor";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            gvProveedoresEmpleado.DataSource = dt;
        }

        public void limpiar_campos()
        {
            txt_nombreproveedorEmpleado.Clear();
            txt_empresaEmpleado.Clear();
            txt_productoreparteEmpleado.Clear();
            txt_diasDerepartoEmpleado.Clear();
            txt_codigodeproductoEmpleado.Clear();
            txt_telefonoEmpleado.Clear();
            txt_nombreproveedorEmpleado.Focus();
        }

        private void btn_AgregarproveedorEmpleado_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false)
            {
                return;
            }
            if (ValidarEmpresa() == false)
            {
                return;
            }
            if (ValidarProducto() == false)
            {
                return;
            }
            if (ValidarDiasReparto() == false)
            {
                return;
            }
            if (ValidarTelefono() == false)
            {
                return;
            }
            if (ValidarCodigoProducto() == false)
            {
                return;
            }


            string query = "INSERT INTO Proveedor(NombreProveedor,Empresa,Producto,DiasDeReparto,Cod_Producto,Telefono) VALUES(@nombreproveedor, @empresa, @producto, @diasdereparto, @cod_producto,@telefono)";
            coneccion.Open();
            SqlCommand comando = new SqlCommand(query, coneccion);
            comando.Parameters.AddWithValue("@nombreproveedor", txt_nombreproveedorEmpleado.Text);
            comando.Parameters.AddWithValue("@empresa", txt_empresaEmpleado.Text);
            comando.Parameters.AddWithValue("@producto", txt_productoreparteEmpleado.Text);
            comando.Parameters.AddWithValue("@diasdereparto", txt_diasDerepartoEmpleado.Text);
            comando.Parameters.AddWithValue("@cod_producto", txt_codigodeproductoEmpleado.Text);
            comando.Parameters.AddWithValue("@telefono", txt_telefonoEmpleado.Text);
            comando.ExecuteNonQuery();
            llenar_tabla();
            limpiar_campos();
            MessageBox.Show("Agregado correctamente");
            coneccion.Close();
        }
        private bool ValidarCodigoProducto()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_codigodeproductoEmpleado.Text))
            {
                ErrorProvider.SetError(txt_codigodeproductoEmpleado, "Debe ingresar el codigo del producto");
                txt_codigodeproductoEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_codigodeproductoEmpleado, "");
                return true;
            }
        }
        private bool ValidarTelefono()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_telefonoEmpleado.Text))
            {
                ErrorProvider.SetError(txt_telefonoEmpleado, "Debe ingresar el codigo del producto");
                txt_telefonoEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_telefonoEmpleado, "");
                return true;
            }
        }
        private bool ValidarDiasReparto()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_diasDerepartoEmpleado.Text))
            {
                ErrorProvider.SetError(txt_diasDerepartoEmpleado, "Debe ingresar los dias que reparte los productos");
                txt_diasDerepartoEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_diasDerepartoEmpleado, "");
                return true;
            }
        }

        private bool ValidarProducto()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_productoreparteEmpleado.Text))
            {
                ErrorProvider.SetError(txt_productoreparteEmpleado, "Debe ingresar el nombre del producto");
                txt_productoreparteEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_productoreparteEmpleado, "");
                return true;
            }
        }

        private bool ValidarEmpresa()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_empresaEmpleado.Text))
            {
                ErrorProvider.SetError(txt_empresaEmpleado, "Debe ingresar el nombre de la empresa");
                txt_empresaEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_empresaEmpleado, "");
                return true;
            }

        }

        //Validar el nombre
        private bool ValidarNombre()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_nombreproveedorEmpleado.Text))
            {
                ErrorProvider.SetError(txt_nombreproveedorEmpleado, "Debe ingresar el nombre del proveedor");
                txt_nombreproveedorEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_nombreproveedorEmpleado, "");
                return true;
            }
        }

        private void btn_eliminarproveedorEmpleado_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Proveedor WHERE NombreProveedor=@NombreProveedor";
            coneccion.Open();
            SqlCommand comando = new SqlCommand(query, coneccion);
            comando.Parameters.AddWithValue("@NombreProveedor", txt_nombreproveedorEmpleado.Text);
            comando.ExecuteNonQuery();
            coneccion.Close();
            MessageBox.Show("Registro Borrado Exitosamente");
            llenar_tabla();
            limpiar_campos();
        }

        private void btn_editarproveedorEmpleado_Click(object sender, EventArgs e)
        {
            string consulta = "update Proveedor set Empresa = @empresa, Producto = @producto, DiasDeReparto=@diasdereparto, Cod_Producto= @cod_producto, Telefono=@telefono WHERE NombreProveedor=@NombreProveedor";
            coneccion.Open();
            SqlCommand comando = new SqlCommand(consulta, coneccion);
            comando.Parameters.AddWithValue("@empresa", txt_empresaEmpleado.Text);
            comando.Parameters.AddWithValue("@producto", txt_productoreparteEmpleado.Text);
            comando.Parameters.AddWithValue("@diasdereparto", txt_diasDerepartoEmpleado.Text);
            comando.Parameters.AddWithValue("@cod_producto", txt_codigodeproductoEmpleado.Text);
            comando.Parameters.AddWithValue("@telefono", txt_telefonoEmpleado.Text);
            comando.Parameters.AddWithValue("@NombreProveedor", txt_nombreproveedorEmpleado.Text);
            comando.ExecuteNonQuery();
            llenar_tabla();
            limpiar_campos();
            coneccion.Close();
            MessageBox.Show("Registro Actualizado");
        }

        private void btn_mostrarproductoEmpleado_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from Proveedor", coneccion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            gvProveedoresEmpleado.DataSource = tabla;
        }

        private void gvProveedoresEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nombreproveedorEmpleado.Text = gvProveedoresEmpleado.SelectedCells[1].Value.ToString();
            txt_empresaEmpleado.Text = gvProveedoresEmpleado.SelectedCells[2].Value.ToString();
            txt_productoreparteEmpleado.Text = gvProveedoresEmpleado.SelectedCells[3].Value.ToString();
            txt_diasDerepartoEmpleado.Text = gvProveedoresEmpleado.SelectedCells[4].Value.ToString();
            txt_codigodeproductoEmpleado.Text = gvProveedoresEmpleado.SelectedCells[6].Value.ToString();
            txt_telefonoEmpleado.Text = gvProveedoresEmpleado.SelectedCells[5].Value.ToString();
        }

        private void btn_buscarproveedorEmpleado_Click(object sender, EventArgs e)
        {
            if (ValidarBuscarProveedores() == false)
            {
                return;
            }
            coneccion.Open();
            string consulta = "select * from Proveedor where NombreProveedor= '" + txt_buscasrcodigoProveedoresEmpleado.Text + "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            gvProveedoresEmpleado.DataSource = dt;
            SqlCommand comando = new SqlCommand(consulta, coneccion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            coneccion.Close();
        }
        private bool ValidarBuscarProveedores()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_buscasrcodigoProveedoresEmpleado.Text))
            {
                ErrorProvider.SetError(txt_buscasrcodigoProveedoresEmpleado, "Debe ingresar el nombre completo del proveedor que desea buscar");
                txt_buscasrcodigoProveedoresEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_buscasrcodigoProveedoresEmpleado, "");
                return true;
            }
        }

        private void btnRegresarproveedorEmpleado_Click(object sender, EventArgs e)
        {
            Form Menu2Empleado = new Menu2Empleado();
            this.Hide();
            Menu2Empleado.Show();
        }

        private void txt_nombreproveedorEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_empresaEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_productoreparteEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_diasDerepartoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_telefonoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_codigodeproductoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}
