namespace ProdyEcommerce
{
    partial class Productos
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
            this.chkrubros = new System.Windows.Forms.CheckedListBox();
            this.lblRubrosEco = new System.Windows.Forms.Label();
            this.txttags = new System.Windows.Forms.TextBox();
            this.lbltags = new System.Windows.Forms.Label();
            this.btngrabar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.CBPulicar = new System.Windows.Forms.CheckBox();
            this.Cbpagrupado = new System.Windows.Forms.CheckBox();
            this.Cbpvariable = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtlistart = new System.Windows.Forms.TextBox();
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
            this.txtarticulo.TextChanged += new System.EventHandler(this.txtarticulo_TextChanged);
            this.txtarticulo.Leave += new System.EventHandler(this.txtarticulo_Leave);
            this.txtarticulo.Validated += new System.EventHandler(this.txtarticulo_Validated);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnbuscar.Location = new System.Drawing.Point(556, 26);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(86, 20);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtnombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtnombre.Location = new System.Drawing.Point(232, 26);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(318, 20);
            this.txtnombre.TabIndex = 2;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            this.txtnombre.Leave += new System.EventHandler(this.txtnombre_Leave);
            this.txtnombre.Validated += new System.EventHandler(this.txtnombre_Validated);
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
            this.txtdetalles.MaxLength = 4000;
            this.txtdetalles.Multiline = true;
            this.txtdetalles.Name = "txtdetalles";
            this.txtdetalles.Size = new System.Drawing.Size(900, 199);
            this.txtdetalles.TabIndex = 7;
            // 
            // chkrubros
            // 
            this.chkrubros.FormattingEnabled = true;
            this.chkrubros.Location = new System.Drawing.Point(29, 352);
            this.chkrubros.Name = "chkrubros";
            this.chkrubros.Size = new System.Drawing.Size(197, 169);
            this.chkrubros.TabIndex = 8;
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
            this.txttags.TabIndex = 9;
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
            this.btngrabar.TabIndex = 10;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(842, 499);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(87, 32);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(842, 21);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(87, 25);
            this.btnlimpiar.TabIndex = 4;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // CBPulicar
            // 
            this.CBPulicar.AutoSize = true;
            this.CBPulicar.Location = new System.Drawing.Point(842, 78);
            this.CBPulicar.Name = "CBPulicar";
            this.CBPulicar.Size = new System.Drawing.Size(87, 17);
            this.CBPulicar.TabIndex = 12;
            this.CBPulicar.Text = "Publicar web";
            this.CBPulicar.UseVisualStyleBackColor = true;
            // 
            // Cbpagrupado
            // 
            this.Cbpagrupado.AutoSize = true;
            this.Cbpagrupado.Location = new System.Drawing.Point(605, 78);
            this.Cbpagrupado.Name = "Cbpagrupado";
            this.Cbpagrupado.Size = new System.Drawing.Size(117, 17);
            this.Cbpagrupado.TabIndex = 14;
            this.Cbpagrupado.Text = "Producto agrupado";
            this.Cbpagrupado.UseVisualStyleBackColor = true;
            // 
            // Cbpvariable
            // 
            this.Cbpvariable.AutoSize = true;
            this.Cbpvariable.Location = new System.Drawing.Point(727, 78);
            this.Cbpvariable.Name = "Cbpvariable";
            this.Cbpvariable.Size = new System.Drawing.Size(109, 17);
            this.Cbpvariable.TabIndex = 15;
            this.Cbpvariable.Text = "Producto variable";
            this.Cbpvariable.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(253, 374);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(168, 147);
            this.listBox1.TabIndex = 16;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(508, 374);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(168, 147);
            this.listBox2.TabIndex = 17;
            this.listBox2.Click += new System.EventHandler(this.listBox2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 24);
            this.button1.TabIndex = 18;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(444, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 24);
            this.button2.TabIndex = 19;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtlistart
            // 
            this.txtlistart.Location = new System.Drawing.Point(253, 352);
            this.txtlistart.Name = "txtlistart";
            this.txtlistart.Size = new System.Drawing.Size(168, 20);
            this.txtlistart.TabIndex = 20;
            this.txtlistart.TextChanged += new System.EventHandler(this.txtlistart_TextChanged);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 543);
            this.Controls.Add(this.txtlistart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Cbpvariable);
            this.Controls.Add(this.Cbpagrupado);
            this.Controls.Add(this.CBPulicar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btngrabar);
            this.Controls.Add(this.lbltags);
            this.Controls.Add(this.txttags);
            this.Controls.Add(this.lblRubrosEco);
            this.Controls.Add(this.chkrubros);
            this.Controls.Add(this.txtdetalles);
            this.Controls.Add(this.lbldetalle);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtarticulo);
            this.Controls.Add(this.lblarticulo);
            this.Name = "Productos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblarticulo;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lbldetalle;
        private System.Windows.Forms.TextBox txtdetalles;
        private System.Windows.Forms.CheckedListBox chkrubros;
        private System.Windows.Forms.Label lblRubrosEco;
        private System.Windows.Forms.TextBox txttags;
        private System.Windows.Forms.Label lbltags;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnlimpiar;
        public System.Windows.Forms.TextBox txtarticulo;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.CheckBox CBPulicar;
        private System.Windows.Forms.CheckBox Cbpagrupado;
        private System.Windows.Forms.CheckBox Cbpvariable;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtlistart;
    }
}

