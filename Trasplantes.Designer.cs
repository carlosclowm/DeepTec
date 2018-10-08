namespace DeepTec
{
    partial class Trasplantes
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
            this.dtaTrasplante = new System.Windows.Forms.DataGridView();
            this.txtEspecifica = new System.Windows.Forms.TextBox();
            this.cbBusqueda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaTrasplante)).BeginInit();
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
            this.btnMostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtaTrasplante
            // 
            this.dtaTrasplante.AllowUserToAddRows = false;
            this.dtaTrasplante.AllowUserToDeleteRows = false;
            this.dtaTrasplante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaTrasplante.Location = new System.Drawing.Point(13, 43);
            this.dtaTrasplante.Name = "dtaTrasplante";
            this.dtaTrasplante.ReadOnly = true;
            this.dtaTrasplante.Size = new System.Drawing.Size(775, 395);
            this.dtaTrasplante.TabIndex = 1;
            // 
            // txtEspecifica
            // 
            this.txtEspecifica.Location = new System.Drawing.Point(402, 11);
            this.txtEspecifica.Name = "txtEspecifica";
            this.txtEspecifica.Size = new System.Drawing.Size(127, 20);
            this.txtEspecifica.TabIndex = 8;
            // 
            // cbBusqueda
            // 
            this.cbBusqueda.FormattingEnabled = true;
            this.cbBusqueda.Items.AddRange(new object[] {
            "Todos",
            "Clave del Trasplante",
            "ID Organo",
            "ID Donador",
            "ID Receptor",
            "Cedula del Doctor",
            "Fecha de Cirugia"});
            this.cbBusqueda.Location = new System.Drawing.Point(275, 12);
            this.cbBusqueda.Name = "cbBusqueda";
            this.cbBusqueda.Size = new System.Drawing.Size(121, 21);
            this.cbBusqueda.TabIndex = 7;
            this.cbBusqueda.Text = "Todos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar Por ";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(546, 10);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "button1";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(627, 9);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "button2";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(708, 9);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "button3";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // Trasplantes
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
            this.Controls.Add(this.dtaTrasplante);
            this.Controls.Add(this.btnMostrar);
            this.Name = "Trasplantes";
            this.Text = "Trasplantes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Trasplantes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtaTrasplante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dtaTrasplante;
        private System.Windows.Forms.TextBox txtEspecifica;
        private System.Windows.Forms.ComboBox cbBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
    }
}