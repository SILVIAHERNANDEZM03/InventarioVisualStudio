namespace Inventario3
{
    partial class SalidaEdicionEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalidaEdicionEmpleado));
            this.btn_Buscar3Empleado = new System.Windows.Forms.Button();
            this.txt_Buscar3Empleado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Mostrar3Empleado = new System.Windows.Forms.Button();
            this.btn_EditarEntrada3Empleado = new System.Windows.Forms.Button();
            this.date_FechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRegresarSalidaEmpleado = new System.Windows.Forms.Button();
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSalida3Empleado = new System.Windows.Forms.DataGridView();
            this.idSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salidaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bDinventarioDataSet = new Inventario3.BDinventarioDataSet();
            this.txt_codigoProveedorSalida3Empleado = new System.Windows.Forms.TextBox();
            this.salidaTableAdapter = new Inventario3.BDinventarioDataSetTableAdapters.SalidaTableAdapter();
            this.entradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salidaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txt_PrecioUnitarioSalida3Empleado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_CodigoProducto3Empleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_CantidadSalida3Empleado = new System.Windows.Forms.TextBox();
            this.txt_NombreProducto3Empleado = new System.Windows.Forms.TextBox();
            this.txt_Presentacion3Empleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Marca3Empleado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvSalida3Empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Buscar3Empleado
            // 
            this.btn_Buscar3Empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            this.btn_Buscar3Empleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar3Empleado.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar3Empleado.Location = new System.Drawing.Point(1131, 105);
            this.btn_Buscar3Empleado.Name = "btn_Buscar3Empleado";
            this.btn_Buscar3Empleado.Size = new System.Drawing.Size(111, 33);
            this.btn_Buscar3Empleado.TabIndex = 114;
            this.btn_Buscar3Empleado.Text = "Buscar";
            this.btn_Buscar3Empleado.UseVisualStyleBackColor = false;
            this.btn_Buscar3Empleado.Click += new System.EventHandler(this.btn_Buscar3Empleado_Click);
            // 
            // txt_Buscar3Empleado
            // 
            this.txt_Buscar3Empleado.Location = new System.Drawing.Point(688, 113);
            this.txt_Buscar3Empleado.Name = "txt_Buscar3Empleado";
            this.txt_Buscar3Empleado.Size = new System.Drawing.Size(409, 20);
            this.txt_Buscar3Empleado.TabIndex = 113;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(498, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 20);
            this.label10.TabIndex = 112;
            this.label10.Text = "Nombre del Producto";
            // 
            // btn_Mostrar3Empleado
            // 
            this.btn_Mostrar3Empleado.BackColor = System.Drawing.Color.Teal;
            this.btn_Mostrar3Empleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mostrar3Empleado.ForeColor = System.Drawing.Color.White;
            this.btn_Mostrar3Empleado.Location = new System.Drawing.Point(164, 636);
            this.btn_Mostrar3Empleado.Name = "btn_Mostrar3Empleado";
            this.btn_Mostrar3Empleado.Size = new System.Drawing.Size(147, 43);
            this.btn_Mostrar3Empleado.TabIndex = 111;
            this.btn_Mostrar3Empleado.Text = "Mostrar";
            this.btn_Mostrar3Empleado.UseVisualStyleBackColor = false;
            this.btn_Mostrar3Empleado.Click += new System.EventHandler(this.btn_Mostrar3Empleado_Click);
            // 
            // btn_EditarEntrada3Empleado
            // 
            this.btn_EditarEntrada3Empleado.BackColor = System.Drawing.Color.Teal;
            this.btn_EditarEntrada3Empleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditarEntrada3Empleado.ForeColor = System.Drawing.Color.White;
            this.btn_EditarEntrada3Empleado.Location = new System.Drawing.Point(11, 636);
            this.btn_EditarEntrada3Empleado.Name = "btn_EditarEntrada3Empleado";
            this.btn_EditarEntrada3Empleado.Size = new System.Drawing.Size(147, 43);
            this.btn_EditarEntrada3Empleado.TabIndex = 110;
            this.btn_EditarEntrada3Empleado.Text = "Editar";
            this.btn_EditarEntrada3Empleado.UseVisualStyleBackColor = false;
            this.btn_EditarEntrada3Empleado.Click += new System.EventHandler(this.btn_EditarEntrada3Empleado_Click);
            // 
            // date_FechaSalida
            // 
            this.date_FechaSalida.CustomFormat = "dd-MM-yyyy";
            this.date_FechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_FechaSalida.Location = new System.Drawing.Point(195, 193);
            this.date_FechaSalida.Name = "date_FechaSalida";
            this.date_FechaSalida.Size = new System.Drawing.Size(100, 20);
            this.date_FechaSalida.TabIndex = 108;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 109;
            this.label9.Text = "Fecha de Salida";
            // 
            // btnRegresarSalidaEmpleado
            // 
            this.btnRegresarSalidaEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            this.btnRegresarSalidaEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarSalidaEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnRegresarSalidaEmpleado.Location = new System.Drawing.Point(1242, 643);
            this.btnRegresarSalidaEmpleado.Name = "btnRegresarSalidaEmpleado";
            this.btnRegresarSalidaEmpleado.Size = new System.Drawing.Size(115, 36);
            this.btnRegresarSalidaEmpleado.TabIndex = 106;
            this.btnRegresarSalidaEmpleado.Text = "Regresar";
            this.btnRegresarSalidaEmpleado.UseVisualStyleBackColor = false;
            this.btnRegresarSalidaEmpleado.Click += new System.EventHandler(this.btnRegresarSalidaEmpleado_Click);
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
            // gvSalida3Empleado
            // 
            this.gvSalida3Empleado.AutoGenerateColumns = false;
            this.gvSalida3Empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSalida3Empleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSalidaDataGridViewTextBoxColumn,
            this.fechaSalidaDataGridViewTextBoxColumn,
            this.codigoProductoDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.presentacionDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn,
            this.codProveedorDataGridViewTextBoxColumn});
            this.gvSalida3Empleado.DataSource = this.salidaBindingSource2;
            this.gvSalida3Empleado.Location = new System.Drawing.Point(518, 157);
            this.gvSalida3Empleado.Name = "gvSalida3Empleado";
            this.gvSalida3Empleado.ReadOnly = true;
            this.gvSalida3Empleado.RowHeadersVisible = false;
            this.gvSalida3Empleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSalida3Empleado.Size = new System.Drawing.Size(801, 461);
            this.gvSalida3Empleado.TabIndex = 107;
            this.gvSalida3Empleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSalida3Empleado_CellClick);
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
            // codProveedorDataGridViewTextBoxColumn
            // 
            this.codProveedorDataGridViewTextBoxColumn.DataPropertyName = "Cod_Proveedor";
            this.codProveedorDataGridViewTextBoxColumn.HeaderText = "Cod_Proveedor";
            this.codProveedorDataGridViewTextBoxColumn.Name = "codProveedorDataGridViewTextBoxColumn";
            this.codProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salidaBindingSource2
            // 
            this.salidaBindingSource2.DataMember = "Salida";
            this.salidaBindingSource2.DataSource = this.bDinventarioDataSet;
            // 
            // bDinventarioDataSet
            // 
            this.bDinventarioDataSet.DataSetName = "BDinventarioDataSet";
            this.bDinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_codigoProveedorSalida3Empleado
            // 
            this.txt_codigoProveedorSalida3Empleado.Location = new System.Drawing.Point(195, 469);
            this.txt_codigoProveedorSalida3Empleado.Name = "txt_codigoProveedorSalida3Empleado";
            this.txt_codigoProveedorSalida3Empleado.Size = new System.Drawing.Size(214, 20);
            this.txt_codigoProveedorSalida3Empleado.TabIndex = 105;
            this.txt_codigoProveedorSalida3Empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigoProveedorSalida3Empleado_KeyPress);
            // 
            // salidaTableAdapter
            // 
            this.salidaTableAdapter.ClearBeforeFill = true;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 104;
            this.label8.Text = "Código Proveedor";
            // 
            // txt_PrecioUnitarioSalida3Empleado
            // 
            this.txt_PrecioUnitarioSalida3Empleado.Location = new System.Drawing.Point(195, 429);
            this.txt_PrecioUnitarioSalida3Empleado.Name = "txt_PrecioUnitarioSalida3Empleado";
            this.txt_PrecioUnitarioSalida3Empleado.Size = new System.Drawing.Size(214, 20);
            this.txt_PrecioUnitarioSalida3Empleado.TabIndex = 103;
            this.txt_PrecioUnitarioSalida3Empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PrecioUnitarioSalida3Empleado_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 102;
            this.label7.Text = "Precio Unitario";
            // 
            // txt_CodigoProducto3Empleado
            // 
            this.txt_CodigoProducto3Empleado.Location = new System.Drawing.Point(195, 229);
            this.txt_CodigoProducto3Empleado.Name = "txt_CodigoProducto3Empleado";
            this.txt_CodigoProducto3Empleado.Size = new System.Drawing.Size(214, 20);
            this.txt_CodigoProducto3Empleado.TabIndex = 96;
            this.txt_CodigoProducto3Empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CodigoProducto3Empleado_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 91;
            this.label2.Text = "Código Producto";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1376, 84);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // txt_CantidadSalida3Empleado
            // 
            this.txt_CantidadSalida3Empleado.Location = new System.Drawing.Point(195, 388);
            this.txt_CantidadSalida3Empleado.Name = "txt_CantidadSalida3Empleado";
            this.txt_CantidadSalida3Empleado.Size = new System.Drawing.Size(214, 20);
            this.txt_CantidadSalida3Empleado.TabIndex = 100;
            this.txt_CantidadSalida3Empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CantidadSalida3Empleado_KeyPress);
            // 
            // txt_NombreProducto3Empleado
            // 
            this.txt_NombreProducto3Empleado.Location = new System.Drawing.Point(195, 272);
            this.txt_NombreProducto3Empleado.Name = "txt_NombreProducto3Empleado";
            this.txt_NombreProducto3Empleado.Size = new System.Drawing.Size(214, 20);
            this.txt_NombreProducto3Empleado.TabIndex = 99;
            this.txt_NombreProducto3Empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreProducto3Empleado_KeyPress);
            // 
            // txt_Presentacion3Empleado
            // 
            this.txt_Presentacion3Empleado.Location = new System.Drawing.Point(195, 349);
            this.txt_Presentacion3Empleado.Name = "txt_Presentacion3Empleado";
            this.txt_Presentacion3Empleado.Size = new System.Drawing.Size(214, 20);
            this.txt_Presentacion3Empleado.TabIndex = 98;
            this.txt_Presentacion3Empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Presentacion3Empleado_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 95;
            this.label6.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 94;
            this.label5.Text = "Nombre del Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 93;
            this.label4.Text = "Presentación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 92;
            this.label3.Text = "Marca";
            // 
            // txt_Marca3Empleado
            // 
            this.txt_Marca3Empleado.Location = new System.Drawing.Point(195, 308);
            this.txt_Marca3Empleado.Name = "txt_Marca3Empleado";
            this.txt_Marca3Empleado.Size = new System.Drawing.Size(214, 20);
            this.txt_Marca3Empleado.TabIndex = 97;
            this.txt_Marca3Empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Marca3Empleado_KeyPress);
            // 
            // SalidaEdicionEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 692);
            this.Controls.Add(this.btn_Buscar3Empleado);
            this.Controls.Add(this.txt_Buscar3Empleado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_Mostrar3Empleado);
            this.Controls.Add(this.btn_EditarEntrada3Empleado);
            this.Controls.Add(this.date_FechaSalida);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRegresarSalidaEmpleado);
            this.Controls.Add(this.gvSalida3Empleado);
            this.Controls.Add(this.txt_codigoProveedorSalida3Empleado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_PrecioUnitarioSalida3Empleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_CodigoProducto3Empleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_CantidadSalida3Empleado);
            this.Controls.Add(this.txt_NombreProducto3Empleado);
            this.Controls.Add(this.txt_Presentacion3Empleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Marca3Empleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalidaEdicionEmpleado";
            this.Text = "Salida Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.gvSalida3Empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Buscar3Empleado;
        private System.Windows.Forms.TextBox txt_Buscar3Empleado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Mostrar3Empleado;
        private System.Windows.Forms.Button btn_EditarEntrada3Empleado;
        private System.Windows.Forms.DateTimePicker date_FechaSalida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRegresarSalidaEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView gvSalida3Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource salidaBindingSource2;
        private BDinventarioDataSet bDinventarioDataSet;
        private System.Windows.Forms.TextBox txt_codigoProveedorSalida3Empleado;
        private BDinventarioDataSetTableAdapters.SalidaTableAdapter salidaTableAdapter;
        private System.Windows.Forms.BindingSource entradaBindingSource;
        private System.Windows.Forms.BindingSource salidaBindingSource1;
        private System.Windows.Forms.BindingSource salidaBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_PrecioUnitarioSalida3Empleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_CodigoProducto3Empleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_CantidadSalida3Empleado;
        private System.Windows.Forms.TextBox txt_NombreProducto3Empleado;
        private System.Windows.Forms.TextBox txt_Presentacion3Empleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Marca3Empleado;
    }
}