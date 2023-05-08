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
    public partial class RegistroEmpleados : Form
    {
        public RegistroEmpleados()
        {
            InitializeComponent();
        }
        SqlConnection coneccion = new SqlConnection("server= DESKTOP-AM37ABU\\SQLEXPRESS; database= BDinventario; integrated security=true");

        public void llenar_tabla()
        {
            string consulta = "select * from Usuarios";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            gvRegistrarProducto.DataSource = dt;
        }

        public void limpiar_campos()
        {
            txt_NombreEmpleado.Clear();
            txt_Usuario.Clear();
            txt_ContrasenaEmpleado.Clear();
            txt_TipoUsuarioEmpleado.Clear();
            txt_NombreEmpleado.Focus();
        }

        private void RegistroEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDinventarioDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.bDinventarioDataSet.Usuarios);

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false)
            {
                return;
            }
            if (ValidarUsuario() == false)
            {
                return;
            }
            if (ValidarContrasena() == false)
            {
                return;
            }
            if (ValidarTipo_usuario() == false)
            {
                return;
            }
            string query = "INSERT INTO Usuarios(Nombre,Usuario,Contrasena,Tipo_usuario) VALUES(@nombre,@usuario,@contrasena, @tipo_usuario)";
            coneccion.Open();
            SqlCommand comando = new SqlCommand(query, coneccion);
            comando.Parameters.AddWithValue("@nombre", txt_NombreEmpleado.Text);
            comando.Parameters.AddWithValue("@usuario", txt_Usuario.Text);
            comando.Parameters.AddWithValue("@contrasena", txt_ContrasenaEmpleado.Text);
            comando.Parameters.AddWithValue("@tipo_usuario", txt_TipoUsuarioEmpleado.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Agregado correctamente");
            llenar_tabla();
            limpiar_campos();
            coneccion.Close();
        }

        private bool ValidarTipo_usuario()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_TipoUsuarioEmpleado.Text))
            {
                ErrorProvider.SetError(txt_TipoUsuarioEmpleado, "Debe ingresar el tipo de empleado que va a manejar la cuenta");
                txt_TipoUsuarioEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_TipoUsuarioEmpleado, "");
                return true;
            }
        }

        private bool ValidarContrasena()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_ContrasenaEmpleado.Text))
            {
                ErrorProvider.SetError(txt_ContrasenaEmpleado, "Debe ingresar la contraseña que desea utilizar");
                txt_ContrasenaEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_ContrasenaEmpleado, "");
                return true;
            }
        }

        private bool ValidarUsuario()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_Usuario.Text))
            {
                ErrorProvider.SetError(txt_Usuario, "Debe ingresar el nombre del usuario que desea utilizar");
                txt_Usuario.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_Usuario, "");
                return true;
            }
        }

        private bool ValidarNombre()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_NombreEmpleado.Text))
            {
                ErrorProvider.SetError(txt_NombreEmpleado, "Debe ingresar el nombre del empleado");
                txt_NombreEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_NombreEmpleado, "");
                return true;
            }
        }

        private void btn_eliminarUsuario_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Usuarios WHERE Nombre=@Nombre";
            coneccion.Open();
            SqlCommand comando = new SqlCommand(query, coneccion);
            comando.Parameters.AddWithValue("@Nombre", txt_NombreEmpleado.Text);
            comando.ExecuteNonQuery();
            llenar_tabla();
            limpiar_campos();
            coneccion.Close();
            MessageBox.Show("Registro Borrado Exitosamente");
        }

        private void btn_editarUsuario_Click(object sender, EventArgs e)
        {
            string consulta = "update Usuarios set Usuario = @usuario, Contrasena = @contrasena, Tipo_Usuario = @tipo_usuario WHERE Nombre=@Nombre";
            coneccion.Open();
            SqlCommand comando = new SqlCommand(consulta, coneccion);
            comando.Parameters.AddWithValue("@usuario", txt_Usuario.Text);
            comando.Parameters.AddWithValue("@contrasena", txt_ContrasenaEmpleado.Text);
            comando.Parameters.AddWithValue("@tipo_usuario", txt_TipoUsuarioEmpleado.Text);
            comando.Parameters.AddWithValue("@Nombre", txt_NombreEmpleado.Text);
            comando.ExecuteNonQuery();
            llenar_tabla();
            limpiar_campos();
            coneccion.Close();
            MessageBox.Show("Registro Actualizado");
        }

        private void btn_mostrarUsuario_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from Usuarios", coneccion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            gvRegistrarProducto.DataSource = tabla;
        }

        private void btn_buscarEmpleado_Click(object sender, EventArgs e)
        {
            if (ValidarBuscarEmpleado() == false)
            {
                return;
            }
            coneccion.Open();
            string consulta = "select * from Usuarios where Nombre= '" + txt_buscarEmpleado.Text + "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            gvRegistrarProducto.DataSource = dt;
            SqlCommand comando = new SqlCommand(consulta, coneccion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            txt_buscarEmpleado.Clear();
            coneccion.Close();
        }

        private bool ValidarBuscarEmpleado()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_buscarEmpleado.Text))
            {
                ErrorProvider.SetError(txt_buscarEmpleado, "Debe ingresar el nombre del empleado que desea buscar");
                txt_buscarEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_buscarEmpleado, "");
                return true;
            }
        }

        private void gvRegistrarProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_NombreEmpleado.Text = gvRegistrarProducto.SelectedCells[1].Value.ToString();
            txt_Usuario.Text = gvRegistrarProducto.SelectedCells[2].Value.ToString();
            txt_ContrasenaEmpleado.Text = gvRegistrarProducto.SelectedCells[3].Value.ToString();
            txt_TipoUsuarioEmpleado.Text = gvRegistrarProducto.SelectedCells[4].Value.ToString();
        }

        private void btnRegresarSalida_Click(object sender, EventArgs e)
        {
            Form Menu2Admin = new Menu2Admin();
            this.Hide();
            Menu2Admin.Show();
        }

        private void txt_NombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_TipoUsuarioEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_buscarEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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
