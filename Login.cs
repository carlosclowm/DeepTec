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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private string conn;
        private MySqlConnection connect;
        public int rango;

        private void Conexion_db()
        {
            try
            {
                frmMenu mn = new frmMenu();
                conn = mn.ConexDBGlobal;
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException ex)
            {
                throw;
            }
        }
        /*
        public string Rango(int r)
        {
            if(r == 1)
            {
                return "Administrador";
            }else if(r == 2)
            {
                return "Doctor";
            }else if(r == 3)
            {
                return "Secretario";
            }
            else
            {
                return "";
            }
        }*/

        private bool Conexion_usuario(string usuario, string contraseña)
        {
            Conexion_db();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from usuarios where usuario=@user and contra=@pass";
            cmd.Parameters.AddWithValue("@user", usuario);
            cmd.Parameters.AddWithValue("@pass", contraseña);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }

        private void Loging()
        {
            string usuario = txtUser.Text;
            string contraseña = txtPass.Text;
            if (usuario == "" || contraseña == "")
            {
                MessageBox.Show("Usuario y contraseña Vacios!");
                return;
            }

            if (Conexion_usuario(usuario, contraseña))
            {
                frmMenu mn = new frmMenu();
                var c = new MySqlConnection(mn.ConexDBGlobal);
                string cif = "SELECT rango FROM usuarios WHERE usuario='" + usuario + "'";
                MySqlCommand cmd = new MySqlCommand(cif, c);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                string vcif = string.Empty;
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    mn.rango(Convert.ToString(row["rango"]));
                    rango = Convert.ToInt32(row["rango"]);

                }
                
                mn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y contraseña Incorrectos!");
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Loging();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                Loging();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
