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
        RegistroActividades_N objSclN = new RegistroActividades_N();

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
            labelHora.Text = DateTime.Now.ToShortTimeString();
            labelFecha.Text = DateTime.Now.ToShortDateString();
        }
        private void FrmRegistros_Load(object sender, EventArgs e)
        {
            //dataGridViewActRgt.DataSource = objSclN.MostrandoRegistros_N();
            DateLabels();
            OcultarDataGrid();

           
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void timerRegistrar_Tick(object sender, EventArgs e)
        {

        }
    }
}
