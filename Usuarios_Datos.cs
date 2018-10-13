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
    public partial class Usuarios_Datos : Form
    {
        public Usuarios_Datos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMenu mn = new frmMenu();
                string query = "Insert Into usuarios Values('"+txtID.Text+"', '"+txtUsuario.Text+"', '"+txtContraseña.Text+"', '"+txtRango.Text+"') ;";
                MySqlConnection MyConn2 = new MySqlConnection(mn.ConexDBGlobal);
                MySqlCommand MyCommand2 = new MySqlCommand(query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Datos Guardados!");
                this.Close();
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarDatos(string id)
        {
            txtID.ReadOnly = true;

            frmMenu mn = new frmMenu();
            var c = new MySqlConnection(mn.ConexDBGlobal);
            string cif = "SELECT * FROM usuarios WHERE id_usuario='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(cif, c);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            string vcif = string.Empty;
            try
            {
                DataRow row = dt.Rows[0];
                txtID.Text = row["id_usuario"].ToString();
                txtUsuario.Text = row["usuario"].ToString();
                txtContraseña.Text = row["contra"].ToString();
                txtRango.Text = row["rango"].ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMenu mn = new frmMenu();
                string query = "Update usuarios Set usuario='"+txtUsuario.Text+ "', contra='"+txtContraseña.Text+ "', rango='"+txtRango.Text+"' where id_usuario='"+txtID.Text+"';";
                MySqlConnection conn = new MySqlConnection(mn.ConexDBGlobal);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader Read;
                conn.Open();
                Read = cmd.ExecuteReader();
                MessageBox.Show("Datos Actualizados");
                while (Read.Read())
                {

                }
                conn.Close();
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
