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
    public partial class FrmRgtActividades : Form
    {
        Actividades_N objActN = new Actividades_N();
        public FrmRgtActividades()
        {
            InitializeComponent();
        }

        private void FrmRgtActividades_Load(object sender, EventArgs e)
        {
            dataGridViewActRgt.DataSource = objActN.MostrandoActividades_N();
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
        private void dataGridViewActRgt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdAct.Text = dataGridViewActRgt.CurrentRow.Cells[0].Value.ToString();
                txtDescr.Text = dataGridViewActRgt.CurrentRow.Cells[1].Value.ToString();
                comboBoxNivel.Text = dataGridViewActRgt.CurrentRow.Cells[2].Value.ToString();
                comboBoxValor.Text = dataGridViewActRgt.CurrentRow.Cells[3].Value.ToString();
               
            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
            dataGridViewActRgt.DataSource = objActN.MostrandoActividades_N();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Actividades_E.IdActividad1 = int.Parse(txtIdAct.Text);
                Actividades_E.DescripcionActividad1 = txtDescr.Text;
                Actividades_E.NivelActividad1 = comboBoxNivel.Text;
                Actividades_E.ValorActividad1 = decimal.Parse(comboBoxValor.Text);

                objActN.EditandoActividades_N();

                MessageBox.Show("Registro Editar");

                dataGridViewActRgt.DataSource = objActN.MostrandoActividades_N();
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
                Actividades_E.IdActividad1 = int.Parse(txtIdAct.Text);

                objActN.BorrandoActividades_N();

                MessageBox.Show("Registro Elimidado");

                dataGridViewActRgt.DataSource = objActN.MostrandoActividades_N();

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
                Actividades_E.DescripcionActividad1 = txtDescr.Text;
                Actividades_E.NivelActividad1 = comboBoxNivel.Text;
                Actividades_E.ValorActividad1 = decimal.Parse(comboBoxValor.Text);

                objActN.GuardandoActividades_N();

                MessageBox.Show("Registro Guardado");

                dataGridViewActRgt.DataSource = objActN.MostrandoActividades_N();
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
                 Actividades_E.DescripcionActividad1 = txtDescr.Text;

                dataGridViewActRgt.DataSource = objActN.BuscandoActividades_N();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            dataGridViewActRgt.DataSource = objActN.MostrandoActividades_N();
        }
    }
}
