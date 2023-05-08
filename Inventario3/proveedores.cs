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
    public partial class proveedores : Form
    {
        public proveedores()
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
            gvProveedores.DataSource = dt;
        }

        public void limpiar_campos()
        {
            txt_nombreproveedor.Clear();
            txt_empresa.Clear();
            txt_productoreparte.Clear();
            txt_diasDereparto.Clear();
            txt_codigodeproducto.Clear();
            txt_telefono.Clear();
            txt_nombreproveedor.Focus();
        }

        private void btn_Agregarproveedor_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false)
            {
                return;
            }
            if(ValidarEmpresa() == false)
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
            comando.Parameters.AddWithValue("@nombreproveedor", txt_nombreproveedor.Text);
            comando.Parameters.AddWithValue("@empresa", txt_empresa.Text);
            comando.Parameters.AddWithValue("@producto", txt_productoreparte.Text);
            comando.Parameters.AddWithValue("@diasdereparto", txt_diasDereparto.Text);
            comando.Parameters.AddWithValue("@cod_producto", txt_codigodeproducto.Text);
            comando.Parameters.AddWithValue("@telefono", txt_telefono.Text);
            comando.ExecuteNonQuery();
            llenar_tabla();
            limpiar_campos();
            MessageBox.Show("Agregado correctamente");
            coneccion.Close();
        }

        private bool ValidarCodigoProducto()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_codigodeproducto.Text))
            {
                ErrorProvider.SetError(txt_codigodeproducto, "Debe ingresar el codigo del producto");
                txt_codigodeproducto.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_codigodeproducto, "");
                return true;
            }
        }
        private bool ValidarTelefono()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_telefono.Text))
            {
                ErrorProvider.SetError(txt_telefono, "Debe ingresar el codigo del producto");
                txt_telefono.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_telefono, "");
                return true;
            }
        }
        private bool ValidarDiasReparto()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_diasDereparto.Text))
            {
                ErrorProvider.SetError(txt_diasDereparto, "Debe ingresar los dias que reparte los productos");
                txt_diasDereparto.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_diasDereparto, "");
                return true;
            }
        }

        private bool ValidarProducto()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_productoreparte.Text))
            {
                ErrorProvider.SetError(txt_productoreparte, "Debe ingresar el nombre del producto");
                txt_productoreparte.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_productoreparte, "");
                return true;
            }
        }

        private bool ValidarEmpresa()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_empresa.Text))
            {
                ErrorProvider.SetError(txt_empresa, "Debe ingresar el nombre de la empresa");
                txt_empresa.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_empresa, "");
                return true;
            }
            
        }

        //Validar el nombre
        private bool ValidarNombre()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_nombreproveedor.Text))
            {
                ErrorProvider.SetError(txt_nombreproveedor, "Debe ingresar el nombre del proveedor");
                txt_nombreproveedor.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_nombreproveedor, "");
                return true;
            }
        }
    
        private void proveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDinventarioDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.bDinventarioDataSet.Proveedor);

        }

        private void btn_eliminarproveedor_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Proveedor WHERE NombreProveedor=@NombreProveedor";
            coneccion.Open();
            SqlCommand comando = new SqlCommand(query, coneccion);
            comando.Parameters.AddWithValue("@NombreProveedor", txt_nombreproveedor.Text);
            comando.ExecuteNonQuery();
            coneccion.Close();
            MessageBox.Show("Registro Borrado Exitosamente");
            llenar_tabla();
            limpiar_campos();
        }

        private void btn_editarproveedor_Click(object sender, EventArgs e)
        {
            string consulta = "update Proveedor set Empresa = @empresa, Producto = @producto, DiasDeReparto=@diasdereparto, Cod_Producto= @cod_producto, Telefono=@telefono WHERE NombreProveedor=@NombreProveedor";
            coneccion.Open();
            SqlCommand comando = new SqlCommand(consulta, coneccion);
            comando.Parameters.AddWithValue("@empresa", txt_empresa.Text);
            comando.Parameters.AddWithValue("@producto", txt_productoreparte.Text);
            comando.Parameters.AddWithValue("@diasdereparto", txt_diasDereparto.Text);
            comando.Parameters.AddWithValue("@cod_producto", txt_codigodeproducto.Text);
            comando.Parameters.AddWithValue("@telefono", txt_telefono.Text);
            comando.Parameters.AddWithValue("@NombreProveedor", txt_nombreproveedor.Text);
            comando.ExecuteNonQuery();
            llenar_tabla();
            limpiar_campos();
            coneccion.Close();
            MessageBox.Show("Registro Actualizado");
        }

        private void btn_mostrarproducto_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from Proveedor", coneccion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            gvProveedores.DataSource = tabla;
        }

        private void gvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nombreproveedor.Text = gvProveedores.SelectedCells[1].Value.ToString();
            txt_empresa.Text = gvProveedores.SelectedCells[2].Value.ToString();
            txt_productoreparte.Text = gvProveedores.SelectedCells[3].Value.ToString();
            txt_diasDereparto.Text = gvProveedores.SelectedCells[4].Value.ToString();
            txt_codigodeproducto.Text = gvProveedores.SelectedCells[6].Value.ToString();
            txt_telefono.Text = gvProveedores.SelectedCells[5].Value.ToString();
        }

        private void btn_buscarproveedor_Click(object sender, EventArgs e)
        {
            if (ValidarBuscarProveedores() == false)
            {
                return;
            }
            coneccion.Open();
            string consulta = "select * from Proveedor where NombreProveedor= '" + txt_buscasrcodigoProveedores.Text + "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            gvProveedores.DataSource = dt;
            SqlCommand comando = new SqlCommand(consulta, coneccion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            coneccion.Close();
        }

        private bool ValidarBuscarProveedores()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_buscasrcodigoProveedores.Text))
            {
                ErrorProvider.SetError(txt_buscasrcodigoProveedores, "Debe ingresar el nombre completo del proveedor que desea buscar");
                txt_buscasrcodigoProveedores.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_buscasrcodigoProveedores, "");
                return true;
            }
        }

        private void btnRegresarproveedor_Click(object sender, EventArgs e)
        {
            Form Menu2Admin = new Menu2Admin();
            this.Hide();
            Menu2Admin.Show();
        }

        private void txt_buscasrcodigoProveedores_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_nombreproveedor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_empresa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_productoreparte_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_diasDereparto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_codigodeproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}
