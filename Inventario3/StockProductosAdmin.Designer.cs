namespace Inventario3
{
    partial class StockProductosAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockProductosAdmin));
            this.btn_PDF = new System.Windows.Forms.Button();
            this.btn_mostrarproducto = new System.Windows.Forms.Button();
            this.btn_editarproducto = new System.Windows.Forms.Button();
            this.btn_eliminarproducto = new System.Windows.Forms.Button();
            this.gvStock = new System.Windows.Forms.DataGridView();
            this.idStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDinventarioDataSet = new Inventario3.BDinventarioDataSet();
            this.btn_buscarcodigoproducto = new System.Windows.Forms.Button();
            this.txt_buscarcodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRegresarproducto = new System.Windows.Forms.Button();
            this.txt_NombreProductoStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_precioUnitarioStock = new System.Windows.Forms.TextBox();
            this.txt_MarcaStock = new System.Windows.Forms.TextBox();
            this.txt_PresentacionStock = new System.Windows.Forms.TextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.txt_CodigoProductoStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.entradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new Inventario3.BDinventarioDataSetTableAdapters.StockTableAdapter();
            this.btn_AgregarStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_PDF
            // 
            this.btn_PDF.BackColor = System.Drawing.Color.Teal;
            this.btn_PDF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PDF.ForeColor = System.Drawing.Color.White;
            this.btn_PDF.Location = new System.Drawing.Point(653, 606);
            this.btn_PDF.Name = "btn_PDF";
            this.btn_PDF.Size = new System.Drawing.Size(147, 43);
            this.btn_PDF.TabIndex = 88;
            this.btn_PDF.Text = "PDF";
            this.btn_PDF.UseVisualStyleBackColor = false;
            this.btn_PDF.Click += new System.EventHandler(this.btn_PDF_Click);
            // 
            // btn_mostrarproducto
            // 
            this.btn_mostrarproducto.BackColor = System.Drawing.Color.Teal;
            this.btn_mostrarproducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrarproducto.ForeColor = System.Drawing.Color.White;
            this.btn_mostrarproducto.Location = new System.Drawing.Point(500, 606);
            this.btn_mostrarproducto.Name = "btn_mostrarproducto";
            this.btn_mostrarproducto.Size = new System.Drawing.Size(147, 43);
            this.btn_mostrarproducto.TabIndex = 87;
            this.btn_mostrarproducto.Text = "Mostrar";
            this.btn_mostrarproducto.UseVisualStyleBackColor = false;
            this.btn_mostrarproducto.Click += new System.EventHandler(this.btn_mostrarproducto_Click);
            // 
            // btn_editarproducto
            // 
            this.btn_editarproducto.BackColor = System.Drawing.Color.Teal;
            this.btn_editarproducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarproducto.ForeColor = System.Drawing.Color.White;
            this.btn_editarproducto.Location = new System.Drawing.Point(337, 606);
            this.btn_editarproducto.Name = "btn_editarproducto";
            this.btn_editarproducto.Size = new System.Drawing.Size(147, 43);
            this.btn_editarproducto.TabIndex = 86;
            this.btn_editarproducto.Text = "Editar";
            this.btn_editarproducto.UseVisualStyleBackColor = false;
            this.btn_editarproducto.Click += new System.EventHandler(this.btn_editarproducto_Click_1);
            // 
            // btn_eliminarproducto
            // 
            this.btn_eliminarproducto.BackColor = System.Drawing.Color.Teal;
            this.btn_eliminarproducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarproducto.ForeColor = System.Drawing.Color.White;
            this.btn_eliminarproducto.Location = new System.Drawing.Point(173, 606);
            this.btn_eliminarproducto.Name = "btn_eliminarproducto";
            this.btn_eliminarproducto.Size = new System.Drawing.Size(147, 43);
            this.btn_eliminarproducto.TabIndex = 85;
            this.btn_eliminarproducto.Text = "Eliminar";
            this.btn_eliminarproducto.UseVisualStyleBackColor = false;
            this.btn_eliminarproducto.Click += new System.EventHandler(this.btn_eliminarproducto_Click);
            // 
            // gvStock
            // 
            this.gvStock.AutoGenerateColumns = false;
            this.gvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStockDataGridViewTextBoxColumn,
            this.codigoProductoDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.presentacionDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn});
            this.gvStock.DataSource = this.stockBindingSource;
            this.gvStock.Location = new System.Drawing.Point(492, 180);
            this.gvStock.Name = "gvStock";
            this.gvStock.ReadOnly = true;
            this.gvStock.RowHeadersVisible = false;
            this.gvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvStock.Size = new System.Drawing.Size(703, 404);
            this.gvStock.TabIndex = 84;
            this.gvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvStock_CellClick);
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
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.bDinventarioDataSet;
            // 
            // bDinventarioDataSet
            // 
            this.bDinventarioDataSet.DataSetName = "BDinventarioDataSet";
            this.bDinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_buscarcodigoproducto
            // 
            this.btn_buscarcodigoproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            this.btn_buscarcodigoproducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarcodigoproducto.ForeColor = System.Drawing.Color.White;
            this.btn_buscarcodigoproducto.Location = new System.Drawing.Point(1119, 112);
            this.btn_buscarcodigoproducto.Name = "btn_buscarcodigoproducto";
            this.btn_buscarcodigoproducto.Size = new System.Drawing.Size(111, 33);
            this.btn_buscarcodigoproducto.TabIndex = 83;
            this.btn_buscarcodigoproducto.Text = "Buscar";
            this.btn_buscarcodigoproducto.UseVisualStyleBackColor = false;
            this.btn_buscarcodigoproducto.Click += new System.EventHandler(this.btn_buscarcodigoproducto_Click);
            // 
            // txt_buscarcodigo
            // 
            this.txt_buscarcodigo.Location = new System.Drawing.Point(676, 120);
            this.txt_buscarcodigo.Name = "txt_buscarcodigo";
            this.txt_buscarcodigo.Size = new System.Drawing.Size(409, 20);
            this.txt_buscarcodigo.TabIndex = 82;
            this.txt_buscarcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscarcodigo_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(511, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 81;
            this.label10.Text = "Código Producto";
            // 
            // btnRegresarproducto
            // 
            this.btnRegresarproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            this.btnRegresarproducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarproducto.ForeColor = System.Drawing.Color.White;
            this.btnRegresarproducto.Location = new System.Drawing.Point(1144, 615);
            this.btnRegresarproducto.Name = "btnRegresarproducto";
            this.btnRegresarproducto.Size = new System.Drawing.Size(147, 43);
            this.btnRegresarproducto.TabIndex = 76;
            this.btnRegresarproducto.Text = "Regresar";
            this.btnRegresarproducto.UseVisualStyleBackColor = false;
            this.btnRegresarproducto.Click += new System.EventHandler(this.btnRegresarproducto_Click);
            // 
            // txt_NombreProductoStock
            // 
            this.txt_NombreProductoStock.Location = new System.Drawing.Point(173, 271);
            this.txt_NombreProductoStock.Name = "txt_NombreProductoStock";
            this.txt_NombreProductoStock.Size = new System.Drawing.Size(225, 20);
            this.txt_NombreProductoStock.TabIndex = 75;
            this.txt_NombreProductoStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreProductoStock_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 74;
            this.label7.Text = "Precio Unitario";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-7, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1312, 84);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
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
            // txt_precioUnitarioStock
            // 
            this.txt_precioUnitarioStock.Location = new System.Drawing.Point(173, 459);
            this.txt_precioUnitarioStock.Name = "txt_precioUnitarioStock";
            this.txt_precioUnitarioStock.Size = new System.Drawing.Size(225, 20);
            this.txt_precioUnitarioStock.TabIndex = 72;
            this.txt_precioUnitarioStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precioUnitarioStock_KeyPress);
            // 
            // txt_MarcaStock
            // 
            this.txt_MarcaStock.Location = new System.Drawing.Point(173, 320);
            this.txt_MarcaStock.Name = "txt_MarcaStock";
            this.txt_MarcaStock.Size = new System.Drawing.Size(225, 20);
            this.txt_MarcaStock.TabIndex = 71;
            this.txt_MarcaStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MarcaStock_KeyPress);
            // 
            // txt_PresentacionStock
            // 
            this.txt_PresentacionStock.Location = new System.Drawing.Point(173, 366);
            this.txt_PresentacionStock.Name = "txt_PresentacionStock";
            this.txt_PresentacionStock.Size = new System.Drawing.Size(225, 20);
            this.txt_PresentacionStock.TabIndex = 70;
            this.txt_PresentacionStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PresentacionStock_KeyPress);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(173, 409);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(225, 20);
            this.txt_Cantidad.TabIndex = 69;
            this.txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cantidad_KeyPress);
            // 
            // txt_CodigoProductoStock
            // 
            this.txt_CodigoProductoStock.Location = new System.Drawing.Point(173, 221);
            this.txt_CodigoProductoStock.Name = "txt_CodigoProductoStock";
            this.txt_CodigoProductoStock.Size = new System.Drawing.Size(225, 20);
            this.txt_CodigoProductoStock.TabIndex = 68;
            this.txt_CodigoProductoStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CodigoProductoStock_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 67;
            this.label6.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Presentación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Nombre Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Código Producto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // btn_AgregarStock
            // 
            this.btn_AgregarStock.BackColor = System.Drawing.Color.Teal;
            this.btn_AgregarStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarStock.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarStock.Location = new System.Drawing.Point(12, 606);
            this.btn_AgregarStock.Name = "btn_AgregarStock";
            this.btn_AgregarStock.Size = new System.Drawing.Size(147, 43);
            this.btn_AgregarStock.TabIndex = 89;
            this.btn_AgregarStock.Text = "Agregar";
            this.btn_AgregarStock.UseVisualStyleBackColor = false;
            this.btn_AgregarStock.Click += new System.EventHandler(this.btn_AgregarStock_Click);
            // 
            // StockProductosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 661);
            this.Controls.Add(this.btn_AgregarStock);
            this.Controls.Add(this.btn_PDF);
            this.Controls.Add(this.btn_mostrarproducto);
            this.Controls.Add(this.btn_editarproducto);
            this.Controls.Add(this.btn_eliminarproducto);
            this.Controls.Add(this.gvStock);
            this.Controls.Add(this.btn_buscarcodigoproducto);
            this.Controls.Add(this.txt_buscarcodigo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegresarproducto);
            this.Controls.Add(this.txt_NombreProductoStock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_precioUnitarioStock);
            this.Controls.Add(this.txt_MarcaStock);
            this.Controls.Add(this.txt_PresentacionStock);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.txt_CodigoProductoStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockProductosAdmin";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.StockProductosAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_PDF;
        private System.Windows.Forms.Button btn_mostrarproducto;
        private System.Windows.Forms.Button btn_editarproducto;
        private System.Windows.Forms.Button btn_eliminarproducto;
        private System.Windows.Forms.DataGridView gvStock;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.Button btn_buscarcodigoproducto;
        private System.Windows.Forms.TextBox txt_buscarcodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegresarproducto;
        private System.Windows.Forms.TextBox txt_NombreProductoStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_precioUnitarioStock;
        private System.Windows.Forms.TextBox txt_MarcaStock;
        private System.Windows.Forms.TextBox txt_PresentacionStock;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.TextBox txt_CodigoProductoStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource entradaBindingSource;
        private BDinventarioDataSet bDinventarioDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private BDinventarioDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_AgregarStock;
    }
}