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
    public partial class FrmRgtUsuarios : Form
    {
        Usuarios_N objUser_N = new Usuarios_N();

        public FrmRgtUsuarios()
        {
            InitializeComponent();
        }

        private void FrmRgtUsuarios_Load(object sender, EventArgs e)
        {
            dataGridViewRgtUser.DataSource = objUser_N.MostrandoUsuarios_N();
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
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            dataGridViewRgtUser.DataSource = objUser_N.MostrandoUsuarios_N();
            Nuevo();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Usuarios_E.IdUsuario1 = int.Parse(txtIdUser.Text);
                Usuarios_E.User1 = txtNameUser.Text;
                Usuarios_E.Pass1 = txtPassUser.Text;
                Usuarios_E.FechaCreacion1 = DateTime.Parse(dateTimePickerUsr.Text);
                Usuarios_E.Idrol1 = int.Parse(txtRol.Text);

                objUser_N.EditandoUsuarios_N();

                dataGridViewRgtUser.DataSource = objUser_N.MostrandoUsuarios_N();

                MessageBox.Show("Registro Editado");

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarios_E.IdUsuario1 = int.Parse(txtIdUser.Text);
                Usuarios_E.User1 = txtNameUser.Text;

                if (MessageBox.Show("Esta seguro que quiere eliminar el registro.", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                objUser_N.BorrandoUsuarios_N();

                MessageBox.Show("Registro Eliminado");

                dataGridViewRgtUser.DataSource = objUser_N.MostrandoUsuarios_N();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Usuarios_E.User1 = txtNameUser.Text;
                Usuarios_E.Pass1 = txtPassUser.Text;
                Usuarios_E.FechaCreacion1 = DateTime.Parse(dateTimePickerUsr.Text);
                Usuarios_E.Idrol1 = int.Parse( txtRol.Text);

                objUser_N.GuardandoUsuarios_N();

                dataGridViewRgtUser.DataSource = objUser_N.MostrandoUsuarios_N();

                MessageBox.Show("Registro Guardado");
            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Usuarios_E.User1 = txtNameUser.Text;

                dataGridViewRgtUser.DataSource = objUser_N.BuscandoAdmUsuarios_N();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }

        private void dataGridViewRgtUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //  txtRol.Text = dataGridViewRol.CurrentRow.Cells[0].Value.ToString(); 
                //  txtRol.Text = dataGridViewRol.CurrentRow.Cells[0].Value.ToString(); 
                //  txtRol.Text = dataGridViewRol.CurrentRow.Cells[0].Value.ToString(); 
                //  txtRol.Text = dataGridViewRol.CurrentRow.Cells[0].Value.ToString(); 
            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }
      
        private void txtRol_Click(object sender, EventArgs e)
        {
            dataGridViewRol.DataSource = objUser_N.MostrandoRoles_D();
            dataGridViewRol.Visible = true;
        }

        private void dataGridViewRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtRol.Text = dataGridViewRol.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }
    }
}
