namespace ProdyEcommerce
{
    partial class Busqueda_avanzada
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
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.lblbusqueda = new System.Windows.Forms.Label();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.comboboxfiltro = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(73, 12);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(429, 20);
            this.txtbusqueda.TabIndex = 0;
            // 
            // lblbusqueda
            // 
            this.lblbusqueda.AutoSize = true;
            this.lblbusqueda.Location = new System.Drawing.Point(9, 15);
            this.lblbusqueda.Name = "lblbusqueda";
            this.lblbusqueda.Size = new System.Drawing.Size(55, 13);
            this.lblbusqueda.TabIndex = 1;
            this.lblbusqueda.Text = "Busqueda";
            // 
            // lblfiltro
            // 
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.Location = new System.Drawing.Point(532, 16);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(53, 13);
            this.lblfiltro.TabIndex = 2;
            this.lblfiltro.Text = "Filtrar por:";
            // 
            // comboboxfiltro
            // 
            this.comboboxfiltro.FormattingEnabled = true;
            this.comboboxfiltro.Location = new System.Drawing.Point(592, 11);
            this.comboboxfiltro.Name = "comboboxfiltro";
            this.comboboxfiltro.Size = new System.Drawing.Size(150, 21);
            this.comboboxfiltro.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(961, 287);
            this.dataGridView1.TabIndex = 4;
            // 
            // Busqueda_avanzada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 351);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboboxfiltro);
            this.Controls.Add(this.lblfiltro);
            this.Controls.Add(this.lblbusqueda);
            this.Controls.Add(this.txtbusqueda);
            this.Name = "Busqueda_avanzada";
            this.Text = "Busqueda_avanzada";
            this.Load += new System.EventHandler(this.Busqueda_avanzada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label lblbusqueda;
        private System.Windows.Forms.Label lblfiltro;
        private System.Windows.Forms.ComboBox comboboxfiltro;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}