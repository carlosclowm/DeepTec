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
    }
}
