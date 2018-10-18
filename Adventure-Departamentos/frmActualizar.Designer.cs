namespace Adventure_Departamentos
{
    partial class frmActualizar
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
            this.gbActualizar = new System.Windows.Forms.GroupBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtDescripción = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbActualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbActualizar
            // 
            this.gbActualizar.Controls.Add(this.txtCodigo);
            this.gbActualizar.Controls.Add(this.label1);
            this.gbActualizar.Controls.Add(this.btnRegresar);
            this.gbActualizar.Controls.Add(this.btnActualizar);
            this.gbActualizar.Controls.Add(this.dtpFecha);
            this.gbActualizar.Controls.Add(this.txtDescripción);
            this.gbActualizar.Controls.Add(this.txtNombre);
            this.gbActualizar.Controls.Add(this.lbFecha);
            this.gbActualizar.Controls.Add(this.lbDescripcion);
            this.gbActualizar.Controls.Add(this.lbNombre);
            this.gbActualizar.Location = new System.Drawing.Point(12, 12);
            this.gbActualizar.Name = "gbActualizar";
            this.gbActualizar.Size = new System.Drawing.Size(412, 252);
            this.gbActualizar.TabIndex = 1;
            this.gbActualizar.TabStop = false;
            this.gbActualizar.Text = "Datos a editar en la tabla de departamentos";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(218, 207);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(123, 207);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(179, 149);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(205, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // txtDescripción
            // 
            this.txtDescripción.Location = new System.Drawing.Point(179, 88);
            this.txtDescripción.Multiline = true;
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.Size = new System.Drawing.Size(205, 49);
            this.txtDescripción.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(179, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(205, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(20, 149);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(115, 13);
            this.lbFecha.TabIndex = 2;
            this.lbFecha.Text = "Fecha de Modificación";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(20, 91);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(60, 13);
            this.lbDescripcion.TabIndex = 1;
            this.lbDescripcion.Text = "Descipción";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(20, 58);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(179, 24);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(205, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo";
            // 
            // frmActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 276);
            this.Controls.Add(this.gbActualizar);
            this.Name = "frmActualizar";
            this.Text = "frmActualizar";
            this.gbActualizar.ResumeLayout(false);
            this.gbActualizar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbActualizar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtDescripción;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
    }
}