
namespace ActividadesAgape
{
    partial class FrmRgtEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRgtEmpleados));
            this.dataGridViewEmpRgt = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDEmp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mskTxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnBorrar = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpRgt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmpRgt
            // 
            this.dataGridViewEmpRgt.AllowUserToDeleteRows = false;
            this.dataGridViewEmpRgt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewEmpRgt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewEmpRgt.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEmpRgt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEmpRgt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewEmpRgt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(147)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(147)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmpRgt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmpRgt.ColumnHeadersHeight = 50;
            this.dataGridViewEmpRgt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmpRgt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEmpRgt.EnableHeadersVisualStyles = false;
            this.dataGridViewEmpRgt.Location = new System.Drawing.Point(13, 485);
            this.dataGridViewEmpRgt.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEmpRgt.Name = "dataGridViewEmpRgt";
            this.dataGridViewEmpRgt.ReadOnly = true;
            this.dataGridViewEmpRgt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmpRgt.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEmpRgt.RowHeadersWidth = 51;
            this.dataGridViewEmpRgt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmpRgt.Size = new System.Drawing.Size(914, 364);
            this.dataGridViewEmpRgt.TabIndex = 257;
            this.dataGridViewEmpRgt.RowHeadersWidthSizeModeChanged += new System.Windows.Forms.DataGridViewAutoSizeModeEventHandler(this.dataGridViewEmpRgt_RowHeadersWidthSizeModeChanged);
            this.dataGridViewEmpRgt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpRgt_CellContentClick);
            this.dataGridViewEmpRgt.RowHeaderCellChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewEmpRgt_RowHeaderCellChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label6.Location = new System.Drawing.Point(510, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 30);
            this.label6.TabIndex = 268;
            this.label6.Text = "ID Empleado:";
            // 
            // txtIDEmp
            // 
            this.txtIDEmp.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtIDEmp.Location = new System.Drawing.Point(692, 229);
            this.txtIDEmp.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDEmp.Multiline = true;
            this.txtIDEmp.Name = "txtIDEmp";
            this.txtIDEmp.Size = new System.Drawing.Size(155, 31);
            this.txtIDEmp.TabIndex = 267;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(444, 318);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 30);
            this.label3.TabIndex = 266;
            this.label3.Text = "Codigo Empleado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(51, 406);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 30);
            this.label2.TabIndex = 264;
            this.label2.Text = "Telefono:";
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(692, 318);
            this.txtCodigoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoEmpleado.Multiline = true;
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(155, 31);
            this.txtCodigoEmpleado.TabIndex = 263;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label4.Location = new System.Drawing.Point(58, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 30);
            this.label4.TabIndex = 274;
            this.label4.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtNombre.Location = new System.Drawing.Point(184, 229);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(193, 31);
            this.txtNombre.TabIndex = 273;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label5.Location = new System.Drawing.Point(444, 406);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 30);
            this.label5.TabIndex = 272;
            this.label5.Text = "Email:";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtApellido.Location = new System.Drawing.Point(184, 318);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(193, 31);
            this.txtApellido.TabIndex = 271;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label7.Location = new System.Drawing.Point(56, 318);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 30);
            this.label7.TabIndex = 270;
            this.label7.Text = "Apellido:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtEmail.Location = new System.Drawing.Point(537, 406);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(310, 31);
            this.txtEmail.TabIndex = 269;
            // 
            // mskTxtTelefono
            // 
            this.mskTxtTelefono.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTxtTelefono.Location = new System.Drawing.Point(184, 403);
            this.mskTxtTelefono.Mask = "(999)000-0000";
            this.mskTxtTelefono.Name = "mskTxtTelefono";
            this.mskTxtTelefono.Size = new System.Drawing.Size(193, 41);
            this.mskTxtTelefono.TabIndex = 275;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(720, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(340, 127);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 276;
            this.pictureBoxLogo.TabStop = false;
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
            this.btnNuevo.Location = new System.Drawing.Point(935, 146);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(124, 105);
            this.btnNuevo.TabIndex = 277;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
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
            this.btnGuardar.Location = new System.Drawing.Point(935, 259);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 105);
            this.btnGuardar.TabIndex = 278;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
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
            this.btnBorrar.Location = new System.Drawing.Point(935, 598);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(124, 105);
            this.btnBorrar.TabIndex = 280;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
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
            this.btnEditar.Location = new System.Drawing.Point(935, 485);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 105);
            this.btnEditar.TabIndex = 281;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
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
            this.btnBuscar.Location = new System.Drawing.Point(935, 372);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(124, 105);
            this.btnBuscar.TabIndex = 282;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(81, 140);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(324, 10);
            this.bunifuGradientPanel1.TabIndex = 284;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(88, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 59);
            this.label1.TabIndex = 283;
            this.label1.Text = "Empleados:";
            // 
            // FrmRgtEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 857);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.mskTxtTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIDEmp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoEmpleado);
            this.Controls.Add(this.dataGridViewEmpRgt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRgtEmpleados";
            this.Text = "FrmRgtEmpleados";
            this.Load += new System.EventHandler(this.FrmRgtEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpRgt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewEmpRgt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mskTxtTelefono;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Bunifu.Framework.UI.BunifuTileButton btnNuevo;
        private Bunifu.Framework.UI.BunifuTileButton btnGuardar;
        private Bunifu.Framework.UI.BunifuTileButton btnBorrar;
        private Bunifu.Framework.UI.BunifuTileButton btnEditar;
        private Bunifu.Framework.UI.BunifuTileButton btnBuscar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
    }
}