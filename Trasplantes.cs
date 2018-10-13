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
    public partial class Trasplantes : Form
    {
        public Trasplantes()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            switch (cbBusqueda.Text)
            {
                case "Todos":
                    ConsultaDB("");
                    break;
                case "Clave del Trasplante":
                    ConsultaDB(" where clave_trasplante ='" + txtEspecifica.Text + "'");
                    break;
                case "ID Organo":
                    ConsultaDB(" where id_organo ='" + txtEspecifica.Text + "'");
                    break;
                case "ID Donador":
                    ConsultaDB(" where id_donador ='" + txtEspecifica.Text + "'");
                    break;
                case "ID Receptor":
                    ConsultaDB(" where id_recpetor ='" + txtEspecifica.Text + "'");
                    break;
                case "Cedula del Doctor":
                    ConsultaDB(" where cedula_doctor ='" + txtEspecifica.Text + "'");
                    break;
                case "Fecha de Cirugia":
                    ConsultaDB(" where fecha_cirugia ='" + txtEspecifica.Text + "'");
                    break;
            }
        }
        private void ConsultaDB(string where)
        {
            frmMenu mn = new frmMenu();
            try
            {
                var consulta = "select * from trasplante" + where + ";";
                var c = new MySqlConnection(mn.ConexDBGlobal);
                var adaptador = new MySqlDataAdapter(consulta, c);

                var commandBuilder = new MySqlCommandBuilder(adaptador);
                var ds = new DataSet();
                adaptador.Fill(ds);
                dtaTrasplante.ReadOnly = true;
                dtaTrasplante.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Trasplantes_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenu mn = new frmMenu();
            mn.rango(rango.ToString());
            mn.Show();
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Trasplantes_Datos TD = new Trasplantes_Datos();
            TD.Show();
            TD.btnModificar.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese Borrar?", "Salir", MessageBoxButtons.YesNoCancel);
            switch (result)
            {
                case DialogResult.Yes:
                    frmMenu mn = new frmMenu();
                    string query = "Delete From trasplante Where clave_trasplante ='" + id_trasplante + "'";
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
        string id_trasplante;
        private void dtaTrasplante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_trasplante = dtaTrasplante.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Trasplantes_Datos TD = new Trasplantes_Datos();
            TD.btnAgregar.Visible = false;
            TD.CargaDatos(id_trasplante);
            TD.Show();
        }
    }
}
