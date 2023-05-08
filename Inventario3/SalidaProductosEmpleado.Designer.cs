namespace Inventario3
{
    partial class SalidaProductosEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalidaProductosEmpleado));
            this.salidaTableAdapter = new Inventario3.BDinventarioDataSetTableAdapters.SalidaTableAdapter();
            this.date_FechaSalida = new System.Windows.Forms.DateTimePicker();
            this.entradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salidaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bDinventarioDataSet = new Inventario3.BDinventarioDataSet();
            this.salidaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.codProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditarDatosSalidaEmpleado = new System.Windows.Forms.Button();
            this.gvSalidaEmpleado = new System.Windows.Forms.DataGridView();
            this.idSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegresarSalidaEmpleado = new System.Windows.Forms.Button();
            this.txt_codigoProveedorSalidaEmpleado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_PrecioUnitarioSalidaEmpleado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_CodigoProducto2Empleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_AgregarEmpleado = new System.Windows.Forms.Button();
            this.txt_CantidadSalidaEmpleado = new System.Windows.Forms.TextBox();
            this.txt_NombreProductoEmpleado = new System.Windows.Forms.TextBox();
            this.txt_Presentacion2Empleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Marca2Empleado = new System.Windows.Forms.TextBox();
            this.btn_Mostrar3Empleado2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSalidaEmpleado)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // salidaTableAdapter
            // 
            this.salidaTableAdapter.ClearBeforeFill = true;
            // 
            // date_FechaSalida
            // 
            this.date_FechaSalida.CustomFormat = "dd-MM-yyyy";
            this.date_FechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_FechaSalida.Location = new System.Drawing.Point(194, 193);
            this.date_FechaSalida.Name = "date_FechaSalida";
            this.date_FechaSalida.Size = new System.Drawing.Size(100, 20);
            this.date_FechaSalida.TabIndex = 80;
            // 
            // entradaBindingSource
            // 
            this.entradaBindingSource.DataMember = "Entrada";
            // 
            // salidaBindingSource1
            // 
            this.salidaBindingSource1.DataMember = "Salida";
            // 
            // salidaBindingSource
            // 
            this.salidaBindingSource.DataMember = "Salida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(479, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salida de  Productos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 81;
            this.label9.Text = "Fecha de Salida";
            // 
            // bDinventarioDataSet
            // 
            this.bDinventarioDataSet.DataSetName = "BDinventarioDataSet";
            this.bDinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salidaBindingSource2
            // 
            this.salidaBindingSource2.DataMember = "Salida";
            this.salidaBindingSource2.DataSource = this.bDinventarioDataSet;
            // 
            // codProveedorDataGridViewTextBoxColumn
            // 
            this.codProveedorDataGridViewTextBoxColumn.DataPropertyName = "Cod_Proveedor";
            this.codProveedorDataGridViewTextBoxColumn.HeaderText = "Cod_Proveedor";
            this.codProveedorDataGridViewTextBoxColumn.Name = "codProveedorDataGridViewTextBoxColumn";
            this.codProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnEditarDatosSalidaEmpleado
            // 
            this.btnEditarDatosSalidaEmpleado.BackColor = System.Drawing.Color.Teal;
            this.btnEditarDatosSalidaEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDatosSalidaEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEditarDatosSalidaEmpleado.Location = new System.Drawing.Point(168, 605);
            this.btnEditarDatosSalidaEmpleado.Name = "btnEditarDatosSalidaEmpleado";
            this.btnEditarDatosSalidaEmpleado.Size = new System.Drawing.Size(147, 43);
            this.btnEditarDatosSalidaEmpleado.TabIndex = 79;
            this.btnEditarDatosSalidaEmpleado.Text = "Modificar";
            this.btnEditarDatosSalidaEmpleado.UseVisualStyleBackColor = false;
            this.btnEditarDatosSalidaEmpleado.Click += new System.EventHandler(this.btnEditarDatosSalidaEmpleado_Click);
            // 
            // gvSalidaEmpleado
            // 
            this.gvSalidaEmpleado.AutoGenerateColumns = false;
            this.gvSalidaEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSalidaEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSalidaDataGridViewTextBoxColumn,
            this.fechaSalidaDataGridViewTextBoxColumn,
            this.codigoProductoDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.presentacionDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn,
            this.codProveedorDataGridViewTextBoxColumn});
            this.gvSalidaEmpleado.DataSource = this.salidaBindingSource2;
            this.gvSalidaEmpleado.Location = new System.Drawing.Point(485, 101);
            this.gvSalidaEmpleado.Name = "gvSalidaEmpleado";
            this.gvSalidaEmpleado.ReadOnly = true;
            this.gvSalidaEmpleado.RowHeadersVisible = false;
            this.gvSalidaEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSalidaEmpleado.Size = new System.Drawing.Size(801, 461);
            this.gvSalidaEmpleado.TabIndex = 78;
            this.gvSalidaEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSalidaEmpleado_CellClick);
            // 
            // idSalidaDataGridViewTextBoxColumn
            // 
            this.idSalidaDataGridViewTextBoxColumn.DataPropertyName = "IdSalida";
            this.idSalidaDataGridViewTextBoxColumn.HeaderText = "IdSalida";
            this.idSalidaDataGridViewTextBoxColumn.Name = "idSalidaDataGridViewTextBoxColumn";
            this.idSalidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaSalidaDataGridViewTextBoxColumn
            // 
            this.fechaSalidaDataGridViewTextBoxColumn.DataPropertyName = "FechaSalida";
            this.fechaSalidaDataGridViewTextBoxColumn.HeaderText = "FechaSalida";
            this.fechaSalidaDataGridViewTextBoxColumn.Name = "fechaSalidaDataGridViewTextBoxColumn";
            this.fechaSalidaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // btnRegresarSalidaEmpleado
            // 
            this.btnRegresarSalidaEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            this.btnRegresarSalidaEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarSalidaEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnRegresarSalidaEmpleado.Location = new System.Drawing.Point(1176, 612);
            this.btnRegresarSalidaEmpleado.Name = "btnRegresarSalidaEmpleado";
            this.btnRegresarSalidaEmpleado.Size = new System.Drawing.Size(115, 36);
            this.btnRegresarSalidaEmpleado.TabIndex = 77;
            this.btnRegresarSalidaEmpleado.Text = "Regresar";
            this.btnRegresarSalidaEmpleado.UseVisualStyleBackColor = false;
            this.btnRegresarSalidaEmpleado.Click += new System.EventHandler(this.btnRegresarSalidaEmpleado_Click);
            // 
            // txt_codigoProveedorSalidaEmpleado
            // 
            this.txt_codigoProveedorSalidaEmpleado.Location = new System.Drawing.Point(194, 469);
            this.txt_codigoProveedorSalidaEmpleado.Name = "txt_codigoProveedorSalidaEmpleado";
            this.txt_codigoProveedorSalidaEmpleado.Size = new System.Drawing.Size(214, 20);
            this.txt_codigoProveedorSalidaEmpleado.TabIndex = 76;
            this.txt_codigoProveedorSalidaEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigoProveedorSalidaEmpleado_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 75;
            this.label8.Text = "Código Proveedor";
            // 
            // txt_PrecioUnitarioSalidaEmpleado
            // 
            this.txt_PrecioUnitarioSalidaEmpleado.Location = new System.Drawing.Point(194, 429);
            this.txt_PrecioUnitarioSalidaEmpleado.Name = "txt_PrecioUnitarioSalidaEmpleado";
            this.txt_PrecioUnitarioSalidaEmpleado.Size = new System.Drawing.Size(214, 20);
            this.txt_PrecioUnitarioSalidaEmpleado.TabIndex = 74;
            this.txt_PrecioUnitarioSalidaEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PrecioUnitarioSalidaEmpleado_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 73;
            this.label7.Text = "Precio Unitario";
            // 
            // txt_CodigoProducto2Empleado
            // 
            this.txt_CodigoProducto2Empleado.Location = new System.Drawing.Point(194, 229);
            this.txt_CodigoProducto2Empleado.Name = "txt_CodigoProducto2Empleado";
            this.txt_CodigoProducto2Empleado.Size = new System.Drawing.Size(214, 20);
            this.txt_CodigoProducto2Empleado.TabIndex = 66;
            this.txt_CodigoProducto2Empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CodigoProducto2Empleado_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Código Producto";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1305, 84);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // btn_AgregarEmpleado
            // 
            this.btn_AgregarEmpleado.BackColor = System.Drawing.Color.Teal;
            this.btn_AgregarEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarEmpleado.Location = new System.Drawing.Point(12, 605);
            this.btn_AgregarEmpleado.Name = "btn_AgregarEmpleado";
            this.btn_AgregarEmpleado.Size = new System.Drawing.Size(147, 43);
            this.btn_AgregarEmpleado.TabIndex = 71;
            this.btn_AgregarEmpleado.Text = "Agregar";
            this.btn_AgregarEmpleado.UseVisualStyleBackColor = false;
            this.btn_AgregarEmpleado.Click += new System.EventHandler(this.btn_AgregarEmpleado_Click);
            // 
            // txt_CantidadSalidaEmpleado
            // 
            this.txt_CantidadSalidaEmpleado.Location = new System.Drawing.Point(194, 388);
            this.txt_CantidadSalidaEmpleado.Name = "txt_CantidadSalidaEmpleado";
            this.txt_CantidadSalidaEmpleado.Size = new System.Drawing.Size(214, 20);
            this.txt_CantidadSalidaEmpleado.TabIndex = 70;
            this.txt_CantidadSalidaEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CantidadSalidaEmpleado_KeyPress);
            // 
            // txt_NombreProductoEmpleado
            // 
            this.txt_NombreProductoEmpleado.Location = new System.Drawing.Point(194, 272);
            this.txt_NombreProductoEmpleado.Name = "txt_NombreProductoEmpleado";
            this.txt_NombreProductoEmpleado.Size = new System.Drawing.Size(214, 20);
            this.txt_NombreProductoEmpleado.TabIndex = 69;
            this.txt_NombreProductoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreProductoEmpleado_KeyPress);
            // 
            // txt_Presentacion2Empleado
            // 
            this.txt_Presentacion2Empleado.Location = new System.Drawing.Point(194, 349);
            this.txt_Presentacion2Empleado.Name = "txt_Presentacion2Empleado";
            this.txt_Presentacion2Empleado.Size = new System.Drawing.Size(214, 20);
            this.txt_Presentacion2Empleado.TabIndex = 68;
            this.txt_Presentacion2Empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Presentacion2Empleado_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 64;
            this.label5.Text = "Nombre del Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Presentación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Marca";
            // 
            // txt_Marca2Empleado
            // 
            this.txt_Marca2Empleado.Location = new System.Drawing.Point(194, 308);
            this.txt_Marca2Empleado.Name = "txt_Marca2Empleado";
            this.txt_Marca2Empleado.Size = new System.Drawing.Size(214, 20);
            this.txt_Marca2Empleado.TabIndex = 67;
            this.txt_Marca2Empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Marca2Empleado_KeyPress);
            // 
            // btn_Mostrar3Empleado2
            // 
            this.btn_Mostrar3Empleado2.BackColor = System.Drawing.Color.Teal;
            this.btn_Mostrar3Empleado2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mostrar3Empleado2.ForeColor = System.Drawing.Color.White;
            this.btn_Mostrar3Empleado2.Location = new System.Drawing.Point(321, 605);
            this.btn_Mostrar3Empleado2.Name = "btn_Mostrar3Empleado2";
            this.btn_Mostrar3Empleado2.Size = new System.Drawing.Size(147, 43);
            this.btn_Mostrar3Empleado2.TabIndex = 112;
            this.btn_Mostrar3Empleado2.Text = "Mostrar";
            this.btn_Mostrar3Empleado2.UseVisualStyleBackColor = false;
            this.btn_Mostrar3Empleado2.Click += new System.EventHandler(this.btn_Mostrar3Empleado2_Click);
            // 
            // SalidaProductosEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 661);
            this.Controls.Add(this.btn_Mostrar3Empleado2);
            this.Controls.Add(this.date_FechaSalida);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEditarDatosSalidaEmpleado);
            this.Controls.Add(this.gvSalidaEmpleado);
            this.Controls.Add(this.btnRegresarSalidaEmpleado);
            this.Controls.Add(this.txt_codigoProveedorSalidaEmpleado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_PrecioUnitarioSalidaEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_CodigoProducto2Empleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_AgregarEmpleado);
            this.Controls.Add(this.txt_CantidadSalidaEmpleado);
            this.Controls.Add(this.txt_NombreProductoEmpleado);
            this.Controls.Add(this.txt_Presentacion2Empleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Marca2Empleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalidaProductosEmpleado";
            this.Text = "Salida Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSalidaEmpleado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDinventarioDataSetTableAdapters.SalidaTableAdapter salidaTableAdapter;
        private System.Windows.Forms.DateTimePicker date_FechaSalida;
        private System.Windows.Forms.BindingSource entradaBindingSource;
        private System.Windows.Forms.BindingSource salidaBindingSource1;
        private System.Windows.Forms.BindingSource salidaBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private BDinventarioDataSet bDinventarioDataSet;
        private System.Windows.Forms.BindingSource salidaBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEditarDatosSalidaEmpleado;
        private System.Windows.Forms.DataGridView gvSalidaEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRegresarSalidaEmpleado;
        private System.Windows.Forms.TextBox txt_codigoProveedorSalidaEmpleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_PrecioUnitarioSalidaEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_CodigoProducto2Empleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_AgregarEmpleado;
        private System.Windows.Forms.TextBox txt_CantidadSalidaEmpleado;
        private System.Windows.Forms.TextBox txt_NombreProductoEmpleado;
        private System.Windows.Forms.TextBox txt_Presentacion2Empleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Marca2Empleado;
        private System.Windows.Forms.Button btn_Mostrar3Empleado2;
    }
}