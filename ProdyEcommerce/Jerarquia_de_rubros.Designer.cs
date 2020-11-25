
namespace ProdyEcommerce
{
    partial class Jerarquia_de_rubros
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
            this.lblrubro = new System.Windows.Forms.Label();
            this.txtidrubro = new System.Windows.Forms.TextBox();
            this.txtnombrerubro = new System.Windows.Forms.TextBox();
            this.btnbuscarrubro = new System.Windows.Forms.Button();
            this.btngrabar = new System.Windows.Forms.Button();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.chkrubros = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lblrubro
            // 
            this.lblrubro.AutoSize = true;
            this.lblrubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrubro.Location = new System.Drawing.Point(25, 35);
            this.lblrubro.Name = "lblrubro";
            this.lblrubro.Size = new System.Drawing.Size(50, 16);
            this.lblrubro.TabIndex = 0;
            this.lblrubro.Text = "Rubro";
            // 
            // txtidrubro
            // 
            this.txtidrubro.Location = new System.Drawing.Point(81, 31);
            this.txtidrubro.Name = "txtidrubro";
            this.txtidrubro.Size = new System.Drawing.Size(124, 20);
            this.txtidrubro.TabIndex = 1;
            this.txtidrubro.TextChanged += new System.EventHandler(this.txtidrubro_TextChanged);
            this.txtidrubro.Leave += new System.EventHandler(this.txtidrubro_Leave);
            // 
            // txtnombrerubro
            // 
            this.txtnombrerubro.Location = new System.Drawing.Point(222, 31);
            this.txtnombrerubro.Name = "txtnombrerubro";
            this.txtnombrerubro.Size = new System.Drawing.Size(334, 20);
            this.txtnombrerubro.TabIndex = 2;
            // 
            // btnbuscarrubro
            // 
            this.btnbuscarrubro.Location = new System.Drawing.Point(574, 31);
            this.btnbuscarrubro.Name = "btnbuscarrubro";
            this.btnbuscarrubro.Size = new System.Drawing.Size(98, 23);
            this.btnbuscarrubro.TabIndex = 3;
            this.btnbuscarrubro.Text = "Buscar";
            this.btnbuscarrubro.UseVisualStyleBackColor = true;
            this.btnbuscarrubro.Click += new System.EventHandler(this.btnbuscarrubro_Click);
            // 
            // btngrabar
            // 
            this.btngrabar.Location = new System.Drawing.Point(444, 305);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(111, 34);
            this.btngrabar.TabIndex = 5;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // Btnsalir
            // 
            this.Btnsalir.Location = new System.Drawing.Point(561, 305);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(111, 34);
            this.Btnsalir.TabIndex = 6;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = true;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rubros dependientes";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(327, 303);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(111, 34);
            this.btnlimpiar.TabIndex = 8;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkrubros
            // 
            this.chkrubros.FormattingEnabled = true;
            this.chkrubros.Location = new System.Drawing.Point(28, 108);
            this.chkrubros.Name = "chkrubros";
            this.chkrubros.Size = new System.Drawing.Size(231, 229);
            this.chkrubros.TabIndex = 9;
            // 
            // Jerarquia_de_rubros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 349);
            this.Controls.Add(this.chkrubros);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.btngrabar);
            this.Controls.Add(this.btnbuscarrubro);
            this.Controls.Add(this.txtnombrerubro);
            this.Controls.Add(this.txtidrubro);
            this.Controls.Add(this.lblrubro);
            this.Name = "Jerarquia_de_rubros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jerarquia_de_rubros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrubro;
        private System.Windows.Forms.Button btnbuscarrubro;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtidrubro;
        public System.Windows.Forms.TextBox txtnombrerubro;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.CheckedListBox chkrubros;
    }
}