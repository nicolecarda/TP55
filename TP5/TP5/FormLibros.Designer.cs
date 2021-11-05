
namespace TP5
{
    partial class FormLibros
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
            this.labTitulo = new System.Windows.Forms.Label();
            this.labPaginas = new System.Windows.Forms.Label();
            this.labAutor = new System.Windows.Forms.Label();
            this.labISBN = new System.Windows.Forms.Label();
            this.labEdicion = new System.Windows.Forms.Label();
            this.labEditorial = new System.Windows.Forms.Label();
            this.labLugar = new System.Windows.Forms.Label();
            this.labFechaEdicion = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.txtFechaEdicion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Arial Black", 8.25F);
            this.labTitulo.Location = new System.Drawing.Point(91, 26);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(42, 15);
            this.labTitulo.TabIndex = 0;
            this.labTitulo.Text = "Titulo";
            // 
            // labPaginas
            // 
            this.labPaginas.AutoSize = true;
            this.labPaginas.Font = new System.Drawing.Font("Arial Black", 8.25F);
            this.labPaginas.Location = new System.Drawing.Point(91, 109);
            this.labPaginas.Name = "labPaginas";
            this.labPaginas.Size = new System.Drawing.Size(122, 15);
            this.labPaginas.TabIndex = 1;
            this.labPaginas.Text = "Número de Paginas";
            // 
            // labAutor
            // 
            this.labAutor.AutoSize = true;
            this.labAutor.Font = new System.Drawing.Font("Arial Black", 8.25F);
            this.labAutor.Location = new System.Drawing.Point(91, 64);
            this.labAutor.Name = "labAutor";
            this.labAutor.Size = new System.Drawing.Size(40, 15);
            this.labAutor.TabIndex = 2;
            this.labAutor.Text = "Autor";
            // 
            // labISBN
            // 
            this.labISBN.AutoSize = true;
            this.labISBN.Font = new System.Drawing.Font("Arial Black", 8.25F);
            this.labISBN.Location = new System.Drawing.Point(91, 160);
            this.labISBN.Name = "labISBN";
            this.labISBN.Size = new System.Drawing.Size(37, 15);
            this.labISBN.TabIndex = 3;
            this.labISBN.Text = "ISBN";
            // 
            // labEdicion
            // 
            this.labEdicion.AutoSize = true;
            this.labEdicion.Font = new System.Drawing.Font("Arial Black", 8.25F);
            this.labEdicion.Location = new System.Drawing.Point(91, 216);
            this.labEdicion.Name = "labEdicion";
            this.labEdicion.Size = new System.Drawing.Size(51, 15);
            this.labEdicion.TabIndex = 4;
            this.labEdicion.Text = "Edición";
            // 
            // labEditorial
            // 
            this.labEditorial.AutoSize = true;
            this.labEditorial.Font = new System.Drawing.Font("Arial Black", 8.25F);
            this.labEditorial.Location = new System.Drawing.Point(91, 268);
            this.labEditorial.Name = "labEditorial";
            this.labEditorial.Size = new System.Drawing.Size(58, 15);
            this.labEditorial.TabIndex = 5;
            this.labEditorial.Text = "Editorial";
            // 
            // labLugar
            // 
            this.labLugar.AutoSize = true;
            this.labLugar.Font = new System.Drawing.Font("Arial Black", 8.25F);
            this.labLugar.Location = new System.Drawing.Point(91, 318);
            this.labLugar.Name = "labLugar";
            this.labLugar.Size = new System.Drawing.Size(89, 15);
            this.labLugar.TabIndex = 6;
            this.labLugar.Text = "Ciudad y País";
            // 
            // labFechaEdicion
            // 
            this.labFechaEdicion.AutoSize = true;
            this.labFechaEdicion.Font = new System.Drawing.Font("Arial Black", 8.25F);
            this.labFechaEdicion.Location = new System.Drawing.Point(91, 368);
            this.labFechaEdicion.Name = "labFechaEdicion";
            this.labFechaEdicion.Size = new System.Drawing.Size(108, 15);
            this.labFechaEdicion.TabIndex = 7;
            this.labFechaEdicion.Text = "Fecha de Edición";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(281, 21);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(319, 20);
            this.txtTitulo.TabIndex = 8;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(281, 59);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(319, 20);
            this.txtAutor.TabIndex = 9;
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(281, 104);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(319, 20);
            this.txtPaginas.TabIndex = 10;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(281, 155);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(319, 20);
            this.txtISBN.TabIndex = 11;
            // 
            // txtEdicion
            // 
            this.txtEdicion.Location = new System.Drawing.Point(281, 211);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(319, 20);
            this.txtEdicion.TabIndex = 12;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(281, 263);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(319, 20);
            this.txtEditorial.TabIndex = 13;
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(281, 313);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(319, 20);
            this.txtLugar.TabIndex = 14;
            // 
            // txtFechaEdicion
            // 
            this.txtFechaEdicion.Location = new System.Drawing.Point(281, 363);
            this.txtFechaEdicion.Name = "txtFechaEdicion";
            this.txtFechaEdicion.Size = new System.Drawing.Size(319, 20);
            this.txtFechaEdicion.TabIndex = 15;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(402, 415);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(525, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtFechaEdicion);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.txtEdicion);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.labFechaEdicion);
            this.Controls.Add(this.labLugar);
            this.Controls.Add(this.labEditorial);
            this.Controls.Add(this.labEdicion);
            this.Controls.Add(this.labISBN);
            this.Controls.Add(this.labAutor);
            this.Controls.Add(this.labPaginas);
            this.Controls.Add(this.labTitulo);
            this.Name = "FormLibros";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Label labPaginas;
        private System.Windows.Forms.Label labAutor;
        private System.Windows.Forms.Label labISBN;
        private System.Windows.Forms.Label labEdicion;
        private System.Windows.Forms.Label labEditorial;
        private System.Windows.Forms.Label labLugar;
        private System.Windows.Forms.Label labFechaEdicion;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.TextBox txtFechaEdicion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

