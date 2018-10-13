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
    public partial class Trasplantes_Datos : Form
    {
        public Trasplantes_Datos()
        {
            InitializeComponent();
        }

        private int StrToInt(string s)
        {
            if(s == "Exitosa")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMenu mn = new frmMenu();
                string query = "Insert Into trasplante Values('"+txtID.Text+"', '"+txtIdOrgano.Text+"', '"+txtIdDonador.Text+"', '"+txtIdReceptor.Text+"', '"+txtCedulaDoctor.Text+"', '"+txtFecha.Text+"', b'"+ StrToInt(cmbEstado.Text)+"');";
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
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargaDatos(string id)
        {
            txtID.ReadOnly = true;
            frmMenu mn = new frmMenu();
            var c = new MySqlConnection(mn.ConexDBGlobal);
            string cif = "SELECT * FROM trasplante WHERE clave_trasplante='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(cif, c);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            string vcif = string.Empty;

            try
            {
                DataRow row = dt.Rows[0];
                txtID.Text = row["clave_trasplante"].ToString();
                txtIdOrgano.Text = row["id_organo"].ToString();
                txtIdDonador.Text = row["id_donador"].ToString();
                txtIdReceptor.Text = row["id_receptor"].ToString();
                txtCedulaDoctor.Text = row["cedula_doctor"].ToString();
                DateTime d = Convert.ToDateTime( row["fecha_cirugia"]);

                txtFecha.Text = d.ToString("yyyy/MM/dd");
                if(row["estatus_cirugia"].ToString() == "1")
                {
                    cmbEstado.Text = "Exitosa";
                }
                else
                {
                    cmbEstado.Text = "Fallida";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMenu mn = new frmMenu();
                string query = "Update trasplante Set id_organo='" + txtIdOrgano.Text + "', id_donador='" + txtIdDonador.Text
                    + "', id_receptor='" + txtIdReceptor.Text + "', cedula_doctor='" + txtCedulaDoctor.Text + "', fecha_cirugia='" + txtFecha.Text +
                    "', estatus_cirugia=b'" + StrToInt(cmbEstado.Text) 
                    + "' where clave_trasplante='"+txtID.Text+"' ;";
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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
