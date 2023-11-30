namespace PIM_FolhaUP_Desktop.Views
{
    partial class FrmTelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaInicial));
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnIniciarSistema = new System.Windows.Forms.Button();
            this.lblDireitos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imglIcones7 = new System.Windows.Forms.ImageList(this.components);
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.BtnIniciarSistema);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(12, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(476, 375);
            this.panel6.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PIM_FolhaUP_Desktop.Properties.Resources.logoFolhaUp;
            this.pictureBox1.Location = new System.Drawing.Point(114, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // BtnIniciarSistema
            // 
            this.BtnIniciarSistema.BackColor = System.Drawing.Color.Indigo;
            this.BtnIniciarSistema.FlatAppearance.BorderSize = 0;
            this.BtnIniciarSistema.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSistema.ForeColor = System.Drawing.Color.LavenderBlush;
            this.BtnIniciarSistema.ImageKey = "(nenhum/a)";
            this.BtnIniciarSistema.Location = new System.Drawing.Point(114, 253);
            this.BtnIniciarSistema.Name = "BtnIniciarSistema";
            this.BtnIniciarSistema.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnIniciarSistema.Size = new System.Drawing.Size(237, 75);
            this.BtnIniciarSistema.TabIndex = 9;
            this.BtnIniciarSistema.Text = "INICIAR SISTEMA";
            this.BtnIniciarSistema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnIniciarSistema.UseVisualStyleBackColor = false;
            this.BtnIniciarSistema.Click += new System.EventHandler(this.BtnIniciarSistema_Click);
            // 
            // lblDireitos
            // 
            this.lblDireitos.AutoSize = true;
            this.lblDireitos.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireitos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDireitos.Location = new System.Drawing.Point(157, 390);
            this.lblDireitos.Name = "lblDireitos";
            this.lblDireitos.Size = new System.Drawing.Size(179, 14);
            this.lblDireitos.TabIndex = 3;
            this.lblDireitos.Text = "FolhaUP - Todos os direitos reservados";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Indigo;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(33, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(409, 330);
            this.label6.TabIndex = 2;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imglIcones7
            // 
            this.imglIcones7.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglIcones7.ImageStream")));
            this.imglIcones7.TransparentColor = System.Drawing.Color.Transparent;
            this.imglIcones7.Images.SetKeyName(0, "back.png");
            this.imglIcones7.Images.SetKeyName(1, "delete.png");
            this.imglIcones7.Images.SetKeyName(2, "failure.png");
            this.imglIcones7.Images.SetKeyName(3, "pen.png");
            this.imglIcones7.Images.SetKeyName(4, "register.png");
            this.imglIcones7.Images.SetKeyName(5, "search.png");
            // 
            // FrmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(500, 411);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lblDireitos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTelaInicial";
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblDireitos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnIniciarSistema;
        private System.Windows.Forms.ImageList imglIcones7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}