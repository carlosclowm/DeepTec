namespace DeepTec
{
    partial class Receptor
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
            this.dtaReceptor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBusqueda = new System.Windows.Forms.ComboBox();
            this.txtEspecifica = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaReceptor)).BeginInit();
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
            // dtaReceptor
            // 
            this.dtaReceptor.AllowUserToAddRows = false;
            this.dtaReceptor.AllowUserToDeleteRows = false;
            this.dtaReceptor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaReceptor.Location = new System.Drawing.Point(13, 43);
            this.dtaReceptor.Name = "dtaReceptor";
            this.dtaReceptor.ReadOnly = true;
            this.dtaReceptor.RowHeadersVisible = false;
            this.dtaReceptor.Size = new System.Drawing.Size(775, 395);
            this.dtaReceptor.TabIndex = 1;
            this.dtaReceptor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaReceptor_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar Por ";
            // 
            // cbBusqueda
            // 
            this.cbBusqueda.FormattingEnabled = true;
            this.cbBusqueda.Items.AddRange(new object[] {
            "Id",
            "Nombre",
            "Apellido Paterno",
            "Apellido Materno",
            "Tipo de Sangre",
            "Edad",
            "Sexo",
            "Pais",
            "Estado",
            "Region",
            "Ciudad"});
            this.cbBusqueda.Location = new System.Drawing.Point(263, 15);
            this.cbBusqueda.Name = "cbBusqueda";
            this.cbBusqueda.Size = new System.Drawing.Size(121, 21);
            this.cbBusqueda.TabIndex = 4;
            this.cbBusqueda.Text = "Todos";
            // 
            // txtEspecifica
            // 
            this.txtEspecifica.Location = new System.Drawing.Point(390, 15);
            this.txtEspecifica.Name = "txtEspecifica";
            this.txtEspecifica.Size = new System.Drawing.Size(127, 20);
            this.txtEspecifica.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(546, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(627, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(708, 13);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Receptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtEspecifica);
            this.Controls.Add(this.cbBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtaReceptor);
            this.Controls.Add(this.btnMostrar);
            this.Name = "Receptor";
            this.Text = "Receptor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Receptor_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtaReceptor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dtaReceptor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBusqueda;
        private System.Windows.Forms.TextBox txtEspecifica;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
    }
}