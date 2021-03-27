using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Entidades;
using ActividadesAgape;


namespace ActividadesAgape
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private Form OpenContenedor;
        private void OpenPanelConten(Form OpenFrm)
        {
            if (OpenContenedor != null)
            {
                OpenContenedor.Close();
            }
            OpenContenedor = OpenFrm;
            OpenFrm.TopLevel = false;
            OpenFrm.FormBorderStyle = FormBorderStyle.None;
            OpenFrm.Dock = DockStyle.Fill;
            panelMain2.Controls.Add(OpenFrm);
            panelMain2.Tag = OpenFrm;
            OpenFrm.BringToFront();
            OpenFrm.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            PanelTools.Visible = false;

            DatosUser();
            RolesUser();
            DateLabels();
        }
        private void DatosUser()
        {
            labelUser.Text = ($" {Usuarios_E.User1} ");
            labelRol.Text = ($" ({Usuarios_E.NombreRol}).");
        }
        private void DateLabels()
        {
            labelHora.Text = DateTime.Now.ToShortTimeString();
            labelFecha.Text = DateTime.Now.ToShortDateString();
        }
        private void RolesUser()
        {
            //if (E_Usuarios.Cargo1 == E_Cargos.General)
            //{
            //    btnUsuarios.Enabled = false;
            //}
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que quiere cerrar sesion ", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();

            
        }

        private void ButtonAcerca_Click(object sender, EventArgs e)
        {
            OpenPanelConten(new FrmAcerca());
        }

        private void ButtonSucursales_Click(object sender, EventArgs e)
        {
            OpenPanelConten(new FrmSucursales());
        }

        private void ButtonEmpleados_Click(object sender, EventArgs e)
        {
            OpenPanelConten(new FrmEmpleados());
        }

        private void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            OpenPanelConten(new FrmVWRegistros());
        }

        private void ButtonActividades_Click(object sender, EventArgs e)
        {
            OpenPanelConten(new FrmActividades());
        }

        private void ButtonUsuarios_Click(object sender, EventArgs e)
        {
            OpenPanelConten(new FrmRgtUsuarios());
        }

        private void ButtonMarcas_Click(object sender, EventArgs e)
        {
            OpenPanelConten(new FrmMarcas());
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que quiere salir", "Advertencia",
             MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (bunifuGradientPanel1.Width == 312)
            {
                bunifuGradientPanel1.Visible = false;
                bunifuGradientPanel1.Width = 95;
                panelMenuLeft.Width = 150;
                linea1.Width = 75;
                linea2.Width = 75;
                linea3.Width = 75;
                Animacion.Show(bunifuGradientPanel1);
            }
            else
            {
                bunifuGradientPanel1.Visible = false;
                bunifuGradientPanel1.Width = 312;
                panelMenuLeft.Width = 312;
                linea1.Width = 265;
                linea2.Width = 265;
                linea3.Width = 265;
                backAni.Show(bunifuGradientPanel1);
            }
            PanelTools.Visible = false;

        }
        private void ButtonTools_Click(object sender, EventArgs e) //Handles
        {
           
            PanelTools.Visible = true;
        }
         
        private void bunifuGradientPanel1_MouseLeave(object sender, EventArgs e)
        {
          //  PanelTools.Visible = false;

        }

        private void PanelTools_MouseLeave(object sender, EventArgs e)
        {
           // PanelTools.Visible = false;
        }
    }
}
