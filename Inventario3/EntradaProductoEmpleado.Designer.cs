namespace Inventario3
{
    partial class EntradaProductoEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaProductoEmpleado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.entradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entradaTableAdapter = new Inventario3.BDinventarioDataSetTableAdapters.EntradaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.entradaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bDinventarioDataSet = new Inventario3.BDinventarioDataSet();
            this.entradaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.date_FechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_CantidadEntradaEmpleado = new System.Windows.Forms.TextBox();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEditarDatosEmpleado = new System.Windows.Forms.Button();
            this.txt_PrecioUnitarioEmpleado = new System.Windows.Forms.TextBox();
            this.gvEntradaEmpleado = new System.Windows.Forms.DataGridView();
            this.idEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.btnRegresarSalida = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_AgregarEmpleado = new System.Windows.Forms.Button();
            this.txt_Cod_ProveedorEmpleado = new System.Windows.Forms.TextBox();
            this.txt_NombreProductoEmpleado = new System.Windows.Forms.TextBox();
            this.txt_PresentacionEmpleado = new System.Windows.Forms.TextBox();
            this.txt_MarcaEmpleado = new System.Windows.Forms.TextBox();
            this.txt_CodigoProductoEmpleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_MostrarEmpleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEntradaEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // entradaTableAdapter
            // 
            this.entradaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(473, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registrar Productos Nuevos";
            // 
            // entradaBindingSource1
            // 
            this.entradaBindingSource1.DataMember = "Entrada";
            // 
            // bDinventarioDataSet
            // 
            this.bDinventarioDataSet.DataSetName = "BDinventarioDataSet";
            this.bDinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entradaBindingSource2
            // 
            this.entradaBindingSource2.DataMember = "Entrada";
            this.entradaBindingSource2.DataSource = this.bDinventarioDataSet;
            // 
            // precioUnitarioDataGridViewTextBoxColumn
            // 
            this.precioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.HeaderText = "PrecioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
            this.precioUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // presentacionDataGridViewTextBoxColumn
            // 
            this.presentacionDataGridViewTextBoxColumn.DataPropertyName = "Presentacion";
            this.presentacionDataGridViewTextBoxColumn.HeaderText = "Presentacion";
            this.presentacionDataGridViewTextBoxColumn.Name = "presentacionDataGridViewTextBoxColumn";
            this.presentacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 490);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 81;
            this.label9.Text = "Precio Unitario";
            // 
            // date_FechaEntrada
            // 
            this.date_FechaEntrada.CustomFormat = "dd-MM-yyyy";
            this.date_FechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_FechaEntrada.Location = new System.Drawing.Point(188, 200);
            this.date_FechaEntrada.Name = "date_FechaEntrada";
            this.date_FechaEntrada.Size = new System.Drawing.Size(100, 20);
            this.date_FechaEntrada.TabIndex = 61;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // txt_CantidadEntradaEmpleado
            // 
            this.txt_CantidadEntradaEmpleado.Location = new System.Drawing.Point(188, 449);
            this.txt_CantidadEntradaEmpleado.Name = "txt_CantidadEntradaEmpleado";
            this.txt_CantidadEntradaEmpleado.Size = new System.Drawing.Size(249, 20);
            this.txt_CantidadEntradaEmpleado.TabIndex = 76;
            this.txt_CantidadEntradaEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CantidadEntradaEmpleado_KeyPress);
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            this.nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "NombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.HeaderText = "NombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            this.nombreProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 80;
            this.label8.Text = "Fecha de Entrada";
            // 
            // btnEditarDatosEmpleado
            // 
            this.btnEditarDatosEmpleado.BackColor = System.Drawing.Color.Teal;
            this.btnEditarDatosEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDatosEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEditarDatosEmpleado.Location = new System.Drawing.Point(165, 607);
            this.btnEditarDatosEmpleado.Name = "btnEditarDatosEmpleado";
            this.btnEditarDatosEmpleado.Size = new System.Drawing.Size(147, 43);
            this.btnEditarDatosEmpleado.TabIndex = 79;
            this.btnEditarDatosEmpleado.Text = "Modificar";
            this.btnEditarDatosEmpleado.UseVisualStyleBackColor = false;
            this.btnEditarDatosEmpleado.Click += new System.EventHandler(this.btnEditarDatosEmpleado_Click);
            // 
            // txt_PrecioUnitarioEmpleado
            // 
            this.txt_PrecioUnitarioEmpleado.Location = new System.Drawing.Point(188, 493);
            this.txt_PrecioUnitarioEmpleado.Name = "txt_PrecioUnitarioEmpleado";
            this.txt_PrecioUnitarioEmpleado.Size = new System.Drawing.Size(249, 20);
            this.txt_PrecioUnitarioEmpleado.TabIndex = 82;
            this.txt_PrecioUnitarioEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PrecioUnitarioEmpleado_KeyPress);
            // 
            // gvEntradaEmpleado
            // 
            this.gvEntradaEmpleado.AutoGenerateColumns = false;
            this.gvEntradaEmpleado.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvEntradaEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvEntradaEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEntradaEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEntradaDataGridViewTextBoxColumn,
            this.fechaEntradaDataGridViewTextBoxColumn,
            this.codProveedorDataGridViewTextBoxColumn,
            this.codigoProductoDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.presentacionDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn});
            this.gvEntradaEmpleado.DataSource = this.entradaBindingSource3;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvEntradaEmpleado.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvEntradaEmpleado.GridColor = System.Drawing.Color.Black;
            this.gvEntradaEmpleado.Location = new System.Drawing.Point(454, 115);
            this.gvEntradaEmpleado.Name = "gvEntradaEmpleado";
            this.gvEntradaEmpleado.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvEntradaEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvEntradaEmpleado.RowHeadersVisible = false;
            this.gvEntradaEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvEntradaEmpleado.Size = new System.Drawing.Size(902, 465);
            this.gvEntradaEmpleado.TabIndex = 78;
            this.gvEntradaEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvEntradaEmpleado_CellClick);
            // 
            // idEntradaDataGridViewTextBoxColumn
            // 
            this.idEntradaDataGridViewTextBoxColumn.DataPropertyName = "IdEntrada";
            this.idEntradaDataGridViewTextBoxColumn.HeaderText = "IdEntrada";
            this.idEntradaDataGridViewTextBoxColumn.Name = "idEntradaDataGridViewTextBoxColumn";
            this.idEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaEntradaDataGridViewTextBoxColumn
            // 
            this.fechaEntradaDataGridViewTextBoxColumn.DataPropertyName = "FechaEntrada";
            this.fechaEntradaDataGridViewTextBoxColumn.HeaderText = "FechaEntrada";
            this.fechaEntradaDataGridViewTextBoxColumn.Name = "fechaEntradaDataGridViewTextBoxColumn";
            this.fechaEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codProveedorDataGridViewTextBoxColumn
            // 
            this.codProveedorDataGridViewTextBoxColumn.DataPropertyName = "Cod_Proveedor";
            this.codProveedorDataGridViewTextBoxColumn.HeaderText = "Cod_Proveedor";
            this.codProveedorDataGridViewTextBoxColumn.Name = "codProveedorDataGridViewTextBoxColumn";
            this.codProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoProductoDataGridViewTextBoxColumn
            // 
            this.codigoProductoDataGridViewTextBoxColumn.DataPropertyName = "CodigoProducto";
            this.codigoProductoDataGridViewTextBoxColumn.HeaderText = "CodigoProducto";
            this.codigoProductoDataGridViewTextBoxColumn.Name = "codigoProductoDataGridViewTextBoxColumn";
            this.codigoProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entradaBindingSource3
            // 
            this.entradaBindingSource3.DataMember = "Entrada";
            this.entradaBindingSource3.DataSource = this.bDinventarioDataSet;
            // 
            // btnRegresarSalida
            // 
            this.btnRegresarSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            this.btnRegresarSalida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarSalida.ForeColor = System.Drawing.Color.White;
            this.btnRegresarSalida.Location = new System.Drawing.Point(1209, 607);
            this.btnRegresarSalida.Name = "btnRegresarSalida";
            this.btnRegresarSalida.Size = new System.Drawing.Size(147, 43);
            this.btnRegresarSalida.TabIndex = 77;
            this.btnRegresarSalida.Text = "Regresar";
            this.btnRegresarSalida.UseVisualStyleBackColor = false;
            this.btnRegresarSalida.Click += new System.EventHandler(this.btnRegresarSalida_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 75;
            this.label7.Text = "Cantidad";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-46, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1419, 84);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            // 
            // btn_AgregarEmpleado
            // 
            this.btn_AgregarEmpleado.BackColor = System.Drawing.Color.Teal;
            this.btn_AgregarEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarEmpleado.Location = new System.Drawing.Point(12, 607);
            this.btn_AgregarEmpleado.Name = "btn_AgregarEmpleado";
            this.btn_AgregarEmpleado.Size = new System.Drawing.Size(147, 43);
            this.btn_AgregarEmpleado.TabIndex = 73;
            this.btn_AgregarEmpleado.Text = "Agregar";
            this.btn_AgregarEmpleado.UseVisualStyleBackColor = false;
            this.btn_AgregarEmpleado.Click += new System.EventHandler(this.btn_AgregarEmpleado_Click);
            // 
            // txt_Cod_ProveedorEmpleado
            // 
            this.txt_Cod_ProveedorEmpleado.Location = new System.Drawing.Point(188, 241);
            this.txt_Cod_ProveedorEmpleado.Name = "txt_Cod_ProveedorEmpleado";
            this.txt_Cod_ProveedorEmpleado.Size = new System.Drawing.Size(245, 20);
            this.txt_Cod_ProveedorEmpleado.TabIndex = 72;
            this.txt_Cod_ProveedorEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cod_ProveedorEmpleado_KeyPress);
            // 
            // txt_NombreProductoEmpleado
            // 
            this.txt_NombreProductoEmpleado.Location = new System.Drawing.Point(188, 320);
            this.txt_NombreProductoEmpleado.Name = "txt_NombreProductoEmpleado";
            this.txt_NombreProductoEmpleado.Size = new System.Drawing.Size(249, 20);
            this.txt_NombreProductoEmpleado.TabIndex = 71;
            this.txt_NombreProductoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreProductoEmpleado_KeyPress);
            // 
            // txt_PresentacionEmpleado
            // 
            this.txt_PresentacionEmpleado.Location = new System.Drawing.Point(189, 402);
            this.txt_PresentacionEmpleado.Name = "txt_PresentacionEmpleado";
            this.txt_PresentacionEmpleado.Size = new System.Drawing.Size(248, 20);
            this.txt_PresentacionEmpleado.TabIndex = 70;
            this.txt_PresentacionEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PresentacionEmpleado_KeyPress);
            // 
            // txt_MarcaEmpleado
            // 
            this.txt_MarcaEmpleado.Location = new System.Drawing.Point(188, 363);
            this.txt_MarcaEmpleado.Name = "txt_MarcaEmpleado";
            this.txt_MarcaEmpleado.Size = new System.Drawing.Size(249, 20);
            this.txt_MarcaEmpleado.TabIndex = 69;
            this.txt_MarcaEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MarcaEmpleado_KeyPress);
            // 
            // txt_CodigoProductoEmpleado
            // 
            this.txt_CodigoProductoEmpleado.Location = new System.Drawing.Point(189, 280);
            this.txt_CodigoProductoEmpleado.Name = "txt_CodigoProductoEmpleado";
            this.txt_CodigoProductoEmpleado.Size = new System.Drawing.Size(248, 20);
            this.txt_CodigoProductoEmpleado.TabIndex = 68;
            this.txt_CodigoProductoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CodigoProductoEmpleado_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 67;
            this.label6.Text = "Código Proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Nombre Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Presentación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Código Producto";
            // 
            // btn_MostrarEmpleado
            // 
            this.btn_MostrarEmpleado.BackColor = System.Drawing.Color.Teal;
            this.btn_MostrarEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MostrarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_MostrarEmpleado.Location = new System.Drawing.Point(318, 607);
            this.btn_MostrarEmpleado.Name = "btn_MostrarEmpleado";
            this.btn_MostrarEmpleado.Size = new System.Drawing.Size(147, 43);
            this.btn_MostrarEmpleado.TabIndex = 106;
            this.btn_MostrarEmpleado.Text = "Mostrar";
            this.btn_MostrarEmpleado.UseVisualStyleBackColor = false;
            this.btn_MostrarEmpleado.Click += new System.EventHandler(this.btn_MostrarEmpleado_Click);
            // 
            // EntradaProductoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1368, 671);
            this.Controls.Add(this.btn_MostrarEmpleado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.date_FechaEntrada);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_CantidadEntradaEmpleado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEditarDatosEmpleado);
            this.Controls.Add(this.txt_PrecioUnitarioEmpleado);
            this.Controls.Add(this.gvEntradaEmpleado);
            this.Controls.Add(this.btnRegresarSalida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_AgregarEmpleado);
            this.Controls.Add(this.txt_Cod_ProveedorEmpleado);
            this.Controls.Add(this.txt_NombreProductoEmpleado);
            this.Controls.Add(this.txt_PresentacionEmpleado);
            this.Controls.Add(this.txt_MarcaEmpleado);
            this.Controls.Add(this.txt_CodigoProductoEmpleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntradaProductoEmpleado";
            this.Text = "Entrada Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEntradaEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource entradaBindingSource;
        private BDinventarioDataSetTableAdapters.EntradaTableAdapter entradaTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource entradaBindingSource1;
        private BDinventarioDataSet bDinventarioDataSet;
        private System.Windows.Forms.BindingSource entradaBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker date_FechaEntrada;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_CantidadEntradaEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEditarDatosEmpleado;
        private System.Windows.Forms.TextBox txt_PrecioUnitarioEmpleado;
        private System.Windows.Forms.DataGridView gvEntradaEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRegresarSalida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AgregarEmpleado;
        private System.Windows.Forms.TextBox txt_Cod_ProveedorEmpleado;
        private System.Windows.Forms.TextBox txt_NombreProductoEmpleado;
        private System.Windows.Forms.TextBox txt_PresentacionEmpleado;
        private System.Windows.Forms.TextBox txt_MarcaEmpleado;
        private System.Windows.Forms.TextBox txt_CodigoProductoEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource entradaBindingSource3;
        private System.Windows.Forms.Button btn_MostrarEmpleado;
    }
}