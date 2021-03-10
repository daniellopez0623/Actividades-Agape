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
using System.Runtime.InteropServices;


namespace ActividadesAgape
{
    public partial class FrmLogin : Form
    {
       // Usuarios_E objUser_E = new Usuarios_E();
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
                Usuarios_E.User1 = txtUser.Text;
                Usuarios_E.Pass1 = txtPass.Text;

                dt = objUser_N.LogeandoUsuarios_N();

                if (dt.Rows.Count > 0)
                {                 
                    Usuarios_E.User1 = dt.Rows[0][0].ToString();
                    Usuarios_E.Pass1 = dt.Rows[0][1].ToString();
                    Usuarios_E.NombreRol = dt.Rows[0][2].ToString();
                   // Usuarios_E.FechaCreacion1 = DateTime.Parse(dt.Rows[0][3].ToString());
                    //Usuarios_E.RolUsuario = int.Parse(dt.Rows[0][5].ToString());
                    //Usuarios_E.RolUsuario1 = int.Parse(dt.Rows[0][6].ToString());
                   // Usuarios_E.NombreRol = dt.Rows[0][7].ToString();



                    MessageBox.Show($"BIENVENIDO: \n {Usuarios_E.User1} ");

                    FrmMain frmPrincipal = new FrmMain();
                    frmPrincipal.Show();
                    frmPrincipal.FormClosed += LogOut;
                    this.Hide();


                }
                else
                {
                    MessageBox.Show($"DATOS INCORRECTOS, VERIFIQUE SU USUARIO O SU CONTACEÑA... ");
                    txtUser.Clear();
                    txtPass.Clear();
                }
            }
            catch (Exception Error)
            {

                MessageBox.Show($"{Error.Message}");
                txtPass.UseSystemPasswordChar = false;
                txtUser.Focus();
                txtUser.Clear();
                txtPass.Clear();
            }
        }
        private void LogOut(object sender, FormClosedEventArgs e)
        {
            txtPass.Clear();
            txtPass.UseSystemPasswordChar = false;
            txtUser.Clear();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToShortTimeString();
            labelFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
           // txtUser.Clear();              
           // ftUser.BackgroundImage = Properties.Resources
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
