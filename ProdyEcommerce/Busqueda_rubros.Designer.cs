
namespace ProdyEcommerce
{
    partial class Busqueda_rubros
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
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dgvrubros = new System.Windows.Forms.DataGridView();
            this.comboboxfiltro = new System.Windows.Forms.ComboBox();
            this.lblbusqueda = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrubros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(514, 32);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(90, 21);
            this.btnbuscar.TabIndex = 10;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // dgvrubros
            // 
            this.dgvrubros.AllowUserToAddRows = false;
            this.dgvrubros.AllowUserToDeleteRows = false;
            this.dgvrubros.AllowUserToOrderColumns = true;
            this.dgvrubros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvrubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrubros.Location = new System.Drawing.Point(17, 72);
            this.dgvrubros.Name = "dgvrubros";
            this.dgvrubros.ReadOnly = true;
            this.dgvrubros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrubros.Size = new System.Drawing.Size(961, 287);
            this.dgvrubros.TabIndex = 9;
            this.dgvrubros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrubros_CellClick);
            // 
            // comboboxfiltro
            // 
            this.comboboxfiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxfiltro.FormattingEnabled = true;
            this.comboboxfiltro.Location = new System.Drawing.Point(794, 31);
            this.comboboxfiltro.Name = "comboboxfiltro";
            this.comboboxfiltro.Size = new System.Drawing.Size(150, 21);
            this.comboboxfiltro.TabIndex = 8;
            // 
            // lblbusqueda
            // 
            this.lblbusqueda.AutoSize = true;
            this.lblbusqueda.Location = new System.Drawing.Point(14, 35);
            this.lblbusqueda.Name = "lblbusqueda";
            this.lblbusqueda.Size = new System.Drawing.Size(55, 13);
            this.lblbusqueda.TabIndex = 7;
            this.lblbusqueda.Text = "Busqueda";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtbusqueda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtbusqueda.Location = new System.Drawing.Point(78, 32);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(429, 20);
            this.txtbusqueda.TabIndex = 6;
            // 
            // Busqueda_rubros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 390);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dgvrubros);
            this.Controls.Add(this.comboboxfiltro);
            this.Controls.Add(this.lblbusqueda);
            this.Controls.Add(this.txtbusqueda);
            this.Name = "Busqueda_rubros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda_rubros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Busqueda_rubros_FormClosed);
            this.Load += new System.EventHandler(this.Busqueda_rubros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrubros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.ComboBox comboboxfiltro;
        private System.Windows.Forms.Label lblbusqueda;
        public System.Windows.Forms.TextBox txtbusqueda;
        public System.Windows.Forms.DataGridView dgvrubros;
    }
}