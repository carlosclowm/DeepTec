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
    public partial class Doctores_Datos : Form
    {
        public Doctores_Datos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMenu mn = new frmMenu();
                string query = "Insert Into doctor Values('"+txtCedula.Text+"', '"+txtNombre.Text+"', '"+txtApa.Text+"','"+txtAma.Text+"') ;";
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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarDatos(string id)
        {
            txtCedula.ReadOnly = true;
            frmMenu mn = new frmMenu();
            var c = new MySqlConnection(mn.ConexDBGlobal);
            string cif = "SELECT * FROM doctor WHERE cedula_doctor='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(cif, c);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            string vcif = string.Empty;

            try
            {
                DataRow row = dt.Rows[0];
                txtCedula.Text = row["cedula_doctor"].ToString();
                txtNombre.Text = row["nombre_doctor"].ToString();
                txtApa.Text = row["apa_doctor"].ToString();
                txtAma.Text = row["ama_doctor"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMenu mn = new frmMenu();
                string query = "Update doctor Set nombre_doctor='"+txtNombre.Text+ "', apa_doctor='"+txtApa.Text+ "', ama_doctor='"+txtAma.Text+ "' where cedula_doctor='"+txtCedula.Text+"' ;";
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
