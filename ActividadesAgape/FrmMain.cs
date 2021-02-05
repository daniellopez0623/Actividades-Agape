using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                //Abrir ventana
                OpenContenedor.Close();
            }
            OpenContenedor = OpenFrm;
            OpenFrm.TopLevel = false;
            OpenFrm.FormBorderStyle = FormBorderStyle.None;
            OpenFrm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(OpenFrm);
            panelMain.Tag = OpenFrm;
            OpenFrm.BringToFront();
            OpenFrm.Show();

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            OpenPanelConten(new FrmEmpleados());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            OpenPanelConten(new FrmUsuarios());
        }

        private void btnActividads_Click(object sender, EventArgs e)
        {
            OpenPanelConten(new FrmActividades());
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            OpenPanelConten(new FrmSucursales());
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            OpenPanelConten(new FrmRegistros());
        }
    }
}
