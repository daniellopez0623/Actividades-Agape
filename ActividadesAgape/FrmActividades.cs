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
    public partial class FrmActividades : Form
    {
        Actividades_N objActN = new Actividades_N();

        public FrmActividades()
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
            panelMaimRgtAct.Controls.Add(OpenFrm);
            panelMaimRgtAct.Tag = OpenFrm;
            OpenFrm.BringToFront();
            OpenFrm.Show();
        }
        private void FrmActividades_Load(object sender, EventArgs e)
        {
            dataGridViewAct.DataSource = objActN.MostrandoActividades_N();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Actividades_E.DescripcionActividad1 = txtDescripcionAct.Text;

                 dataGridViewAct.DataSource = objActN.BuscandoActividades_N();

            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            OpenPanelConten(new FrmRgtActividades());
        }
    }
}
