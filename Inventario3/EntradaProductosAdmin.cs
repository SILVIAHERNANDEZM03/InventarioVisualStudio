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
    public partial class EntradaProductosAdmin : Form
    {
        public EntradaProductosAdmin()
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
            dataGridView1.DataSource = dt;
        }

        public void limpiar_campos()
        {
            txt_Cod_Proveedor.Clear();
            txt_CodigoProducto.Clear();
            txt_CantidadEntrada.Clear();
            txt_NombreProducto.Clear();
            txt_Presentacion.Clear();
            txt_Marca.Clear();
            txt_PrecioUnitario.Clear();
            txt_Cod_Proveedor.Focus();
        }

        private void EntradaProductosAdmin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDinventarioDataSet.Entrada' Puede moverla o quitarla según sea necesario.
            this.entradaTableAdapter.Fill(this.bDinventarioDataSet.Entrada);

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
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
            comando.Parameters.AddWithValue("@cod_proveedor", txt_Cod_Proveedor.Text);
            comando.Parameters.AddWithValue("@codigoproducto", txt_CodigoProducto.Text);
            comando.Parameters.AddWithValue("@nombreproducto", txt_NombreProducto.Text);
            comando.Parameters.AddWithValue("@marca", txt_Marca.Text);
            comando.Parameters.AddWithValue("@presentacion", txt_Presentacion.Text);
            comando.Parameters.AddWithValue("@cantidad", txt_CantidadEntrada.Text);
            comando.Parameters.AddWithValue("@preciounitario", txt_PrecioUnitario.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Agregado correctamente");
            llenar_tabla();
            limpiar_campos();
            coneccion.Close();
        }

        private bool ValidarPrecioUnitario()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_PrecioUnitario.Text))
            {
                ErrorProvider.SetError(txt_PrecioUnitario, "Debe ingresar el precio del producto");
                txt_PrecioUnitario.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_PrecioUnitario, "");
                return true;
            }
        }

        private bool ValidarCantidad()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_CantidadEntrada.Text))
            {
                ErrorProvider.SetError(txt_CantidadEntrada, "Debe ingresar la cantidad de productos que ingreso al inventario del producto");
                txt_CantidadEntrada.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_CantidadEntrada, "");
                return true;
            }
        }

private bool ValidarPresentacion()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_Presentacion.Text))
            {
                ErrorProvider.SetError(txt_Presentacion, "Debe ingresar la presentación del producto");
                txt_Presentacion.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_Presentacion, "");
                return true;
            }
        }

        private bool ValidarMarca()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_Marca.Text))
            {
                ErrorProvider.SetError(txt_Marca, "Debe ingresar la marca del producto");
                txt_Marca.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_Marca, "");
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
            if (string.IsNullOrEmpty(txt_CodigoProducto.Text))
            {
                ErrorProvider.SetError(txt_CodigoProducto, "Debe ingresar el codigo del producto");
                txt_CodigoProducto.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_CodigoProducto, "");
                return true;
            }
        }

        private bool ValidarCod_Proveedor()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_Cod_Proveedor.Text))
            {
                ErrorProvider.SetError(txt_Cod_Proveedor, "Debe ingresar el codigo del proveedor");
                txt_Cod_Proveedor.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_Cod_Proveedor, "");
                return true;
            }
        }

        private void btnRegresarSalida_Click(object sender, EventArgs e)
        {
            Form Menu2Admin = new Menu2Admin();
            this.Hide();
            Menu2Admin.Show();
        }

        private void txt_Cod_Proveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_CodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_CantidadEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_PrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
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

        private void txt_Marca_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Presentacion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnEditarDatos_Click(object sender, EventArgs e)
        {
            Form EntradaEdicionAdmin = new EntradaEdicionAdmin();
            this.Hide();
            EntradaEdicionAdmin.Show();
        }
    }
}
