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
    public partial class Receptor_Datos : Form
    {
        public Receptor_Datos()
        {
            InitializeComponent();
        }

        public void CargarDatos(string id)
        {
            frmMenu mn = new frmMenu();
            var c = new MySqlConnection(mn.ConexDBGlobal);
            string cif = "SELECT * FROM receptor WHERE id_receptor='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(cif, c);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            string vcif = string.Empty;
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtID.Text = row["id_receptor"].ToString();
            }
            btnAgregar.Visible = false;
            txtID.ReadOnly = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMenu mn = new frmMenu();
                string query = "Insert Into receptor Values('"+txtID.Text+"', '"+txtNombre.Text+"', '"+txtAPA.Text+"', '"+txtAMA.Text+"', '"+cmbSangre.Text+"', '"
                    +txtEdad.Text+"', '"+cmbSexo.Text+"', b'"+IntaBit(cmbPago.Text)+"', '"+ txtMontoPago.Text+"', '"+txtNomRespon.Text+"', '"+txtFechaEspera.Text+"' , '"
                    +txtTelefono.Text+"', '"+ txtPais.Text+"', '"+ txtEstado.Text+"', '"+ txtRegion.Text+"', '"+ txtCiudad.Text+"', '"+txtDireccion+"');";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int IntaBit(string S)
        {
            if(S == "X")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
