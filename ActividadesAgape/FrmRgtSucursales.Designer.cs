
namespace ActividadesAgape
{
    partial class FrmRgtSucursales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRgtSucursales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnBorrar = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuTileButton();
            this.dataGridViewSclRgt = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtScl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.dataGridViewIDMarc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSclRgt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIDMarc)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(718, 10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(340, 127);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 309;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(147)))), ((int)(((byte)(181)))));
            this.btnBuscar.color = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(147)))), ((int)(((byte)(181)))));
            this.btnBuscar.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImagePosition = 15;
            this.btnBuscar.ImageZoom = 45;
            this.btnBuscar.LabelPosition = 29;
            this.btnBuscar.LabelText = "Buscar";
            this.btnBuscar.Location = new System.Drawing.Point(933, 370);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(124, 105);
            this.btnBuscar.TabIndex = 308;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(147)))), ((int)(((byte)(181)))));
            this.btnEditar.color = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(147)))), ((int)(((byte)(181)))));
            this.btnEditar.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImagePosition = 15;
            this.btnEditar.ImageZoom = 48;
            this.btnEditar.LabelPosition = 29;
            this.btnEditar.LabelText = "Editar";
            this.btnEditar.Location = new System.Drawing.Point(933, 483);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 105);
            this.btnEditar.TabIndex = 307;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(147)))), ((int)(((byte)(181)))));
            this.btnBorrar.color = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(147)))), ((int)(((byte)(181)))));
            this.btnBorrar.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.Black;
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImagePosition = 15;
            this.btnBorrar.ImageZoom = 45;
            this.btnBorrar.LabelPosition = 29;
            this.btnBorrar.LabelText = "Borrar";
            this.btnBorrar.Location = new System.Drawing.Point(933, 596);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(124, 105);
            this.btnBorrar.TabIndex = 306;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(147)))), ((int)(((byte)(181)))));
            this.btnGuardar.color = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(147)))), ((int)(((byte)(181)))));
            this.btnGuardar.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImagePosition = 15;
            this.btnGuardar.ImageZoom = 45;
            this.btnGuardar.LabelPosition = 29;
            this.btnGuardar.LabelText = "Guardar";
            this.btnGuardar.Location = new System.Drawing.Point(933, 257);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 105);
            this.btnGuardar.TabIndex = 305;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(147)))), ((int)(((byte)(181)))));
            this.btnNuevo.color = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(147)))), ((int)(((byte)(181)))));
            this.btnNuevo.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImagePosition = 15;
            this.btnNuevo.ImageZoom = 45;
            this.btnNuevo.LabelPosition = 29;
            this.btnNuevo.LabelText = "Nuevo";
            this.btnNuevo.Location = new System.Drawing.Point(933, 144);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(124, 105);
            this.btnNuevo.TabIndex = 304;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dataGridViewSclRgt
            // 
            this.dataGridViewSclRgt.AllowUserToDeleteRows = false;
            this.dataGridViewSclRgt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSclRgt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSclRgt.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSclRgt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSclRgt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewSclRgt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(147)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(147)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSclRgt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewSclRgt.ColumnHeadersHeight = 50;
            this.dataGridViewSclRgt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSclRgt.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewSclRgt.EnableHeadersVisualStyles = false;
            this.dataGridViewSclRgt.Location = new System.Drawing.Point(15, 483);
            this.dataGridViewSclRgt.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSclRgt.Name = "dataGridViewSclRgt";
            this.dataGridViewSclRgt.ReadOnly = true;
            this.dataGridViewSclRgt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSclRgt.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewSclRgt.RowHeadersWidth = 51;
            this.dataGridViewSclRgt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSclRgt.Size = new System.Drawing.Size(896, 364);
            this.dataGridViewSclRgt.TabIndex = 303;
            this.dataGridViewSclRgt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSclRgt_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(83, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(391, 47);
            this.label5.TabIndex = 311;
            this.label5.Text = "Registro Sucursales";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(71, 115);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(442, 10);
            this.bunifuGradientPanel1.TabIndex = 310;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(58, 337);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 321;
            this.label1.Text = "ID Sucursal:";
            // 
            // txtScl
            // 
            this.txtScl.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtScl.Location = new System.Drawing.Point(216, 336);
            this.txtScl.Margin = new System.Windows.Forms.Padding(4);
            this.txtScl.Multiline = true;
            this.txtScl.Name = "txtScl";
            this.txtScl.Size = new System.Drawing.Size(101, 31);
            this.txtScl.TabIndex = 320;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(93, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 30);
            this.label2.TabIndex = 324;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 14.2F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtNombre.Location = new System.Drawing.Point(220, 239);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(291, 37);
            this.txtNombre.TabIndex = 323;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.labelMarca.Location = new System.Drawing.Point(327, 336);
            this.labelMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(129, 30);
            this.labelMarca.TabIndex = 326;
            this.labelMarca.Text = "ID Marca:";
            this.labelMarca.Click += new System.EventHandler(this.labelMarca_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtMarca.Location = new System.Drawing.Point(464, 336);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Multiline = true;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(101, 31);
            this.txtMarca.TabIndex = 325;
            // 
            // dataGridViewIDMarc
            // 
            this.dataGridViewIDMarc.AllowUserToDeleteRows = false;
            this.dataGridViewIDMarc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewIDMarc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewIDMarc.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewIDMarc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewIDMarc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewIDMarc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(147)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(147)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewIDMarc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewIDMarc.ColumnHeadersHeight = 50;
            this.dataGridViewIDMarc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewIDMarc.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewIDMarc.EnableHeadersVisualStyles = false;
            this.dataGridViewIDMarc.Location = new System.Drawing.Point(603, 169);
            this.dataGridViewIDMarc.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewIDMarc.Name = "dataGridViewIDMarc";
            this.dataGridViewIDMarc.ReadOnly = true;
            this.dataGridViewIDMarc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewIDMarc.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewIDMarc.RowHeadersWidth = 51;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewIDMarc.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewIDMarc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIDMarc.Size = new System.Drawing.Size(308, 300);
            this.dataGridViewIDMarc.TabIndex = 327;
            this.dataGridViewIDMarc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewIDMarc_CellContentClick);
            // 
            // FrmRgtSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 857);
            this.Controls.Add(this.dataGridViewIDMarc);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dataGridViewSclRgt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRgtSucursales";
            this.Text = "FrmRgtSucursales";
            this.Load += new System.EventHandler(this.FrmRgtSucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSclRgt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIDMarc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Bunifu.Framework.UI.BunifuTileButton btnBuscar;
        private Bunifu.Framework.UI.BunifuTileButton btnEditar;
        private Bunifu.Framework.UI.BunifuTileButton btnBorrar;
        private Bunifu.Framework.UI.BunifuTileButton btnGuardar;
        private Bunifu.Framework.UI.BunifuTileButton btnNuevo;
        private System.Windows.Forms.DataGridView dataGridViewSclRgt;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.DataGridView dataGridViewIDMarc;
    }
}