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
    public partial class frmMenu : Form
    {
        public string ConexDBGlobal = "server=localhost; database=trasplante_de_organos; Uid=root; pwd=peluche785;SslMode=none";
        private int RangoGlobal;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void Iniciar_Rango(int rango)
        {
            if(rango == 1)
            {
                btnUsuarios.Visible = true;
            }
            else
            {
                btnUsuarios.Visible = false;
            }
        }

        private void btnDonador_Click(object sender, EventArgs e)
        {
            Donador dn = new Donador();
            dn.Show();
            dn.envia_rango(RangoGlobal);
            this.Close();


        }

        public void rango(string ran)
        {
            RangoGlobal = Convert.ToInt32(ran);
            if (RangoGlobal == 1)
            {
                lblRango.Text = "Administrador";
            }else if(RangoGlobal == 2)
            {
                lblRango.Text = "Especialista";
            }else if(RangoGlobal == 3)
            {
                lblRango.Text = "Secretario";
            }
            Iniciar_Rango(RangoGlobal);

        }




        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btnReceptores_Click(object sender, EventArgs e)
        {
            Receptor rc = new Receptor();
            rc.envia_rango(RangoGlobal);
            rc.Show();
            this.Hide();
        }

        private void btnTrasplantes_Click(object sender, EventArgs e)
        {
            Trasplantes ts = new Trasplantes();
            ts.envia_rango(RangoGlobal);
            ts.Show();
            this.Hide();
        }

        private void btnOrganos_Click(object sender, EventArgs e)
        {
            Organos or = new Organos();
            or.envia_rango(RangoGlobal);
            or.Show();
            this.Hide();
        }

        private void btnDoctores_Click(object sender, EventArgs e)
        {
            Doctores dc = new Doctores();
            dc.Show();
            this.Hide();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmLogin lg = new frmLogin();
            this.Close();
            lg.Show();
        }
    }
}
