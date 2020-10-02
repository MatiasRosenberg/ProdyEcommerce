namespace ProdyEcommerce
{
    partial class Prodyecommerce
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
            this.Btnproductos = new System.Windows.Forms.Button();
            this.btnconfiguracion = new System.Windows.Forms.Button();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btnproductos
            // 
            this.Btnproductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Btnproductos.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnproductos.Location = new System.Drawing.Point(100, 128);
            this.Btnproductos.Name = "Btnproductos";
            this.Btnproductos.Size = new System.Drawing.Size(183, 100);
            this.Btnproductos.TabIndex = 0;
            this.Btnproductos.Text = "Productos";
            this.Btnproductos.UseVisualStyleBackColor = false;
            this.Btnproductos.Click += new System.EventHandler(this.Btnproductos_Click);
            // 
            // btnconfiguracion
            // 
            this.btnconfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnconfiguracion.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfiguracion.Location = new System.Drawing.Point(354, 128);
            this.btnconfiguracion.Name = "btnconfiguracion";
            this.btnconfiguracion.Size = new System.Drawing.Size(183, 100);
            this.btnconfiguracion.TabIndex = 1;
            this.btnconfiguracion.Text = "Configuracion";
            this.btnconfiguracion.UseVisualStyleBackColor = false;
            // 
            // Btnsalir
            // 
            this.Btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btnsalir.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsalir.Location = new System.Drawing.Point(596, 128);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(183, 100);
            this.Btnsalir.TabIndex = 2;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = false;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Prodyecommerce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 384);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.btnconfiguracion);
            this.Controls.Add(this.Btnproductos);
            this.Name = "Prodyecommerce";
            this.Text = "Prodyecommerce";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btnproductos;
        private System.Windows.Forms.Button btnconfiguracion;
        private System.Windows.Forms.Button Btnsalir;
    }
}