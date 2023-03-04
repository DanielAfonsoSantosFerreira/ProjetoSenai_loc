namespace ProjetoSenai
{
    partial class TelaAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAdm));
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.Minimizar = new FontAwesome.Sharp.IconButton();
            this.Janelas = new FontAwesome.Sharp.IconButton();
            this.Fechar = new FontAwesome.Sharp.IconButton();
            this.Nomepag = new System.Windows.Forms.Label();
            this.iconeprin = new System.Windows.Forms.PictureBox();
            this.PainelGeral = new System.Windows.Forms.Panel();
            this.iconesenai = new System.Windows.Forms.PictureBox();
            this.PainelMenu = new ProjetoSenai.GradientPanel();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.btnsair = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnfeedback = new FontAwesome.Sharp.IconButton();
            this.Btneventos = new FontAwesome.Sharp.IconButton();
            this.btnSala = new FontAwesome.Sharp.IconButton();
            this.Btnperfil = new FontAwesome.Sharp.IconButton();
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeprin)).BeginInit();
            this.PainelGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconesenai)).BeginInit();
            this.PainelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.BarraSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarraSuperior.Controls.Add(this.Minimizar);
            this.BarraSuperior.Controls.Add(this.Janelas);
            this.BarraSuperior.Controls.Add(this.Fechar);
            this.BarraSuperior.Controls.Add(this.Nomepag);
            this.BarraSuperior.Controls.Add(this.iconeprin);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(1899, 50);
            this.BarraSuperior.TabIndex = 1;
            this.BarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseDown);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Minimizar.FlatAppearance.BorderSize = 0;
            this.Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.Minimizar.IconColor = System.Drawing.Color.White;
            this.Minimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Minimizar.IconSize = 25;
            this.Minimizar.Location = new System.Drawing.Point(1778, 11);
            this.Minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(29, 30);
            this.Minimizar.TabIndex = 7;
            this.Minimizar.UseVisualStyleBackColor = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Janelas
            // 
            this.Janelas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Janelas.BackColor = System.Drawing.Color.Transparent;
            this.Janelas.FlatAppearance.BorderSize = 0;
            this.Janelas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.Janelas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.Janelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Janelas.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.Janelas.IconColor = System.Drawing.Color.White;
            this.Janelas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Janelas.IconSize = 25;
            this.Janelas.Location = new System.Drawing.Point(1820, 11);
            this.Janelas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Janelas.Name = "Janelas";
            this.Janelas.Size = new System.Drawing.Size(29, 30);
            this.Janelas.TabIndex = 6;
            this.Janelas.UseVisualStyleBackColor = false;
            this.Janelas.Click += new System.EventHandler(this.Janelas_Click);
            // 
            // Fechar
            // 
            this.Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Fechar.FlatAppearance.BorderSize = 0;
            this.Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fechar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.Fechar.IconColor = System.Drawing.Color.White;
            this.Fechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Fechar.IconSize = 25;
            this.Fechar.Location = new System.Drawing.Point(1856, 11);
            this.Fechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(29, 30);
            this.Fechar.TabIndex = 5;
            this.Fechar.UseVisualStyleBackColor = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Nomepag
            // 
            this.Nomepag.AutoSize = true;
            this.Nomepag.BackColor = System.Drawing.Color.Transparent;
            this.Nomepag.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nomepag.ForeColor = System.Drawing.Color.White;
            this.Nomepag.Location = new System.Drawing.Point(72, 4);
            this.Nomepag.Name = "Nomepag";
            this.Nomepag.Size = new System.Drawing.Size(249, 40);
            this.Nomepag.TabIndex = 1;
            this.Nomepag.Text = "Administração";
            // 
            // iconeprin
            // 
            this.iconeprin.Image = ((System.Drawing.Image)(resources.GetObject("iconeprin.Image")));
            this.iconeprin.Location = new System.Drawing.Point(11, -7);
            this.iconeprin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconeprin.Name = "iconeprin";
            this.iconeprin.Size = new System.Drawing.Size(60, 60);
            this.iconeprin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconeprin.TabIndex = 0;
            this.iconeprin.TabStop = false;
            // 
            // PainelGeral
            // 
            this.PainelGeral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PainelGeral.Controls.Add(this.iconesenai);
            this.PainelGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PainelGeral.Location = new System.Drawing.Point(346, 50);
            this.PainelGeral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PainelGeral.Name = "PainelGeral";
            this.PainelGeral.Size = new System.Drawing.Size(1553, 1005);
            this.PainelGeral.TabIndex = 6;
            // 
            // iconesenai
            // 
            this.iconesenai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconesenai.Image = ((System.Drawing.Image)(resources.GetObject("iconesenai.Image")));
            this.iconesenai.Location = new System.Drawing.Point(367, 395);
            this.iconesenai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconesenai.Name = "iconesenai";
            this.iconesenai.Size = new System.Drawing.Size(893, 150);
            this.iconesenai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconesenai.TabIndex = 0;
            this.iconesenai.TabStop = false;
            // 
            // PainelMenu
            // 
            this.PainelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PainelMenu.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.PainelMenu.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.PainelMenu.Controls.Add(this.btnInicio);
            this.PainelMenu.Controls.Add(this.btnsair);
            this.PainelMenu.Controls.Add(this.label3);
            this.PainelMenu.Controls.Add(this.label2);
            this.PainelMenu.Controls.Add(this.label1);
            this.PainelMenu.Controls.Add(this.iconPictureBox1);
            this.PainelMenu.Controls.Add(this.btnfeedback);
            this.PainelMenu.Controls.Add(this.Btneventos);
            this.PainelMenu.Controls.Add(this.btnSala);
            this.PainelMenu.Controls.Add(this.Btnperfil);
            this.PainelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PainelMenu.Location = new System.Drawing.Point(0, 50);
            this.PainelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PainelMenu.Name = "PainelMenu";
            this.PainelMenu.Size = new System.Drawing.Size(346, 1005);
            this.PainelMenu.TabIndex = 3;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnInicio.IconColor = System.Drawing.Color.White;
            this.btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInicio.IconSize = 52;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 194);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(347, 75);
            this.btnInicio.TabIndex = 9;
            this.btnInicio.Text = "  Início";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnsair
            // 
            this.btnsair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnsair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.btnsair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.Color.White;
            this.btnsair.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnsair.IconColor = System.Drawing.Color.White;
            this.btnsair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsair.IconSize = 52;
            this.btnsair.Location = new System.Drawing.Point(0, 904);
            this.btnsair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsair.Name = "btnsair";
            this.btnsair.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnsair.Size = new System.Drawing.Size(347, 100);
            this.btnsair.TabIndex = 4;
            this.btnsair.Text = "Sair";
            this.btnsair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(109, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 51);
            this.label3.TabIndex = 8;
            this.label3.Text = "Indústria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "Campus da";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "Senai";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MapMarkerAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 100;
            this.iconPictureBox1.Location = new System.Drawing.Point(3, 53);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnfeedback
            // 
            this.btnfeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.btnfeedback.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnfeedback.FlatAppearance.BorderSize = 0;
            this.btnfeedback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.btnfeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfeedback.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfeedback.ForeColor = System.Drawing.Color.White;
            this.btnfeedback.IconChar = FontAwesome.Sharp.IconChar.UserPen;
            this.btnfeedback.IconColor = System.Drawing.Color.White;
            this.btnfeedback.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnfeedback.IconSize = 52;
            this.btnfeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfeedback.Location = new System.Drawing.Point(0, 492);
            this.btnfeedback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfeedback.Name = "btnfeedback";
            this.btnfeedback.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnfeedback.Size = new System.Drawing.Size(347, 75);
            this.btnfeedback.TabIndex = 3;
            this.btnfeedback.Text = "  FeedBack";
            this.btnfeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfeedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnfeedback.UseVisualStyleBackColor = false;
            this.btnfeedback.Click += new System.EventHandler(this.btnfeedback_Click);
            // 
            // Btneventos
            // 
            this.Btneventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.Btneventos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btneventos.FlatAppearance.BorderSize = 0;
            this.Btneventos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.Btneventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btneventos.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btneventos.ForeColor = System.Drawing.Color.White;
            this.Btneventos.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.Btneventos.IconColor = System.Drawing.Color.White;
            this.Btneventos.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btneventos.IconSize = 52;
            this.Btneventos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btneventos.Location = new System.Drawing.Point(0, 417);
            this.Btneventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btneventos.Name = "Btneventos";
            this.Btneventos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Btneventos.Size = new System.Drawing.Size(347, 75);
            this.Btneventos.TabIndex = 2;
            this.Btneventos.Text = "  Eventos";
            this.Btneventos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btneventos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btneventos.UseVisualStyleBackColor = false;
            this.Btneventos.Click += new System.EventHandler(this.Btneventos_Click);
            // 
            // btnSala
            // 
            this.btnSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.btnSala.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSala.FlatAppearance.BorderSize = 0;
            this.btnSala.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.btnSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSala.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSala.ForeColor = System.Drawing.Color.White;
            this.btnSala.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btnSala.IconColor = System.Drawing.Color.White;
            this.btnSala.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSala.IconSize = 52;
            this.btnSala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSala.Location = new System.Drawing.Point(0, 344);
            this.btnSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSala.Name = "btnSala";
            this.btnSala.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSala.Size = new System.Drawing.Size(347, 75);
            this.btnSala.TabIndex = 1;
            this.btnSala.Text = "  Salas";
            this.btnSala.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSala.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSala.UseVisualStyleBackColor = false;
            this.btnSala.Click += new System.EventHandler(this.btnSala_Click);
            // 
            // Btnperfil
            // 
            this.Btnperfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.Btnperfil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btnperfil.FlatAppearance.BorderSize = 0;
            this.Btnperfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.Btnperfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnperfil.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnperfil.ForeColor = System.Drawing.Color.White;
            this.Btnperfil.IconChar = FontAwesome.Sharp.IconChar.User;
            this.Btnperfil.IconColor = System.Drawing.Color.White;
            this.Btnperfil.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btnperfil.IconSize = 52;
            this.Btnperfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnperfil.Location = new System.Drawing.Point(0, 269);
            this.Btnperfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btnperfil.Name = "Btnperfil";
            this.Btnperfil.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Btnperfil.Size = new System.Drawing.Size(345, 75);
            this.Btnperfil.TabIndex = 0;
            this.Btnperfil.Text = "  Perfil";
            this.Btnperfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnperfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btnperfil.UseVisualStyleBackColor = false;
            this.Btnperfil.Click += new System.EventHandler(this.Btnperfil_Click);
            // 
            // TelaAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 1055);
            this.Controls.Add(this.PainelGeral);
            this.Controls.Add(this.PainelMenu);
            this.Controls.Add(this.BarraSuperior);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TelaAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeprin)).EndInit();
            this.PainelGeral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconesenai)).EndInit();
            this.PainelMenu.ResumeLayout(false);
            this.PainelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label Nomepag;
        private System.Windows.Forms.PictureBox iconeprin;
        private FontAwesome.Sharp.IconButton Fechar;
        private FontAwesome.Sharp.IconButton Minimizar;
        private FontAwesome.Sharp.IconButton Janelas;
        private GradientPanel PainelMenu;
        private FontAwesome.Sharp.IconButton Btnperfil;
        private FontAwesome.Sharp.IconButton btnfeedback;
        private FontAwesome.Sharp.IconButton Btneventos;
        private FontAwesome.Sharp.IconButton btnSala;
        private FontAwesome.Sharp.IconButton btnsair;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PainelGeral;
        private System.Windows.Forms.PictureBox iconesenai;
        private FontAwesome.Sharp.IconButton btnInicio;
    }
}