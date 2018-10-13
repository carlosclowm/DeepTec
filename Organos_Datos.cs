using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepTec
{
    public partial class Organos_Datos : Form
    {
        public Organos_Datos()
        {
            InitializeComponent();
        }

        public void CargarDatos(string id)
        {
            btnAgregar.Visible = false;
            txtID.ReadOnly = true;
            frmMenu mn = new frmMenu();
            var c = new MySqlConnection(mn.ConexDBGlobal);
            string cif = "SELECT * FROM organos WHERE id_organo='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(cif, c);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            string vcif = string.Empty;

            try
            {
                DataRow row = dt.Rows[0];
                txtID.Text = row["id_organo"].ToString();
                txtNombreOrg.Text = row["nombre_organo"].ToString();
                //aqui empieza la batalla solamente para remplazar una coma por un punto
                System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
                customCulture.NumberFormat.NumberDecimalSeparator = ".";
                System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
                //aqui termina pero aun se burla de mi
                txtPeso.Text = Convert.ToDecimal(row["peso"], CultureInfo.CreateSpecificCulture("en-US")).ToString();
                DateTime d = Convert.ToDateTime(row["fecha_extraccion"]);
                txtFecha.Text = d.ToString("yyyy/MM/dd");
                txtIdDonador.Text = row["id_donador"].ToString();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMenu mn = new frmMenu();
                string query = "Insert Into organos Values('"+txtID.Text+"', '"+txtNombreOrg.Text+"', '"+txtPeso.Text
                    +"', '"+txtFecha.Text+"', '"+txtIdDonador.Text+"') ;";
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMenu mn = new frmMenu();
                string query = "Update organos Set nombre_organo='"+txtNombreOrg.Text+ "', peso='"+txtPeso.Text+ "', fecha_extraccion='"+txtFecha.Text+ "', id_donador='"+txtIdDonador.Text
                    + "' where id_organo='"+txtID.Text+"' ;";
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
