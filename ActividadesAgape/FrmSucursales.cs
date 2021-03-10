using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;

namespace ActividadesAgape
{
    public partial class FrmSucursales : Form
    {
        Sucursales_N objScl_N = new Sucursales_N();
        public FrmSucursales()
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
            panelRgtScl.Controls.Add(OpenFrm);
            panelRgtScl.Tag = OpenFrm;
            OpenFrm.BringToFront();
            OpenFrm.Show();
        }
        private void FrmSucursales_Load(object sender, EventArgs e)
        {
            dataGridViewRgtScl.DataSource = objScl_N.MostrandoSucursales_N();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Sucursales_E.NombreSucursal1 = txtNombreScl.Text;

                dataGridViewRgtScl.DataSource = objScl_N.BuscandoSucursales_N();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            OpenPanelConten(new FrmRgtSucursales());
        }
    }
}
