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
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
           // if (MessageBox.Show("Esta seguro que quiere salir", "Advertencia",
         //   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
        }
    }
}
