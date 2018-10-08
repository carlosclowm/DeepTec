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
    }
}
