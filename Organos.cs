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
    public partial class Organos : Form
    {
        public Organos()
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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            switch (cbBusqueda.Text)
            {
                case "Todos":
                    ConsultaDB("");
                    break;
                case "ID Organo":
                    ConsultaDB(" where id_organo='" + txtEspecifica.Text + "'");
                    break;
                case "Nombre del Organo":
                    ConsultaDB(" where nombre_organo='" + txtEspecifica.Text + "'");
                    break;
                case "Peso":
                    ConsultaDB(" where peso='" + txtEspecifica.Text + "'");
                    break;
                case "Fecha de Extraccion":
                    ConsultaDB(" where fecha_extraccion='" + txtEspecifica.Text + "'");
                    break;
                case "ID Donador":
                    ConsultaDB(" where id_donador='" + txtEspecifica.Text + "'");
                    break;


            }
        }

        private void ConsultaDB(string where)
        {
            frmMenu mn = new frmMenu();
            try
            {
                var consulta = "select * from organos" + where + ";";
                var c = new MySqlConnection(mn.ConexDBGlobal);
                var adaptador = new MySqlDataAdapter(consulta, c);

                var commandBuilder = new MySqlCommandBuilder(adaptador);
                var ds = new DataSet();
                adaptador.Fill(ds);
                dtaOrganos.ReadOnly = true;
                dtaOrganos.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Organos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenu mn = new frmMenu();
            mn.rango(rango.ToString());
            mn.Show();
            this.Dispose();
        }
    }
}
