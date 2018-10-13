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
                txtNombre.Text = row["nombre_receptor"].ToString();
                txtAPA.Text = row["apa_receptor"].ToString();
                txtAMA.Text = row["ama_receptor"].ToString();
                cmbSangre.Text = row["tipo_sangre_receptor"].ToString();
                txtEdad.Text = row["edad_receptor"].ToString();
                cmbSexo.Text = row["sexo_receptor"].ToString();
                if(row["pago"].ToString() == "1")
                {
                    cmbPago.Text = "✓";
                }
                else
                {
                    cmbPago.Text = "X";
                }
                txtMontoPago.Text = row["cantidad_pago"].ToString();
                txtNomRespon.Text = row["nombre_responsable"].ToString();
                txtFechaEspera.Text = row["tiempo_espera"].ToString();
                txtTelefono.Text = row["telefono_receptor"].ToString();
                txtDireccion.Text = row["direccion"].ToString();
                txtPais.Text = row["pais_receptor"].ToString();
                txtEstado.Text = row["estado_receptor"].ToString();
                txtRegion.Text = row["region_receptor"].ToString();
                txtCiudad.Text = row["ciudad_receptor"].ToString();
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


        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMenu mn = new frmMenu();
                string query = "Update receptor set nombre_receptor='"+txtNombre.Text+ "', apa_receptor='"+txtAPA.Text+ "', ama_receptor='"+txtAMA.Text
                    + "', tipo_sangre_receptor='"+ cmbSangre.Text+ "', edad_receptor='"+txtEdad.Text+ "', sexo_receptor='"+cmbSexo.Text+ "', pago=b'"+IntaBit(cmbPago.Text)
                    + "', cantidad_pago='"+txtMontoPago.Text+ "', nombre_responsable='"+txtNomRespon.Text+ "', tiempo_espera='"+ txtFechaEspera.Text
                    + "', telefono_receptor='"+txtTelefono.Text+ "', pais_receptor='"+ txtPais.Text+ "', estado_receptor='"+ txtEstado.Text+ "', region_receptor='"+ txtRegion.Text
                    + "', ciudad_receptor='"+ txtCiudad.Text+ "', direccion='"+txtDireccion.Text+ "' where id_receptor='"+txtID.Text+"' ;";
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
