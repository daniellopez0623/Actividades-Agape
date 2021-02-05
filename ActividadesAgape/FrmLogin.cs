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
    public partial class FrmLogin : Form
    {
        Usuarios_E objUser_E = new Usuarios_E();
        Usuarios_N objUser_N = new Usuarios_N();

        public FrmLogin()
        {
            InitializeComponent();
        }
      
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                objUser_E.Usuario1 = txtuser.Text;
                objUser_E.Password = txtpass.Text;

                dt = objUser_N.LogeandoUsuarios_N();

                if (dt.Rows.Count > 0)
                {
                    objUser_E.IdUsuario1 = int.Parse(dt.Rows[0][0].ToString());
                 //   objUser_E.User = dt.Rows[0][1].ToString();
                    objUser_E.Usuario1 = dt.Rows[0][2].ToString();
                    objUser_E.Password = dt.Rows[0][3].ToString();
                    objUser_E.IdRoles1 = int.Parse( dt.Rows[0][4].ToString());
                    objUser_E.FechaCreacion1 = Convert.ToDateTime(dt.Rows[0][5].ToString());
                    

                    MessageBox.Show($"BIENVENIDO: \n {objUser_E.Usuario1}  ");
                    /*({objUser_E.}{objUser_E.Apellido1})*/
                    FrmMain frmPrincipal = new FrmMain();
                    frmPrincipal.Show();
                    frmPrincipal.FormClosed += Logout;
                    this.Hide();


                }
                else
                {
                    MessageBox.Show($"DATOS INCORRECTOS, VERIFIQUE SU USUARIO O SU CONTACEÑA... ");
                    txtuser.Clear();
                    txtpass.Clear();
                }
            }
            catch (Exception Error)
            {

                MessageBox.Show($"{Error.Message}");
                txtpass.UseSystemPasswordChar = false;
                txtuser.Focus();
                txtuser.Clear();
                txtpass.Clear();
            }
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpass.Clear();
            txtpass.UseSystemPasswordChar = false;
            txtuser.Clear();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
