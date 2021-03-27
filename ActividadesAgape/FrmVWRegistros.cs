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
    public partial class FrmVWRegistros : Form
    {
        RegistroActividades_N objRgtN = new RegistroActividades_N();
        public FrmVWRegistros()
        {
            InitializeComponent();
        }
        private void NuevoVW()
        {
            foreach (Control tool in Controls)
            {
                if (tool is TextBox)
                {
                    tool.Text = "";
                }
            }
        }
        private void FrmVWRegistros_Load(object sender, EventArgs e)
        {
            //
            dataGridViewIDAct.Visible = false;
            dataGridViewIDScl.Visible = false;
            dataGridVWRgt.DataSource = objRgtN.MostrandoAdmRegistros_N();
        }

        private void labelCodEm_Click(object sender, EventArgs e)
        {
           // dataGridViewBusquedas.DataSource = objRgtN
        }      
        private void dataGridViewIDScl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIDScl.Text = dataGridViewIDScl.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }

        private void dataGridViewIDAct_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIDAct.Text = dataGridViewIDAct.CurrentRow.Cells[0].Value.ToString();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                RegistroActividades_E.IdActividades1 = int.Parse(txtIDAct.Text);
                RegistroActividades_E.IdSucursales1 = int.Parse(txtIDScl.Text);
                RegistroActividades_E.CodeEmpleados1 = int.Parse(txtCodEmp.Text);

                dataGridVWRgt.DataSource = objRgtN.BuscandoRegistros_N();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoVW();
            dataGridViewIDAct.Visible = false;
            dataGridViewIDScl.Visible = false;
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
            panelRgtVW.Controls.Add(OpenFrm);
            panelRgtVW.Tag = OpenFrm;
            OpenFrm.BringToFront();
            OpenFrm.Show();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            OpenPanelConten(new FrmRegistros());

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            OpenPanelConten(new FrmRegistrosAdm());

        }
             
        private void txtIDScl_Click(object sender, EventArgs e)
        {
            dataGridViewIDAct.Visible = false;
            dataGridViewIDScl.DataSource = objRgtN.MostrandoRegistrosIDScl_N();
            dataGridViewIDScl.Visible = true;
        }

        private void txtIDAct_Click(object sender, EventArgs e)
        {
            dataGridViewIDScl.Visible = false;
            dataGridViewIDAct.DataSource = objRgtN.MostrandoRegistrosIDAct_N();
            dataGridViewIDAct.Visible = true;
        }
    }
}
