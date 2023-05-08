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
    public partial class StockProductosEmpleados : Form
    {
        public StockProductosEmpleados()
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
            gvStockEmpleado.DataSource = dt;
        }

        public void limpiar_campos()
        {
            txt_CodigoProductoStockEmpleado.Clear();
            txt_NombreProductoStockEmpleado.Clear();
            txt_MarcaStockEmpleado.Clear();
            txt_PresentacionStockEmpleado.Clear();
            txt_CantidadEmpleado.Clear();
            txt_precioUnitarioStockEmpleado.Clear();
            txt_CodigoProductoStockEmpleado.Focus();
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
        private void btn_AgregarStockEmpleado_Click(object sender, EventArgs e)
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
            comando.Parameters.AddWithValue("@codigoproducto", txt_CodigoProductoStockEmpleado.Text);
            comando.Parameters.AddWithValue("@nombreproducto", txt_NombreProductoStockEmpleado.Text);
            comando.Parameters.AddWithValue("@marca", txt_MarcaStockEmpleado.Text);
            comando.Parameters.AddWithValue("@presentacion", txt_PresentacionStockEmpleado.Text);
            comando.Parameters.AddWithValue("@cantidad", txt_CantidadEmpleado.Text);
            comando.Parameters.AddWithValue("@preciounitario", txt_precioUnitarioStockEmpleado.Text);
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
            if (string.IsNullOrEmpty(txt_precioUnitarioStockEmpleado.Text))
            {
                ErrorProvider.SetError(txt_precioUnitarioStockEmpleado, "Debe ingresar el precio del producto");
                txt_precioUnitarioStockEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_precioUnitarioStockEmpleado, "");
                return true;
            }
        }

        private bool ValidarCantidad()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_CantidadEmpleado.Text))
            {
                ErrorProvider.SetError(txt_CantidadEmpleado, "Debe ingresar la cantidad de productos que se agregaron al inventario");
                txt_CantidadEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_CantidadEmpleado, "");
                return true;
            }
        }

        private bool ValidarPresentacion()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_PresentacionStockEmpleado.Text))
            {
                ErrorProvider.SetError(txt_PresentacionStockEmpleado, "Debe ingresar la presentación del producto");
                txt_PresentacionStockEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_PresentacionStockEmpleado, "");
                return true;
            }
        }

        private bool ValidarMarca()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_MarcaStockEmpleado.Text))
            {
                ErrorProvider.SetError(txt_MarcaStockEmpleado, "Debe ingresar la marca del producto");
                txt_MarcaStockEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_MarcaStockEmpleado, "");
                return true;
            }
        }

        private bool ValidarNombreProducto()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_NombreProductoStockEmpleado.Text))
            {
                ErrorProvider.SetError(txt_NombreProductoStockEmpleado, "Debe ingresar el nombre del producto");
                txt_NombreProductoStockEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_NombreProductoStockEmpleado, "");
                return true;
            }
        }

        private bool ValidarCodigoProducto()
        {

            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_CodigoProductoStockEmpleado.Text))
            {
                ErrorProvider.SetError(txt_CodigoProductoStockEmpleado, "Debe ingresar el codigo del producto");
                txt_CodigoProductoStockEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_CodigoProductoStockEmpleado, "");
                return true;
            }
        }

        private void btn_eliminarproductoEmpleado_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Stock WHERE CodigoProducto=@CodigoProducto";
            coneccion.Open();
            SqlCommand comando = new SqlCommand(query, coneccion);
            comando.Parameters.AddWithValue("CodigoProducto", txt_CodigoProductoStockEmpleado.Text);
            comando.ExecuteNonQuery();
            coneccion.Close();
            MessageBox.Show("Registro Borrado Exitosamente");
            llenar_tabla();
            limpiar_campos();
            // Validar campos y eliminar producto
            verificarCantidadProductos();
        }

        private void btn_mostrarproductoEmpleado_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from Stock", coneccion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            gvStockEmpleado.DataSource = tabla;
        }

        private void gvStockEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_CodigoProductoStockEmpleado.Text = gvStockEmpleado.SelectedCells[1].Value.ToString();
            txt_NombreProductoStockEmpleado.Text = gvStockEmpleado.SelectedCells[2].Value.ToString();
            txt_MarcaStockEmpleado.Text = gvStockEmpleado.SelectedCells[3].Value.ToString();
            txt_PresentacionStockEmpleado.Text = gvStockEmpleado.SelectedCells[4].Value.ToString();
            txt_CantidadEmpleado.Text = gvStockEmpleado.SelectedCells[5].Value.ToString();
            txt_precioUnitarioStockEmpleado.Text = gvStockEmpleado.SelectedCells[6].Value.ToString();
        }

        private void btnRegresarproductoEmpleado_Click(object sender, EventArgs e)
        {
            Form Menu2Empleado = new Menu2Empleado();
            this.Hide();
            Menu2Empleado.Show();
        }

        private void btn_buscarcodigoproductoEmpleado_Click(object sender, EventArgs e)
        {
            if (ValidarBuscarProducto() == false)
            {
                return;
            }
            coneccion.Open();
            string consulta = "select * from Stock where CodigoProducto= '" + txt_buscarcodigoEmpleado.Text + "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            gvStockEmpleado.DataSource = dt;
            SqlCommand comando = new SqlCommand(consulta, coneccion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            coneccion.Close();
        }
        private bool ValidarBuscarProducto()
        {
            ErrorProvider ErrorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(txt_buscarcodigoEmpleado.Text))
            {
                ErrorProvider.SetError(txt_buscarcodigoEmpleado, "Debe ingresar el codigo del producto que desea buscar");
                txt_buscarcodigoEmpleado.Focus();
                return false;
            }
            else
            {
                ErrorProvider.SetError(txt_buscarcodigoEmpleado, "");
                return true;
            }
        }

        private void btn_editarproductoEmpleado_Click(object sender, EventArgs e)
        {
            string consulta = "update Stock set NombreProducto = @nombreproducto, Marca = @marca, Presentacion=@presentacion, Cantidad= @cantidad, PrecioUnitario=@preciounitario WHERE CodigoProducto=@CodigoProducto";
            coneccion.Open();
            SqlCommand comando = new SqlCommand(consulta, coneccion);
            comando.Parameters.AddWithValue("@nombreproducto", txt_NombreProductoStockEmpleado.Text);
            comando.Parameters.AddWithValue("@marca", txt_MarcaStockEmpleado.Text);
            comando.Parameters.AddWithValue("@presentacion", txt_PresentacionStockEmpleado.Text);
            comando.Parameters.AddWithValue("@cantidad", txt_CantidadEmpleado.Text);
            comando.Parameters.AddWithValue("@preciounitario", txt_precioUnitarioStockEmpleado.Text);
            comando.Parameters.AddWithValue("@CodigoProducto", txt_CodigoProductoStockEmpleado.Text);
            comando.ExecuteNonQuery();
            llenar_tabla();
            limpiar_campos();
            coneccion.Close();
            MessageBox.Show("Registro Actualizado");
        }

        private void txt_NombreProductoStockEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_MarcaStockEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_PresentacionStockEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_CodigoProductoStockEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_CantidadEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_precioUnitarioStockEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void btn_PDFEmpleado_Click(object sender, EventArgs e)
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
                Paragraph titulo = new Paragraph("Reporte Inventario DES", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD));
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
                PdfPTable tabla = new PdfPTable(gvStockEmpleado.Columns.Count);
                tabla.WidthPercentage = 100;
                tabla.DefaultCell.BorderWidth = 1;
                tabla.DefaultCell.Padding = 5;
                tabla.DefaultCell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);

                // Establecer el ancho de la tabla como un porcentaje del ancho de la página
                tabla.WidthPercentage = 100;
                // Agregar las cabeceras de la tabla con negritas y tamaño de letra más pequeño
                iTextSharp.text.Font fontCabecera = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD);
                // Agregar las cabeceras de la tabla
                for (int i = 0; i < gvStockEmpleado.Columns.Count; i++)
                {
                    tabla.AddCell(new PdfPCell(new Phrase(gvStockEmpleado.Columns[i].HeaderText, fontCabecera))
                    {
                        BorderWidth = 1,
                        Padding = 5,
                        BackgroundColor = new iTextSharp.text.BaseColor(210, 210, 210)
                    });
                }
                // Agregar las filas de la tabla con estilo de letra normal y tamaño más pequeño
                iTextSharp.text.Font fontCelda = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL);
                // Agregar las filas de la tabla
                for (int i = 0; i < gvStockEmpleado.Rows.Count; i++)
                {

                    for (int j = 0; j < gvStockEmpleado.Columns.Count; j++)
                    {
                        if (gvStockEmpleado.Rows[i].Cells[j].Value != null)
                        {
                            tabla.AddCell(new PdfPCell(new Phrase(gvStockEmpleado.Rows[i].Cells[j].Value.ToString(), fontCelda))
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

        private void gvStockEmpleado_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_CodigoProductoStockEmpleado.Text = gvStockEmpleado.SelectedCells[1].Value.ToString();
            txt_NombreProductoStockEmpleado.Text = gvStockEmpleado.SelectedCells[2].Value.ToString();
            txt_MarcaStockEmpleado.Text = gvStockEmpleado.SelectedCells[3].Value.ToString();
            txt_PresentacionStockEmpleado.Text = gvStockEmpleado.SelectedCells[4].Value.ToString();
            txt_CantidadEmpleado.Text = gvStockEmpleado.SelectedCells[5].Value.ToString();
            txt_precioUnitarioStockEmpleado.Text = gvStockEmpleado.SelectedCells[6].Value.ToString();
        }
    }
 }

