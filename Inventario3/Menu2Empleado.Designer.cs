namespace Inventario3
{
    partial class Menu2Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu2Empleado));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Proveedores = new System.Windows.Forms.Button();
            this.btn_Productos = new System.Windows.Forms.Button();
            this.btn_Salida = new System.Windows.Forms.Button();
            this.btn_Entrada = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1300, 76);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(648, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Empleado";
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(11, 9);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(0, 13);
            this.lblmensaje.TabIndex = 39;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(1160, 604);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(126, 45);
            this.btnsalir.TabIndex = 51;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(234, 555);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 50;
            this.label5.Text = "Proveedores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(976, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(577, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "Salida Productos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 19);
            this.label6.TabIndex = 47;
            this.label6.Text = "Entrada Productos";
            // 
            // btn_Proveedores
            // 
            this.btn_Proveedores.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Proveedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Proveedores.BackgroundImage")));
            this.btn_Proveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Proveedores.FlatAppearance.BorderSize = 2;
            this.btn_Proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Proveedores.ForeColor = System.Drawing.Color.Teal;
            this.btn_Proveedores.Location = new System.Drawing.Point(201, 381);
            this.btn_Proveedores.Name = "btn_Proveedores";
            this.btn_Proveedores.Size = new System.Drawing.Size(180, 160);
            this.btn_Proveedores.TabIndex = 46;
            this.btn_Proveedores.UseVisualStyleBackColor = false;
            this.btn_Proveedores.Click += new System.EventHandler(this.btn_Proveedores_Click);
            // 
            // btn_Productos
            // 
            this.btn_Productos.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Productos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Productos.BackgroundImage")));
            this.btn_Productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Productos.FlatAppearance.BorderSize = 2;
            this.btn_Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Productos.ForeColor = System.Drawing.Color.Teal;
            this.btn_Productos.Location = new System.Drawing.Point(912, 151);
            this.btn_Productos.Name = "btn_Productos";
            this.btn_Productos.Size = new System.Drawing.Size(180, 160);
            this.btn_Productos.TabIndex = 45;
            this.btn_Productos.UseVisualStyleBackColor = false;
            this.btn_Productos.Click += new System.EventHandler(this.btn_Productos_Click);
            // 
            // btn_Salida
            // 
            this.btn_Salida.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Salida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salida.BackgroundImage")));
            this.btn_Salida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Salida.FlatAppearance.BorderSize = 2;
            this.btn_Salida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salida.ForeColor = System.Drawing.Color.Teal;
            this.btn_Salida.Location = new System.Drawing.Point(560, 151);
            this.btn_Salida.Name = "btn_Salida";
            this.btn_Salida.Size = new System.Drawing.Size(180, 160);
            this.btn_Salida.TabIndex = 44;
            this.btn_Salida.UseVisualStyleBackColor = false;
            this.btn_Salida.Click += new System.EventHandler(this.btn_Salida_Click);
            // 
            // btn_Entrada
            // 
            this.btn_Entrada.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Entrada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Entrada.BackgroundImage")));
            this.btn_Entrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Entrada.FlatAppearance.BorderSize = 2;
            this.btn_Entrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entrada.ForeColor = System.Drawing.Color.Teal;
            this.btn_Entrada.Location = new System.Drawing.Point(201, 151);
            this.btn_Entrada.Name = "btn_Entrada";
            this.btn_Entrada.Size = new System.Drawing.Size(180, 160);
            this.btn_Entrada.TabIndex = 43;
            this.btn_Entrada.UseVisualStyleBackColor = false;
            this.btn_Entrada.Click += new System.EventHandler(this.btn_Entrada_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // Menu2Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Proveedores);
            this.Controls.Add(this.btn_Productos);
            this.Controls.Add(this.btn_Salida);
            this.Controls.Add(this.btn_Entrada);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu2Empleado";
            this.Text = "MenuEmpleado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Proveedores;
        private System.Windows.Forms.Button btn_Productos;
        private System.Windows.Forms.Button btn_Salida;
        private System.Windows.Forms.Button btn_Entrada;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}