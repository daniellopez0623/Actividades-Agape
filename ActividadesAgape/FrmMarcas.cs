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
    public partial class FrmMarcas : Form
    {
        Marcas_N objM_N = new Marcas_N();

        public FrmMarcas()
        {
            InitializeComponent();
        }
        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            dataGridViewMarcas.DataSource = objM_N.MostrandoMarcas_N();

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
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
            dataGridViewMarcas.DataSource = objM_N.MostrandoMarcas_N();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                Diviciones_E.IdMarcas1 = int.Parse(txtIDMarca.Text);
                Diviciones_E.AliasMarcas1 = txtAlias.Text;
                Diviciones_E.NombreMarcas1 = txtNameMarca.Text;

                objM_N.EditandoMarcas_N();

                dataGridViewMarcas.DataSource = objM_N.MostrandoMarcas_N();

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
                Diviciones_E.IdMarcas1 = int.Parse(txtIDMarca.Text);
                Diviciones_E.AliasMarcas1 = txtAlias.Text;

                if (MessageBox.Show("Esta seguro que quiere eliminar el registro.", "Advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    objM_N.BorrandoMarcas_N();

                dataGridViewMarcas.DataSource = objM_N.MostrandoMarcas_N();

                MessageBox.Show("Registro Borrado");
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
                Diviciones_E.AliasMarcas1 = txtAlias.Text;
                Diviciones_E.NombreMarcas1 = txtNameMarca.Text;

                objM_N.GuardandoMarcas_N();

                dataGridViewMarcas.DataSource = objM_N.MostrandoMarcas_N();

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
                Diviciones_E.AliasMarcas1 = txtAlias.Text;

                dataGridViewMarcas.DataSource = objM_N.BuscandoMarcas_N();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }

        private void dataGridViewMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIDMarca.Text = dataGridViewMarcas.CurrentRow.Cells[0].Value.ToString(); 
                txtAlias.Text = dataGridViewMarcas.CurrentRow.Cells[1].Value.ToString(); 
                txtNameMarca.Text = dataGridViewMarcas.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }
    }
}
