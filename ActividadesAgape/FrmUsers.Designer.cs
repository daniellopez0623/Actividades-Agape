
namespace ActividadesAgape
{
    partial class FrmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsers));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnAdmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(33, 829);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(401, 10);
            this.bunifuGradientPanel1.TabIndex = 267;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.HideSelection = false;
            this.txtUser.Location = new System.Drawing.Point(279, 779);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(155, 43);
            this.txtUser.TabIndex = 266;
            this.txtUser.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 778);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 36);
            this.label2.TabIndex = 265;
            this.label2.Text = "Nombre Usuario:";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.dataGridViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(33, 129);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.Size = new System.Drawing.Size(1021, 416);
            this.dataGridViewUsers.TabIndex = 264;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 80);
            this.label1.TabIndex = 263;
            this.label1.Text = "Usuarios:";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(786, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(274, 97);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 270;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Activecolor = System.Drawing.Color.Transparent;
            this.btnAdmin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmin.BorderRadius = 0;
            this.btnAdmin.ButtonText = "    Administrar";
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdmin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdmin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Iconimage")));
            this.btnAdmin.Iconimage_right = null;
            this.btnAdmin.Iconimage_right_Selected = null;
            this.btnAdmin.Iconimage_Selected = null;
            this.btnAdmin.IconMarginLeft = 0;
            this.btnAdmin.IconMarginRight = 0;
            this.btnAdmin.IconRightVisible = true;
            this.btnAdmin.IconRightZoom = 0D;
            this.btnAdmin.IconVisible = true;
            this.btnAdmin.IconZoom = 70D;
            this.btnAdmin.IsTab = false;
            this.btnAdmin.Location = new System.Drawing.Point(768, 779);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdmin.OnHovercolor = System.Drawing.Color.White;
            this.btnAdmin.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnAdmin.selected = false;
            this.btnAdmin.Size = new System.Drawing.Size(237, 52);
            this.btnAdmin.TabIndex = 272;
            this.btnAdmin.Text = "    Administrar";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnAdmin.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 13F);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Activecolor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.BorderRadius = 0;
            this.btnBuscar.ButtonText = "    Buscar";
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Iconimage")));
            this.btnBuscar.Iconimage_right = null;
            this.btnBuscar.Iconimage_right_Selected = null;
            this.btnBuscar.Iconimage_Selected = null;
            this.btnBuscar.IconMarginLeft = 0;
            this.btnBuscar.IconMarginRight = 0;
            this.btnBuscar.IconRightVisible = true;
            this.btnBuscar.IconRightZoom = 0D;
            this.btnBuscar.IconVisible = true;
            this.btnBuscar.IconZoom = 70D;
            this.btnBuscar.IsTab = false;
            this.btnBuscar.Location = new System.Drawing.Point(505, 779);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.OnHovercolor = System.Drawing.Color.White;
            this.btnBuscar.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnBuscar.selected = false;
            this.btnBuscar.Size = new System.Drawing.Size(210, 52);
            this.btnBuscar.TabIndex = 271;
            this.btnBuscar.Text = "    Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnBuscar.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 13F);
            this.btnBuscar.Click += new System.EventHandler(this.ButtonRegistrar_Click);
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1072, 857);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsers";
            this.Text = "FrmUsers";
            this.Load += new System.EventHandler(this.FrmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdmin;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscar;
    }
}