using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Entidades;

namespace ActividadesAgape
{
    public partial class FrmRgtSucursales : Form
    {
        Sucursales_N objScl_N = new Sucursales_N();

        public FrmRgtSucursales()
        {
            InitializeComponent();
        }

        private void FrmRgtSucursales_Load(object sender, EventArgs e)
        {
            
            dataGridViewIDMarc.DataSource = objScl_N.MostrandoMarcaSucursales_N();
            dataGridViewIDMarc.Visible = false;
            dataGridViewSclRgt.DataSource = objScl_N.MostrandoAdmSucursales_N();
            
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
            dataGridViewSclRgt.DataSource = objScl_N.MostrandoAdmSucursales_N();
            dataGridViewIDMarc.Visible = false;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                Sucursales_E.IdSucursal1 = int.Parse(txtScl.Text);
                Sucursales_E.IdDiviciones1 = int.Parse(txtMarca.Text);
                Sucursales_E.NombreSucursal1 = txtNombre.Text;
              
                objScl_N.EditandoSucursales_N();

                dataGridViewSclRgt.DataSource = objScl_N.MostrandoAdmSucursales_N();

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
                Sucursales_E.IdSucursal1 = int.Parse(txtScl.Text);
                Sucursales_E.IdDiviciones1 = int.Parse(txtMarca.Text);

                if (MessageBox.Show("Esta seguro que quiere eliminar el registro.", "Advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    objScl_N.BorrandoSucursales_N();

                MessageBox.Show("Registro Eliminado");

                dataGridViewSclRgt.DataSource = objScl_N.MostrandoAdmSucursales_N();


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
                Sucursales_E.IdDiviciones1 = int.Parse(txtMarca.Text);
                Sucursales_E.NombreSucursal1 = txtNombre.Text;

                objScl_N.GuardandoSucursales_N();

                dataGridViewSclRgt.DataSource = objScl_N.MostrandoAdmSucursales_N();

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
                Sucursales_E.NombreSucursal1 = txtNombre.Text;

                dataGridViewSclRgt.DataSource = objScl_N.BuscandoAdmSucursales_N();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }
      
        private void dataGridViewSclRgt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombre.Text = dataGridViewSclRgt.CurrentRow.Cells[1].Value.ToString();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }

        private void dataGridViewIDMarc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMarca.Text = dataGridViewIDMarc.CurrentRow.Cells[0].Value.ToString();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }

        private void txtMarca_Click(object sender, EventArgs e)
        {
            dataGridViewIDMarc.Visible = true;
        }
    }
}
