namespace ProjetoSenai
{
    partial class TelaVisitante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVisitante));
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.Minimizar = new FontAwesome.Sharp.IconButton();
            this.Janelas = new FontAwesome.Sharp.IconButton();
            this.Fechar = new FontAwesome.Sharp.IconButton();
            this.Nomepag = new System.Windows.Forms.Label();
            this.iconeprin = new System.Windows.Forms.PictureBox();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.PainelGeral = new System.Windows.Forms.Panel();
            this.iconesenai = new System.Windows.Forms.PictureBox();
            this.PainelLateral = new ProjetoSenai.GradientPanel();
            this.BtnSair = new FontAwesome.Sharp.IconButton();
            this.BtnInfo = new FontAwesome.Sharp.IconButton();
            this.BtnInicio = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEvento = new FontAwesome.Sharp.IconButton();
            this.BtnMenu = new FontAwesome.Sharp.IconPictureBox();
            this.BtnMapa = new FontAwesome.Sharp.IconButton();
            this.BtnFeedback = new FontAwesome.Sharp.IconButton();
            this.BtnContato = new FontAwesome.Sharp.IconButton();
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeprin)).BeginInit();
            this.PainelGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconesenai)).BeginInit();
            this.PainelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).BeginInit();
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
            this.BarraSuperior.TabIndex = 8;
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
            this.Janelas.Click += new System.EventHandler(this.Janelas_Click_1);
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
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click_1);
            // 
            // Nomepag
            // 
            this.Nomepag.AutoSize = true;
            this.Nomepag.BackColor = System.Drawing.Color.Transparent;
            this.Nomepag.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nomepag.ForeColor = System.Drawing.Color.White;
            this.Nomepag.Location = new System.Drawing.Point(72, 4);
            this.Nomepag.Name = "Nomepag";
            this.Nomepag.Size = new System.Drawing.Size(305, 40);
            this.Nomepag.TabIndex = 1;
            this.Nomepag.Text = "Guia de Visitantes";
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
            // sidebarTimer
            // 
            this.sidebarTimer.Enabled = true;
            this.sidebarTimer.Interval = 25;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // PainelGeral
            // 
            this.PainelGeral.BackColor = System.Drawing.Color.White;
            this.PainelGeral.Controls.Add(this.iconesenai);
            this.PainelGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PainelGeral.Location = new System.Drawing.Point(300, 50);
            this.PainelGeral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PainelGeral.Name = "PainelGeral";
            this.PainelGeral.Size = new System.Drawing.Size(1599, 1005);
            this.PainelGeral.TabIndex = 15;
            // 
            // iconesenai
            // 
            this.iconesenai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconesenai.Image = ((System.Drawing.Image)(resources.GetObject("iconesenai.Image")));
            this.iconesenai.Location = new System.Drawing.Point(389, 395);
            this.iconesenai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconesenai.Name = "iconesenai";
            this.iconesenai.Size = new System.Drawing.Size(893, 150);
            this.iconesenai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconesenai.TabIndex = 0;
            this.iconesenai.TabStop = false;
            // 
            // PainelLateral
            // 
            this.PainelLateral.AutoScroll = true;
            this.PainelLateral.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.PainelLateral.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.PainelLateral.Controls.Add(this.BtnSair);
            this.PainelLateral.Controls.Add(this.BtnInfo);
            this.PainelLateral.Controls.Add(this.BtnInicio);
            this.PainelLateral.Controls.Add(this.label1);
            this.PainelLateral.Controls.Add(this.BtnEvento);
            this.PainelLateral.Controls.Add(this.BtnMenu);
            this.PainelLateral.Controls.Add(this.BtnMapa);
            this.PainelLateral.Controls.Add(this.BtnFeedback);
            this.PainelLateral.Controls.Add(this.BtnContato);
            this.PainelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PainelLateral.Location = new System.Drawing.Point(0, 50);
            this.PainelLateral.Margin = new System.Windows.Forms.Padding(4);
            this.PainelLateral.MaximumSize = new System.Drawing.Size(300, 1723);
            this.PainelLateral.MinimumSize = new System.Drawing.Size(80, 1723);
            this.PainelLateral.Name = "PainelLateral";
            this.PainelLateral.Size = new System.Drawing.Size(300, 1723);
            this.PainelLateral.TabIndex = 14;
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.BtnSair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.BtnSair.IconColor = System.Drawing.Color.White;
            this.BtnSair.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnSair.IconSize = 54;
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSair.Location = new System.Drawing.Point(0, 500);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.BtnSair.Size = new System.Drawing.Size(300, 70);
            this.BtnSair.TabIndex = 15;
            this.BtnSair.Text = "  Sair";
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnInfo
            // 
            this.BtnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.BtnInfo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnInfo.FlatAppearance.BorderSize = 0;
            this.BtnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInfo.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInfo.ForeColor = System.Drawing.Color.White;
            this.BtnInfo.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.BtnInfo.IconColor = System.Drawing.Color.White;
            this.BtnInfo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnInfo.IconSize = 50;
            this.BtnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInfo.Location = new System.Drawing.Point(0, 430);
            this.BtnInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.BtnInfo.Size = new System.Drawing.Size(300, 70);
            this.BtnInfo.TabIndex = 14;
            this.BtnInfo.Text = "  Informação";
            this.BtnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInfo.UseVisualStyleBackColor = false;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // BtnInicio
            // 
            this.BtnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.BtnInicio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.Color.White;
            this.BtnInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.BtnInicio.IconColor = System.Drawing.Color.White;
            this.BtnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInicio.IconSize = 54;
            this.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.Location = new System.Drawing.Point(0, 80);
            this.BtnInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.BtnInicio.Size = new System.Drawing.Size(297, 70);
            this.BtnInicio.TabIndex = 6;
            this.BtnInicio.Text = "  Início";
            this.BtnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInicio.UseVisualStyleBackColor = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Menu";
            // 
            // BtnEvento
            // 
            this.BtnEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.BtnEvento.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEvento.FlatAppearance.BorderSize = 0;
            this.BtnEvento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.BtnEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEvento.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEvento.ForeColor = System.Drawing.Color.White;
            this.BtnEvento.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.BtnEvento.IconColor = System.Drawing.Color.White;
            this.BtnEvento.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnEvento.IconSize = 54;
            this.BtnEvento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEvento.Location = new System.Drawing.Point(0, 220);
            this.BtnEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEvento.Name = "BtnEvento";
            this.BtnEvento.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.BtnEvento.Size = new System.Drawing.Size(300, 70);
            this.BtnEvento.TabIndex = 8;
            this.BtnEvento.Text = "  Eventos";
            this.BtnEvento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEvento.UseVisualStyleBackColor = false;
            this.BtnEvento.Click += new System.EventHandler(this.BtnEvento_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMenu.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            this.BtnMenu.IconColor = System.Drawing.Color.White;
            this.BtnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMenu.IconSize = 57;
            this.BtnMenu.Location = new System.Drawing.Point(16, 15);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(61, 57);
            this.BtnMenu.TabIndex = 12;
            this.BtnMenu.TabStop = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnMapa
            // 
            this.BtnMapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.BtnMapa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnMapa.FlatAppearance.BorderSize = 0;
            this.BtnMapa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.BtnMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMapa.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMapa.ForeColor = System.Drawing.Color.White;
            this.BtnMapa.IconChar = FontAwesome.Sharp.IconChar.MapLocationDot;
            this.BtnMapa.IconColor = System.Drawing.Color.White;
            this.BtnMapa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMapa.IconSize = 52;
            this.BtnMapa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMapa.Location = new System.Drawing.Point(0, 150);
            this.BtnMapa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMapa.Name = "BtnMapa";
            this.BtnMapa.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.BtnMapa.Size = new System.Drawing.Size(300, 70);
            this.BtnMapa.TabIndex = 7;
            this.BtnMapa.Text = "  Localização";
            this.BtnMapa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMapa.UseVisualStyleBackColor = false;
            this.BtnMapa.Click += new System.EventHandler(this.BtnMapa_Click);
            // 
            // BtnFeedback
            // 
            this.BtnFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.BtnFeedback.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnFeedback.FlatAppearance.BorderSize = 0;
            this.BtnFeedback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.BtnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFeedback.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFeedback.ForeColor = System.Drawing.Color.White;
            this.BtnFeedback.IconChar = FontAwesome.Sharp.IconChar.UserPen;
            this.BtnFeedback.IconColor = System.Drawing.Color.White;
            this.BtnFeedback.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnFeedback.IconSize = 54;
            this.BtnFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFeedback.Location = new System.Drawing.Point(0, 290);
            this.BtnFeedback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFeedback.Name = "BtnFeedback";
            this.BtnFeedback.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.BtnFeedback.Size = new System.Drawing.Size(300, 70);
            this.BtnFeedback.TabIndex = 9;
            this.BtnFeedback.Text = "  FeedBack";
            this.BtnFeedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFeedback.UseVisualStyleBackColor = false;
            this.BtnFeedback.Click += new System.EventHandler(this.BtnFeedback_Click);
            // 
            // BtnContato
            // 
            this.BtnContato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.BtnContato.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnContato.FlatAppearance.BorderSize = 0;
            this.BtnContato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.BtnContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContato.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContato.ForeColor = System.Drawing.Color.White;
            this.BtnContato.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.BtnContato.IconColor = System.Drawing.Color.White;
            this.BtnContato.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnContato.IconSize = 54;
            this.BtnContato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnContato.Location = new System.Drawing.Point(0, 360);
            this.BtnContato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnContato.Name = "BtnContato";
            this.BtnContato.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.BtnContato.Size = new System.Drawing.Size(300, 70);
            this.BtnContato.TabIndex = 10;
            this.BtnContato.Text = "  Contato";
            this.BtnContato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnContato.UseVisualStyleBackColor = false;
            this.BtnContato.Click += new System.EventHandler(this.BtnContato_Click);
            // 
            // TelaVisitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 1055);
            this.Controls.Add(this.PainelGeral);
            this.Controls.Add(this.PainelLateral);
            this.Controls.Add(this.BarraSuperior);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TelaVisitante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TelaVisitante";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeprin)).EndInit();
            this.PainelGeral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconesenai)).EndInit();
            this.PainelLateral.ResumeLayout(false);
            this.PainelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BarraSuperior;
        private FontAwesome.Sharp.IconButton Minimizar;
        private FontAwesome.Sharp.IconButton Janelas;
        private FontAwesome.Sharp.IconButton Fechar;
        private System.Windows.Forms.Label Nomepag;
        private System.Windows.Forms.PictureBox iconeprin;
        private FontAwesome.Sharp.IconButton BtnInicio;
        private FontAwesome.Sharp.IconButton BtnMapa;
        private FontAwesome.Sharp.IconButton BtnEvento;
        private FontAwesome.Sharp.IconButton BtnFeedback;
        private FontAwesome.Sharp.IconButton BtnContato;
        private FontAwesome.Sharp.IconPictureBox BtnMenu;
        private System.Windows.Forms.Label label1;
        private GradientPanel PainelLateral;
        private FontAwesome.Sharp.IconButton BtnInfo;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel PainelGeral;
        private System.Windows.Forms.PictureBox iconesenai;
        private FontAwesome.Sharp.IconButton BtnSair;
    }
}