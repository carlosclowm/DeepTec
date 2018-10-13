namespace DeepTec
{
    partial class usuarios
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
            this.dtaUsuarios = new System.Windows.Forms.DataGridView();
            this.txtAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaUsuarios
            // 
            this.dtaUsuarios.AllowUserToAddRows = false;
            this.dtaUsuarios.AllowUserToDeleteRows = false;
            this.dtaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaUsuarios.Location = new System.Drawing.Point(12, 37);
            this.dtaUsuarios.Name = "dtaUsuarios";
            this.dtaUsuarios.ReadOnly = true;
            this.dtaUsuarios.RowHeadersVisible = false;
            this.dtaUsuarios.Size = new System.Drawing.Size(406, 235);
            this.dtaUsuarios.TabIndex = 0;
            this.dtaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaUsuarios_CellClick);
            // 
            // txtAgregar
            // 
            this.txtAgregar.Location = new System.Drawing.Point(55, 8);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(75, 23);
            this.txtAgregar.TabIndex = 1;
            this.txtAgregar.Text = "Agregar";
            this.txtAgregar.UseVisualStyleBackColor = true;
            this.txtAgregar.Click += new System.EventHandler(this.txtAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(136, 8);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(217, 8);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(343, 8);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(75, 23);
            this.btnAct.TabIndex = 4;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 284);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtAgregar);
            this.Controls.Add(this.dtaUsuarios);
            this.Name = "usuarios";
            this.Text = "usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.usuarios_FormClosed);
            this.Load += new System.EventHandler(this.usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaUsuarios;
        private System.Windows.Forms.Button txtAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAct;
    }
}