namespace Inventario3
{
    partial class RegistroEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroEmpleados));
            this.btn_buscarEmpleado = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_buscarEmpleado = new System.Windows.Forms.TextBox();
            this.btn_mostrarUsuario = new System.Windows.Forms.Button();
            this.btn_editarUsuario = new System.Windows.Forms.Button();
            this.btn_eliminarUsuario = new System.Windows.Forms.Button();
            this.gvRegistrarProducto = new System.Windows.Forms.DataGridView();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipousuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bDinventarioDataSet = new Inventario3.BDinventarioDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_TipoUsuarioEmpleado = new System.Windows.Forms.TextBox();
            this.txt_NombreEmpleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegresarSalida = new System.Windows.Forms.Button();
            this.txt_ContrasenaEmpleado = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.entradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Inventario3.BDinventarioDataSetTableAdapters.UsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gvRegistrarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscarEmpleado
            // 
            this.btn_buscarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            this.btn_buscarEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_buscarEmpleado.Location = new System.Drawing.Point(1143, 95);
            this.btn_buscarEmpleado.Name = "btn_buscarEmpleado";
            this.btn_buscarEmpleado.Size = new System.Drawing.Size(112, 41);
            this.btn_buscarEmpleado.TabIndex = 74;
            this.btn_buscarEmpleado.Text = "Buscar";
            this.btn_buscarEmpleado.UseVisualStyleBackColor = false;
            this.btn_buscarEmpleado.Click += new System.EventHandler(this.btn_buscarEmpleado_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(641, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Nombre";
            // 
            // txt_buscarEmpleado
            // 
            this.txt_buscarEmpleado.Location = new System.Drawing.Point(730, 107);
            this.txt_buscarEmpleado.Name = "txt_buscarEmpleado";
            this.txt_buscarEmpleado.Size = new System.Drawing.Size(376, 20);
            this.txt_buscarEmpleado.TabIndex = 72;
            this.txt_buscarEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscarEmpleado_KeyPress);
            // 
            // btn_mostrarUsuario
            // 
            this.btn_mostrarUsuario.BackColor = System.Drawing.Color.Teal;
            this.btn_mostrarUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btn_mostrarUsuario.Location = new System.Drawing.Point(508, 606);
            this.btn_mostrarUsuario.Name = "btn_mostrarUsuario";
            this.btn_mostrarUsuario.Size = new System.Drawing.Size(147, 43);
            this.btn_mostrarUsuario.TabIndex = 71;
            this.btn_mostrarUsuario.Text = "Mostrar";
            this.btn_mostrarUsuario.UseVisualStyleBackColor = false;
            this.btn_mostrarUsuario.Click += new System.EventHandler(this.btn_mostrarUsuario_Click);
            // 
            // btn_editarUsuario
            // 
            this.btn_editarUsuario.BackColor = System.Drawing.Color.Teal;
            this.btn_editarUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarUsuario.ForeColor = System.Drawing.Color.White;
            this.btn_editarUsuario.Location = new System.Drawing.Point(345, 606);
            this.btn_editarUsuario.Name = "btn_editarUsuario";
            this.btn_editarUsuario.Size = new System.Drawing.Size(147, 43);
            this.btn_editarUsuario.TabIndex = 70;
            this.btn_editarUsuario.Text = "Editar";
            this.btn_editarUsuario.UseVisualStyleBackColor = false;
            this.btn_editarUsuario.Click += new System.EventHandler(this.btn_editarUsuario_Click);
            // 
            // btn_eliminarUsuario
            // 
            this.btn_eliminarUsuario.BackColor = System.Drawing.Color.Teal;
            this.btn_eliminarUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarUsuario.ForeColor = System.Drawing.Color.White;
            this.btn_eliminarUsuario.Location = new System.Drawing.Point(181, 606);
            this.btn_eliminarUsuario.Name = "btn_eliminarUsuario";
            this.btn_eliminarUsuario.Size = new System.Drawing.Size(147, 43);
            this.btn_eliminarUsuario.TabIndex = 69;
            this.btn_eliminarUsuario.Text = "Eliminar";
            this.btn_eliminarUsuario.UseVisualStyleBackColor = false;
            this.btn_eliminarUsuario.Click += new System.EventHandler(this.btn_eliminarUsuario_Click);
            // 
            // gvRegistrarProducto
            // 
            this.gvRegistrarProducto.AutoGenerateColumns = false;
            this.gvRegistrarProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvRegistrarProducto.BackgroundColor = System.Drawing.Color.Gray;
            this.gvRegistrarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRegistrarProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.contrasenaDataGridViewTextBoxColumn,
            this.tipousuarioDataGridViewTextBoxColumn});
            this.gvRegistrarProducto.DataSource = this.usuariosBindingSource2;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvRegistrarProducto.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvRegistrarProducto.Location = new System.Drawing.Point(612, 155);
            this.gvRegistrarProducto.Name = "gvRegistrarProducto";
            this.gvRegistrarProducto.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvRegistrarProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvRegistrarProducto.RowHeadersVisible = false;
            this.gvRegistrarProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvRegistrarProducto.Size = new System.Drawing.Size(643, 432);
            this.gvRegistrarProducto.TabIndex = 57;
            this.gvRegistrarProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRegistrarProducto_CellClick);
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Id_Usuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "Id_Usuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contrasenaDataGridViewTextBoxColumn
            // 
            this.contrasenaDataGridViewTextBoxColumn.DataPropertyName = "Contrasena";
            this.contrasenaDataGridViewTextBoxColumn.HeaderText = "Contrasena";
            this.contrasenaDataGridViewTextBoxColumn.Name = "contrasenaDataGridViewTextBoxColumn";
            this.contrasenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipousuarioDataGridViewTextBoxColumn
            // 
            this.tipousuarioDataGridViewTextBoxColumn.DataPropertyName = "Tipo_usuario";
            this.tipousuarioDataGridViewTextBoxColumn.HeaderText = "Tipo_usuario";
            this.tipousuarioDataGridViewTextBoxColumn.Name = "tipousuarioDataGridViewTextBoxColumn";
            this.tipousuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuariosBindingSource2
            // 
            this.usuariosBindingSource2.DataMember = "Usuarios";
            this.usuariosBindingSource2.DataSource = this.bDinventarioDataSet;
            // 
            // bDinventarioDataSet
            // 
            this.bDinventarioDataSet.DataSetName = "BDinventarioDataSet";
            this.bDinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-13, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1324, 84);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(462, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registrar Nuevos Empleados";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.Teal;
            this.btn_Agregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.Color.White;
            this.btn_Agregar.Location = new System.Drawing.Point(12, 606);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(147, 43);
            this.btn_Agregar.TabIndex = 66;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(147, 275);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(343, 20);
            this.txt_Usuario.TabIndex = 65;
            // 
            // txt_TipoUsuarioEmpleado
            // 
            this.txt_TipoUsuarioEmpleado.Location = new System.Drawing.Point(147, 374);
            this.txt_TipoUsuarioEmpleado.Name = "txt_TipoUsuarioEmpleado";
            this.txt_TipoUsuarioEmpleado.Size = new System.Drawing.Size(343, 20);
            this.txt_TipoUsuarioEmpleado.TabIndex = 64;
            this.txt_TipoUsuarioEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TipoUsuarioEmpleado_KeyPress);
            // 
            // txt_NombreEmpleado
            // 
            this.txt_NombreEmpleado.Location = new System.Drawing.Point(147, 224);
            this.txt_NombreEmpleado.Name = "txt_NombreEmpleado";
            this.txt_NombreEmpleado.Size = new System.Drawing.Size(343, 20);
            this.txt_NombreEmpleado.TabIndex = 62;
            this.txt_NombreEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreEmpleado_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "Tipo de Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Contraseña";
            // 
            // btnRegresarSalida
            // 
            this.btnRegresarSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            this.btnRegresarSalida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarSalida.ForeColor = System.Drawing.Color.White;
            this.btnRegresarSalida.Location = new System.Drawing.Point(1140, 606);
            this.btnRegresarSalida.Name = "btnRegresarSalida";
            this.btnRegresarSalida.Size = new System.Drawing.Size(147, 43);
            this.btnRegresarSalida.TabIndex = 68;
            this.btnRegresarSalida.Text = "Regresar";
            this.btnRegresarSalida.UseVisualStyleBackColor = false;
            this.btnRegresarSalida.Click += new System.EventHandler(this.btnRegresarSalida_Click);
            // 
            // txt_ContrasenaEmpleado
            // 
            this.txt_ContrasenaEmpleado.Location = new System.Drawing.Point(147, 322);
            this.txt_ContrasenaEmpleado.Name = "txt_ContrasenaEmpleado";
            this.txt_ContrasenaEmpleado.Size = new System.Drawing.Size(343, 20);
            this.txt_ContrasenaEmpleado.TabIndex = 63;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "Usuarios";
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // RegistroEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 661);
            this.Controls.Add(this.btn_buscarEmpleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_buscarEmpleado);
            this.Controls.Add(this.btn_mostrarUsuario);
            this.Controls.Add(this.btn_editarUsuario);
            this.Controls.Add(this.btn_eliminarUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gvRegistrarProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.txt_TipoUsuarioEmpleado);
            this.Controls.Add(this.txt_NombreEmpleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegresarSalida);
            this.Controls.Add(this.txt_ContrasenaEmpleado);
            this.Name = "RegistroEmpleados";
            this.Text = "RegistroEmpleados";
            this.Load += new System.EventHandler(this.RegistroEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRegistrarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDinventarioDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscarEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_buscarEmpleado;
        private System.Windows.Forms.Button btn_mostrarUsuario;
        private System.Windows.Forms.Button btn_editarUsuario;
        private System.Windows.Forms.Button btn_eliminarUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView gvRegistrarProducto;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_TipoUsuarioEmpleado;
        private System.Windows.Forms.TextBox txt_NombreEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegresarSalida;
        private System.Windows.Forms.BindingSource entradaBindingSource;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.TextBox txt_ContrasenaEmpleado;
        private System.Windows.Forms.BindingSource salidaBindingSource;
        private BDinventarioDataSet bDinventarioDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource2;
        private BDinventarioDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipousuarioDataGridViewTextBoxColumn;
    }
}