using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepTec
{
    public partial class usuarios : Form
    {
        private int rango;
        public usuarios()
        {
            InitializeComponent();
        }

        public void envia_rango(int ran)
        {
            rango = ran;
            if (rango == 1)
            {
               
            }
            else if (rango == 2)
            {
                
            }
            else if (rango == 3)
            {
                
            }
        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            recarga();
        }

        private void usuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenu mn = new frmMenu();
            mn.rango(rango.ToString());
            mn.Show();
            this.Dispose();
        }

        public void recarga()
        {
            frmMenu mn = new frmMenu();
            try
            {
                var consulta = "select * from usuarios;";
                var c = new MySqlConnection(mn.ConexDBGlobal);
                var adaptador = new MySqlDataAdapter(consulta, c);


                var ds = new DataSet();
                adaptador.Fill(ds);
                dtaUsuarios.ReadOnly = true;
                dtaUsuarios.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAgregar_Click(object sender, EventArgs e)
        {
            Usuarios_Datos UD = new Usuarios_Datos();
            UD.btnEditar.Visible = false;
            UD.Show();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            recarga();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese Borrar?", "Salir", MessageBoxButtons.YesNoCancel);
            switch (result)
            {
                case DialogResult.Yes:
                    frmMenu mn = new frmMenu();
                    string query = "Delete From usuarios Where id_usuario ='" + id + "'";
                    MySqlConnection Conn = new MySqlConnection(mn.ConexDBGlobal);
                    MySqlCommand cmd = new MySqlCommand(query, Conn);
                    MySqlDataReader Read;
                    try
                    {
                        Conn.Open();
                        Read = cmd.ExecuteReader();
                        MessageBox.Show("Borrado!");
                        while (Read.Read())
                        {

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    btnAct.PerformClick();
                    break;
                case DialogResult.No:
                    MessageBox.Show("No");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Cancel");
                    break;
            }
        }
        string id;
        private void dtaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dtaUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuarios_Datos UD = new Usuarios_Datos();
            UD.btnAgregar.Visible = false;
            UD.CargarDatos(id);
            UD.Show();
        }
    }
}
