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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection coneccion = new SqlConnection("server=DESKTOP-AM37ABU\\SQLEXPRESS ; database=BDinventario; INTEGRATED SECURITY = true");

        public void logear(string usuario, string contrasena)
        {
            try
            {

                coneccion.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nombre, Tipo_usuario FROM usuarios WHERE Usuario = @usuario AND Contrasena = @contrasena ", coneccion);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("contrasena", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Admin")
                    {
                        new Admin(dt.Rows[0][0].ToString()).Show();



                    }
                    else if (dt.Rows[0][1].ToString() == "Empleado")
                    {
                        new Empleado(dt.Rows[0][0].ToString()).Show();


                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta");

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                coneccion.Close();

            }
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_contrasena.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logear(this.txt_usuario.Text, this.txt_contrasena.Text);
        }
    }
}