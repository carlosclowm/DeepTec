namespace DeepTec
{
    partial class frmMenu
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
            this.lblTituloMenu = new System.Windows.Forms.Label();
            this.btnDonador = new System.Windows.Forms.Button();
            this.btnReceptores = new System.Windows.Forms.Button();
            this.btnDoctores = new System.Windows.Forms.Button();
            this.btnOrganos = new System.Windows.Forms.Button();
            this.btnTrasplantes = new System.Windows.Forms.Button();
            this.lblRango = new System.Windows.Forms.Label();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloMenu
            // 
            this.lblTituloMenu.AutoSize = true;
            this.lblTituloMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMenu.Location = new System.Drawing.Point(37, 9);
            this.lblTituloMenu.Name = "lblTituloMenu";
            this.lblTituloMenu.Size = new System.Drawing.Size(278, 20);
            this.lblTituloMenu.TabIndex = 0;
            this.lblTituloMenu.Text = "Sistema de Donacion de Organos";
            // 
            // btnDonador
            // 
            this.btnDonador.Location = new System.Drawing.Point(12, 70);
            this.btnDonador.Name = "btnDonador";
            this.btnDonador.Size = new System.Drawing.Size(105, 23);
            this.btnDonador.TabIndex = 1;
            this.btnDonador.Text = "Donadores";
            this.btnDonador.UseVisualStyleBackColor = true;
            this.btnDonador.Click += new System.EventHandler(this.btnDonador_Click);
            // 
            // btnReceptores
            // 
            this.btnReceptores.Location = new System.Drawing.Point(241, 70);
            this.btnReceptores.Name = "btnReceptores";
            this.btnReceptores.Size = new System.Drawing.Size(104, 23);
            this.btnReceptores.TabIndex = 2;
            this.btnReceptores.Text = "Receptores";
            this.btnReceptores.UseVisualStyleBackColor = true;
            this.btnReceptores.Click += new System.EventHandler(this.btnReceptores_Click);
            // 
            // btnDoctores
            // 
            this.btnDoctores.Location = new System.Drawing.Point(138, 174);
            this.btnDoctores.Name = "btnDoctores";
            this.btnDoctores.Size = new System.Drawing.Size(81, 23);
            this.btnDoctores.TabIndex = 3;
            this.btnDoctores.Text = "Doctores";
            this.btnDoctores.UseVisualStyleBackColor = true;
            this.btnDoctores.Click += new System.EventHandler(this.btnDoctores_Click);
            // 
            // btnOrganos
            // 
            this.btnOrganos.Location = new System.Drawing.Point(138, 128);
            this.btnOrganos.Name = "btnOrganos";
            this.btnOrganos.Size = new System.Drawing.Size(81, 23);
            this.btnOrganos.TabIndex = 4;
            this.btnOrganos.Text = "Organos";
            this.btnOrganos.UseVisualStyleBackColor = true;
            this.btnOrganos.Click += new System.EventHandler(this.btnOrganos_Click);
            // 
            // btnTrasplantes
            // 
            this.btnTrasplantes.Location = new System.Drawing.Point(138, 86);
            this.btnTrasplantes.Name = "btnTrasplantes";
            this.btnTrasplantes.Size = new System.Drawing.Size(81, 23);
            this.btnTrasplantes.TabIndex = 5;
            this.btnTrasplantes.Text = "Trasplantes";
            this.btnTrasplantes.UseVisualStyleBackColor = true;
            this.btnTrasplantes.Click += new System.EventHandler(this.btnTrasplantes_Click);
            // 
            // lblRango
            // 
            this.lblRango.AutoSize = true;
            this.lblRango.Location = new System.Drawing.Point(9, 191);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(39, 13);
            this.lblRango.TabIndex = 6;
            this.lblRango.Text = "Rango";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(12, 155);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(105, 23);
            this.btnUsuarios.TabIndex = 7;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Visible = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(265, 191);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(91, 23);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 213);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.lblRango);
            this.Controls.Add(this.btnTrasplantes);
            this.Controls.Add(this.btnOrganos);
            this.Controls.Add(this.btnDoctores);
            this.Controls.Add(this.btnReceptores);
            this.Controls.Add(this.btnDonador);
            this.Controls.Add(this.lblTituloMenu);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloMenu;
        private System.Windows.Forms.Button btnDonador;
        private System.Windows.Forms.Button btnReceptores;
        private System.Windows.Forms.Button btnDoctores;
        private System.Windows.Forms.Button btnOrganos;
        private System.Windows.Forms.Button btnTrasplantes;
        public System.Windows.Forms.Label lblRango;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}

