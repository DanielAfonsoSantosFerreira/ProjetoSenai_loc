namespace ProjetoSenai
{
    partial class TelaPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPerfil));
            this.Idusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nomefun = new System.Windows.Forms.TextBox();
            this.Funcaofun = new System.Windows.Forms.TextBox();
            this.Emailfun = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.FotoPerfil = new ProjetoSenai.BordasPerfil();
            this.gradientPanel1 = new ProjetoSenai.GradientPanel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.box_pesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Idusuario
            // 
            this.Idusuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Idusuario.Enabled = false;
            this.Idusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idusuario.Location = new System.Drawing.Point(215, 400);
            this.Idusuario.Margin = new System.Windows.Forms.Padding(2);
            this.Idusuario.MaxLength = 50;
            this.Idusuario.Name = "Idusuario";
            this.Idusuario.Size = new System.Drawing.Size(207, 32);
            this.Idusuario.TabIndex = 1;
            this.Idusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 377);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID usuário";
            // 
            // Nomefun
            // 
            this.Nomefun.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Nomefun.Enabled = false;
            this.Nomefun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nomefun.Location = new System.Drawing.Point(477, 237);
            this.Nomefun.Margin = new System.Windows.Forms.Padding(2);
            this.Nomefun.MaxLength = 50;
            this.Nomefun.Name = "Nomefun";
            this.Nomefun.Size = new System.Drawing.Size(470, 32);
            this.Nomefun.TabIndex = 3;
            // 
            // Funcaofun
            // 
            this.Funcaofun.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Funcaofun.Enabled = false;
            this.Funcaofun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Funcaofun.Location = new System.Drawing.Point(477, 400);
            this.Funcaofun.Margin = new System.Windows.Forms.Padding(2);
            this.Funcaofun.MaxLength = 50;
            this.Funcaofun.Name = "Funcaofun";
            this.Funcaofun.Size = new System.Drawing.Size(470, 32);
            this.Funcaofun.TabIndex = 4;
            // 
            // Emailfun
            // 
            this.Emailfun.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Emailfun.Enabled = false;
            this.Emailfun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailfun.Location = new System.Drawing.Point(477, 318);
            this.Emailfun.Margin = new System.Windows.Forms.Padding(2);
            this.Emailfun.MaxLength = 50;
            this.Emailfun.Name = "Emailfun";
            this.Emailfun.Size = new System.Drawing.Size(470, 32);
            this.Emailfun.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome do Funcionário";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 296);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(473, 377);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Função";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 478);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1086, 370);
            this.dataGridView1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 455);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Histórico";
            // 
            // FotoPerfil
            // 
            this.FotoPerfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FotoPerfil.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.FotoPerfil.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.FotoPerfil.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.FotoPerfil.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.FotoPerfil.BorderSize = 3;
            this.FotoPerfil.GradientAngle = 100F;
            this.FotoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("FotoPerfil.Image")));
            this.FotoPerfil.Location = new System.Drawing.Point(229, 182);
            this.FotoPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.FotoPerfil.Name = "FotoPerfil";
            this.FotoPerfil.Size = new System.Drawing.Size(184, 184);
            this.FotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoPerfil.TabIndex = 0;
            this.FotoPerfil.TabStop = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.gradientPanel1.Controls.Add(this.iconPictureBox1);
            this.gradientPanel1.Controls.Add(this.label6);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1149, 172);
            this.gradientPanel1.TabIndex = 11;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox1.IconSize = 112;
            this.iconPictureBox1.Location = new System.Drawing.Point(90, 24);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(112, 122);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 46.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(207, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(642, 77);
            this.label6.TabIndex = 0;
            this.label6.Text = "Perfil do Funcionário";
            // 
            // box_pesquisa
            // 
            this.box_pesquisa.Location = new System.Drawing.Point(38, 182);
            this.box_pesquisa.Name = "box_pesquisa";
            this.box_pesquisa.Size = new System.Drawing.Size(100, 20);
            this.box_pesquisa.TabIndex = 13;
            this.box_pesquisa.Visible = false;
            // 
            // TelaPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1149, 881);
            this.Controls.Add(this.box_pesquisa);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Emailfun);
            this.Controls.Add(this.Funcaofun);
            this.Controls.Add(this.Nomefun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Idusuario);
            this.Controls.Add(this.FotoPerfil);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TelaPerfil";
            this.Text = "TelaPerfil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BordasPerfil FotoPerfil;
        private System.Windows.Forms.TextBox Idusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nomefun;
        private System.Windows.Forms.TextBox Funcaofun;
        private System.Windows.Forms.TextBox Emailfun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox box_pesquisa;
    }
}