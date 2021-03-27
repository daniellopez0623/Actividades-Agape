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
    public partial class FrmRegistrosAdm : Form
    {
        RegistroActividades_N objRgtN = new RegistroActividades_N();

        public FrmRegistrosAdm()
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

        private void FrmRegistrosAdm_Load(object sender, EventArgs e)
        {
            dataGridViewRgtAdm.DataSource = objRgtN.MostrandoAdmRegistros_N();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
            dataGridViewRgtAdm.DataSource = objRgtN.MostrandoAdmRegistros_N();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                RegistroActividades_E.IdRegistro1 = int.Parse(txtIDRgt.Text);
                RegistroActividades_E.CodeEmpleados1 = int.Parse(txtCodEmp.Text);

                if (MessageBox.Show("Esta seguro que quiere eliminar el registro.", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 

                objRgtN.BorrandoRegistros_N();

                MessageBox.Show("Registro Eliminado");

                dataGridViewRgtAdm.DataSource = objRgtN.MostrandoAdmRegistros_N();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                RegistroActividades_E.IdActividades1 = int.Parse(txtIDAct.Text);
                RegistroActividades_E.IdSucursales1 = int.Parse(txtIDScl.Text);
                RegistroActividades_E.CodeEmpleados1 = int.Parse(txtCodEmp.Text);
                RegistroActividades_E.Hora1 = DateTime.Parse(txtHora.Text);
                RegistroActividades_E.Fecha1 = DateTime.Parse(txtFecha.Text);

                objRgtN.GuardandoRegistros_N();

                dataGridViewRgtAdm.DataSource = objRgtN.MostrandoAdmRegistros_N();

                MessageBox.Show("Registro Guardado");
            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                RegistroActividades_E.IdRegistro1 = int.Parse(txtIDRgt.Text);
                RegistroActividades_E.IdActividades1 = int.Parse(txtIDAct.Text);
                RegistroActividades_E.IdSucursales1 = int.Parse(txtIDScl.Text);
                RegistroActividades_E.CodeEmpleados1 = int.Parse(txtCodEmp.Text);
                RegistroActividades_E.Hora1 = DateTime.Parse(txtHora.Text);
                RegistroActividades_E.Fecha1 = DateTime.Parse(txtFecha.Text);

                objRgtN.EditandoRegistros_N();

                dataGridViewRgtAdm.DataSource = objRgtN.MostrandoAdmRegistros_N();

                MessageBox.Show("Registro Editado");
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

                dataGridViewRgtAdm.DataSource = objRgtN.BuscandoAdmRegistros_N();

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
                txtIDScl.Text = dataGridViewIDSclAdm.CurrentRow.Cells[0].Value.ToString();
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
                txtIDAct.Text = dataGridViewIDActAdm.CurrentRow.Cells[0].Value.ToString();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }
     
        private void dataGridViewRgtAdm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIDRgt.Text = dataGridViewRgtAdm.CurrentRow.Cells[0].Value.ToString();
                txtCodEmp.Text = dataGridViewRgtAdm.CurrentRow.Cells[1].Value.ToString();
                txtIDAct.Text = dataGridViewRgtAdm.CurrentRow.Cells[2].Value.ToString();
                txtIDScl.Text = dataGridViewRgtAdm.CurrentRow.Cells[3].Value.ToString();
                txtHora.Text = dataGridViewRgtAdm.CurrentRow.Cells[4].Value.ToString();
                txtFecha.Text = dataGridViewRgtAdm.CurrentRow.Cells[5].Value.ToString();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }


        private void txtIDScl_Click(object sender, EventArgs e)
        {
            dataGridViewIDSclAdm.DataSource = objRgtN.MostrandoRegistrosIDScl_N();
            dataGridViewIDSclAdm.Visible = true;
            dataGridViewIDActAdm.Visible = false;
        }

        private void txtIDAct_Click(object sender, EventArgs e)
        {
            dataGridViewIDActAdm.DataSource = objRgtN.MostrandoRegistrosIDAct_N();
            dataGridViewIDActAdm.Visible = true;
            dataGridViewIDSclAdm.Visible = false;
        }
    }
}
