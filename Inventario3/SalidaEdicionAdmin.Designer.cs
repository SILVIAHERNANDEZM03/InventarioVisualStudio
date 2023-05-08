namespace Inventario3
{
    partial class SalidaEdicionAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalidaEdicionAdmin));
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
            this.gvSalida3 = new System.Windows.Forms.DataGridView();
            this.idSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegresarSalida = new System.Windows.Forms.Button();
            this.txt_codigoProveedorSalida3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_PrecioUnitarioSalida3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_CodigoProducto3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_CantidadSalida3 = new System.Windows.Forms.TextBox();
            this.txt_NombreProducto3 = new System.Windows.Forms.TextBox();
            this.txt_Presentacion3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Marca3 = new System.Windows.Forms.TextBox();
            this.btn_Mostrar3 = new System.Windows.Forms.Button();
            this.btn_EditarEntrada3 = new System.Windows.Forms.Button();
            this.btn_Buscar3 = new System.Windows.Forms.Button();
            this.txt_Buscar3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSalida3)).BeginInit();
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
            this.date_FechaSalida.Location = new System.Drawing.Point(196, 194);
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
            this.label9.Location = new System.Drawing.Point(20, 194);
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
            // gvSalida3
            // 
            this.gvSalida3.AutoGenerateColumns = false;
            this.gvSalida3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSalida3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSalidaDataGridViewTextBoxColumn,
            this.fechaSalidaDataGridViewTextBoxColumn,
            this.codigoProductoDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.presentacionDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn,
            this.codProveedorDataGridViewTextBoxColumn});
            this.gvSalida3.DataSource = this.salidaBindingSource2;
            this.gvSalida3.Location = new System.Drawing.Point(519, 158);
            this.gvSalida3.Name = "gvSalida3";
            this.gvSalida3.ReadOnly = true;
            this.gvSalida3.RowHeadersVisible = false;
            this.gvSalida3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSalida3.Size = new System.Drawing.Size(801, 461);
            this.gvSalida3.TabIndex = 78;
            this.gvSalida3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSalida3_CellClick);
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
            // btnRegresarSalida
            // 
            this.btnRegresarSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            this.btnRegresarSalida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarSalida.ForeColor = System.Drawing.Color.White;
            this.btnRegresarSalida.Location = new System.Drawing.Point(1243, 644);
            this.btnRegresarSalida.Name = "btnRegresarSalida";
            this.btnRegresarSalida.Size = new System.Drawing.Size(115, 36);
            this.btnRegresarSalida.TabIndex = 77;
            this.btnRegresarSalida.Text = "Regresar";
            this.btnRegresarSalida.UseVisualStyleBackColor = false;
            this.btnRegresarSalida.Click += new System.EventHandler(this.btnRegresarSalida_Click);
            // 
            // txt_codigoProveedorSalida3
            // 
            this.txt_codigoProveedorSalida3.Location = new System.Drawing.Point(196, 470);
            this.txt_codigoProveedorSalida3.Name = "txt_codigoProveedorSalida3";
            this.txt_codigoProveedorSalida3.Size = new System.Drawing.Size(214, 20);
            this.txt_codigoProveedorSalida3.TabIndex = 76;
            this.txt_codigoProveedorSalida3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigoProveedorSalida3_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 75;
            this.label8.Text = "Código Proveedor";
            // 
            // txt_PrecioUnitarioSalida3
            // 
            this.txt_PrecioUnitarioSalida3.Location = new System.Drawing.Point(196, 430);
            this.txt_PrecioUnitarioSalida3.Name = "txt_PrecioUnitarioSalida3";
            this.txt_PrecioUnitarioSalida3.Size = new System.Drawing.Size(214, 20);
            this.txt_PrecioUnitarioSalida3.TabIndex = 74;
            this.txt_PrecioUnitarioSalida3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PrecioUnitarioSalida3_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 73;
            this.label7.Text = "Precio Unitario";
            // 
            // txt_CodigoProducto3
            // 
            this.txt_CodigoProducto3.Location = new System.Drawing.Point(196, 230);
            this.txt_CodigoProducto3.Name = "txt_CodigoProducto3";
            this.txt_CodigoProducto3.Size = new System.Drawing.Size(214, 20);
            this.txt_CodigoProducto3.TabIndex = 66;
            this.txt_CodigoProducto3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CodigoProducto3_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Código Producto";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1376, 84);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // txt_CantidadSalida3
            // 
            this.txt_CantidadSalida3.Location = new System.Drawing.Point(196, 389);
            this.txt_CantidadSalida3.Name = "txt_CantidadSalida3";
            this.txt_CantidadSalida3.Size = new System.Drawing.Size(214, 20);
            this.txt_CantidadSalida3.TabIndex = 70;
            this.txt_CantidadSalida3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CantidadSalida3_KeyPress);
            // 
            // txt_NombreProducto3
            // 
            this.txt_NombreProducto3.Location = new System.Drawing.Point(196, 273);
            this.txt_NombreProducto3.Name = "txt_NombreProducto3";
            this.txt_NombreProducto3.Size = new System.Drawing.Size(214, 20);
            this.txt_NombreProducto3.TabIndex = 69;
            this.txt_NombreProducto3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreProducto3_KeyPress);
            // 
            // txt_Presentacion3
            // 
            this.txt_Presentacion3.Location = new System.Drawing.Point(196, 350);
            this.txt_Presentacion3.Name = "txt_Presentacion3";
            this.txt_Presentacion3.Size = new System.Drawing.Size(214, 20);
            this.txt_Presentacion3.TabIndex = 68;
            this.txt_Presentacion3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Presentacion3_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 64;
            this.label5.Text = "Nombre del Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Presentación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Marca";
            // 
            // txt_Marca3
            // 
            this.txt_Marca3.Location = new System.Drawing.Point(196, 309);
            this.txt_Marca3.Name = "txt_Marca3";
            this.txt_Marca3.Size = new System.Drawing.Size(214, 20);
            this.txt_Marca3.TabIndex = 67;
            this.txt_Marca3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Marca3_KeyPress);
            // 
            // btn_Mostrar3
            // 
            this.btn_Mostrar3.BackColor = System.Drawing.Color.Teal;
            this.btn_Mostrar3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mostrar3.ForeColor = System.Drawing.Color.White;
            this.btn_Mostrar3.Location = new System.Drawing.Point(165, 637);
            this.btn_Mostrar3.Name = "btn_Mostrar3";
            this.btn_Mostrar3.Size = new System.Drawing.Size(147, 43);
            this.btn_Mostrar3.TabIndex = 83;
            this.btn_Mostrar3.Text = "Mostrar";
            this.btn_Mostrar3.UseVisualStyleBackColor = false;
            this.btn_Mostrar3.Click += new System.EventHandler(this.btn_Mostrar3_Click);
            // 
            // btn_EditarEntrada3
            // 
            this.btn_EditarEntrada3.BackColor = System.Drawing.Color.Teal;
            this.btn_EditarEntrada3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditarEntrada3.ForeColor = System.Drawing.Color.White;
            this.btn_EditarEntrada3.Location = new System.Drawing.Point(12, 637);
            this.btn_EditarEntrada3.Name = "btn_EditarEntrada3";
            this.btn_EditarEntrada3.Size = new System.Drawing.Size(147, 43);
            this.btn_EditarEntrada3.TabIndex = 82;
            this.btn_EditarEntrada3.Text = "Editar";
            this.btn_EditarEntrada3.UseVisualStyleBackColor = false;
            this.btn_EditarEntrada3.Click += new System.EventHandler(this.btn_EditarEntrada3_Click);
            // 
            // btn_Buscar3
            // 
            this.btn_Buscar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            this.btn_Buscar3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar3.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar3.Location = new System.Drawing.Point(1132, 106);
            this.btn_Buscar3.Name = "btn_Buscar3";
            this.btn_Buscar3.Size = new System.Drawing.Size(111, 33);
            this.btn_Buscar3.TabIndex = 89;
            this.btn_Buscar3.Text = "Buscar";
            this.btn_Buscar3.UseVisualStyleBackColor = false;
            this.btn_Buscar3.Click += new System.EventHandler(this.btn_Buscar3_Click);
            // 
            // txt_Buscar3
            // 
            this.txt_Buscar3.Location = new System.Drawing.Point(689, 114);
            this.txt_Buscar3.Name = "txt_Buscar3";
            this.txt_Buscar3.Size = new System.Drawing.Size(409, 20);
            this.txt_Buscar3.TabIndex = 88;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(499, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 20);
            this.label10.TabIndex = 87;
            this.label10.Text = "Nombre del Producto";
            // 
            // SalidaEdicionAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 692);
            this.Controls.Add(this.btn_Buscar3);
            this.Controls.Add(this.txt_Buscar3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_Mostrar3);
            this.Controls.Add(this.btn_EditarEntrada3);
            this.Controls.Add(this.date_FechaSalida);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gvSalida3);
            this.Controls.Add(this.btnRegresarSalida);
            this.Controls.Add(this.txt_codigoProveedorSalida3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_PrecioUnitarioSalida3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_CodigoProducto3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_CantidadSalida3);
            this.Controls.Add(this.txt_NombreProducto3);
            this.Controls.Add(this.txt_Presentacion3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Marca3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalidaEdicionAdmin";
            this.Text = "Salida";
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSalida3)).EndInit();
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
        private System.Windows.Forms.DataGridView gvSalida3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRegresarSalida;
        private System.Windows.Forms.TextBox txt_codigoProveedorSalida3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_PrecioUnitarioSalida3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_CodigoProducto3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_CantidadSalida3;
        private System.Windows.Forms.TextBox txt_NombreProducto3;
        private System.Windows.Forms.TextBox txt_Presentacion3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Marca3;
        private System.Windows.Forms.Button btn_Mostrar3;
        private System.Windows.Forms.Button btn_EditarEntrada3;
        private System.Windows.Forms.Button btn_Buscar3;
        private System.Windows.Forms.TextBox txt_Buscar3;
        private System.Windows.Forms.Label label10;
    }
}