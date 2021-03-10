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
    public partial class FrmEmpleados : Form 
    {
        Empleados_N objEmpN = new Empleados_N();

        public FrmEmpleados()
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
            panelMaimRgtEmp.Controls.Add(OpenFrm);
            panelMaimRgtEmp.Tag = OpenFrm;
            OpenFrm.BringToFront();
            OpenFrm.Show();
        }
        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
           dataGridViewEmp.DataSource = objEmpN.MostrandoEmpleados_N();
        }          
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleados_E.CodigoEmpleado1 = int.Parse(txtCodEmp.Text);

                dataGridViewEmp.DataSource = objEmpN.BuscandoEmpleados_N();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            OpenPanelConten(new FrmRgtEmpleados());

        }


    }
}
