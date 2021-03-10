
namespace ActividadesAgape
{
    partial class FrmActividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActividades));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtDescripcionAct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRgtAct = new System.Windows.Forms.Panel();
            this.btnAdmin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.dataGridViewAct = new System.Windows.Forms.DataGridView();
            this.panelMaimRgtAct = new System.Windows.Forms.Panel();
            this.panelRgtAct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAct)).BeginInit();
            this.panelMaimRgtAct.SuspendLayout();
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
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(33, 769);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(516, 10);
            this.bunifuGradientPanel1.TabIndex = 261;
            // 
            // txtDescripcionAct
            // 
            this.txtDescripcionAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtDescripcionAct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcionAct.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionAct.ForeColor = System.Drawing.Color.White;
            this.txtDescripcionAct.HideSelection = false;
            this.txtDescripcionAct.Location = new System.Drawing.Point(225, 711);
            this.txtDescripcionAct.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionAct.Multiline = true;
            this.txtDescripcionAct.Name = "txtDescripcionAct";
            this.txtDescripcionAct.Size = new System.Drawing.Size(300, 43);
            this.txtDescripcionAct.TabIndex = 260;
            this.txtDescripcionAct.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 718);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 36);
            this.label2.TabIndex = 259;
            this.label2.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 74);
            this.label1.TabIndex = 257;
            this.label1.Text = "Actividades:";
            // 
            // panelRgtAct
            // 
            this.panelRgtAct.Controls.Add(this.panelMaimRgtAct);
            this.panelRgtAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRgtAct.Location = new System.Drawing.Point(0, 0);
            this.panelRgtAct.Name = "panelRgtAct";
            this.panelRgtAct.Size = new System.Drawing.Size(1072, 857);
            this.panelRgtAct.TabIndex = 264;
            // 
            // btnAdmin
            // 
            this.btnAdmin.ActiveBorderThickness = 1;
            this.btnAdmin.ActiveCornerRadius = 20;
            this.btnAdmin.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdmin.ActiveForecolor = System.Drawing.Color.White;
            this.btnAdmin.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdmin.BackgroundImage")));
            this.btnAdmin.ButtonText = "Administrar";
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnAdmin.IdleBorderThickness = 1;
            this.btnAdmin.IdleCornerRadius = 20;
            this.btnAdmin.IdleFillColor = System.Drawing.Color.White;
            this.btnAdmin.IdleForecolor = System.Drawing.Color.Black;
            this.btnAdmin.IdleLineColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(832, 727);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(199, 56);
            this.btnAdmin.TabIndex = 263;
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ActiveBorderThickness = 1;
            this.btnBuscar.ActiveCornerRadius = 20;
            this.btnBuscar.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.ActiveForecolor = System.Drawing.Color.White;
            this.btnBuscar.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.ButtonText = "Buscar";
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.IdleBorderThickness = 1;
            this.btnBuscar.IdleCornerRadius = 20;
            this.btnBuscar.IdleFillColor = System.Drawing.Color.White;
            this.btnBuscar.IdleForecolor = System.Drawing.Color.Black;
            this.btnBuscar.IdleLineColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(633, 727);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(170, 56);
            this.btnBuscar.TabIndex = 262;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(766, 27);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(274, 97);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 264;
            this.pictureBoxLogo.TabStop = false;
            // 
            // dataGridViewAct
            // 
            this.dataGridViewAct.AllowUserToDeleteRows = false;
            this.dataGridViewAct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.dataGridViewAct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewAct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(147)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(147)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAct.ColumnHeadersHeight = 50;
            this.dataGridViewAct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAct.EnableHeadersVisualStyles = false;
            this.dataGridViewAct.Location = new System.Drawing.Point(33, 205);
            this.dataGridViewAct.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAct.Name = "dataGridViewAct";
            this.dataGridViewAct.ReadOnly = true;
            this.dataGridViewAct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAct.RowHeadersWidth = 51;
            this.dataGridViewAct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAct.Size = new System.Drawing.Size(1007, 449);
            this.dataGridViewAct.TabIndex = 265;
            // 
            // panelMaimRgtAct
            // 
            this.panelMaimRgtAct.Controls.Add(this.txtDescripcionAct);
            this.panelMaimRgtAct.Controls.Add(this.dataGridViewAct);
            this.panelMaimRgtAct.Controls.Add(this.label2);
            this.panelMaimRgtAct.Controls.Add(this.pictureBoxLogo);
            this.panelMaimRgtAct.Controls.Add(this.bunifuGradientPanel1);
            this.panelMaimRgtAct.Controls.Add(this.btnAdmin);
            this.panelMaimRgtAct.Controls.Add(this.label1);
            this.panelMaimRgtAct.Controls.Add(this.btnBuscar);
            this.panelMaimRgtAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMaimRgtAct.Location = new System.Drawing.Point(0, 0);
            this.panelMaimRgtAct.Name = "panelMaimRgtAct";
            this.panelMaimRgtAct.Size = new System.Drawing.Size(1072, 857);
            this.panelMaimRgtAct.TabIndex = 266;
            // 
            // FrmActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1072, 857);
            this.Controls.Add(this.panelRgtAct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmActividades";
            this.Text = "FrmActividades";
            this.Load += new System.EventHandler(this.FrmActividades_Load);
            this.panelRgtAct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAct)).EndInit();
            this.panelMaimRgtAct.ResumeLayout(false);
            this.panelMaimRgtAct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.TextBox txtDescripcionAct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRgtAct;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdmin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBuscar;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.DataGridView dataGridViewAct;
        private System.Windows.Forms.Panel panelMaimRgtAct;
    }
}