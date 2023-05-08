namespace Inventario3
{
    partial class StockProductosEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockProductosEmpleados));
            this.btn_AgregarStockEmpleado = new System.Windows.Forms.Button();
            this.entradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.stockTableAdapter = new Inventario3.BDinventarioDataSetTableAdapters.StockTableAdapter();
            this.bDinventarioDataSet = new Inventario3.BDinventarioDataSet();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_PDFEmpleado = new System.Windows.Forms.Button();
            this.btn_mostrarproductoEmpleado = new System.Windows.Forms.Button();
            this.btn_editarproductoEmpleado = new System.Windows.Forms.Button();
            this.btn_eliminarproductoEmpleado = new System.Windows.Forms.Button();
            this.btn_buscarcodigoproductoEmpleado = new System.Windows.Forms.Button();
            this.txt_buscarcodigoEmpleado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresarproductoEmpleado = new System.Windows.Forms.Button();
            this.txt_NombreProductoStockEmpleado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_precioUnitarioStockEmpleado = new System.Windows.Forms.TextBox();
            this.txt_MarcaStockEmpleado = new System.Windows.Forms.TextBox();
            this.txt_PresentacionStockEmpleado = new System.Windows.Forms.TextBox();
            this.txt_CantidadEmpleado = new System.Windows.Forms.TextBox();
            this.txt_CodigoProductoStockEmpleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gvStockEmpleado = new System.Windows.Forms.DataGridView();
            this.idStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AgregarStockEmpleado
            // 
            this.btn_AgregarStockEmpleado.BackColor = System.Drawing.Color.Teal;
            this.btn_AgregarStockEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarStockEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarStockEmpleado.Location = new System.Drawing.Point(12, 606);
            this.btn_AgregarStockEmpleado.Name = "btn_AgregarStockEmpleado";
            this.btn_AgregarStockEmpleado.Size = new System.Drawing.Size(147, 43);
            this.btn_AgregarStockEmpleado.TabIndex = 113;
            this.btn_AgregarStockEmpleado.Text = "Agregar";
            this.btn_AgregarStockEmpleado.UseVisualStyleBackColor = false;
            this.btn_AgregarStockEmpleado.Click += new System.EventHandler(this.btn_AgregarStockEmpleado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(529, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stock Productos";
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // bDinventarioDataSet
            // 
            this.bDinventarioDataSet.DataSetName = "BDinventarioDataSet";
            this.bDinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.bDinventarioDataSet;
            // 
            // btn_PDFEmpleado
            // 
            this.btn_PDFEmpleado.BackColor = System.Drawing.Color.Teal;
            this.btn_PDFEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PDFEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_PDFEmpleado.Location = new System.Drawing.Point(653, 606);
            this.btn_PDFEmpleado.Name = "btn_PDFEmpleado";
            this.btn_PDFEmpleado.Size = new System.Drawing.Size(147, 43);
            this.btn_PDFEmpleado.TabIndex = 112;
            this.btn_PDFEmpleado.Text = "PDF";
            this.btn_PDFEmpleado.UseVisualStyleBackColor = false;
            this.btn_PDFEmpleado.Click += new System.EventHandler(this.btn_PDFEmpleado_Click);
            // 
            // btn_mostrarproductoEmpleado
            // 
            this.btn_mostrarproductoEmpleado.BackColor = System.Drawing.Color.Teal;
            this.btn_mostrarproductoEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrarproductoEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_mostrarproductoEmpleado.Location = new System.Drawing.Point(500, 606);
            this.btn_mostrarproductoEmpleado.Name = "btn_mostrarproductoEmpleado";
            this.btn_mostrarproductoEmpleado.Size = new System.Drawing.Size(147, 43);
            this.btn_mostrarproductoEmpleado.TabIndex = 111;
            this.btn_mostrarproductoEmpleado.Text = "Mostrar";
            this.btn_mostrarproductoEmpleado.UseVisualStyleBackColor = false;
            this.btn_mostrarproductoEmpleado.Click += new System.EventHandler(this.btn_mostrarproductoEmpleado_Click);
            // 
            // btn_editarproductoEmpleado
            // 
            this.btn_editarproductoEmpleado.BackColor = System.Drawing.Color.Teal;
            this.btn_editarproductoEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarproductoEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_editarproductoEmpleado.Location = new System.Drawing.Point(337, 606);
            this.btn_editarproductoEmpleado.Name = "btn_editarproductoEmpleado";
            this.btn_editarproductoEmpleado.Size = new System.Drawing.Size(147, 43);
            this.btn_editarproductoEmpleado.TabIndex = 110;
            this.btn_editarproductoEmpleado.Text = "Editar";
            this.btn_editarproductoEmpleado.UseVisualStyleBackColor = false;
            this.btn_editarproductoEmpleado.Click += new System.EventHandler(this.btn_editarproductoEmpleado_Click);
            // 
            // btn_eliminarproductoEmpleado
            // 
            this.btn_eliminarproductoEmpleado.BackColor = System.Drawing.Color.Teal;
            this.btn_eliminarproductoEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarproductoEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_eliminarproductoEmpleado.Location = new System.Drawing.Point(173, 606);
            this.btn_eliminarproductoEmpleado.Name = "btn_eliminarproductoEmpleado";
            this.btn_eliminarproductoEmpleado.Size = new System.Drawing.Size(147, 43);
            this.btn_eliminarproductoEmpleado.TabIndex = 109;
            this.btn_eliminarproductoEmpleado.Text = "Eliminar";
            this.btn_eliminarproductoEmpleado.UseVisualStyleBackColor = false;
            this.btn_eliminarproductoEmpleado.Click += new System.EventHandler(this.btn_eliminarproductoEmpleado_Click);
            // 
            // btn_buscarcodigoproductoEmpleado
            // 
            this.btn_buscarcodigoproductoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            this.btn_buscarcodigoproductoEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarcodigoproductoEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_buscarcodigoproductoEmpleado.Location = new System.Drawing.Point(1119, 112);
            this.btn_buscarcodigoproductoEmpleado.Name = "btn_buscarcodigoproductoEmpleado";
            this.btn_buscarcodigoproductoEmpleado.Size = new System.Drawing.Size(111, 33);
            this.btn_buscarcodigoproductoEmpleado.TabIndex = 107;
            this.btn_buscarcodigoproductoEmpleado.Text = "Buscar";
            this.btn_buscarcodigoproductoEmpleado.UseVisualStyleBackColor = false;
            this.btn_buscarcodigoproductoEmpleado.Click += new System.EventHandler(this.btn_buscarcodigoproductoEmpleado_Click);
            // 
            // txt_buscarcodigoEmpleado
            // 
            this.txt_buscarcodigoEmpleado.Location = new System.Drawing.Point(676, 120);
            this.txt_buscarcodigoEmpleado.Name = "txt_buscarcodigoEmpleado";
            this.txt_buscarcodigoEmpleado.Size = new System.Drawing.Size(409, 20);
            this.txt_buscarcodigoEmpleado.TabIndex = 106;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(511, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 105;
            this.label10.Text = "Código Producto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegresarproductoEmpleado
            // 
            this.btnRegresarproductoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            this.btnRegresarproductoEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarproductoEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnRegresarproductoEmpleado.Location = new System.Drawing.Point(1144, 615);
            this.btnRegresarproductoEmpleado.Name = "btnRegresarproductoEmpleado";
            this.btnRegresarproductoEmpleado.Size = new System.Drawing.Size(147, 43);
            this.btnRegresarproductoEmpleado.TabIndex = 104;
            this.btnRegresarproductoEmpleado.Text = "Regresar";
            this.btnRegresarproductoEmpleado.UseVisualStyleBackColor = false;
            this.btnRegresarproductoEmpleado.Click += new System.EventHandler(this.btnRegresarproductoEmpleado_Click);
            // 
            // txt_NombreProductoStockEmpleado
            // 
            this.txt_NombreProductoStockEmpleado.Location = new System.Drawing.Point(173, 271);
            this.txt_NombreProductoStockEmpleado.Name = "txt_NombreProductoStockEmpleado";
            this.txt_NombreProductoStockEmpleado.Size = new System.Drawing.Size(225, 20);
            this.txt_NombreProductoStockEmpleado.TabIndex = 103;
            this.txt_NombreProductoStockEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreProductoStockEmpleado_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 102;
            this.label7.Text = "Precio Unitario";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-7, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1312, 84);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            // 
            // txt_precioUnitarioStockEmpleado
            // 
            this.txt_precioUnitarioStockEmpleado.Location = new System.Drawing.Point(173, 459);
            this.txt_precioUnitarioStockEmpleado.Name = "txt_precioUnitarioStockEmpleado";
            this.txt_precioUnitarioStockEmpleado.Size = new System.Drawing.Size(225, 20);
            this.txt_precioUnitarioStockEmpleado.TabIndex = 100;
            this.txt_precioUnitarioStockEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precioUnitarioStockEmpleado_KeyPress);
            // 
            // txt_MarcaStockEmpleado
            // 
            this.txt_MarcaStockEmpleado.Location = new System.Drawing.Point(173, 320);
            this.txt_MarcaStockEmpleado.Name = "txt_MarcaStockEmpleado";
            this.txt_MarcaStockEmpleado.Size = new System.Drawing.Size(225, 20);
            this.txt_MarcaStockEmpleado.TabIndex = 99;
            this.txt_MarcaStockEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MarcaStockEmpleado_KeyPress);
            // 
            // txt_PresentacionStockEmpleado
            // 
            this.txt_PresentacionStockEmpleado.Location = new System.Drawing.Point(173, 366);
            this.txt_PresentacionStockEmpleado.Name = "txt_PresentacionStockEmpleado";
            this.txt_PresentacionStockEmpleado.Size = new System.Drawing.Size(225, 20);
            this.txt_PresentacionStockEmpleado.TabIndex = 98;
            this.txt_PresentacionStockEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PresentacionStockEmpleado_KeyPress);
            // 
            // txt_CantidadEmpleado
            // 
            this.txt_CantidadEmpleado.Location = new System.Drawing.Point(173, 409);
            this.txt_CantidadEmpleado.Name = "txt_CantidadEmpleado";
            this.txt_CantidadEmpleado.Size = new System.Drawing.Size(225, 20);
            this.txt_CantidadEmpleado.TabIndex = 97;
            this.txt_CantidadEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CantidadEmpleado_KeyPress);
            // 
            // txt_CodigoProductoStockEmpleado
            // 
            this.txt_CodigoProductoStockEmpleado.Location = new System.Drawing.Point(173, 221);
            this.txt_CodigoProductoStockEmpleado.Name = "txt_CodigoProductoStockEmpleado";
            this.txt_CodigoProductoStockEmpleado.Size = new System.Drawing.Size(225, 20);
            this.txt_CodigoProductoStockEmpleado.TabIndex = 96;
            this.txt_CodigoProductoStockEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CodigoProductoStockEmpleado_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 95;
            this.label6.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 94;
            this.label5.Text = "Presentación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 93;
            this.label4.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 92;
            this.label3.Text = "Nombre Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 91;
            this.label2.Text = "Código Producto";
            // 
            // gvStockEmpleado
            // 
            this.gvStockEmpleado.AutoGenerateColumns = false;
            this.gvStockEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStockEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStockDataGridViewTextBoxColumn,
            this.codigoProductoDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.presentacionDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn});
            this.gvStockEmpleado.DataSource = this.stockBindingSource1;
            this.gvStockEmpleado.Location = new System.Drawing.Point(456, 172);
            this.gvStockEmpleado.Name = "gvStockEmpleado";
            this.gvStockEmpleado.ReadOnly = true;
            this.gvStockEmpleado.RowHeadersVisible = false;
            this.gvStockEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvStockEmpleado.Size = new System.Drawing.Size(703, 404);
            this.gvStockEmpleado.TabIndex = 114;
            this.gvStockEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvStockEmpleado_CellClick_1);
            // 
            // idStockDataGridViewTextBoxColumn
            // 
            this.idStockDataGridViewTextBoxColumn.DataPropertyName = "IdStock";
            this.idStockDataGridViewTextBoxColumn.HeaderText = "IdStock";
            this.idStockDataGridViewTextBoxColumn.Name = "idStockDataGridViewTextBoxColumn";
            this.idStockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoProductoDataGridViewTextBoxColumn
            // 
            this.codigoProductoDataGridViewTextBoxColumn.DataPropertyName = "CodigoProducto";
            this.codigoProductoDataGridViewTextBoxColumn.HeaderText = "CodigoProducto";
            this.codigoProductoDataGridViewTextBoxColumn.Name = "codigoProductoDataGridViewTextBoxColumn";
            this.codigoProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            this.nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "NombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.HeaderText = "NombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            this.nombreProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // presentacionDataGridViewTextBoxColumn
            // 
            this.presentacionDataGridViewTextBoxColumn.DataPropertyName = "Presentacion";
            this.presentacionDataGridViewTextBoxColumn.HeaderText = "Presentacion";
            this.presentacionDataGridViewTextBoxColumn.Name = "presentacionDataGridViewTextBoxColumn";
            this.presentacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioUnitarioDataGridViewTextBoxColumn
            // 
            this.precioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.HeaderText = "PrecioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
            this.precioUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockBindingSource1
            // 
            this.stockBindingSource1.DataMember = "Stock";
            this.stockBindingSource1.DataSource = this.bDinventarioDataSet;
            // 
            // StockProductosEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 661);
            this.Controls.Add(this.gvStockEmpleado);
            this.Controls.Add(this.btn_AgregarStockEmpleado);
            this.Controls.Add(this.btn_PDFEmpleado);
            this.Controls.Add(this.btn_mostrarproductoEmpleado);
            this.Controls.Add(this.btn_editarproductoEmpleado);
            this.Controls.Add(this.btn_eliminarproductoEmpleado);
            this.Controls.Add(this.btn_buscarcodigoproductoEmpleado);
            this.Controls.Add(this.txt_buscarcodigoEmpleado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegresarproductoEmpleado);
            this.Controls.Add(this.txt_NombreProductoStockEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_precioUnitarioStockEmpleado);
            this.Controls.Add(this.txt_MarcaStockEmpleado);
            this.Controls.Add(this.txt_PresentacionStockEmpleado);
            this.Controls.Add(this.txt_CantidadEmpleado);
            this.Controls.Add(this.txt_CodigoProductoStockEmpleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockProductosEmpleados";
            this.Text = "Stock Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AgregarStockEmpleado;
        private System.Windows.Forms.BindingSource entradaBindingSource;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.Label label1;
        private BDinventarioDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private BDinventarioDataSet bDinventarioDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private System.Windows.Forms.Button btn_PDFEmpleado;
        private System.Windows.Forms.Button btn_mostrarproductoEmpleado;
        private System.Windows.Forms.Button btn_editarproductoEmpleado;
        private System.Windows.Forms.Button btn_eliminarproductoEmpleado;
        private System.Windows.Forms.Button btn_buscarcodigoproductoEmpleado;
        private System.Windows.Forms.TextBox txt_buscarcodigoEmpleado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegresarproductoEmpleado;
        private System.Windows.Forms.TextBox txt_NombreProductoStockEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_precioUnitarioStockEmpleado;
        private System.Windows.Forms.TextBox txt_MarcaStockEmpleado;
        private System.Windows.Forms.TextBox txt_PresentacionStockEmpleado;
        private System.Windows.Forms.TextBox txt_CantidadEmpleado;
        private System.Windows.Forms.TextBox txt_CodigoProductoStockEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gvStockEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stockBindingSource1;
    }
}