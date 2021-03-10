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
    public partial class FrmUsers : Form
    {
        FrmMain frmMain = new FrmMain();
        Usuarios_N objUser_N = new Usuarios_N();

        public FrmUsers()
        {
            InitializeComponent();
        }

        private void btnBuscar_Paint(object sender, PaintEventArgs e)
        {
            Usuarios_E.User1 = txtUser.Text;

            dataGridViewUsers.DataSource = objUser_N.BuscandoUsuarios_N();
            /*
            try
            {
                Usuarios_E.User1 = txtUser.Text;

                dataGridViewUsers.DataSource = objUser_N.BuscandoUsuarios_N();
            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}");
            }
            */
        }

        private void btnAdmin_Paint(object sender, PaintEventArgs e)
        {
          //  frmMain.OpenPanelConten(new FrmRgtUsuarios());
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            dataGridViewUsers.DataSource = objUser_N.MostrandoUsuarios_N();
        }

        private void ButtonRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}
