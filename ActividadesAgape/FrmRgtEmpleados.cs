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
    public partial class FrmRgtEmpleados : Form
    {
        Empleados_N objEmp_N = new Empleados_N();

        public FrmRgtEmpleados()
        {
            InitializeComponent();
        }
        private void FrmRgtEmpleados_Load(object sender, EventArgs e)
        {
            dataGridViewEmpRgt.DataSource = objEmp_N.MostrandoEmpleados_N();
        }
     
        private void Nuevo()
        {
            foreach (Control tool in Controls)
            {
                if (tool is TextBox)
                {
                    tool.Text = "";
                }
                if (tool is MaskedTextBox)
                {
                    tool.Text = "";
                }             
            }
        }
        

        private void dataGridViewEmpRgt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIDEmp.Text = dataGridViewEmpRgt.CurrentRow.Cells[0].Value.ToString();
                txtCodigoEmpleado.Text = dataGridViewEmpRgt.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dataGridViewEmpRgt.CurrentRow.Cells[2].Value.ToString();
                txtApellido.Text = dataGridViewEmpRgt.CurrentRow.Cells[3].Value.ToString();
                txtEmail.Text = dataGridViewEmpRgt.CurrentRow.Cells[4].Value.ToString();
                mskTxtTelefono.Text = dataGridViewEmpRgt.CurrentRow.Cells[5].Value.ToString();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }
          
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
            dataGridViewEmpRgt.DataSource = objEmp_N.MostrandoEmpleados_N();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleados_E.IdEmpleado1 = int.Parse(txtIDEmp.Text);
                Empleados_E.CodigoEmpleado1 = int.Parse(txtCodigoEmpleado.Text);
                Empleados_E.Nombre1 = txtNombre.Text;
                Empleados_E.Apellido1 = txtApellido.Text;
                Empleados_E.Email1 = txtEmail.Text;
                Empleados_E.Telefono1 = mskTxtTelefono.Text;

                objEmp_N.EditandoEmpleados_N();

                dataGridViewEmpRgt.DataSource = objEmp_N.BuscandoAdminEmpleados_N();

                MessageBox.Show("Registro Editado");

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Empleados_E.IdEmpleado1 = int.Parse(txtIDEmp.Text);
                Empleados_E.CodigoEmpleado1 = int.Parse(txtCodigoEmpleado.Text);

                if (MessageBox.Show("Esta seguro que quiere eliminar el registro.", "Advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    objEmp_N.BorrandoEmpleados_N();

                MessageBox.Show("Registro Eliminado");

                dataGridViewEmpRgt.DataSource = objEmp_N.BuscandoAdminEmpleados_N();

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
                Empleados_E.CodigoEmpleado1 = int.Parse(txtCodigoEmpleado.Text);
                Empleados_E.Nombre1 = txtNombre.Text;
                Empleados_E.Apellido1 = txtApellido.Text;
                Empleados_E.Email1 = txtEmail.Text;
                Empleados_E.Telefono1 = mskTxtTelefono.Text;

                objEmp_N.GuardandoEmpleados_N();

                dataGridViewEmpRgt.DataSource = objEmp_N.BuscandoAdminEmpleados_N();

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
                Empleados_E.CodigoEmpleado1 = int.Parse(txtCodigoEmpleado.Text);

                dataGridViewEmpRgt.DataSource = objEmp_N.BuscandoAdminEmpleados_N();
            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }
    }
}
