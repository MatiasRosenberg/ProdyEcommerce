﻿namespace ProdyEcommerce
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btngrabar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtimagen = new System.Windows.Forms.TextBox();
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
            this.lblftp.Location = new System.Drawing.Point(22, 162);
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(183, 207);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Admitir reserva?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btngrabar
            // 
            this.btngrabar.Location = new System.Drawing.Point(25, 239);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(75, 23);
            this.btngrabar.TabIndex = 10;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(375, 239);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // txtimagen
            // 
            this.txtimagen.Location = new System.Drawing.Point(105, 155);
            this.txtimagen.MaxLength = 200;
            this.txtimagen.Name = "txtimagen";
            this.txtimagen.Size = new System.Drawing.Size(226, 20);
            this.txtimagen.TabIndex = 12;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 277);
            this.Controls.Add(this.txtimagen);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btngrabar);
            this.Controls.Add(this.checkBox1);
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
        private System.Windows.Forms.ComboBox cbpublicar;
        private System.Windows.Forms.ComboBox cbvendedor;
        private System.Windows.Forms.ComboBox cbstock;
        private System.Windows.Forms.ComboBox cbmoneda;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txtimagen;
    }
}