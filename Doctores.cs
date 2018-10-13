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
    public partial class Doctores : Form
    {
        public Doctores()
        {
            InitializeComponent();
        }

        private void Doctores_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenu mn = new frmMenu();
            mn.rango(rango.ToString());
            mn.Show();
            this.Dispose();
        }

        private int rango;
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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            switch (cbBusqueda.Text)
            {
                case "Todos":
                    ConsultaDB("");
                    break;
                case "Cedula del Doctor":
                    ConsultaDB(" where cedula_doctor='" + txtEspecifica.Text + "'");
                    break;
                case "Nombre":
                    ConsultaDB(" where nombre_doctor='" + txtEspecifica.Text + "'");
                    break;
                case "Apellido Paterno":
                    ConsultaDB(" where apa_doctor='" + txtEspecifica.Text + "'");
                    break;
                case "Apellido Materno":
                    ConsultaDB(" where ama_doctor='" + txtEspecifica.Text + "'");
                    break;
            }
        }
        private void ConsultaDB(string where)
        {
            frmMenu mn = new frmMenu();
            try
            {
                var consulta = "select * from doctor" + where + ";";
                var c = new MySqlConnection(mn.ConexDBGlobal);
                var adaptador = new MySqlDataAdapter(consulta, c);

                var commandBuilder = new MySqlCommandBuilder(adaptador);
                var ds = new DataSet();
                adaptador.Fill(ds);
                dtaDoctores.ReadOnly = true;
                dtaDoctores.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Doctores_Datos DT = new Doctores_Datos();
            DT.btnEditar.Visible = false;
            DT.Show();
        }

        string cedula = "";
        private void dtaDoctores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cedula = dtaDoctores.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese Borrar?", "Salir", MessageBoxButtons.YesNoCancel);
            switch (result)
            {
                case DialogResult.Yes:
                    frmMenu mn = new frmMenu();
                    string query = "Delete From doctor Where cedula_doctor ='" + cedula + "'";
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Doctores_Datos DT = new Doctores_Datos();
            DT.btnAgregar.Visible = false;
            DT.CargarDatos(cedula);
            DT.Show();
        }
    }
}
