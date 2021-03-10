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
        
        public FrmMarcas()
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
                if (tool is MaskedTextBox)
                {
                    tool.Text = "";
                }
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
