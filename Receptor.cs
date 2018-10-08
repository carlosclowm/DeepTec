using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DeepTec
{
    public partial class Receptor : Form
    {
        public Receptor()
        {
            InitializeComponent();
        }

        public int rango;
        public void envia_rango(int ran)
        {
            rango = ran;
            if (rango == 1)
            {
                btnAgregar.Visible = true;
                btnEditar.Visible = true;
                btnEliminar.Visible = true;
            }
            else if (rango == 2)
            {
                btnAgregar.Visible = true;
                btnEditar.Visible = true;
                btnEliminar.Visible = false;
            }
            else if (rango == 3)
            {
                btnAgregar.Visible = false;
                btnEditar.Visible = false;
                btnEliminar.Visible = false;
            }
        }

        private void Receptor_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenu mn = new frmMenu();
            mn.rango(rango.ToString());
            mn.Show();
            this.Dispose();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            switch (cbBusqueda.Text)
            {
                case "Todos":
                    ConsultaDB("");
                    break;
                case "Id":
                    ConsultaDB(" where id_receptor='" + txtEspecifica.Text + "'");
                    break;
                case "Nombre":
                    ConsultaDB(" where nombre_receptor='" + txtEspecifica.Text + "'");
                    break;
                case "Apellido Paterno":
                    ConsultaDB(" where apa_receptor='" + txtEspecifica.Text + "'");
                    break;
                case "Apellido Materno":
                    ConsultaDB(" where ama_receptor='" + txtEspecifica.Text + "'");
                    break;
                case "Tipo de Sangre":
                    ConsultaDB(" where tipo_sangre_receptor='" + txtEspecifica.Text + "'");
                    break;
                case "Edad":
                    ConsultaDB(" where edad_receptor ='" + txtEspecifica.Text + "'");
                    break;
                case "Sexo":
                    ConsultaDB(" where sexo_receptor ='" + txtEspecifica.Text + "'");
                    break;
                case "Pais":
                    ConsultaDB(" where pais_receptor ='" + txtEspecifica.Text + "'");
                    break;
                case "Estado":
                    ConsultaDB(" where estado_receptor ='" + txtEspecifica.Text + "'");
                    break;
                case "Region":
                    ConsultaDB(" where region_receptor ='" + txtEspecifica.Text + "'");
                    break;
                case "Ciudad":
                    ConsultaDB(" where ciudad_receptor ='" + txtEspecifica.Text + "'");
                    break;
            }
        }
        private void ConsultaDB(string where)
        {
            frmMenu mn = new frmMenu();
            try
            {
                var consulta = "select * from receptor" + where + ";";
                var c = new MySqlConnection(mn.ConexDBGlobal);
                var adaptador = new MySqlDataAdapter(consulta, c);

                var commandBuilder = new MySqlCommandBuilder(adaptador);
                var ds = new DataSet();
                adaptador.Fill(ds);
                dtaReceptor.ReadOnly = true;
                dtaReceptor.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Receptor_Datos RD = new Receptor_Datos();
            RD.btnModificar.Visible = false;
            RD.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese Borrar?", "Salir", MessageBoxButtons.YesNoCancel);
            switch (result)
            {
                case DialogResult.Yes:
                    frmMenu mn = new frmMenu();
                    string query = "Delete From receptor Where id_receptor ='" + id_receptor + "'";
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
                    btnMostrar.PerformClick();
                    break;
                case DialogResult.No:
                    MessageBox.Show("No");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Cancel");
                    break;
            }
        }
        string id_receptor;
        private void dtaReceptor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_receptor = dtaReceptor.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Receptor_Datos RD = new Receptor_Datos();
            RD.CargarDatos(id_receptor);
            RD.Show();
        }
    }
}
