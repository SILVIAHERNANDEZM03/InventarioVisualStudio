namespace Inventario3
{
    partial class proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(proveedores));
            this.gvProveedores = new System.Windows.Forms.DataGridView();
            this.idProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasDeRepartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bDinventarioDataSet = new Inventario3.BDinventarioDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_eliminarproveedor = new System.Windows.Forms.Button();
            this.btn_buscarproveedor = new System.Windows.Forms.Button();
            this.txt_buscasrcodigoProveedores = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_mostrarproducto = new System.Windows.Forms.Button();
            this.btn_editarproveedor = new System.Windows.Forms.Button();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRegresarproveedor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Agregarproveedor = new System.Windows.Forms.Button();
            this.txt_empresa = new System.Windows.Forms.TextBox();
            this.txt_productoreparte = new System.Windows.Forms.TextBox();
            this.txt_diasDereparto = new System.Windows.Forms.TextBox();
            this.txt_nombreproveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigodeproducto = new System.Windows.Forms.TextBox();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.entradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorTableAdapter = new Inventario3.BDinventarioDataSetTableAdapters.ProveedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gvProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gvProveedores
            // 
            this.gvProveedores.AutoGenerateColumns = false;
            this.gvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProveedorDataGridViewTextBoxColumn,
            this.nombreProveedorDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.diasDeRepartoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.codProductoDataGridViewTextBoxColumn});
            this.gvProveedores.DataSource = this.proveedorBindingSource1;
            this.gvProveedores.Location = new System.Drawing.Point(528, 181);
            this.gvProveedores.Name = "gvProveedores";
            this.gvProveedores.ReadOnly = true;
            this.gvProveedores.RowHeadersVisible = false;
            this.gvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProveedores.Size = new System.Drawing.Size(702, 412);
            this.gvProveedores.TabIndex = 115;
            this.gvProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProveedores_CellClick);
            // 
            // idProveedorDataGridViewTextBoxColumn
            // 
            this.idProveedorDataGridViewTextBoxColumn.DataPropertyName = "IdProveedor";
            this.idProveedorDataGridViewTextBoxColumn.HeaderText = "IdProveedor";
            this.idProveedorDataGridViewTextBoxColumn.Name = "idProveedorDataGridViewTextBoxColumn";
            this.idProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreProveedorDataGridViewTextBoxColumn
            // 
            this.nombreProveedorDataGridViewTextBoxColumn.DataPropertyName = "NombreProveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.HeaderText = "NombreProveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.Name = "nombreProveedorDataGridViewTextBoxColumn";
            this.nombreProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            this.productoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diasDeRepartoDataGridViewTextBoxColumn
            // 
            this.diasDeRepartoDataGridViewTextBoxColumn.DataPropertyName = "DiasDeReparto";
            this.diasDeRepartoDataGridViewTextBoxColumn.HeaderText = "DiasDeReparto";
            this.diasDeRepartoDataGridViewTextBoxColumn.Name = "diasDeRepartoDataGridViewTextBoxColumn";
            this.diasDeRepartoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codProductoDataGridViewTextBoxColumn
            // 
            this.codProductoDataGridViewTextBoxColumn.DataPropertyName = "Cod_Producto";
            this.codProductoDataGridViewTextBoxColumn.HeaderText = "Cod_Producto";
            this.codProductoDataGridViewTextBoxColumn.Name = "codProductoDataGridViewTextBoxColumn";
            this.codProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedorBindingSource1
            // 
            this.proveedorBindingSource1.DataMember = "Proveedor";
            this.proveedorBindingSource1.DataSource = this.bDinventarioDataSet;
            // 
            // bDinventarioDataSet
            // 
            this.bDinventarioDataSet.DataSetName = "BDinventarioDataSet";
            this.bDinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(529, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proveedores";
            // 
            // btn_eliminarproveedor
            // 
            this.btn_eliminarproveedor.BackColor = System.Drawing.Color.Teal;
            this.btn_eliminarproveedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarproveedor.ForeColor = System.Drawing.Color.White;
            this.btn_eliminarproveedor.Location = new System.Drawing.Point(173, 615);
            this.btn_eliminarproveedor.Name = "btn_eliminarproveedor";
            this.btn_eliminarproveedor.Size = new System.Drawing.Size(147, 43);
            this.btn_eliminarproveedor.TabIndex = 112;
            this.btn_eliminarproveedor.Text = "Eliminar";
            this.btn_eliminarproveedor.UseVisualStyleBackColor = false;
            this.btn_eliminarproveedor.Click += new System.EventHandler(this.btn_eliminarproveedor_Click);
            // 
            // btn_buscarproveedor
            // 
            this.btn_buscarproveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            this.btn_buscarproveedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarproveedor.ForeColor = System.Drawing.Color.White;
            this.btn_buscarproveedor.Location = new System.Drawing.Point(1119, 112);
            this.btn_buscarproveedor.Name = "btn_buscarproveedor";
            this.btn_buscarproveedor.Size = new System.Drawing.Size(111, 33);
            this.btn_buscarproveedor.TabIndex = 111;
            this.btn_buscarproveedor.Text = "Buscar";
            this.btn_buscarproveedor.UseVisualStyleBackColor = false;
            this.btn_buscarproveedor.Click += new System.EventHandler(this.btn_buscarproveedor_Click);
            // 
            // txt_buscasrcodigoProveedores
            // 
            this.txt_buscasrcodigoProveedores.Location = new System.Drawing.Point(676, 120);
            this.txt_buscasrcodigoProveedores.Name = "txt_buscasrcodigoProveedores";
            this.txt_buscasrcodigoProveedores.Size = new System.Drawing.Size(409, 20);
            this.txt_buscasrcodigoProveedores.TabIndex = 110;
            this.txt_buscasrcodigoProveedores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscasrcodigoProveedores_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(511, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 109;
            this.label10.Text = "Nombre";
            // 
            // btn_mostrarproducto
            // 
            this.btn_mostrarproducto.BackColor = System.Drawing.Color.Teal;
            this.btn_mostrarproducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrarproducto.ForeColor = System.Drawing.Color.White;
            this.btn_mostrarproducto.Location = new System.Drawing.Point(500, 615);
            this.btn_mostrarproducto.Name = "btn_mostrarproducto";
            this.btn_mostrarproducto.Size = new System.Drawing.Size(147, 43);
            this.btn_mostrarproducto.TabIndex = 114;
            this.btn_mostrarproducto.Text = "Mostrar";
            this.btn_mostrarproducto.UseVisualStyleBackColor = false;
            this.btn_mostrarproducto.Click += new System.EventHandler(this.btn_mostrarproducto_Click);
            // 
            // btn_editarproveedor
            // 
            this.btn_editarproveedor.BackColor = System.Drawing.Color.Teal;
            this.btn_editarproveedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarproveedor.ForeColor = System.Drawing.Color.White;
            this.btn_editarproveedor.Location = new System.Drawing.Point(337, 615);
            this.btn_editarproveedor.Name = "btn_editarproveedor";
            this.btn_editarproveedor.Size = new System.Drawing.Size(147, 43);
            this.btn_editarproveedor.TabIndex = 113;
            this.btn_editarproveedor.Text = "Editar";
            this.btn_editarproveedor.UseVisualStyleBackColor = false;
            this.btn_editarproveedor.Click += new System.EventHandler(this.btn_editarproveedor_Click);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(173, 406);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(264, 20);
            this.txt_telefono.TabIndex = 108;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 107;
            this.label8.Text = "Teléfono";
            // 
            // btnRegresarproveedor
            // 
            this.btnRegresarproveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            this.btnRegresarproveedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarproveedor.ForeColor = System.Drawing.Color.White;
            this.btnRegresarproveedor.Location = new System.Drawing.Point(1144, 615);
            this.btnRegresarproveedor.Name = "btnRegresarproveedor";
            this.btnRegresarproveedor.Size = new System.Drawing.Size(147, 43);
            this.btnRegresarproveedor.TabIndex = 106;
            this.btnRegresarproveedor.Text = "Regresar";
            this.btnRegresarproveedor.UseVisualStyleBackColor = false;
            this.btnRegresarproveedor.Click += new System.EventHandler(this.btnRegresarproveedor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 104;
            this.label7.Text = "Código de Producto";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-7, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1312, 84);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            // 
            // btn_Agregarproveedor
            // 
            this.btn_Agregarproveedor.BackColor = System.Drawing.Color.Teal;
            this.btn_Agregarproveedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregarproveedor.ForeColor = System.Drawing.Color.White;
            this.btn_Agregarproveedor.Location = new System.Drawing.Point(16, 615);
            this.btn_Agregarproveedor.Name = "btn_Agregarproveedor";
            this.btn_Agregarproveedor.Size = new System.Drawing.Size(147, 43);
            this.btn_Agregarproveedor.TabIndex = 102;
            this.btn_Agregarproveedor.Text = "Agregar";
            this.btn_Agregarproveedor.UseVisualStyleBackColor = false;
            this.btn_Agregarproveedor.Click += new System.EventHandler(this.btn_Agregarproveedor_Click);
            // 
            // txt_empresa
            // 
            this.txt_empresa.Location = new System.Drawing.Point(173, 272);
            this.txt_empresa.Name = "txt_empresa";
            this.txt_empresa.Size = new System.Drawing.Size(264, 20);
            this.txt_empresa.TabIndex = 100;
            this.txt_empresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_empresa_KeyPress);
            // 
            // txt_productoreparte
            // 
            this.txt_productoreparte.Location = new System.Drawing.Point(173, 318);
            this.txt_productoreparte.Name = "txt_productoreparte";
            this.txt_productoreparte.Size = new System.Drawing.Size(264, 20);
            this.txt_productoreparte.TabIndex = 99;
            this.txt_productoreparte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productoreparte_KeyPress);
            // 
            // txt_diasDereparto
            // 
            this.txt_diasDereparto.Location = new System.Drawing.Point(173, 361);
            this.txt_diasDereparto.Name = "txt_diasDereparto";
            this.txt_diasDereparto.Size = new System.Drawing.Size(264, 20);
            this.txt_diasDereparto.TabIndex = 98;
            this.txt_diasDereparto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_diasDereparto_KeyPress);
            // 
            // txt_nombreproveedor
            // 
            this.txt_nombreproveedor.Location = new System.Drawing.Point(173, 221);
            this.txt_nombreproveedor.Name = "txt_nombreproveedor";
            this.txt_nombreproveedor.Size = new System.Drawing.Size(264, 20);
            this.txt_nombreproveedor.TabIndex = 97;
            this.txt_nombreproveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombreproveedor_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 96;
            this.label6.Text = "Días de Reparto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 95;
            this.label5.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 94;
            this.label4.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 92;
            this.label2.Text = "Nombre";
            // 
            // txt_codigodeproducto
            // 
            this.txt_codigodeproducto.Location = new System.Drawing.Point(173, 453);
            this.txt_codigodeproducto.Name = "txt_codigodeproducto";
            this.txt_codigodeproducto.Size = new System.Drawing.Size(264, 20);
            this.txt_codigodeproducto.TabIndex = 101;
            this.txt_codigodeproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigodeproducto_KeyPress);
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // entradaBindingSource
            // 
            this.entradaBindingSource.DataMember = "Entrada";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 661);
            this.Controls.Add(this.gvProveedores);
            this.Controls.Add(this.btn_eliminarproveedor);
            this.Controls.Add(this.btn_buscarproveedor);
            this.Controls.Add(this.txt_buscasrcodigoProveedores);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_mostrarproducto);
            this.Controls.Add(this.btn_editarproveedor);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegresarproveedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Agregarproveedor);
            this.Controls.Add(this.txt_empresa);
            this.Controls.Add(this.txt_productoreparte);
            this.Controls.Add(this.txt_diasDereparto);
            this.Controls.Add(this.txt_nombreproveedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_codigodeproducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "proveedores";
            this.Text = "proveedores";
            this.Load += new System.EventHandler(this.proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private System.Windows.Forms.DataGridView gvProveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource entradaBindingSource;
        private System.Windows.Forms.Button btn_eliminarproveedor;
        private System.Windows.Forms.Button btn_buscarproveedor;
        private System.Windows.Forms.TextBox txt_buscasrcodigoProveedores;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_mostrarproducto;
        private System.Windows.Forms.Button btn_editarproveedor;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegresarproveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Agregarproveedor;
        private System.Windows.Forms.TextBox txt_empresa;
        private System.Windows.Forms.TextBox txt_productoreparte;
        private System.Windows.Forms.TextBox txt_diasDereparto;
        private System.Windows.Forms.TextBox txt_nombreproveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.TextBox txt_codigodeproducto;
        private BDinventarioDataSet bDinventarioDataSet;
        private System.Windows.Forms.BindingSource proveedorBindingSource1;
        private BDinventarioDataSetTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasDeRepartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProductoDataGridViewTextBoxColumn;
    }
}