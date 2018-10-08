namespace DeepTec
{
    partial class Organos
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtEspecifica = new System.Windows.Forms.TextBox();
            this.cbBusqueda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtaOrganos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaOrganos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(13, 13);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtEspecifica
            // 
            this.txtEspecifica.Location = new System.Drawing.Point(298, 14);
            this.txtEspecifica.Name = "txtEspecifica";
            this.txtEspecifica.Size = new System.Drawing.Size(127, 20);
            this.txtEspecifica.TabIndex = 8;
            // 
            // cbBusqueda
            // 
            this.cbBusqueda.FormattingEnabled = true;
            this.cbBusqueda.Items.AddRange(new object[] {
            "Todos",
            "ID Organo",
            "Nombre del Organo",
            "Peso",
            "Fecha de Extraccion",
            "ID Donador"});
            this.cbBusqueda.Location = new System.Drawing.Point(171, 15);
            this.cbBusqueda.Name = "cbBusqueda";
            this.cbBusqueda.Size = new System.Drawing.Size(121, 21);
            this.cbBusqueda.TabIndex = 7;
            this.cbBusqueda.Text = "Todos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar Por ";
            // 
            // dtaOrganos
            // 
            this.dtaOrganos.AllowUserToAddRows = false;
            this.dtaOrganos.AllowUserToDeleteRows = false;
            this.dtaOrganos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaOrganos.Location = new System.Drawing.Point(13, 43);
            this.dtaOrganos.Name = "dtaOrganos";
            this.dtaOrganos.ReadOnly = true;
            this.dtaOrganos.Size = new System.Drawing.Size(544, 395);
            this.dtaOrganos.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(432, 13);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "button1";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(513, 13);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "button1";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(594, 14);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "button1";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // Organos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtaOrganos);
            this.Controls.Add(this.txtEspecifica);
            this.Controls.Add(this.cbBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrar);
            this.Name = "Organos";
            this.Text = "Organos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Organos_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtaOrganos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtEspecifica;
        private System.Windows.Forms.ComboBox cbBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtaOrganos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
    }
}