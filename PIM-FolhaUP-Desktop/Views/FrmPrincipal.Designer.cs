namespace PIM_FolhaUP_Desktop
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.imglIcones1 = new System.Windows.Forms.ImageList(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDireitos = new System.Windows.Forms.Label();
            this.pnlEmpresas = new System.Windows.Forms.Panel();
            this.btnVerEmpresas = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblEmpresas = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnVerRelatorios = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRelatorio = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnVerManualUsuario = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDepartamentos = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnVerSobreNos = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlEmpresas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 465);
            this.panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnSair.ImageKey = "failure.png";
            this.btnSair.ImageList = this.imglIcones1;
            this.btnSair.Location = new System.Drawing.Point(0, 390);
            this.btnSair.Name = "btnSair";
            this.btnSair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSair.Size = new System.Drawing.Size(186, 65);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "  Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // imglIcones1
            // 
            this.imglIcones1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglIcones1.ImageStream")));
            this.imglIcones1.TransparentColor = System.Drawing.Color.Transparent;
            this.imglIcones1.Images.SetKeyName(0, "delete.png");
            this.imglIcones1.Images.SetKeyName(1, "failure.png");
            this.imglIcones1.Images.SetKeyName(2, "pen.png");
            this.imglIcones1.Images.SetKeyName(3, "register.png");
            this.imglIcones1.Images.SetKeyName(4, "search.png");
            // 
            // btnBuscar
            // 
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.ImageKey = "search.png";
            this.btnBuscar.ImageList = this.imglIcones1;
            this.btnBuscar.Location = new System.Drawing.Point(0, 324);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBuscar.Size = new System.Drawing.Size(186, 60);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "  Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.ImageKey = "delete.png";
            this.btnExcluir.ImageList = this.imglIcones1;
            this.btnExcluir.Location = new System.Drawing.Point(0, 264);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExcluir.Size = new System.Drawing.Size(186, 60);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "  Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.ImageKey = "pen.png";
            this.btnEditar.ImageList = this.imglIcones1;
            this.btnEditar.Location = new System.Drawing.Point(0, 204);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditar.Size = new System.Drawing.Size(186, 60);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "  Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.ImageKey = "register.png";
            this.btnInserir.ImageList = this.imglIcones1;
            this.btnInserir.Location = new System.Drawing.Point(0, 144);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInserir.Size = new System.Drawing.Size(186, 60);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "  Inserir";
            this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblAdministrador);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrador.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblAdministrador.Location = new System.Drawing.Point(37, 96);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(103, 16);
            this.lblAdministrador.TabIndex = 1;
            this.lblAdministrador.Text = "Administrador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PIM_FolhaUP_Desktop.Properties.Resources.programmer;
            this.pictureBox1.Location = new System.Drawing.Point(60, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDireitos
            // 
            this.lblDireitos.AutoSize = true;
            this.lblDireitos.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireitos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDireitos.Location = new System.Drawing.Point(664, 451);
            this.lblDireitos.Name = "lblDireitos";
            this.lblDireitos.Size = new System.Drawing.Size(179, 14);
            this.lblDireitos.TabIndex = 1;
            this.lblDireitos.Text = "FolhaUP - Todos os direitos reservados";
            // 
            // pnlEmpresas
            // 
            this.pnlEmpresas.BackColor = System.Drawing.Color.Indigo;
            this.pnlEmpresas.Controls.Add(this.btnVerEmpresas);
            this.pnlEmpresas.Controls.Add(this.pictureBox2);
            this.pnlEmpresas.Controls.Add(this.lblTotal);
            this.pnlEmpresas.Controls.Add(this.lblNumero);
            this.pnlEmpresas.Controls.Add(this.lblEmpresas);
            this.pnlEmpresas.Location = new System.Drawing.Point(211, 30);
            this.pnlEmpresas.Name = "pnlEmpresas";
            this.pnlEmpresas.Size = new System.Drawing.Size(258, 130);
            this.pnlEmpresas.TabIndex = 2;
            this.pnlEmpresas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEmpresas_Click);
            // 
            // btnVerEmpresas
            // 
            this.btnVerEmpresas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVerEmpresas.FlatAppearance.BorderSize = 0;
            this.btnVerEmpresas.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEmpresas.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnVerEmpresas.ImageKey = "failure.png";
            this.btnVerEmpresas.Location = new System.Drawing.Point(214, 3);
            this.btnVerEmpresas.Name = "btnVerEmpresas";
            this.btnVerEmpresas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVerEmpresas.Size = new System.Drawing.Size(41, 29);
            this.btnVerEmpresas.TabIndex = 7;
            this.btnVerEmpresas.Text = "Ver";
            this.btnVerEmpresas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerEmpresas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerEmpresas.UseVisualStyleBackColor = false;
            this.btnVerEmpresas.Click += new System.EventHandler(this.btnVerEmpresas_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PIM_FolhaUP_Desktop.Properties.Resources.buildings;
            this.pictureBox2.Location = new System.Drawing.Point(130, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTotal.Location = new System.Drawing.Point(27, 88);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(203, 42);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total de empresas cadastradas em todo o período.";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblNumero.Location = new System.Drawing.Point(23, 57);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(29, 31);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "0";
            // 
            // lblEmpresas
            // 
            this.lblEmpresas.AutoSize = true;
            this.lblEmpresas.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmpresas.Location = new System.Drawing.Point(24, 17);
            this.lblEmpresas.Name = "lblEmpresas";
            this.lblEmpresas.Size = new System.Drawing.Size(92, 25);
            this.lblEmpresas.TabIndex = 0;
            this.lblEmpresas.Text = "Empresas";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Controls.Add(this.btnVerRelatorios);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lblRelatorio);
            this.panel4.Location = new System.Drawing.Point(475, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(347, 130);
            this.panel4.TabIndex = 4;
            // 
            // btnVerRelatorios
            // 
            this.btnVerRelatorios.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVerRelatorios.FlatAppearance.BorderSize = 0;
            this.btnVerRelatorios.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerRelatorios.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnVerRelatorios.ImageKey = "failure.png";
            this.btnVerRelatorios.Location = new System.Drawing.Point(303, 3);
            this.btnVerRelatorios.Name = "btnVerRelatorios";
            this.btnVerRelatorios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVerRelatorios.Size = new System.Drawing.Size(41, 29);
            this.btnVerRelatorios.TabIndex = 10;
            this.btnVerRelatorios.Text = "Ver";
            this.btnVerRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerRelatorios.UseVisualStyleBackColor = false;
            this.btnVerRelatorios.Click += new System.EventHandler(this.btnVerRelatorios_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PIM_FolhaUP_Desktop.Properties.Resources.report;
            this.pictureBox3.Location = new System.Drawing.Point(225, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(27, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Relatório de todos os dados de todas as empresas. Geração de PDF.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRelatorio
            // 
            this.lblRelatorio.AutoSize = true;
            this.lblRelatorio.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRelatorio.Location = new System.Drawing.Point(24, 17);
            this.lblRelatorio.Name = "lblRelatorio";
            this.lblRelatorio.Size = new System.Drawing.Size(87, 25);
            this.lblRelatorio.TabIndex = 0;
            this.lblRelatorio.Text = "Relatório";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Indigo;
            this.panel5.Controls.Add(this.btnVerManualUsuario);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lblDepartamentos);
            this.panel5.Location = new System.Drawing.Point(475, 166);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(347, 130);
            this.panel5.TabIndex = 4;
            // 
            // btnVerManualUsuario
            // 
            this.btnVerManualUsuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVerManualUsuario.FlatAppearance.BorderSize = 0;
            this.btnVerManualUsuario.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerManualUsuario.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnVerManualUsuario.ImageKey = "failure.png";
            this.btnVerManualUsuario.Location = new System.Drawing.Point(301, 3);
            this.btnVerManualUsuario.Name = "btnVerManualUsuario";
            this.btnVerManualUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVerManualUsuario.Size = new System.Drawing.Size(41, 29);
            this.btnVerManualUsuario.TabIndex = 8;
            this.btnVerManualUsuario.Text = "Ver";
            this.btnVerManualUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerManualUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerManualUsuario.UseVisualStyleBackColor = false;
            this.btnVerManualUsuario.Click += new System.EventHandler(this.btnVerManualUsuario_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PIM_FolhaUP_Desktop.Properties.Resources.buildings;
            this.pictureBox4.Location = new System.Drawing.Point(227, 38);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(27, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aprenda a utilizar o nosso software para liberação do acesso as empresas.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepartamentos
            // 
            this.lblDepartamentos.AutoSize = true;
            this.lblDepartamentos.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamentos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDepartamentos.Location = new System.Drawing.Point(24, 17);
            this.lblDepartamentos.Name = "lblDepartamentos";
            this.lblDepartamentos.Size = new System.Drawing.Size(173, 25);
            this.lblDepartamentos.TabIndex = 0;
            this.lblDepartamentos.Text = "Manual do Usuário";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Indigo;
            this.panel6.Controls.Add(this.btnVerSobreNos);
            this.panel6.Controls.Add(this.pictureBox5);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(209, 166);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(260, 130);
            this.panel6.TabIndex = 4;
            // 
            // btnVerSobreNos
            // 
            this.btnVerSobreNos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVerSobreNos.FlatAppearance.BorderSize = 0;
            this.btnVerSobreNos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerSobreNos.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnVerSobreNos.ImageKey = "failure.png";
            this.btnVerSobreNos.Location = new System.Drawing.Point(216, 3);
            this.btnVerSobreNos.Name = "btnVerSobreNos";
            this.btnVerSobreNos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVerSobreNos.Size = new System.Drawing.Size(41, 29);
            this.btnVerSobreNos.TabIndex = 9;
            this.btnVerSobreNos.Text = "Ver";
            this.btnVerSobreNos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerSobreNos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerSobreNos.UseVisualStyleBackColor = false;
            this.btnVerSobreNos.Click += new System.EventHandler(this.btnVerSobreNos_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PIM_FolhaUP_Desktop.Properties.Resources.information;
            this.pictureBox5.Location = new System.Drawing.Point(129, 38);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(29, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 42);
            this.label6.TabIndex = 2;
            this.label6.Text = "Informações sobre o sistema.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(24, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sobre Nós";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(846, 465);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlEmpresas);
            this.Controls.Add(this.lblDireitos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FolhaUp";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlEmpresas.ResumeLayout(false);
            this.pnlEmpresas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ImageList imglIcones1;
        private System.Windows.Forms.Label lblDireitos;
        private System.Windows.Forms.Panel pnlEmpresas;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblEmpresas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRelatorio;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDepartamentos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVerEmpresas;
        private System.Windows.Forms.Button btnVerRelatorios;
        private System.Windows.Forms.Button btnVerManualUsuario;
        private System.Windows.Forms.Button btnVerSobreNos;
    }
}

