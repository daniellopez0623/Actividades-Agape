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

        private void FrmVWRegistros_Load(object sender, EventArgs e)
        {
            //
            dataGridViewIDAct.Visible = false;
            dataGridViewIDScl.Visible = false;
            dataGridViewScl.DataSource = objRgtN.MostrandoAdmRegistros_N();
        }

        private void labelIDScl_Click(object sender, EventArgs e)
        {
            dataGridViewIDAct.Visible = false;
            dataGridViewIDScl.DataSource = objRgtN.MostrandoRegistrosIDScl_N();
            dataGridViewIDScl.Visible = true;
        }

        private void labelIDAct_Click(object sender, EventArgs e)
        {
            dataGridViewIDScl.Visible = false;
            dataGridViewIDAct.DataSource = objRgtN.MostrandoRegistrosIDAct_N();
            dataGridViewIDAct.Visible = true;

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

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
