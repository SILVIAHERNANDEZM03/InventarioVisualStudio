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
    public partial class SalidaEdicionAdmin : Form
    {
        public SalidaEdicionAdmin()
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
            gvSalida3.DataSource = dt;
        }

        public void limpiar_campos()
        {
            txt_CodigoProducto3.Clear();
            txt_NombreProducto3.Clear();
            txt_Marca3.Clear();
            txt_Presentacion3.Clear();
            txt_CantidadSalida3.Clear();
            txt_PrecioUnitarioSalida3.Clear();
            txt_codigoProveedorSalida3.Clear();
            txt_CodigoProducto3.Focus();
        }


        private void btn_EditarEntrada3_Click(object sender, EventArgs e)
        {
            coneccion.Open();
            // Actualizar la entrada en la base de datos
            string query = "UPDATE Salida SET FechaSalida = @fechasalida, NombreProducto = @nombreproducto, Marca = @marca, Presentacion = @presentacion, Cantidad = @cantidad, PrecioUnitario = @preciounitario, Cod_Proveedor=@cod_proveedor WHERE CodigoProducto = @codigoproducto";

            SqlCommand command = new SqlCommand(query, coneccion);

            command.Parameters.AddWithValue("@fechasalida", date_FechaSalida.Value);
            command.Parameters.AddWithValue("@nombreproducto", txt_NombreProducto3.Text);
            command.Parameters.AddWithValue("@marca", txt_Marca3.Text);
            command.Parameters.AddWithValue("@presentacion", txt_Presentacion3.Text);
            command.Parameters.AddWithValue("@cantidad", txt_CantidadSalida3.Text);
            command.Parameters.AddWithValue("@preciounitario", float.Parse(txt_PrecioUnitarioSalida3.Text));
            command.Parameters.AddWithValue("@cod_proveedor", txt_codigoProveedorSalida3.Text);
            command.Parameters.AddWithValue("@CodigoProducto", txt_CodigoProducto3.Text);
            command.ExecuteNonQuery();
            coneccion.Close();
            llenar_tabla();
            limpiar_campos();
        }

        private void btn_Mostrar3_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from Salida", coneccion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            gvSalida3.DataSource = tabla;
        }

        private void gvSalida3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            date_FechaSalida.Text = gvSalida3.SelectedCells[1].Value.ToString();
            txt_CodigoProducto3.Text = gvSalida3.SelectedCells[2].Value.ToString();
            txt_NombreProducto3.Text = gvSalida3.SelectedCells[3].Value.ToString();
            txt_Marca3.Text = gvSalida3.SelectedCells[4].Value.ToString();
            txt_Presentacion3.Text = gvSalida3.SelectedCells[5].Value.ToString();
            txt_CantidadSalida3.Text = gvSalida3.SelectedCells[6].Value.ToString();
            txt_PrecioUnitarioSalida3.Text = gvSalida3.SelectedCells[7].Value.ToString();
            txt_codigoProveedorSalida3.Text = gvSalida3.SelectedCells[8].Value.ToString();
        }

        private void btnRegresarSalida_Click(object sender, EventArgs e)
        {
            Form SalidaProductosAdmin = new SalidaProductosAdmin();
            this.Hide();
            SalidaProductosAdmin.Show();
        }

        private void btn_Buscar3_Click(object sender, EventArgs e)
        {
            if (ValidarBuscarProductosSalida() == false)
            {
                return;
            }
            string consulta = "SELECT * FROM Salida WHERE NombreProducto LIKE '%" + txt_Buscar3.Text + "%'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            gvSalida3.DataSource = dt;
        }

        private bool ValidarBuscarProductosSalida()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_Buscar3.Text))
            {
                ErrorProvider.SetError(txt_Buscar3, "Debe ingresar el nombre del producto que desea buscar");
                txt_Buscar3.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_Buscar3, "");
                return true;
            }
        }

        private void txt_CodigoProducto3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_CantidadSalida3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_PrecioUnitarioSalida3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_codigoProveedorSalida3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_NombreProducto3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Marca3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Presentacion3_KeyPress(object sender, KeyPressEventArgs e)
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
