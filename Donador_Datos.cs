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
    public partial class Donador_Agregar : Form
    {
        public Donador_Agregar()
        {
            InitializeComponent();
        }


        public void CargarDatos(string id)
        {
            frmMenu mn = new frmMenu();
            var c = new MySqlConnection(mn.ConexDBGlobal);
            string cif = "SELECT * FROM donador WHERE id_donador='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(cif, c);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            string vcif = string.Empty;
            
            {
                try
                {
                    DataRow row = dt.Rows[0];

                    txtID_Donador.Text = row["id_donador"].ToString();
                    txtNombre.Text = row["nombre_donador"].ToString();
                    txtApa.Text = row["apa_donador"].ToString();
                    txtAma.Text = row["ama_donador"].ToString();
                    cmbSangre.Text = row["tipo_sangre_donador"].ToString();
                    txtEdad.Text = row["edad_donador"].ToString();
                    if (row["apto"].ToString() == "1")
                    {
                        cmbApto.Text = "Si";
                    }
                    else
                    {
                        cmbApto.Text = "No";
                    }
                    txtDescApto.Text = row["desc_apto"].ToString();
                    txtConsentimiento.Text = row["consentimiento"].ToString();
                    cmbSexo.Text = row["sexo_donador"].ToString();
                    if (row["estatus_vida"].ToString() == "1")
                    {
                        cmbEstadoVida.Text = "Vivo";
                    }
                    else
                    {
                        cmbEstadoVida.Text = "Muerto";
                    }
                    txtTelefono.Text = row["telefono_donador"].ToString();
                    txtDireccion.Text = row["direccion"].ToString();
                    txtPais.Text = row["pais_donador"].ToString();
                    txtEstado.Text = row["estado_donador"].ToString();
                    txtRegion.Text = row["region_donador"].ToString();
                    txtCiudad.Text = row["ciudad_donador"].ToString();
                }catch(Exception ex)
                {
                    MessageBox.Show("Seleccione un Campo Valido", ex.Message);
                    
                }
                
            }

            btnAgregar.Visible = false;
            txtID_Donador.ReadOnly = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            try
            {

                frmMenu mn = new frmMenu();
                
                string Query = "insert into donador values('" + txtID_Donador.Text + "','" + txtNombre.Text + "','"+ txtApa.Text + "','" + txtAma.Text + "'," +
                    "'" + cmbSangre.Text + "','" + txtEdad.Text + "',b'" + ConvApto(cmbApto.Text) + "','" + txtDescApto.Text + "','" + txtConsentimiento.Text + "'," +
                    "'" + cmbSexo.Text + "',b'" + ConvVida(cmbEstadoVida.Text) + "','" + txtTelefono.Text + "','" + txtPais.Text + "','" + txtEstado.Text + "'," +
                    "'" + txtRegion.Text + "','" + txtCiudad.Text + "','" + txtDireccion.Text + "');";
                  
                MySqlConnection MyConn2 = new MySqlConnection(mn.ConexDBGlobal);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
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

        private int ConvVida(string t)
        {
            if(t == "Vivo")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private int ConvApto(string t)
        {
            if(t == "Si")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMenu mn = new frmMenu();
                string query = "Update donador set nombre_donador='" + txtNombre.Text+"', "+ "apa_donador='"+ txtApa.Text+ "', " + "ama_donador='" + txtAma.Text + "', "
                    + "tipo_sangre_donador='" + cmbSangre.Text + "', " + "edad_donador='" + txtEdad.Text + "', " + "apto=b'" + ConvApto(cmbApto.Text) + "', "
                    + "desc_apto='" + txtDescApto.Text + "', " + "consentimiento='" + txtConsentimiento.Text + "', " + "sexo_donador='" + cmbSexo.Text + "', "
                    + "estatus_vida=b'" + ConvVida(cmbEstadoVida.Text) + "', " + "telefono_donador='" + txtTelefono.Text + "', " + "pais_donador='" + txtPais.Text + "', "
                    + "estado_donador='" + txtEstado.Text + "', " + "region_donador='" + txtRegion.Text + "', " + "ciudad_donador='" + txtCiudad.Text + "', " + "direccion='" + txtDireccion.Text + "'"
                    + "where id_donador='"+txtID_Donador.Text+"';";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Donador_Agregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            this.Dispose();
        }
    }
}
