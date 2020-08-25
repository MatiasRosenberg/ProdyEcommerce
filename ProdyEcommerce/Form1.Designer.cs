namespace ProdyEcommerce
{
    partial class Form1
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
            this.lblarticulo = new System.Windows.Forms.Label();
            this.txtarticulo = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lbldetalle = new System.Windows.Forms.Label();
            this.txtdetalles = new System.Windows.Forms.TextBox();
            this.chbpublicar = new System.Windows.Forms.CheckBox();
            this.chbreservas = new System.Windows.Forms.CheckBox();
            this.checkboxrubros = new System.Windows.Forms.CheckedListBox();
            this.lblRubrosEco = new System.Windows.Forms.Label();
            this.txttags = new System.Windows.Forms.TextBox();
            this.lbltags = new System.Windows.Forms.Label();
            this.btngrabar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblarticulo
            // 
            this.lblarticulo.AutoSize = true;
            this.lblarticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblarticulo.Location = new System.Drawing.Point(26, 26);
            this.lblarticulo.Name = "lblarticulo";
            this.lblarticulo.Size = new System.Drawing.Size(65, 18);
            this.lblarticulo.TabIndex = 0;
            this.lblarticulo.Text = "Articulo";
            // 
            // txtarticulo
            // 
            this.txtarticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtarticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtarticulo.Location = new System.Drawing.Point(97, 26);
            this.txtarticulo.Name = "txtarticulo";
            this.txtarticulo.Size = new System.Drawing.Size(129, 20);
            this.txtarticulo.TabIndex = 1;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnbuscar.Location = new System.Drawing.Point(556, 26);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(86, 20);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(232, 26);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(318, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // lbldetalle
            // 
            this.lbldetalle.AutoSize = true;
            this.lbldetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetalle.Location = new System.Drawing.Point(26, 78);
            this.lbldetalle.Name = "lbldetalle";
            this.lbldetalle.Size = new System.Drawing.Size(60, 18);
            this.lbldetalle.TabIndex = 4;
            this.lbldetalle.Text = "Detalle";
            // 
            // txtdetalles
            // 
            this.txtdetalles.Location = new System.Drawing.Point(29, 110);
            this.txtdetalles.Multiline = true;
            this.txtdetalles.Name = "txtdetalles";
            this.txtdetalles.Size = new System.Drawing.Size(900, 199);
            this.txtdetalles.TabIndex = 5;
            // 
            // chbpublicar
            // 
            this.chbpublicar.AutoSize = true;
            this.chbpublicar.Location = new System.Drawing.Point(718, 78);
            this.chbpublicar.Name = "chbpublicar";
            this.chbpublicar.Size = new System.Drawing.Size(87, 17);
            this.chbpublicar.TabIndex = 6;
            this.chbpublicar.Text = "Publicar web";
            this.chbpublicar.UseVisualStyleBackColor = true;
            // 
            // chbreservas
            // 
            this.chbreservas.AutoSize = true;
            this.chbreservas.Location = new System.Drawing.Point(821, 78);
            this.chbreservas.Name = "chbreservas";
            this.chbreservas.Size = new System.Drawing.Size(108, 17);
            this.chbreservas.TabIndex = 7;
            this.chbreservas.Text = "Permitir Reservas";
            this.chbreservas.UseVisualStyleBackColor = true;
            // 
            // checkboxrubros
            // 
            this.checkboxrubros.FormattingEnabled = true;
            this.checkboxrubros.Location = new System.Drawing.Point(29, 352);
            this.checkboxrubros.Name = "checkboxrubros";
            this.checkboxrubros.Size = new System.Drawing.Size(197, 169);
            this.checkboxrubros.TabIndex = 8;
            // 
            // lblRubrosEco
            // 
            this.lblRubrosEco.AutoSize = true;
            this.lblRubrosEco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubrosEco.Location = new System.Drawing.Point(26, 322);
            this.lblRubrosEco.Name = "lblRubrosEco";
            this.lblRubrosEco.Size = new System.Drawing.Size(182, 18);
            this.lblRubrosEco.TabIndex = 9;
            this.lblRubrosEco.Text = "Rubros de Ecommerce";
            // 
            // txttags
            // 
            this.txttags.Location = new System.Drawing.Point(698, 352);
            this.txttags.Multiline = true;
            this.txttags.Name = "txttags";
            this.txttags.Size = new System.Drawing.Size(231, 109);
            this.txttags.TabIndex = 10;
            // 
            // lbltags
            // 
            this.lbltags.AutoSize = true;
            this.lbltags.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltags.Location = new System.Drawing.Point(695, 322);
            this.lbltags.Name = "lbltags";
            this.lbltags.Size = new System.Drawing.Size(45, 18);
            this.lbltags.TabIndex = 11;
            this.lbltags.Text = "Tags";
            // 
            // btngrabar
            // 
            this.btngrabar.Location = new System.Drawing.Point(718, 499);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(87, 32);
            this.btngrabar.TabIndex = 12;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(842, 499);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(87, 32);
            this.btnsalir.TabIndex = 13;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 543);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btngrabar);
            this.Controls.Add(this.lbltags);
            this.Controls.Add(this.txttags);
            this.Controls.Add(this.lblRubrosEco);
            this.Controls.Add(this.checkboxrubros);
            this.Controls.Add(this.chbreservas);
            this.Controls.Add(this.chbpublicar);
            this.Controls.Add(this.txtdetalles);
            this.Controls.Add(this.lbldetalle);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtarticulo);
            this.Controls.Add(this.lblarticulo);
            this.Name = "Form1";
            this.Text = "ProdyEcommerce";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblarticulo;
        private System.Windows.Forms.TextBox txtarticulo;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lbldetalle;
        private System.Windows.Forms.TextBox txtdetalles;
        private System.Windows.Forms.CheckBox chbpublicar;
        private System.Windows.Forms.CheckBox chbreservas;
        private System.Windows.Forms.CheckedListBox checkboxrubros;
        private System.Windows.Forms.Label lblRubrosEco;
        private System.Windows.Forms.TextBox txttags;
        private System.Windows.Forms.Label lbltags;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.Button btnsalir;
    }
}

