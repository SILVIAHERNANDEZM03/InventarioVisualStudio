namespace Inventario3
{
    partial class EntradaEdicionEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaEdicionEmpleado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.entradaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_BuscarEmpleado = new System.Windows.Forms.Button();
            this.txt_BuscarEmpleado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresarSalidaEmpleado = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_EditarEntradaEmpleado = new System.Windows.Forms.Button();
            this.txt_Cod_Proveedor2Empleado = new System.Windows.Forms.TextBox();
            this.txt_NombreProducto2Empleado = new System.Windows.Forms.TextBox();
            this.txt_Presentacion2Empleado = new System.Windows.Forms.TextBox();
            this.txt_Marca2Empleado = new System.Windows.Forms.TextBox();
            this.txt_CodigoProducto2Empleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.entradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.entradaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bDinventarioDataSet = new Inventario3.BDinventarioDataSet();
            this.entradaTableAdapter = new Inventario3.BDinventarioDataSetTableAdapters.EntradaTableAdapter();
            this.entradaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.date_FechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.txt_CantidadEntrada2Empleado = new System.Windows.Forms.TextBox();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Mostrar2Empleado = new System.Windows.Forms.Button();
            this.txt_PrecioUnitario2Empleado = new System.Windows.Forms.TextBox();
            this.gvEntradaEdicionEmpleado = new System.Windows.Forms.DataGridView();
            this.idEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEntradaEdicionEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // entradaBindingSource1
            // 
            this.entradaBindingSource1.DataMember = "Entrada";
            // 
            // btn_BuscarEmpleado
            // 
            this.btn_BuscarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            this.btn_BuscarEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_BuscarEmpleado.Location = new System.Drawing.Point(1145, 102);
            this.btn_BuscarEmpleado.Name = "btn_BuscarEmpleado";
            this.btn_BuscarEmpleado.Size = new System.Drawing.Size(111, 33);
            this.btn_BuscarEmpleado.TabIndex = 111;
            this.btn_BuscarEmpleado.Text = "Buscar";
            this.btn_BuscarEmpleado.UseVisualStyleBackColor = false;
            this.btn_BuscarEmpleado.Click += new System.EventHandler(this.btn_BuscarEmpleado_Click);
            // 
            // txt_BuscarEmpleado
            // 
            this.txt_BuscarEmpleado.Location = new System.Drawing.Point(702, 110);
            this.txt_BuscarEmpleado.Name = "txt_BuscarEmpleado";
            this.txt_BuscarEmpleado.Size = new System.Drawing.Size(409, 20);
            this.txt_BuscarEmpleado.TabIndex = 110;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(512, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 20);
            this.label10.TabIndex = 109;
            this.label10.Text = "Nombre del Producto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegresarSalidaEmpleado
            // 
            this.btnRegresarSalidaEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            this.btnRegresarSalidaEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarSalidaEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnRegresarSalidaEmpleado.Location = new System.Drawing.Point(1211, 636);
            this.btnRegresarSalidaEmpleado.Name = "btnRegresarSalidaEmpleado";
            this.btnRegresarSalidaEmpleado.Size = new System.Drawing.Size(147, 43);
            this.btnRegresarSalidaEmpleado.TabIndex = 103;
            this.btnRegresarSalidaEmpleado.Text = "Regresar";
            this.btnRegresarSalidaEmpleado.UseVisualStyleBackColor = false;
            this.btnRegresarSalidaEmpleado.Click += new System.EventHandler(this.btnRegresarSalidaEmpleado_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 101;
            this.label7.Text = "Cantidad";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1419, 84);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
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
            // btn_EditarEntradaEmpleado
            // 
            this.btn_EditarEntradaEmpleado.BackColor = System.Drawing.Color.Teal;
            this.btn_EditarEntradaEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditarEntradaEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_EditarEntradaEmpleado.Location = new System.Drawing.Point(12, 630);
            this.btn_EditarEntradaEmpleado.Name = "btn_EditarEntradaEmpleado";
            this.btn_EditarEntradaEmpleado.Size = new System.Drawing.Size(147, 43);
            this.btn_EditarEntradaEmpleado.TabIndex = 99;
            this.btn_EditarEntradaEmpleado.Text = "Editar";
            this.btn_EditarEntradaEmpleado.UseVisualStyleBackColor = false;
            this.btn_EditarEntradaEmpleado.Click += new System.EventHandler(this.btn_EditarEntradaEmpleado_Click);
            // 
            // txt_Cod_Proveedor2Empleado
            // 
            this.txt_Cod_Proveedor2Empleado.Location = new System.Drawing.Point(190, 266);
            this.txt_Cod_Proveedor2Empleado.Name = "txt_Cod_Proveedor2Empleado";
            this.txt_Cod_Proveedor2Empleado.Size = new System.Drawing.Size(245, 20);
            this.txt_Cod_Proveedor2Empleado.TabIndex = 98;
            this.txt_Cod_Proveedor2Empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cod_Proveedor2Empleado_KeyPress);
            // 
            // txt_NombreProducto2Empleado
            // 
            this.txt_NombreProducto2Empleado.Location = new System.Drawing.Point(190, 345);
            this.txt_NombreProducto2Empleado.Name = "txt_NombreProducto2Empleado";
            this.txt_NombreProducto2Empleado.Size = new System.Drawing.Size(249, 20);
            this.txt_NombreProducto2Empleado.TabIndex = 97;
            this.txt_NombreProducto2Empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreProducto2Empleado_KeyPress);
            // 
            // txt_Presentacion2Empleado
            // 
            this.txt_Presentacion2Empleado.Location = new System.Drawing.Point(191, 427);
            this.txt_Presentacion2Empleado.Name = "txt_Presentacion2Empleado";
            this.txt_Presentacion2Empleado.Size = new System.Drawing.Size(248, 20);
            this.txt_Presentacion2Empleado.TabIndex = 96;
            this.txt_Presentacion2Empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Presentacion2Empleado_KeyPress);
            // 
            // txt_Marca2Empleado
            // 
            this.txt_Marca2Empleado.Location = new System.Drawing.Point(190, 388);
            this.txt_Marca2Empleado.Name = "txt_Marca2Empleado";
            this.txt_Marca2Empleado.Size = new System.Drawing.Size(249, 20);
            this.txt_Marca2Empleado.TabIndex = 95;
            this.txt_Marca2Empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Marca2Empleado_KeyPress);
            // 
            // txt_CodigoProducto2Empleado
            // 
            this.txt_CodigoProducto2Empleado.Location = new System.Drawing.Point(191, 305);
            this.txt_CodigoProducto2Empleado.Name = "txt_CodigoProducto2Empleado";
            this.txt_CodigoProducto2Empleado.Size = new System.Drawing.Size(248, 20);
            this.txt_CodigoProducto2Empleado.TabIndex = 94;
            this.txt_CodigoProducto2Empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CodigoProducto2Empleado_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 92;
            this.label5.Text = "Nombre Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 91;
            this.label4.Text = "Presentación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 90;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 88;
            this.label2.Text = "Código Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 93;
            this.label6.Text = "Código Proveedor";
            // 
            // entradaBindingSource3
            // 
            this.entradaBindingSource3.DataMember = "Entrada";
            this.entradaBindingSource3.DataSource = this.bDinventarioDataSet;
            // 
            // bDinventarioDataSet
            // 
            this.bDinventarioDataSet.DataSetName = "BDinventarioDataSet";
            this.bDinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entradaTableAdapter
            // 
            this.entradaTableAdapter.ClearBeforeFill = true;
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
            this.label9.Location = new System.Drawing.Point(14, 515);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 107;
            this.label9.Text = "Precio Unitario";
            // 
            // date_FechaEntrada
            // 
            this.date_FechaEntrada.CustomFormat = "dd-MM-yyyy";
            this.date_FechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_FechaEntrada.Location = new System.Drawing.Point(190, 225);
            this.date_FechaEntrada.Name = "date_FechaEntrada";
            this.date_FechaEntrada.Size = new System.Drawing.Size(100, 20);
            this.date_FechaEntrada.TabIndex = 87;
            // 
            // txt_CantidadEntrada2Empleado
            // 
            this.txt_CantidadEntrada2Empleado.Location = new System.Drawing.Point(190, 474);
            this.txt_CantidadEntrada2Empleado.Name = "txt_CantidadEntrada2Empleado";
            this.txt_CantidadEntrada2Empleado.Size = new System.Drawing.Size(249, 20);
            this.txt_CantidadEntrada2Empleado.TabIndex = 102;
            this.txt_CantidadEntrada2Empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CantidadEntrada2Empleado_KeyPress);
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
            this.label8.Location = new System.Drawing.Point(14, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 106;
            this.label8.Text = "Fecha de Entrada";
            // 
            // btn_Mostrar2Empleado
            // 
            this.btn_Mostrar2Empleado.BackColor = System.Drawing.Color.Teal;
            this.btn_Mostrar2Empleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mostrar2Empleado.ForeColor = System.Drawing.Color.White;
            this.btn_Mostrar2Empleado.Location = new System.Drawing.Point(165, 630);
            this.btn_Mostrar2Empleado.Name = "btn_Mostrar2Empleado";
            this.btn_Mostrar2Empleado.Size = new System.Drawing.Size(147, 43);
            this.btn_Mostrar2Empleado.TabIndex = 105;
            this.btn_Mostrar2Empleado.Text = "Mostrar";
            this.btn_Mostrar2Empleado.UseVisualStyleBackColor = false;
            this.btn_Mostrar2Empleado.Click += new System.EventHandler(this.btn_Mostrar2Empleado_Click);
            // 
            // txt_PrecioUnitario2Empleado
            // 
            this.txt_PrecioUnitario2Empleado.Location = new System.Drawing.Point(190, 518);
            this.txt_PrecioUnitario2Empleado.Name = "txt_PrecioUnitario2Empleado";
            this.txt_PrecioUnitario2Empleado.Size = new System.Drawing.Size(249, 20);
            this.txt_PrecioUnitario2Empleado.TabIndex = 108;
            this.txt_PrecioUnitario2Empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PrecioUnitario2Empleado_KeyPress);
            // 
            // gvEntradaEdicionEmpleado
            // 
            this.gvEntradaEdicionEmpleado.AutoGenerateColumns = false;
            this.gvEntradaEdicionEmpleado.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvEntradaEdicionEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.gvEntradaEdicionEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEntradaEdicionEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEntradaDataGridViewTextBoxColumn,
            this.fechaEntradaDataGridViewTextBoxColumn,
            this.codProveedorDataGridViewTextBoxColumn,
            this.codigoProductoDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.presentacionDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn});
            this.gvEntradaEdicionEmpleado.DataSource = this.entradaBindingSource3;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvEntradaEdicionEmpleado.DefaultCellStyle = dataGridViewCellStyle32;
            this.gvEntradaEdicionEmpleado.GridColor = System.Drawing.Color.Black;
            this.gvEntradaEdicionEmpleado.Location = new System.Drawing.Point(456, 159);
            this.gvEntradaEdicionEmpleado.Name = "gvEntradaEdicionEmpleado";
            this.gvEntradaEdicionEmpleado.ReadOnly = true;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvEntradaEdicionEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.gvEntradaEdicionEmpleado.RowHeadersVisible = false;
            this.gvEntradaEdicionEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvEntradaEdicionEmpleado.Size = new System.Drawing.Size(902, 465);
            this.gvEntradaEdicionEmpleado.TabIndex = 104;
            this.gvEntradaEdicionEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvEntradaEdicionEmpleado_CellClick);
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
            // EntradaEdicionEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 692);
            this.Controls.Add(this.btn_BuscarEmpleado);
            this.Controls.Add(this.txt_BuscarEmpleado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegresarSalidaEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_EditarEntradaEmpleado);
            this.Controls.Add(this.txt_Cod_Proveedor2Empleado);
            this.Controls.Add(this.txt_NombreProducto2Empleado);
            this.Controls.Add(this.txt_Presentacion2Empleado);
            this.Controls.Add(this.txt_Marca2Empleado);
            this.Controls.Add(this.txt_CodigoProducto2Empleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.date_FechaEntrada);
            this.Controls.Add(this.txt_CantidadEntrada2Empleado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Mostrar2Empleado);
            this.Controls.Add(this.txt_PrecioUnitario2Empleado);
            this.Controls.Add(this.gvEntradaEdicionEmpleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntradaEdicionEmpleado";
            this.Text = "Entrada Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEntradaEdicionEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource entradaBindingSource1;
        private System.Windows.Forms.Button btn_BuscarEmpleado;
        private System.Windows.Forms.TextBox txt_BuscarEmpleado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegresarSalidaEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_EditarEntradaEmpleado;
        private System.Windows.Forms.TextBox txt_Cod_Proveedor2Empleado;
        private System.Windows.Forms.TextBox txt_NombreProducto2Empleado;
        private System.Windows.Forms.TextBox txt_Presentacion2Empleado;
        private System.Windows.Forms.TextBox txt_Marca2Empleado;
        private System.Windows.Forms.TextBox txt_CodigoProducto2Empleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource entradaBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource entradaBindingSource3;
        private BDinventarioDataSet bDinventarioDataSet;
        private BDinventarioDataSetTableAdapters.EntradaTableAdapter entradaTableAdapter;
        private System.Windows.Forms.BindingSource entradaBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker date_FechaEntrada;
        private System.Windows.Forms.TextBox txt_CantidadEntrada2Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Mostrar2Empleado;
        private System.Windows.Forms.TextBox txt_PrecioUnitario2Empleado;
        private System.Windows.Forms.DataGridView gvEntradaEdicionEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProductoDataGridViewTextBoxColumn;
    }
}