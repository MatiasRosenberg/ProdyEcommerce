namespace ProdyEcommerce
{
    partial class Configuracion
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
            this.lbllista = new System.Windows.Forms.Label();
            this.lblvendedor = new System.Windows.Forms.Label();
            this.lblstock = new System.Windows.Forms.Label();
            this.lblmoneda = new System.Windows.Forms.Label();
            this.lblftp = new System.Windows.Forms.Label();
            this.cbpublicar = new System.Windows.Forms.ComboBox();
            this.cbvendedor = new System.Windows.Forms.ComboBox();
            this.cbstock = new System.Windows.Forms.ComboBox();
            this.cbmoneda = new System.Windows.Forms.ComboBox();
            this.chbreserva = new System.Windows.Forms.CheckBox();
            this.txtimagen = new System.Windows.Forms.TextBox();
            this.Btngrabar = new System.Windows.Forms.Button();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.btnsync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbllista
            // 
            this.lbllista.AutoSize = true;
            this.lbllista.Location = new System.Drawing.Point(22, 41);
            this.lbllista.Name = "lbllista";
            this.lbllista.Size = new System.Drawing.Size(133, 13);
            this.lbllista.TabIndex = 0;
            this.lbllista.Text = "Lista de precios a publicar:";
            // 
            // lblvendedor
            // 
            this.lblvendedor.AutoSize = true;
            this.lblvendedor.Location = new System.Drawing.Point(22, 71);
            this.lblvendedor.Name = "lblvendedor";
            this.lblvendedor.Size = new System.Drawing.Size(130, 13);
            this.lblvendedor.TabIndex = 1;
            this.lblvendedor.Text = "Vendedor de Ecommerce:";
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Location = new System.Drawing.Point(22, 98);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(145, 13);
            this.lblstock.TabIndex = 2;
            this.lblstock.Text = "Deposito de stock a publicar:";
            // 
            // lblmoneda
            // 
            this.lblmoneda.AutoSize = true;
            this.lblmoneda.Location = new System.Drawing.Point(22, 130);
            this.lblmoneda.Name = "lblmoneda";
            this.lblmoneda.Size = new System.Drawing.Size(145, 13);
            this.lblmoneda.TabIndex = 3;
            this.lblmoneda.Text = "Moneda de precio a publicar:";
            // 
            // lblftp
            // 
            this.lblftp.AutoSize = true;
            this.lblftp.Location = new System.Drawing.Point(22, 188);
            this.lblftp.Name = "lblftp";
            this.lblftp.Size = new System.Drawing.Size(77, 13);
            this.lblftp.TabIndex = 4;
            this.lblftp.Text = "Ftp de imagen:";
            // 
            // cbpublicar
            // 
            this.cbpublicar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpublicar.FormattingEnabled = true;
            this.cbpublicar.Location = new System.Drawing.Point(173, 33);
            this.cbpublicar.Name = "cbpublicar";
            this.cbpublicar.Size = new System.Drawing.Size(121, 21);
            this.cbpublicar.TabIndex = 5;
            // 
            // cbvendedor
            // 
            this.cbvendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbvendedor.FormattingEnabled = true;
            this.cbvendedor.Location = new System.Drawing.Point(173, 60);
            this.cbvendedor.Name = "cbvendedor";
            this.cbvendedor.Size = new System.Drawing.Size(121, 21);
            this.cbvendedor.TabIndex = 6;
            // 
            // cbstock
            // 
            this.cbstock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbstock.FormattingEnabled = true;
            this.cbstock.Location = new System.Drawing.Point(173, 90);
            this.cbstock.Name = "cbstock";
            this.cbstock.Size = new System.Drawing.Size(121, 21);
            this.cbstock.TabIndex = 7;
            // 
            // cbmoneda
            // 
            this.cbmoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmoneda.FormattingEnabled = true;
            this.cbmoneda.Location = new System.Drawing.Point(173, 122);
            this.cbmoneda.Name = "cbmoneda";
            this.cbmoneda.Size = new System.Drawing.Size(121, 21);
            this.cbmoneda.TabIndex = 8;
            // 
            // chbreserva
            // 
            this.chbreserva.AutoSize = true;
            this.chbreserva.Location = new System.Drawing.Point(25, 157);
            this.chbreserva.Name = "chbreserva";
            this.chbreserva.Size = new System.Drawing.Size(101, 17);
            this.chbreserva.TabIndex = 9;
            this.chbreserva.Text = "Admitir reserva?";
            this.chbreserva.UseVisualStyleBackColor = true;
            // 
            // txtimagen
            // 
            this.txtimagen.Location = new System.Drawing.Point(105, 185);
            this.txtimagen.MaxLength = 200;
            this.txtimagen.Name = "txtimagen";
            this.txtimagen.Size = new System.Drawing.Size(226, 20);
            this.txtimagen.TabIndex = 12;
            // 
            // Btngrabar
            // 
            this.Btngrabar.Location = new System.Drawing.Point(289, 241);
            this.Btngrabar.Name = "Btngrabar";
            this.Btngrabar.Size = new System.Drawing.Size(81, 24);
            this.Btngrabar.TabIndex = 13;
            this.Btngrabar.Text = "Grabar";
            this.Btngrabar.UseVisualStyleBackColor = true;
            this.Btngrabar.Click += new System.EventHandler(this.Btngrabar_Click_1);
            // 
            // Btnsalir
            // 
            this.Btnsalir.Location = new System.Drawing.Point(376, 241);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(81, 24);
            this.Btnsalir.TabIndex = 14;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = true;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click_1);
            // 
            // btnsync
            // 
            this.btnsync.Location = new System.Drawing.Point(25, 241);
            this.btnsync.Name = "btnsync";
            this.btnsync.Size = new System.Drawing.Size(81, 24);
            this.btnsync.TabIndex = 15;
            this.btnsync.Text = "Sync Masiva";
            this.btnsync.UseVisualStyleBackColor = true;
            this.btnsync.Click += new System.EventHandler(this.btnsync_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 277);
            this.Controls.Add(this.btnsync);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.Btngrabar);
            this.Controls.Add(this.txtimagen);
            this.Controls.Add(this.chbreserva);
            this.Controls.Add(this.cbmoneda);
            this.Controls.Add(this.cbstock);
            this.Controls.Add(this.cbvendedor);
            this.Controls.Add(this.cbpublicar);
            this.Controls.Add(this.lblftp);
            this.Controls.Add(this.lblmoneda);
            this.Controls.Add(this.lblstock);
            this.Controls.Add(this.lblvendedor);
            this.Controls.Add(this.lbllista);
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllista;
        private System.Windows.Forms.Label lblvendedor;
        private System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.Label lblmoneda;
        private System.Windows.Forms.Label lblftp;
        private System.Windows.Forms.Button Btngrabar;
        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.Button btnsync;
        public System.Windows.Forms.ComboBox cbpublicar;
        public System.Windows.Forms.ComboBox cbvendedor;
        public System.Windows.Forms.ComboBox cbstock;
        public System.Windows.Forms.ComboBox cbmoneda;
        public System.Windows.Forms.CheckBox chbreserva;
        public System.Windows.Forms.TextBox txtimagen;
    }
}