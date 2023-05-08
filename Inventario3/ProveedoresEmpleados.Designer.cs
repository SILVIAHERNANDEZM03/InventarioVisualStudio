namespace Inventario3
{
    partial class ProveedoresEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveedoresEmpleados));
            this.proveedorTableAdapter = new Inventario3.BDinventarioDataSetTableAdapters.ProveedorTableAdapter();
            this.entradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bDinventarioDataSet = new Inventario3.BDinventarioDataSet();
            this.proveedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gvProveedoresEmpleado = new System.Windows.Forms.DataGridView();
            this.idProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasDeRepartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_eliminarproveedorEmpleado = new System.Windows.Forms.Button();
            this.btn_buscarproveedorEmpleado = new System.Windows.Forms.Button();
            this.txt_buscasrcodigoProveedoresEmpleado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_mostrarproductoEmpleado = new System.Windows.Forms.Button();
            this.btn_editarproveedorEmpleado = new System.Windows.Forms.Button();
            this.txt_telefonoEmpleado = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresarproveedorEmpleado = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_AgregarproveedorEmpleado = new System.Windows.Forms.Button();
            this.txt_empresaEmpleado = new System.Windows.Forms.TextBox();
            this.txt_productoreparteEmpleado = new System.Windows.Forms.TextBox();
            this.txt_diasDerepartoEmpleado = new System.Windows.Forms.TextBox();
            this.txt_nombreproveedorEmpleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigodeproductoEmpleado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProveedoresEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // entradaBindingSource
            // 
            this.entradaBindingSource.DataMember = "Entrada";
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
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
            // bDinventarioDataSet
            // 
            this.bDinventarioDataSet.DataSetName = "BDinventarioDataSet";
            this.bDinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorBindingSource1
            // 
            this.proveedorBindingSource1.DataMember = "Proveedor";
            this.proveedorBindingSource1.DataSource = this.bDinventarioDataSet;
            // 
            // gvProveedoresEmpleado
            // 
            this.gvProveedoresEmpleado.AutoGenerateColumns = false;
            this.gvProveedoresEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProveedoresEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProveedorDataGridViewTextBoxColumn,
            this.nombreProveedorDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.diasDeRepartoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.codProductoDataGridViewTextBoxColumn});
            this.gvProveedoresEmpleado.DataSource = this.proveedorBindingSource1;
            this.gvProveedoresEmpleado.Location = new System.Drawing.Point(528, 181);
            this.gvProveedoresEmpleado.Name = "gvProveedoresEmpleado";
            this.gvProveedoresEmpleado.ReadOnly = true;
            this.gvProveedoresEmpleado.RowHeadersVisible = false;
            this.gvProveedoresEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProveedoresEmpleado.Size = new System.Drawing.Size(702, 412);
            this.gvProveedoresEmpleado.TabIndex = 138;
            this.gvProveedoresEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProveedoresEmpleado_CellClick);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 130;
            this.label8.Text = "Teléfono";
            // 
            // btn_eliminarproveedorEmpleado
            // 
            this.btn_eliminarproveedorEmpleado.BackColor = System.Drawing.Color.Teal;
            this.btn_eliminarproveedorEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarproveedorEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_eliminarproveedorEmpleado.Location = new System.Drawing.Point(173, 615);
            this.btn_eliminarproveedorEmpleado.Name = "btn_eliminarproveedorEmpleado";
            this.btn_eliminarproveedorEmpleado.Size = new System.Drawing.Size(147, 43);
            this.btn_eliminarproveedorEmpleado.TabIndex = 135;
            this.btn_eliminarproveedorEmpleado.Text = "Eliminar";
            this.btn_eliminarproveedorEmpleado.UseVisualStyleBackColor = false;
            this.btn_eliminarproveedorEmpleado.Click += new System.EventHandler(this.btn_eliminarproveedorEmpleado_Click);
            // 
            // btn_buscarproveedorEmpleado
            // 
            this.btn_buscarproveedorEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            this.btn_buscarproveedorEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarproveedorEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_buscarproveedorEmpleado.Location = new System.Drawing.Point(1119, 112);
            this.btn_buscarproveedorEmpleado.Name = "btn_buscarproveedorEmpleado";
            this.btn_buscarproveedorEmpleado.Size = new System.Drawing.Size(111, 33);
            this.btn_buscarproveedorEmpleado.TabIndex = 134;
            this.btn_buscarproveedorEmpleado.Text = "Buscar";
            this.btn_buscarproveedorEmpleado.UseVisualStyleBackColor = false;
            this.btn_buscarproveedorEmpleado.Click += new System.EventHandler(this.btn_buscarproveedorEmpleado_Click);
            // 
            // txt_buscasrcodigoProveedoresEmpleado
            // 
            this.txt_buscasrcodigoProveedoresEmpleado.Location = new System.Drawing.Point(676, 120);
            this.txt_buscasrcodigoProveedoresEmpleado.Name = "txt_buscasrcodigoProveedoresEmpleado";
            this.txt_buscasrcodigoProveedoresEmpleado.Size = new System.Drawing.Size(409, 20);
            this.txt_buscasrcodigoProveedoresEmpleado.TabIndex = 133;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(511, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 132;
            this.label10.Text = "Nombre";
            // 
            // btn_mostrarproductoEmpleado
            // 
            this.btn_mostrarproductoEmpleado.BackColor = System.Drawing.Color.Teal;
            this.btn_mostrarproductoEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrarproductoEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_mostrarproductoEmpleado.Location = new System.Drawing.Point(500, 615);
            this.btn_mostrarproductoEmpleado.Name = "btn_mostrarproductoEmpleado";
            this.btn_mostrarproductoEmpleado.Size = new System.Drawing.Size(147, 43);
            this.btn_mostrarproductoEmpleado.TabIndex = 137;
            this.btn_mostrarproductoEmpleado.Text = "Mostrar";
            this.btn_mostrarproductoEmpleado.UseVisualStyleBackColor = false;
            this.btn_mostrarproductoEmpleado.Click += new System.EventHandler(this.btn_mostrarproductoEmpleado_Click);
            // 
            // btn_editarproveedorEmpleado
            // 
            this.btn_editarproveedorEmpleado.BackColor = System.Drawing.Color.Teal;
            this.btn_editarproveedorEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarproveedorEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_editarproveedorEmpleado.Location = new System.Drawing.Point(337, 615);
            this.btn_editarproveedorEmpleado.Name = "btn_editarproveedorEmpleado";
            this.btn_editarproveedorEmpleado.Size = new System.Drawing.Size(147, 43);
            this.btn_editarproveedorEmpleado.TabIndex = 136;
            this.btn_editarproveedorEmpleado.Text = "Editar";
            this.btn_editarproveedorEmpleado.UseVisualStyleBackColor = false;
            this.btn_editarproveedorEmpleado.Click += new System.EventHandler(this.btn_editarproveedorEmpleado_Click);
            // 
            // txt_telefonoEmpleado
            // 
            this.txt_telefonoEmpleado.Location = new System.Drawing.Point(173, 406);
            this.txt_telefonoEmpleado.Name = "txt_telefonoEmpleado";
            this.txt_telefonoEmpleado.Size = new System.Drawing.Size(264, 20);
            this.txt_telefonoEmpleado.TabIndex = 131;
            this.txt_telefonoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefonoEmpleado_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 116;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegresarproveedorEmpleado
            // 
            this.btnRegresarproveedorEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            this.btnRegresarproveedorEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarproveedorEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnRegresarproveedorEmpleado.Location = new System.Drawing.Point(1144, 615);
            this.btnRegresarproveedorEmpleado.Name = "btnRegresarproveedorEmpleado";
            this.btnRegresarproveedorEmpleado.Size = new System.Drawing.Size(147, 43);
            this.btnRegresarproveedorEmpleado.TabIndex = 129;
            this.btnRegresarproveedorEmpleado.Text = "Regresar";
            this.btnRegresarproveedorEmpleado.UseVisualStyleBackColor = false;
            this.btnRegresarproveedorEmpleado.Click += new System.EventHandler(this.btnRegresarproveedorEmpleado_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 128;
            this.label7.Text = "Código de Producto";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-7, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1312, 84);
            this.groupBox1.TabIndex = 127;
            this.groupBox1.TabStop = false;
            // 
            // btn_AgregarproveedorEmpleado
            // 
            this.btn_AgregarproveedorEmpleado.BackColor = System.Drawing.Color.Teal;
            this.btn_AgregarproveedorEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarproveedorEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarproveedorEmpleado.Location = new System.Drawing.Point(16, 615);
            this.btn_AgregarproveedorEmpleado.Name = "btn_AgregarproveedorEmpleado";
            this.btn_AgregarproveedorEmpleado.Size = new System.Drawing.Size(147, 43);
            this.btn_AgregarproveedorEmpleado.TabIndex = 126;
            this.btn_AgregarproveedorEmpleado.Text = "Agregar";
            this.btn_AgregarproveedorEmpleado.UseVisualStyleBackColor = false;
            this.btn_AgregarproveedorEmpleado.Click += new System.EventHandler(this.btn_AgregarproveedorEmpleado_Click);
            // 
            // txt_empresaEmpleado
            // 
            this.txt_empresaEmpleado.Location = new System.Drawing.Point(173, 272);
            this.txt_empresaEmpleado.Name = "txt_empresaEmpleado";
            this.txt_empresaEmpleado.Size = new System.Drawing.Size(264, 20);
            this.txt_empresaEmpleado.TabIndex = 124;
            this.txt_empresaEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_empresaEmpleado_KeyPress);
            // 
            // txt_productoreparteEmpleado
            // 
            this.txt_productoreparteEmpleado.Location = new System.Drawing.Point(173, 318);
            this.txt_productoreparteEmpleado.Name = "txt_productoreparteEmpleado";
            this.txt_productoreparteEmpleado.Size = new System.Drawing.Size(264, 20);
            this.txt_productoreparteEmpleado.TabIndex = 123;
            this.txt_productoreparteEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productoreparteEmpleado_KeyPress);
            // 
            // txt_diasDerepartoEmpleado
            // 
            this.txt_diasDerepartoEmpleado.Location = new System.Drawing.Point(173, 361);
            this.txt_diasDerepartoEmpleado.Name = "txt_diasDerepartoEmpleado";
            this.txt_diasDerepartoEmpleado.Size = new System.Drawing.Size(264, 20);
            this.txt_diasDerepartoEmpleado.TabIndex = 122;
            this.txt_diasDerepartoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_diasDerepartoEmpleado_KeyPress);
            // 
            // txt_nombreproveedorEmpleado
            // 
            this.txt_nombreproveedorEmpleado.Location = new System.Drawing.Point(173, 221);
            this.txt_nombreproveedorEmpleado.Name = "txt_nombreproveedorEmpleado";
            this.txt_nombreproveedorEmpleado.Size = new System.Drawing.Size(264, 20);
            this.txt_nombreproveedorEmpleado.TabIndex = 121;
            this.txt_nombreproveedorEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombreproveedorEmpleado_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 120;
            this.label6.Text = "Días de Reparto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 119;
            this.label5.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 118;
            this.label4.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 117;
            this.label2.Text = "Nombre";
            // 
            // txt_codigodeproductoEmpleado
            // 
            this.txt_codigodeproductoEmpleado.Location = new System.Drawing.Point(173, 453);
            this.txt_codigodeproductoEmpleado.Name = "txt_codigodeproductoEmpleado";
            this.txt_codigodeproductoEmpleado.Size = new System.Drawing.Size(264, 20);
            this.txt_codigodeproductoEmpleado.TabIndex = 125;
            this.txt_codigodeproductoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigodeproductoEmpleado_KeyPress);
            // 
            // ProveedoresEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 661);
            this.Controls.Add(this.gvProveedoresEmpleado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_eliminarproveedorEmpleado);
            this.Controls.Add(this.btn_buscarproveedorEmpleado);
            this.Controls.Add(this.txt_buscasrcodigoProveedoresEmpleado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_mostrarproductoEmpleado);
            this.Controls.Add(this.btn_editarproveedorEmpleado);
            this.Controls.Add(this.txt_telefonoEmpleado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegresarproveedorEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_AgregarproveedorEmpleado);
            this.Controls.Add(this.txt_empresaEmpleado);
            this.Controls.Add(this.txt_productoreparteEmpleado);
            this.Controls.Add(this.txt_diasDerepartoEmpleado);
            this.Controls.Add(this.txt_nombreproveedorEmpleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_codigodeproductoEmpleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProveedoresEmpleados";
            this.Text = "Proveedores Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProveedoresEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDinventarioDataSetTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.BindingSource entradaBindingSource;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.Label label1;
        private BDinventarioDataSet bDinventarioDataSet;
        private System.Windows.Forms.BindingSource proveedorBindingSource1;
        private System.Windows.Forms.DataGridView gvProveedoresEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasDeRepartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_eliminarproveedorEmpleado;
        private System.Windows.Forms.Button btn_buscarproveedorEmpleado;
        private System.Windows.Forms.TextBox txt_buscasrcodigoProveedoresEmpleado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_mostrarproductoEmpleado;
        private System.Windows.Forms.Button btn_editarproveedorEmpleado;
        private System.Windows.Forms.TextBox txt_telefonoEmpleado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegresarproveedorEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AgregarproveedorEmpleado;
        private System.Windows.Forms.TextBox txt_empresaEmpleado;
        private System.Windows.Forms.TextBox txt_productoreparteEmpleado;
        private System.Windows.Forms.TextBox txt_diasDerepartoEmpleado;
        private System.Windows.Forms.TextBox txt_nombreproveedorEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigodeproductoEmpleado;
    }
}