namespace Inventario3
{
    partial class EntradaEdicionAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaEdicionAdmin));
            this.entradaTableAdapter = new Inventario3.BDinventarioDataSetTableAdapters.EntradaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.bDinventarioDataSet = new Inventario3.BDinventarioDataSet();
            this.entradaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.date_FechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.txt_CantidadEntrada2 = new System.Windows.Forms.TextBox();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Mostrar2 = new System.Windows.Forms.Button();
            this.txt_PrecioUnitario2 = new System.Windows.Forms.TextBox();
            this.gvEntradaEdicion = new System.Windows.Forms.DataGridView();
            this.idEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.btnRegresarSalida = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_EditarEntrada = new System.Windows.Forms.Button();
            this.txt_Cod_Proveedor2 = new System.Windows.Forms.TextBox();
            this.txt_NombreProducto2 = new System.Windows.Forms.TextBox();
            this.txt_Presentacion2 = new System.Windows.Forms.TextBox();
            this.txt_Marca2 = new System.Windows.Forms.TextBox();
            this.txt_CodigoProducto2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.entradaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.entradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEntradaEdicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).BeginInit();
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
            this.label9.Location = new System.Drawing.Point(14, 516);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 81;
            this.label9.Text = "Precio Unitario";
            // 
            // date_FechaEntrada
            // 
            this.date_FechaEntrada.CustomFormat = "dd-MM-yyyy";
            this.date_FechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_FechaEntrada.Location = new System.Drawing.Point(190, 226);
            this.date_FechaEntrada.Name = "date_FechaEntrada";
            this.date_FechaEntrada.Size = new System.Drawing.Size(100, 20);
            this.date_FechaEntrada.TabIndex = 61;
            // 
            // txt_CantidadEntrada2
            // 
            this.txt_CantidadEntrada2.Location = new System.Drawing.Point(190, 475);
            this.txt_CantidadEntrada2.Name = "txt_CantidadEntrada2";
            this.txt_CantidadEntrada2.Size = new System.Drawing.Size(249, 20);
            this.txt_CantidadEntrada2.TabIndex = 76;
            this.txt_CantidadEntrada2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CantidadEntrada2_KeyPress);
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
            this.label8.Location = new System.Drawing.Point(14, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 80;
            this.label8.Text = "Fecha de Entrada";
            // 
            // btn_Mostrar2
            // 
            this.btn_Mostrar2.BackColor = System.Drawing.Color.Teal;
            this.btn_Mostrar2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mostrar2.ForeColor = System.Drawing.Color.White;
            this.btn_Mostrar2.Location = new System.Drawing.Point(165, 631);
            this.btn_Mostrar2.Name = "btn_Mostrar2";
            this.btn_Mostrar2.Size = new System.Drawing.Size(147, 43);
            this.btn_Mostrar2.TabIndex = 79;
            this.btn_Mostrar2.Text = "Mostrar";
            this.btn_Mostrar2.UseVisualStyleBackColor = false;
            this.btn_Mostrar2.Click += new System.EventHandler(this.btn_Mostrar2_Click);
            // 
            // txt_PrecioUnitario2
            // 
            this.txt_PrecioUnitario2.Location = new System.Drawing.Point(190, 519);
            this.txt_PrecioUnitario2.Name = "txt_PrecioUnitario2";
            this.txt_PrecioUnitario2.Size = new System.Drawing.Size(249, 20);
            this.txt_PrecioUnitario2.TabIndex = 82;
            this.txt_PrecioUnitario2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PrecioUnitario2_KeyPress);
            // 
            // gvEntradaEdicion
            // 
            this.gvEntradaEdicion.AutoGenerateColumns = false;
            this.gvEntradaEdicion.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvEntradaEdicion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gvEntradaEdicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEntradaEdicion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEntradaDataGridViewTextBoxColumn,
            this.fechaEntradaDataGridViewTextBoxColumn,
            this.codProveedorDataGridViewTextBoxColumn,
            this.codigoProductoDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.presentacionDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn});
            this.gvEntradaEdicion.DataSource = this.entradaBindingSource3;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvEntradaEdicion.DefaultCellStyle = dataGridViewCellStyle11;
            this.gvEntradaEdicion.GridColor = System.Drawing.Color.Black;
            this.gvEntradaEdicion.Location = new System.Drawing.Point(456, 160);
            this.gvEntradaEdicion.Name = "gvEntradaEdicion";
            this.gvEntradaEdicion.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvEntradaEdicion.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gvEntradaEdicion.RowHeadersVisible = false;
            this.gvEntradaEdicion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvEntradaEdicion.Size = new System.Drawing.Size(902, 465);
            this.gvEntradaEdicion.TabIndex = 78;
            this.gvEntradaEdicion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvEntradaEdicion_CellClick);
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
            this.btnRegresarSalida.Location = new System.Drawing.Point(1211, 637);
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
            this.label7.Location = new System.Drawing.Point(14, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 75;
            this.label7.Text = "Cantidad";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1419, 84);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            // 
            // btn_EditarEntrada
            // 
            this.btn_EditarEntrada.BackColor = System.Drawing.Color.Teal;
            this.btn_EditarEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditarEntrada.ForeColor = System.Drawing.Color.White;
            this.btn_EditarEntrada.Location = new System.Drawing.Point(12, 631);
            this.btn_EditarEntrada.Name = "btn_EditarEntrada";
            this.btn_EditarEntrada.Size = new System.Drawing.Size(147, 43);
            this.btn_EditarEntrada.TabIndex = 73;
            this.btn_EditarEntrada.Text = "Editar";
            this.btn_EditarEntrada.UseVisualStyleBackColor = false;
            this.btn_EditarEntrada.Click += new System.EventHandler(this.btn_EditarEntrada_Click);
            // 
            // txt_Cod_Proveedor2
            // 
            this.txt_Cod_Proveedor2.Location = new System.Drawing.Point(190, 267);
            this.txt_Cod_Proveedor2.Name = "txt_Cod_Proveedor2";
            this.txt_Cod_Proveedor2.Size = new System.Drawing.Size(245, 20);
            this.txt_Cod_Proveedor2.TabIndex = 72;
            this.txt_Cod_Proveedor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cod_Proveedor2_KeyPress);
            // 
            // txt_NombreProducto2
            // 
            this.txt_NombreProducto2.Location = new System.Drawing.Point(190, 346);
            this.txt_NombreProducto2.Name = "txt_NombreProducto2";
            this.txt_NombreProducto2.Size = new System.Drawing.Size(249, 20);
            this.txt_NombreProducto2.TabIndex = 71;
            this.txt_NombreProducto2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreProducto2_KeyPress);
            // 
            // txt_Presentacion2
            // 
            this.txt_Presentacion2.Location = new System.Drawing.Point(191, 428);
            this.txt_Presentacion2.Name = "txt_Presentacion2";
            this.txt_Presentacion2.Size = new System.Drawing.Size(248, 20);
            this.txt_Presentacion2.TabIndex = 70;
            this.txt_Presentacion2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Presentacion2_KeyPress);
            // 
            // txt_Marca2
            // 
            this.txt_Marca2.Location = new System.Drawing.Point(190, 389);
            this.txt_Marca2.Name = "txt_Marca2";
            this.txt_Marca2.Size = new System.Drawing.Size(249, 20);
            this.txt_Marca2.TabIndex = 69;
            this.txt_Marca2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Marca2_KeyPress);
            // 
            // txt_CodigoProducto2
            // 
            this.txt_CodigoProducto2.Location = new System.Drawing.Point(191, 306);
            this.txt_CodigoProducto2.Name = "txt_CodigoProducto2";
            this.txt_CodigoProducto2.Size = new System.Drawing.Size(248, 20);
            this.txt_CodigoProducto2.TabIndex = 68;
            this.txt_CodigoProducto2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CodigoProducto2_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 67;
            this.label6.Text = "Código Proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Nombre Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Presentación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Código Producto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // entradaBindingSource1
            // 
            this.entradaBindingSource1.DataMember = "Entrada";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            this.btn_Buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.Location = new System.Drawing.Point(1145, 103);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(111, 33);
            this.btn_Buscar.TabIndex = 86;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(702, 111);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(409, 20);
            this.txt_Buscar.TabIndex = 85;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(512, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 20);
            this.label10.TabIndex = 84;
            this.label10.Text = "Nombre del Producto";
            // 
            // EntradaEdicionAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 692);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.date_FechaEntrada);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_CantidadEntrada2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Mostrar2);
            this.Controls.Add(this.txt_PrecioUnitario2);
            this.Controls.Add(this.gvEntradaEdicion);
            this.Controls.Add(this.btnRegresarSalida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_EditarEntrada);
            this.Controls.Add(this.txt_Cod_Proveedor2);
            this.Controls.Add(this.txt_NombreProducto2);
            this.Controls.Add(this.txt_Presentacion2);
            this.Controls.Add(this.txt_Marca2);
            this.Controls.Add(this.txt_CodigoProducto2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntradaEdicionAdmin";
            this.Text = "EntradaEdicionAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEntradaEdicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDinventarioDataSetTableAdapters.EntradaTableAdapter entradaTableAdapter;
        private System.Windows.Forms.BindingSource entradaBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource entradaBindingSource;
        private BDinventarioDataSet bDinventarioDataSet;
        private System.Windows.Forms.BindingSource entradaBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker date_FechaEntrada;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_CantidadEntrada2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Mostrar2;
        private System.Windows.Forms.TextBox txt_PrecioUnitario2;
        private System.Windows.Forms.DataGridView gvEntradaEdicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRegresarSalida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_EditarEntrada;
        private System.Windows.Forms.TextBox txt_Cod_Proveedor2;
        private System.Windows.Forms.TextBox txt_NombreProducto2;
        private System.Windows.Forms.TextBox txt_Presentacion2;
        private System.Windows.Forms.TextBox txt_Marca2;
        private System.Windows.Forms.TextBox txt_CodigoProducto2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource entradaBindingSource3;
    }
}