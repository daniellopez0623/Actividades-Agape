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
    public partial class FrmRegistros : Form
    {
        RegistroActividades_N objRgtN = new RegistroActividades_N();

        public FrmRegistros()
        {
            InitializeComponent();
        }
        private void Nuevo()
        {
            foreach (Control tool in Controls)
            {
                if (tool is TextBox)
                {
                    tool.Text = "";
                }
            }
        }
        private void OcultarDataGrid()
        {
            dataGridViewIDAct.Visible = false;
            dataGridViewIDRgt.Visible = false;
            dataGridViewIDScl.Visible = false;
        }
        private void DateLabels()
        {
            labelHoraRgt.Text = DateTime.Now.ToLongTimeString();
            labelFechaRgt.Text = DateTime.Now.ToShortDateString();
        }
        private void FrmRegistros_Load(object sender, EventArgs e)
        {
            dataGridViewRgt.DataSource = objRgtN.MostrandoRegistros_N();
            DateLabels();
            OcultarDataGrid();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dataGridViewIDAct.Visible = false;
            dataGridViewIDScl.Visible = false;
            Nuevo();
            dataGridViewRgt.DataSource = objRgtN.MostrandoRegistros_N();
        }

        private void timerRegistrar_Tick(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                RegistroActividades_E.IdActividades1 = int.Parse(txtIDAct.Text);
                RegistroActividades_E.IdSucursales1 = int.Parse(txtIDScl.Text);
                RegistroActividades_E.CodeEmpleados1 = int.Parse( txtCodEmp.Text);
                RegistroActividades_E.Hora1 = DateTime.Parse(labelHoraRgt.Text);
                RegistroActividades_E.Fecha1 = DateTime.Parse(labelFechaRgt.Text);

                objRgtN.GuardandoRegistros_N();

                dataGridViewRgt.DataSource = objRgtN.MostrandoRegistros_N();

                MessageBox.Show("Registro Guardado");
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

                dataGridViewRgt.DataSource = objRgtN.BuscandoRegistros_N();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
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
        private void dataGridViewIDAct_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void txtIDScl_Click(object sender, EventArgs e)
        {
            dataGridViewIDScl.DataSource = objRgtN.MostrandoRegistrosIDScl_N();
            dataGridViewIDScl.Visible = true;
            dataGridViewIDAct.Visible = false;
        }

        private void txtIDAct_Click(object sender, EventArgs e)
        {
            dataGridViewIDAct.DataSource = objRgtN.MostrandoRegistrosIDAct_N();
            dataGridViewIDAct.Visible = true;
            dataGridViewIDScl.Visible = false;
        }

      
    }
}
