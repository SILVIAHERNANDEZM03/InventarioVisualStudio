namespace Inventario3
{
    partial class SalidaProductosAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalidaProductosAdmin));
            this.btnEditarDatosSalida = new System.Windows.Forms.Button();
            this.gvSalida = new System.Windows.Forms.DataGridView();
            this.idSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salidaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bDinventarioDataSet = new Inventario3.BDinventarioDataSet();
            this.btnRegresarSalida = new System.Windows.Forms.Button();
            this.txt_codigoProveedorSalida = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_PrecioUnitarioSalida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_CodigoProducto2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.txt_CantidadSalida = new System.Windows.Forms.TextBox();
            this.txt_NombreProducto = new System.Windows.Forms.TextBox();
            this.txt_Presentacion2 = new System.Windows.Forms.TextBox();
            this.txt_Marca2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.salidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.salidaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.entradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.date_FechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.salidaTableAdapter = new Inventario3.BDinventarioDataSetTableAdapters.SalidaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gvSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditarDatosSalida
            // 
            this.btnEditarDatosSalida.BackColor = System.Drawing.Color.Teal;
            this.btnEditarDatosSalida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDatosSalida.ForeColor = System.Drawing.Color.White;
            this.btnEditarDatosSalida.Location = new System.Drawing.Point(195, 587);
            this.btnEditarDatosSalida.Name = "btnEditarDatosSalida";
            this.btnEditarDatosSalida.Size = new System.Drawing.Size(147, 43);
            this.btnEditarDatosSalida.TabIndex = 55;
            this.btnEditarDatosSalida.Text = "Modificar";
            this.btnEditarDatosSalida.UseVisualStyleBackColor = false;
            this.btnEditarDatosSalida.Click += new System.EventHandler(this.btnEditarDatosSalida_Click);
            // 
            // gvSalida
            // 
            this.gvSalida.AutoGenerateColumns = false;
            this.gvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSalida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSalidaDataGridViewTextBoxColumn,
            this.fechaSalidaDataGridViewTextBoxColumn,
            this.codigoProductoDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.presentacionDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn,
            this.codProveedorDataGridViewTextBoxColumn});
            this.gvSalida.DataSource = this.salidaBindingSource2;
            this.gvSalida.Location = new System.Drawing.Point(486, 102);
            this.gvSalida.Name = "gvSalida";
            this.gvSalida.ReadOnly = true;
            this.gvSalida.RowHeadersVisible = false;
            this.gvSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSalida.Size = new System.Drawing.Size(801, 461);
            this.gvSalida.TabIndex = 54;
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
            // btnRegresarSalida
            // 
            this.btnRegresarSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            this.btnRegresarSalida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarSalida.ForeColor = System.Drawing.Color.White;
            this.btnRegresarSalida.Location = new System.Drawing.Point(1177, 613);
            this.btnRegresarSalida.Name = "btnRegresarSalida";
            this.btnRegresarSalida.Size = new System.Drawing.Size(115, 36);
            this.btnRegresarSalida.TabIndex = 53;
            this.btnRegresarSalida.Text = "Regresar";
            this.btnRegresarSalida.UseVisualStyleBackColor = false;
            this.btnRegresarSalida.Click += new System.EventHandler(this.btnRegresarSalida_Click);
            // 
            // txt_codigoProveedorSalida
            // 
            this.txt_codigoProveedorSalida.Location = new System.Drawing.Point(195, 470);
            this.txt_codigoProveedorSalida.Name = "txt_codigoProveedorSalida";
            this.txt_codigoProveedorSalida.Size = new System.Drawing.Size(214, 20);
            this.txt_codigoProveedorSalida.TabIndex = 52;
            this.txt_codigoProveedorSalida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigoProveedorSalida_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Código Proveedor";
            // 
            // txt_PrecioUnitarioSalida
            // 
            this.txt_PrecioUnitarioSalida.Location = new System.Drawing.Point(195, 430);
            this.txt_PrecioUnitarioSalida.Name = "txt_PrecioUnitarioSalida";
            this.txt_PrecioUnitarioSalida.Size = new System.Drawing.Size(214, 20);
            this.txt_PrecioUnitarioSalida.TabIndex = 50;
            this.txt_PrecioUnitarioSalida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PrecioUnitarioSalida_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Precio Unitario";
            // 
            // txt_CodigoProducto2
            // 
            this.txt_CodigoProducto2.Location = new System.Drawing.Point(195, 230);
            this.txt_CodigoProducto2.Name = "txt_CodigoProducto2";
            this.txt_CodigoProducto2.Size = new System.Drawing.Size(214, 20);
            this.txt_CodigoProducto2.TabIndex = 42;
            this.txt_CodigoProducto2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CodigoProducto2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Código Producto";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1305, 84);
            this.groupBox1.TabIndex = 48;
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
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.Teal;
            this.btn_Agregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.Color.White;
            this.btn_Agregar.Location = new System.Drawing.Point(39, 587);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(147, 43);
            this.btn_Agregar.TabIndex = 47;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txt_CantidadSalida
            // 
            this.txt_CantidadSalida.Location = new System.Drawing.Point(195, 389);
            this.txt_CantidadSalida.Name = "txt_CantidadSalida";
            this.txt_CantidadSalida.Size = new System.Drawing.Size(214, 20);
            this.txt_CantidadSalida.TabIndex = 46;
            this.txt_CantidadSalida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CantidadSalida_KeyPress);
            // 
            // txt_NombreProducto
            // 
            this.txt_NombreProducto.Location = new System.Drawing.Point(195, 273);
            this.txt_NombreProducto.Name = "txt_NombreProducto";
            this.txt_NombreProducto.Size = new System.Drawing.Size(214, 20);
            this.txt_NombreProducto.TabIndex = 45;
            this.txt_NombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreProducto_KeyPress);
            // 
            // txt_Presentacion2
            // 
            this.txt_Presentacion2.Location = new System.Drawing.Point(195, 350);
            this.txt_Presentacion2.Name = "txt_Presentacion2";
            this.txt_Presentacion2.Size = new System.Drawing.Size(214, 20);
            this.txt_Presentacion2.TabIndex = 44;
            this.txt_Presentacion2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Presentacion2_KeyPress);
            // 
            // txt_Marca2
            // 
            this.txt_Marca2.Location = new System.Drawing.Point(195, 309);
            this.txt_Marca2.Name = "txt_Marca2";
            this.txt_Marca2.Size = new System.Drawing.Size(214, 20);
            this.txt_Marca2.TabIndex = 43;
            this.txt_Marca2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Marca2_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Nombre del Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Presentación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Marca";
            // 
            // salidaBindingSource
            // 
            this.salidaBindingSource.DataMember = "Salida";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // salidaBindingSource1
            // 
            this.salidaBindingSource1.DataMember = "Salida";
            // 
            // entradaBindingSource
            // 
            this.entradaBindingSource.DataMember = "Entrada";
            // 
            // date_FechaSalida
            // 
            this.date_FechaSalida.CustomFormat = "dd-MM-yyyy";
            this.date_FechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_FechaSalida.Location = new System.Drawing.Point(195, 194);
            this.date_FechaSalida.Name = "date_FechaSalida";
            this.date_FechaSalida.Size = new System.Drawing.Size(100, 20);
            this.date_FechaSalida.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "Fecha de Salida";
            // 
            // salidaTableAdapter
            // 
            this.salidaTableAdapter.ClearBeforeFill = true;
            // 
            // SalidaProductosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 661);
            this.Controls.Add(this.date_FechaSalida);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEditarDatosSalida);
            this.Controls.Add(this.gvSalida);
            this.Controls.Add(this.btnRegresarSalida);
            this.Controls.Add(this.txt_codigoProveedorSalida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_PrecioUnitarioSalida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_CodigoProducto2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txt_CantidadSalida);
            this.Controls.Add(this.txt_NombreProducto);
            this.Controls.Add(this.txt_Presentacion2);
            this.Controls.Add(this.txt_Marca2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalidaProductosAdmin";
            this.Text = "Salida";
            this.Load += new System.EventHandler(this.SalidaProductosAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditarDatosSalida;
        private System.Windows.Forms.DataGridView gvSalida;
        private System.Windows.Forms.BindingSource salidaBindingSource;
        private System.Windows.Forms.BindingSource salidaBindingSource1;
        private System.Windows.Forms.Button btnRegresarSalida;
        private System.Windows.Forms.TextBox txt_codigoProveedorSalida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_PrecioUnitarioSalida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_CodigoProducto2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource entradaBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox txt_CantidadSalida;
        private System.Windows.Forms.TextBox txt_NombreProducto;
        private System.Windows.Forms.TextBox txt_Presentacion2;
        private System.Windows.Forms.TextBox txt_Marca2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_FechaSalida;
        private System.Windows.Forms.Label label9;
        private BDinventarioDataSet bDinventarioDataSet;
        private System.Windows.Forms.BindingSource salidaBindingSource2;
        private BDinventarioDataSetTableAdapters.SalidaTableAdapter salidaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProveedorDataGridViewTextBoxColumn;
    }
}