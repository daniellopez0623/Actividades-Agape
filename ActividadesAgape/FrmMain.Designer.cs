
namespace ActividadesAgape
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.PanelTools = new System.Windows.Forms.Panel();
            this.ButtonUsuarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ButtonAcerca = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ButtonMarcas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ButtonTools = new Bunifu.Framework.UI.BunifuFlatButton();
            this.linea3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.linea2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.ButtonBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.linea1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.ButtonSucursales = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelRol = new System.Windows.Forms.Label();
            this.ButtonEmpleados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ButtonRegistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ButtonActividades = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipseMenu = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelMenuLeft = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMain2 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.Animacion = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.backAni = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipseMain2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            this.PanelTools.SuspendLayout();
            this.panelMenuLeft.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelMain2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this.bunifuGradientPanel1;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.PanelTools);
            this.bunifuGradientPanel1.Controls.Add(this.ButtonTools);
            this.bunifuGradientPanel1.Controls.Add(this.linea3);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.linea2);
            this.bunifuGradientPanel1.Controls.Add(this.ButtonBack);
            this.bunifuGradientPanel1.Controls.Add(this.linea1);
            this.bunifuGradientPanel1.Controls.Add(this.labelFecha);
            this.bunifuGradientPanel1.Controls.Add(this.labelHora);
            this.bunifuGradientPanel1.Controls.Add(this.labelUser);
            this.bunifuGradientPanel1.Controls.Add(this.ButtonSucursales);
            this.bunifuGradientPanel1.Controls.Add(this.labelRol);
            this.bunifuGradientPanel1.Controls.Add(this.ButtonEmpleados);
            this.bunifuGradientPanel1.Controls.Add(this.ButtonRegistrar);
            this.bunifuGradientPanel1.Controls.Add(this.ButtonActividades);
            this.backAni.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.Animacion.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(17, 93);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(285, 857);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.MouseLeave += new System.EventHandler(this.bunifuGradientPanel1_MouseLeave);
            // 
            // PanelTools
            // 
            this.PanelTools.BackColor = System.Drawing.Color.Transparent;
            this.PanelTools.Controls.Add(this.ButtonUsuarios);
            this.PanelTools.Controls.Add(this.ButtonAcerca);
            this.PanelTools.Controls.Add(this.ButtonMarcas);
            this.backAni.SetDecoration(this.PanelTools, BunifuAnimatorNS.DecorationType.None);
            this.Animacion.SetDecoration(this.PanelTools, BunifuAnimatorNS.DecorationType.None);
            this.PanelTools.Location = new System.Drawing.Point(10, 427);
            this.PanelTools.Name = "PanelTools";
            this.PanelTools.Size = new System.Drawing.Size(258, 244);
            this.PanelTools.TabIndex = 248;
            this.PanelTools.MouseLeave += new System.EventHandler(this.PanelTools_MouseLeave);
            // 
            // ButtonUsuarios
            // 
            this.ButtonUsuarios.Activecolor = System.Drawing.Color.Transparent;
            this.ButtonUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.ButtonUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonUsuarios.BorderRadius = 0;
            this.ButtonUsuarios.ButtonText = "    Usuarios";
            this.ButtonUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion.SetDecoration(this.ButtonUsuarios, BunifuAnimatorNS.DecorationType.None);
            this.backAni.SetDecoration(this.ButtonUsuarios, BunifuAnimatorNS.DecorationType.None);
            this.ButtonUsuarios.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonUsuarios.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonUsuarios.Iconimage = ((System.Drawing.Image)(resources.GetObject("ButtonUsuarios.Iconimage")));
            this.ButtonUsuarios.Iconimage_right = null;
            this.ButtonUsuarios.Iconimage_right_Selected = null;
            this.ButtonUsuarios.Iconimage_Selected = null;
            this.ButtonUsuarios.IconMarginLeft = 0;
            this.ButtonUsuarios.IconMarginRight = 0;
            this.ButtonUsuarios.IconRightVisible = true;
            this.ButtonUsuarios.IconRightZoom = 0D;
            this.ButtonUsuarios.IconVisible = true;
            this.ButtonUsuarios.IconZoom = 85D;
            this.ButtonUsuarios.IsTab = false;
            this.ButtonUsuarios.Location = new System.Drawing.Point(4, 158);
            this.ButtonUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonUsuarios.Name = "ButtonUsuarios";
            this.ButtonUsuarios.Normalcolor = System.Drawing.Color.Transparent;
            this.ButtonUsuarios.OnHovercolor = System.Drawing.Color.Transparent;
            this.ButtonUsuarios.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonUsuarios.selected = false;
            this.ButtonUsuarios.Size = new System.Drawing.Size(253, 69);
            this.ButtonUsuarios.TabIndex = 198;
            this.ButtonUsuarios.Text = "    Usuarios";
            this.ButtonUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonUsuarios.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ButtonUsuarios.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUsuarios.Click += new System.EventHandler(this.ButtonUsuarios_Click);
            // 
            // ButtonAcerca
            // 
            this.ButtonAcerca.Activecolor = System.Drawing.Color.Transparent;
            this.ButtonAcerca.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAcerca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonAcerca.BorderRadius = 0;
            this.ButtonAcerca.ButtonText = "     Acerca De";
            this.ButtonAcerca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion.SetDecoration(this.ButtonAcerca, BunifuAnimatorNS.DecorationType.None);
            this.backAni.SetDecoration(this.ButtonAcerca, BunifuAnimatorNS.DecorationType.None);
            this.ButtonAcerca.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonAcerca.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonAcerca.Iconimage = ((System.Drawing.Image)(resources.GetObject("ButtonAcerca.Iconimage")));
            this.ButtonAcerca.Iconimage_right = null;
            this.ButtonAcerca.Iconimage_right_Selected = null;
            this.ButtonAcerca.Iconimage_Selected = null;
            this.ButtonAcerca.IconMarginLeft = 0;
            this.ButtonAcerca.IconMarginRight = 0;
            this.ButtonAcerca.IconRightVisible = true;
            this.ButtonAcerca.IconRightZoom = 0D;
            this.ButtonAcerca.IconVisible = true;
            this.ButtonAcerca.IconZoom = 85D;
            this.ButtonAcerca.IsTab = false;
            this.ButtonAcerca.Location = new System.Drawing.Point(4, 6);
            this.ButtonAcerca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonAcerca.Name = "ButtonAcerca";
            this.ButtonAcerca.Normalcolor = System.Drawing.Color.Transparent;
            this.ButtonAcerca.OnHovercolor = System.Drawing.Color.Transparent;
            this.ButtonAcerca.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonAcerca.selected = false;
            this.ButtonAcerca.Size = new System.Drawing.Size(253, 69);
            this.ButtonAcerca.TabIndex = 202;
            this.ButtonAcerca.Text = "     Acerca De";
            this.ButtonAcerca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAcerca.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ButtonAcerca.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAcerca.Click += new System.EventHandler(this.ButtonAcerca_Click);
            // 
            // ButtonMarcas
            // 
            this.ButtonMarcas.Activecolor = System.Drawing.Color.Transparent;
            this.ButtonMarcas.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMarcas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonMarcas.BorderRadius = 0;
            this.ButtonMarcas.ButtonText = "    Marcas";
            this.ButtonMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion.SetDecoration(this.ButtonMarcas, BunifuAnimatorNS.DecorationType.None);
            this.backAni.SetDecoration(this.ButtonMarcas, BunifuAnimatorNS.DecorationType.None);
            this.ButtonMarcas.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonMarcas.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonMarcas.Iconimage = ((System.Drawing.Image)(resources.GetObject("ButtonMarcas.Iconimage")));
            this.ButtonMarcas.Iconimage_right = null;
            this.ButtonMarcas.Iconimage_right_Selected = null;
            this.ButtonMarcas.Iconimage_Selected = null;
            this.ButtonMarcas.IconMarginLeft = 0;
            this.ButtonMarcas.IconMarginRight = 0;
            this.ButtonMarcas.IconRightVisible = true;
            this.ButtonMarcas.IconRightZoom = 0D;
            this.ButtonMarcas.IconVisible = true;
            this.ButtonMarcas.IconZoom = 85D;
            this.ButtonMarcas.IsTab = false;
            this.ButtonMarcas.Location = new System.Drawing.Point(4, 82);
            this.ButtonMarcas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonMarcas.Name = "ButtonMarcas";
            this.ButtonMarcas.Normalcolor = System.Drawing.Color.Transparent;
            this.ButtonMarcas.OnHovercolor = System.Drawing.Color.Transparent;
            this.ButtonMarcas.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonMarcas.selected = false;
            this.ButtonMarcas.Size = new System.Drawing.Size(253, 69);
            this.ButtonMarcas.TabIndex = 199;
            this.ButtonMarcas.Text = "    Marcas";
            this.ButtonMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonMarcas.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ButtonMarcas.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMarcas.Click += new System.EventHandler(this.ButtonMarcas_Click);
            // 
            // ButtonTools
            // 
            this.ButtonTools.Activecolor = System.Drawing.Color.Transparent;
            this.ButtonTools.BackColor = System.Drawing.Color.Transparent;
            this.ButtonTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonTools.BorderRadius = 0;
            this.ButtonTools.ButtonText = "   Herramientas";
            this.ButtonTools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion.SetDecoration(this.ButtonTools, BunifuAnimatorNS.DecorationType.None);
            this.backAni.SetDecoration(this.ButtonTools, BunifuAnimatorNS.DecorationType.None);
            this.ButtonTools.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonTools.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonTools.Iconimage = ((System.Drawing.Image)(resources.GetObject("ButtonTools.Iconimage")));
            this.ButtonTools.Iconimage_right = null;
            this.ButtonTools.Iconimage_right_Selected = null;
            this.ButtonTools.Iconimage_Selected = null;
            this.ButtonTools.IconMarginLeft = 0;
            this.ButtonTools.IconMarginRight = 0;
            this.ButtonTools.IconRightVisible = true;
            this.ButtonTools.IconRightZoom = 0D;
            this.ButtonTools.IconVisible = true;
            this.ButtonTools.IconZoom = 85D;
            this.ButtonTools.IsTab = false;
            this.ButtonTools.Location = new System.Drawing.Point(10, 355);
            this.ButtonTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonTools.Name = "ButtonTools";
            this.ButtonTools.Normalcolor = System.Drawing.Color.Transparent;
            this.ButtonTools.OnHovercolor = System.Drawing.Color.Transparent;
            this.ButtonTools.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonTools.selected = false;
            this.ButtonTools.Size = new System.Drawing.Size(264, 69);
            this.ButtonTools.TabIndex = 217;
            this.ButtonTools.Text = "   Herramientas";
            this.ButtonTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonTools.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ButtonTools.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTools.Click += new System.EventHandler(this.ButtonTools_Click);
            // 
            // linea3
            // 
            this.linea3.BackColor = System.Drawing.Color.Transparent;
            this.backAni.SetDecoration(this.linea3, BunifuAnimatorNS.DecorationType.None);
            this.Animacion.SetDecoration(this.linea3, BunifuAnimatorNS.DecorationType.None);
            this.linea3.ForeColor = System.Drawing.Color.Black;
            this.linea3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linea3.LineThickness = 1;
            this.linea3.Location = new System.Drawing.Point(10, 811);
            this.linea3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.linea3.Name = "linea3";
            this.linea3.Size = new System.Drawing.Size(265, 2);
            this.linea3.TabIndex = 207;
            this.linea3.Transparency = 255;
            this.linea3.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.Animacion.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.backAni.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(13, 823);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 20);
            this.label2.TabIndex = 205;
            this.label2.Text = "Copyright ©  2021 by Daniel Lopez.";
            // 
            // linea2
            // 
            this.linea2.BackColor = System.Drawing.Color.Transparent;
            this.backAni.SetDecoration(this.linea2, BunifuAnimatorNS.DecorationType.None);
            this.Animacion.SetDecoration(this.linea2, BunifuAnimatorNS.DecorationType.None);
            this.linea2.ForeColor = System.Drawing.Color.Black;
            this.linea2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linea2.LineThickness = 1;
            this.linea2.Location = new System.Drawing.Point(10, 765);
            this.linea2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.linea2.Name = "linea2";
            this.linea2.Size = new System.Drawing.Size(265, 2);
            this.linea2.TabIndex = 204;
            this.linea2.Transparency = 255;
            this.linea2.Vertical = false;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Activecolor = System.Drawing.Color.Transparent;
            this.ButtonBack.BackColor = System.Drawing.Color.Transparent;
            this.ButtonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonBack.BorderRadius = 0;
            this.ButtonBack.ButtonText = "     Atras";
            this.ButtonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion.SetDecoration(this.ButtonBack, BunifuAnimatorNS.DecorationType.None);
            this.backAni.SetDecoration(this.ButtonBack, BunifuAnimatorNS.DecorationType.None);
            this.ButtonBack.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBack.ForeColor = System.Drawing.Color.White;
            this.ButtonBack.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonBack.Iconimage = ((System.Drawing.Image)(resources.GetObject("ButtonBack.Iconimage")));
            this.ButtonBack.Iconimage_right = null;
            this.ButtonBack.Iconimage_right_Selected = null;
            this.ButtonBack.Iconimage_Selected = null;
            this.ButtonBack.IconMarginLeft = 0;
            this.ButtonBack.IconMarginRight = 0;
            this.ButtonBack.IconRightVisible = true;
            this.ButtonBack.IconRightZoom = 0D;
            this.ButtonBack.IconVisible = true;
            this.ButtonBack.IconZoom = 85D;
            this.ButtonBack.IsTab = false;
            this.ButtonBack.Location = new System.Drawing.Point(17, 688);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Normalcolor = System.Drawing.Color.Transparent;
            this.ButtonBack.OnHovercolor = System.Drawing.Color.Transparent;
            this.ButtonBack.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonBack.selected = false;
            this.ButtonBack.Size = new System.Drawing.Size(242, 69);
            this.ButtonBack.TabIndex = 203;
            this.ButtonBack.Text = "     Atras";
            this.ButtonBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonBack.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ButtonBack.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // linea1
            // 
            this.linea1.BackColor = System.Drawing.Color.Transparent;
            this.backAni.SetDecoration(this.linea1, BunifuAnimatorNS.DecorationType.None);
            this.Animacion.SetDecoration(this.linea1, BunifuAnimatorNS.DecorationType.None);
            this.linea1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linea1.LineThickness = 1;
            this.linea1.Location = new System.Drawing.Point(10, 60);
            this.linea1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.linea1.Name = "linea1";
            this.linea1.Size = new System.Drawing.Size(265, 2);
            this.linea1.TabIndex = 0;
            this.linea1.Transparency = 255;
            this.linea1.Vertical = false;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.BackColor = System.Drawing.Color.Transparent;
            this.Animacion.SetDecoration(this.labelFecha, BunifuAnimatorNS.DecorationType.None);
            this.backAni.SetDecoration(this.labelFecha, BunifuAnimatorNS.DecorationType.None);
            this.labelFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.labelFecha.Location = new System.Drawing.Point(130, 776);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(67, 27);
            this.labelFecha.TabIndex = 194;
            this.labelFecha.Text = "Fecha";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.BackColor = System.Drawing.Color.Transparent;
            this.Animacion.SetDecoration(this.labelHora, BunifuAnimatorNS.DecorationType.None);
            this.backAni.SetDecoration(this.labelHora, BunifuAnimatorNS.DecorationType.None);
            this.labelHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHora.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.labelHora.Location = new System.Drawing.Point(9, 776);
            this.labelHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(59, 27);
            this.labelHora.TabIndex = 193;
            this.labelHora.Text = "Hora";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.Animacion.SetDecoration(this.labelUser, BunifuAnimatorNS.DecorationType.None);
            this.backAni.SetDecoration(this.labelUser, BunifuAnimatorNS.DecorationType.None);
            this.labelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.labelUser.Location = new System.Drawing.Point(9, 16);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(85, 27);
            this.labelUser.TabIndex = 194;
            this.labelUser.Text = "Usuario";
            // 
            // ButtonSucursales
            // 
            this.ButtonSucursales.Activecolor = System.Drawing.Color.Transparent;
            this.ButtonSucursales.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSucursales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonSucursales.BorderRadius = 0;
            this.ButtonSucursales.ButtonText = "    Sucursales";
            this.ButtonSucursales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion.SetDecoration(this.ButtonSucursales, BunifuAnimatorNS.DecorationType.None);
            this.backAni.SetDecoration(this.ButtonSucursales, BunifuAnimatorNS.DecorationType.None);
            this.ButtonSucursales.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonSucursales.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonSucursales.Iconimage = ((System.Drawing.Image)(resources.GetObject("ButtonSucursales.Iconimage")));
            this.ButtonSucursales.Iconimage_right = null;
            this.ButtonSucursales.Iconimage_right_Selected = null;
            this.ButtonSucursales.Iconimage_Selected = null;
            this.ButtonSucursales.IconMarginLeft = 0;
            this.ButtonSucursales.IconMarginRight = 0;
            this.ButtonSucursales.IconRightVisible = true;
            this.ButtonSucursales.IconRightZoom = 0D;
            this.ButtonSucursales.IconVisible = true;
            this.ButtonSucursales.IconZoom = 85D;
            this.ButtonSucursales.IsTab = false;
            this.ButtonSucursales.Location = new System.Drawing.Point(10, 211);
            this.ButtonSucursales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonSucursales.Name = "ButtonSucursales";
            this.ButtonSucursales.Normalcolor = System.Drawing.Color.Transparent;
            this.ButtonSucursales.OnHovercolor = System.Drawing.Color.Transparent;
            this.ButtonSucursales.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonSucursales.selected = false;
            this.ButtonSucursales.Size = new System.Drawing.Size(242, 69);
            this.ButtonSucursales.TabIndex = 201;
            this.ButtonSucursales.Text = "    Sucursales";
            this.ButtonSucursales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSucursales.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ButtonSucursales.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSucursales.Click += new System.EventHandler(this.ButtonSucursales_Click);
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.BackColor = System.Drawing.Color.Transparent;
            this.Animacion.SetDecoration(this.labelRol, BunifuAnimatorNS.DecorationType.None);
            this.backAni.SetDecoration(this.labelRol, BunifuAnimatorNS.DecorationType.None);
            this.labelRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRol.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.labelRol.Location = new System.Drawing.Point(95, 17);
            this.labelRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(43, 27);
            this.labelRol.TabIndex = 195;
            this.labelRol.Text = "Rol";
            // 
            // ButtonEmpleados
            // 
            this.ButtonEmpleados.Activecolor = System.Drawing.Color.Transparent;
            this.ButtonEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonEmpleados.BorderRadius = 0;
            this.ButtonEmpleados.ButtonText = "    Empleados";
            this.ButtonEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion.SetDecoration(this.ButtonEmpleados, BunifuAnimatorNS.DecorationType.None);
            this.backAni.SetDecoration(this.ButtonEmpleados, BunifuAnimatorNS.DecorationType.None);
            this.ButtonEmpleados.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonEmpleados.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonEmpleados.Iconimage = ((System.Drawing.Image)(resources.GetObject("ButtonEmpleados.Iconimage")));
            this.ButtonEmpleados.Iconimage_right = null;
            this.ButtonEmpleados.Iconimage_right_Selected = null;
            this.ButtonEmpleados.Iconimage_Selected = null;
            this.ButtonEmpleados.IconMarginLeft = 0;
            this.ButtonEmpleados.IconMarginRight = 0;
            this.ButtonEmpleados.IconRightVisible = true;
            this.ButtonEmpleados.IconRightZoom = 0D;
            this.ButtonEmpleados.IconVisible = true;
            this.ButtonEmpleados.IconZoom = 85D;
            this.ButtonEmpleados.IsTab = false;
            this.ButtonEmpleados.Location = new System.Drawing.Point(10, 67);
            this.ButtonEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonEmpleados.Name = "ButtonEmpleados";
            this.ButtonEmpleados.Normalcolor = System.Drawing.Color.Transparent;
            this.ButtonEmpleados.OnHovercolor = System.Drawing.Color.Transparent;
            this.ButtonEmpleados.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonEmpleados.selected = false;
            this.ButtonEmpleados.Size = new System.Drawing.Size(242, 69);
            this.ButtonEmpleados.TabIndex = 196;
            this.ButtonEmpleados.Text = "    Empleados";
            this.ButtonEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonEmpleados.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ButtonEmpleados.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEmpleados.Click += new System.EventHandler(this.ButtonEmpleados_Click);
            // 
            // ButtonRegistrar
            // 
            this.ButtonRegistrar.Activecolor = System.Drawing.Color.Transparent;
            this.ButtonRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonRegistrar.BorderRadius = 0;
            this.ButtonRegistrar.ButtonText = "    Registrar";
            this.ButtonRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion.SetDecoration(this.ButtonRegistrar, BunifuAnimatorNS.DecorationType.None);
            this.backAni.SetDecoration(this.ButtonRegistrar, BunifuAnimatorNS.DecorationType.None);
            this.ButtonRegistrar.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonRegistrar.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonRegistrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("ButtonRegistrar.Iconimage")));
            this.ButtonRegistrar.Iconimage_right = null;
            this.ButtonRegistrar.Iconimage_right_Selected = null;
            this.ButtonRegistrar.Iconimage_Selected = null;
            this.ButtonRegistrar.IconMarginLeft = 0;
            this.ButtonRegistrar.IconMarginRight = 0;
            this.ButtonRegistrar.IconRightVisible = true;
            this.ButtonRegistrar.IconRightZoom = 0D;
            this.ButtonRegistrar.IconVisible = true;
            this.ButtonRegistrar.IconZoom = 85D;
            this.ButtonRegistrar.IsTab = false;
            this.ButtonRegistrar.Location = new System.Drawing.Point(10, 283);
            this.ButtonRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonRegistrar.Name = "ButtonRegistrar";
            this.ButtonRegistrar.Normalcolor = System.Drawing.Color.Transparent;
            this.ButtonRegistrar.OnHovercolor = System.Drawing.Color.Transparent;
            this.ButtonRegistrar.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonRegistrar.selected = false;
            this.ButtonRegistrar.Size = new System.Drawing.Size(242, 69);
            this.ButtonRegistrar.TabIndex = 200;
            this.ButtonRegistrar.Text = "    Registrar";
            this.ButtonRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonRegistrar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ButtonRegistrar.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRegistrar.Click += new System.EventHandler(this.ButtonRegistrar_Click);
            // 
            // ButtonActividades
            // 
            this.ButtonActividades.Activecolor = System.Drawing.Color.Transparent;
            this.ButtonActividades.BackColor = System.Drawing.Color.Transparent;
            this.ButtonActividades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonActividades.BorderRadius = 0;
            this.ButtonActividades.ButtonText = "    Actividades";
            this.ButtonActividades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion.SetDecoration(this.ButtonActividades, BunifuAnimatorNS.DecorationType.None);
            this.backAni.SetDecoration(this.ButtonActividades, BunifuAnimatorNS.DecorationType.None);
            this.ButtonActividades.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonActividades.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonActividades.Iconimage = ((System.Drawing.Image)(resources.GetObject("ButtonActividades.Iconimage")));
            this.ButtonActividades.Iconimage_right = null;
            this.ButtonActividades.Iconimage_right_Selected = null;
            this.ButtonActividades.Iconimage_Selected = null;
            this.ButtonActividades.IconMarginLeft = 0;
            this.ButtonActividades.IconMarginRight = 0;
            this.ButtonActividades.IconRightVisible = true;
            this.ButtonActividades.IconRightZoom = 0D;
            this.ButtonActividades.IconVisible = true;
            this.ButtonActividades.IconZoom = 85D;
            this.ButtonActividades.IsTab = false;
            this.ButtonActividades.Location = new System.Drawing.Point(10, 139);
            this.ButtonActividades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonActividades.Name = "ButtonActividades";
            this.ButtonActividades.Normalcolor = System.Drawing.Color.Transparent;
            this.ButtonActividades.OnHovercolor = System.Drawing.Color.Transparent;
            this.ButtonActividades.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonActividades.selected = false;
            this.ButtonActividades.Size = new System.Drawing.Size(242, 69);
            this.ButtonActividades.TabIndex = 197;
            this.ButtonActividades.Text = "    Actividades";
            this.ButtonActividades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonActividades.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ButtonActividades.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonActividades.Click += new System.EventHandler(this.ButtonActividades_Click);
            // 
            // bunifuElipseMenu
            // 
            this.bunifuElipseMenu.ElipseRadius = 7;
            this.bunifuElipseMenu.TargetControl = this;
            // 
            // panelMenuLeft
            // 
            this.panelMenuLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelMenuLeft.Controls.Add(this.bunifuGradientPanel1);
            this.backAni.SetDecoration(this.panelMenuLeft, BunifuAnimatorNS.DecorationType.None);
            this.Animacion.SetDecoration(this.panelMenuLeft, BunifuAnimatorNS.DecorationType.None);
            this.panelMenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLeft.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenuLeft.Name = "panelMenuLeft";
            this.panelMenuLeft.Size = new System.Drawing.Size(312, 964);
            this.panelMenuLeft.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelMain.Controls.Add(this.panelMain2);
            this.backAni.SetDecoration(this.panelMain, BunifuAnimatorNS.DecorationType.None);
            this.Animacion.SetDecoration(this.panelMain, BunifuAnimatorNS.DecorationType.None);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(312, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1100, 964);
            this.panelMain.TabIndex = 1;
            // 
            // panelMain2
            // 
            this.panelMain2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelMain2.Controls.Add(this.pictureBoxLogo);
            this.backAni.SetDecoration(this.panelMain2, BunifuAnimatorNS.DecorationType.None);
            this.Animacion.SetDecoration(this.panelMain2, BunifuAnimatorNS.DecorationType.None);
            this.panelMain2.Location = new System.Drawing.Point(7, 93);
            this.panelMain2.Name = "panelMain2";
            this.panelMain2.Size = new System.Drawing.Size(1072, 857);
            this.panelMain2.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.Animacion.SetDecoration(this.pictureBoxLogo, BunifuAnimatorNS.DecorationType.None);
            this.backAni.SetDecoration(this.pictureBoxLogo, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(134, 205);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(851, 453);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 198;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.BorderRadius = 0;
            this.btnMenu.ButtonText = "";
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.backAni.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenu.Iconimage")));
            this.btnMenu.Iconimage_right = null;
            this.btnMenu.Iconimage_right_Selected = null;
            this.btnMenu.Iconimage_Selected = null;
            this.btnMenu.IconMarginLeft = 0;
            this.btnMenu.IconMarginRight = 0;
            this.btnMenu.IconRightVisible = true;
            this.btnMenu.IconRightZoom = 0D;
            this.btnMenu.IconVisible = true;
            this.btnMenu.IconZoom = 100D;
            this.btnMenu.IsTab = false;
            this.btnMenu.Location = new System.Drawing.Point(22, 4);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenu.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenu.selected = false;
            this.btnMenu.Size = new System.Drawing.Size(76, 72);
            this.btnMenu.TabIndex = 214;
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Textcolor = System.Drawing.Color.White;
            this.btnMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.backAni.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 70D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(1309, 16);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(44, 44);
            this.bunifuFlatButton2.TabIndex = 1;
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.backAni.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(1355, 14);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(44, 44);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelTop.Controls.Add(this.btnMenu);
            this.panelTop.Controls.Add(this.bunifuFlatButton2);
            this.panelTop.Controls.Add(this.bunifuFlatButton1);
            this.backAni.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.Animacion.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1408, 80);
            this.panelTop.TabIndex = 2;
            // 
            // Animacion
            // 
            this.Animacion.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.Animacion.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.Animacion.DefaultAnimation = animation1;
            // 
            // backAni
            // 
            this.backAni.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.backAni.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.backAni.DefaultAnimation = animation2;
            // 
            // bunifuElipseMain2
            // 
            this.bunifuElipseMain2.ElipseRadius = 5;
            this.bunifuElipseMain2.TargetControl = this.panelMain2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1412, 964);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenuLeft);
            this.backAni.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Animacion.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.PanelTools.ResumeLayout(false);
            this.panelMenuLeft.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuLeft;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Panel panelTop;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonBack;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonAcerca;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonSucursales;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonRegistrar;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonMarcas;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonUsuarios;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonActividades;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonEmpleados;
        private Bunifu.Framework.UI.BunifuSeparator linea1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenu;
        private Bunifu.Framework.UI.BunifuSeparator linea2;
        private Bunifu.Framework.UI.BunifuSeparator linea3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseMenu;
        private BunifuAnimatorNS.BunifuTransition Animacion;
        private BunifuAnimatorNS.BunifuTransition backAni;
        private System.Windows.Forms.Panel panelMain2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseMain2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonTools;
        private System.Windows.Forms.Panel PanelTools;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}