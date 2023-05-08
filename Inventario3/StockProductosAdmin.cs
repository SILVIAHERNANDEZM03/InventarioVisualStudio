using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Inventario3
{
    public partial class StockProductosAdmin : Form
    {
        public StockProductosAdmin()
        {
            InitializeComponent();
        }
        SqlConnection coneccion = new SqlConnection("server= DESKTOP-AM37ABU\\SQLEXPRESS; database= BDinventario; integrated security=true");

        public void llenar_tabla()
        {
            string consulta = "select * from Stock";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            gvStock.DataSource = dt;
        }

        public void limpiar_campos()
        {
            txt_CodigoProductoStock.Clear();
            txt_NombreProductoStock.Clear();
            txt_MarcaStock.Clear();
            txt_PresentacionStock.Clear();
            txt_Cantidad.Clear();
            txt_precioUnitarioStock.Clear();
            txt_CodigoProductoStock.Focus();
        }
        private void verificarCantidadProductos()
        {
            // consulta para obtener la cantidad de productos en stock
            string consulta = "SELECT SUM(Cantidad) AS Total FROM Stock";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            // obtener el total de productos en stock
            int totalProductos = Convert.ToInt32(dt.Rows[0]["Total"]);

            // mostrar una alerta si quedan 5 o menos productos
            if (totalProductos <= 5)
            {
                MessageBox.Show("Quedan " + totalProductos + " productos en stock.", "Alerta de Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void StockProductosAdmin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDinventarioDataSet.Stock' Puede moverla o quitarla según sea necesario.
            this.stockTableAdapter.Fill(this.bDinventarioDataSet.Stock);

        }

        private void btn_AgregarStock_Click(object sender, EventArgs e)
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
            string query = "INSERT INTO Stock(CodigoProducto,NombreProducto,Marca,Presentacion,Cantidad,PrecioUnitario) VALUES(@codigoproducto,@nombreproducto, @marca,@presentacion,@cantidad, @preciounitario)";
            coneccion.Open();
            SqlCommand comando = new SqlCommand(query, coneccion);
            comando.Parameters.AddWithValue("@codigoproducto", txt_CodigoProductoStock.Text);
            comando.Parameters.AddWithValue("@nombreproducto", txt_NombreProductoStock.Text);
            comando.Parameters.AddWithValue("@marca", txt_MarcaStock.Text);
            comando.Parameters.AddWithValue("@presentacion", txt_PresentacionStock.Text);
            comando.Parameters.AddWithValue("@cantidad", txt_Cantidad.Text);
            comando.Parameters.AddWithValue("@preciounitario", txt_precioUnitarioStock.Text);
            comando.ExecuteNonQuery();
            llenar_tabla();
            limpiar_campos();
            MessageBox.Show("Agregado correctamente");
            // Validar campos y agregar producto
            verificarCantidadProductos();
            coneccion.Close();

        }

        private bool ValidarPrecioUnitario()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_precioUnitarioStock.Text))
            {
                ErrorProvider.SetError(txt_precioUnitarioStock, "Debe ingresar el precio del producto");
                txt_precioUnitarioStock.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_precioUnitarioStock, "");
                return true;
            }
        }

        private bool ValidarCantidad()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_Cantidad.Text))
            {
                ErrorProvider.SetError(txt_Cantidad, "Debe ingresar la cantidad de productos que se agregaron al inventario");
                txt_Cantidad.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_Cantidad, "");
                return true;
            }
        }

        private bool ValidarPresentacion()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_PresentacionStock.Text))
            {
                ErrorProvider.SetError(txt_PresentacionStock, "Debe ingresar la presentación del producto");
                txt_PresentacionStock.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_PresentacionStock, "");
                return true;
            }
        }

        private bool ValidarMarca()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_MarcaStock.Text))
            {
                ErrorProvider.SetError(txt_MarcaStock, "Debe ingresar la marca del producto");
                txt_MarcaStock.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_MarcaStock, "");
                return true;
            }
        }

        private bool ValidarNombreProducto()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_NombreProductoStock.Text))
            {
                ErrorProvider.SetError(txt_NombreProductoStock, "Debe ingresar el nombre del producto");
                txt_NombreProductoStock.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_NombreProductoStock, "");
                return true;
            }
        }

        private bool ValidarCodigoProducto()
        {

            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_CodigoProductoStock.Text))
            {
                ErrorProvider.SetError(txt_CodigoProductoStock, "Debe ingresar el codigo del producto");
                txt_CodigoProductoStock.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_CodigoProductoStock, "");
                return true;
            }
        }

        private void btn_eliminarproducto_Click(object sender, EventArgs e)
        {

            string query = "DELETE FROM Stock WHERE CodigoProducto=@CodigoProducto";
            coneccion.Open();
            SqlCommand comando = new SqlCommand(query, coneccion);
            comando.Parameters.AddWithValue("CodigoProducto", txt_CodigoProductoStock.Text);
            comando.ExecuteNonQuery();
            coneccion.Close();
            MessageBox.Show("Registro Borrado Exitosamente");
            llenar_tabla();
            limpiar_campos();
            // Validar campos y eliminar producto
            verificarCantidadProductos();

        }


        private void btn_mostrarproducto_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from Stock", coneccion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            gvStock.DataSource = tabla;
        }

        private void gvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_CodigoProductoStock.Text = gvStock.SelectedCells[1].Value.ToString();
            txt_NombreProductoStock.Text = gvStock.SelectedCells[2].Value.ToString();
            txt_MarcaStock.Text = gvStock.SelectedCells[3].Value.ToString();
            txt_PresentacionStock.Text = gvStock.SelectedCells[4].Value.ToString();
            txt_Cantidad.Text = gvStock.SelectedCells[5].Value.ToString();
            txt_precioUnitarioStock.Text = gvStock.SelectedCells[6].Value.ToString();
        }

        private void btnRegresarproducto_Click(object sender, EventArgs e)
        {
            Form Menu2Admin = new Menu2Admin();
            this.Hide();
            Menu2Admin.Show();
        }

        private void btn_buscarcodigoproducto_Click(object sender, EventArgs e)
        {
            if (ValidarBuscarProducto() == false)
            {
                return;
            }
            coneccion.Open();
            string consulta = "select * from Stock where CodigoProducto= '" + txt_buscarcodigo.Text + "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            gvStock.DataSource = dt;
            SqlCommand comando = new SqlCommand(consulta, coneccion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            coneccion.Close();
        }

        private bool ValidarBuscarProducto()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_buscarcodigo.Text))
            {
                ErrorProvider.SetError(txt_buscarcodigo, "Debe ingresar el codigo del producto que desea buscar");
                txt_buscarcodigo.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_buscarcodigo, "");
                return true;
            }
        }

        private void txt_CodigoProductoStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_buscarcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_precioUnitarioStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_NombreProductoStock_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_MarcaStock_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_PresentacionStock_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_editarproducto_Click_1(object sender, EventArgs e)
        {
            string consulta = "update Stock set NombreProducto = @nombreproducto, Marca = @marca, Presentacion=@presentacion, Cantidad= @cantidad, PrecioUnitario=@preciounitario WHERE CodigoProducto=@CodigoProducto";
            coneccion.Open();
            SqlCommand comando = new SqlCommand(consulta, coneccion);
            comando.Parameters.AddWithValue("@nombreproducto", txt_NombreProductoStock.Text);
            comando.Parameters.AddWithValue("@marca", txt_MarcaStock.Text);
            comando.Parameters.AddWithValue("@presentacion", txt_PresentacionStock.Text);
            comando.Parameters.AddWithValue("@cantidad", txt_Cantidad.Text);
            comando.Parameters.AddWithValue("@preciounitario", txt_precioUnitarioStock.Text);
            comando.Parameters.AddWithValue("@CodigoProducto", txt_CodigoProductoStock.Text);
            comando.ExecuteNonQuery();
            llenar_tabla();
            limpiar_campos();
            coneccion.Close();
            MessageBox.Show("Registro Actualizado");
        }

        private void btn_PDF_Click(object sender, EventArgs e)
        {
            // Crear un cuadro de diálogo de guardado de archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo PDF|*.pdf";
            saveFileDialog.Title = "Guardar archivo PDF";
            saveFileDialog.ShowDialog();

            // Si se seleccionó una ruta válida, crear el archivo PDF
            if (saveFileDialog.FileName != "")
            {
                // Crear el documento PDF
                Document documento = new Document(PageSize.A4);
                PdfWriter.GetInstance(documento, new FileStream(saveFileDialog.FileName, FileMode.Create));
                // Agregar el título al documento
                Paragraph titulo = new Paragraph("Reporte Inventario DES", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD));
                titulo.Alignment = Element.ALIGN_CENTER;
                documento.Open();
                // Agregar la imagen
                iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("C:\\Users\\Silvia\\source\\repos\\Inventario3\\Inventario3\\imagenes\\image-removebg-preview.png");
                imagen.ScaleToFit(100f, 100f); // Escalar la imagen al tamaño deseado
                documento.Add(imagen);
                documento.Add(titulo);
                documento.Add(new Paragraph(" "));

                // Agregar contenido al documento PDF
                // Crear la tabla con bordes y color de fondo
                PdfPTable tabla = new PdfPTable(gvStock.Columns.Count);
                tabla.WidthPercentage = 100;
                tabla.DefaultCell.BorderWidth = 1;
                tabla.DefaultCell.Padding = 5;
                tabla.DefaultCell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);

                // Establecer el ancho de la tabla como un porcentaje del ancho de la página
                tabla.WidthPercentage = 100;
                // Agregar las cabeceras de la tabla con negritas y tamaño de letra más pequeño
                iTextSharp.text.Font fontCabecera = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD);
                // Agregar las cabeceras de la tabla
                for (int i = 0; i < gvStock.Columns.Count; i++)
                {
                    tabla.AddCell(new PdfPCell(new Phrase(gvStock.Columns[i].HeaderText, fontCabecera))
                    {
                        BorderWidth = 1,
                        Padding = 5,
                        BackgroundColor = new iTextSharp.text.BaseColor(210, 210, 210)
                    });
                }
                // Agregar las filas de la tabla con estilo de letra normal y tamaño más pequeño
                iTextSharp.text.Font fontCelda = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL);
                // Agregar las filas de la tabla
                for (int i = 0; i < gvStock.Rows.Count; i++)
                {

                    for (int j = 0; j < gvStock.Columns.Count; j++)
                    {
                        if (gvStock.Rows[i].Cells[j].Value != null)
                        {
                            tabla.AddCell(new PdfPCell(new Phrase(gvStock.Rows[i].Cells[j].Value.ToString(), fontCelda))
                            {
                                BorderWidth = 1,
                                Padding = 5,
                                BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 255)
                            });
                        }
                    }
                }
                documento.Add(tabla);

                // Cerrar el documento PDF
                documento.Close();
                MessageBox.Show("Archivo PDF creado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}