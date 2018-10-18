namespace Adventure_Departamentos
{
    partial class FrmOperacionesCRUD
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.gbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.btnEliminar);
            this.gbOpciones.Controls.Add(this.btnActualizar);
            this.gbOpciones.Controls.Add(this.btnCrear);
            this.gbOpciones.Controls.Add(this.btnListar);
            this.gbOpciones.Location = new System.Drawing.Point(12, 12);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(466, 167);
            this.gbOpciones.TabIndex = 0;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones Disponibles Para Departarmento";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(248, 108);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(181, 35);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar Departamento";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(42, 108);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(181, 35);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar Departamentos";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(248, 58);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(181, 35);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear Departamentos";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(42, 58);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(181, 35);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar Departamentos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // FrmOperacionesCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 195);
            this.Controls.Add(this.gbOpciones);
            this.Name = "FrmOperacionesCRUD";
            this.Text = "Operaiones CRUD con departamentos Adventure Works";
            this.Load += new System.EventHandler(this.FrmOperacionesCRUD_Load);
            this.gbOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnListar;
    }
}

