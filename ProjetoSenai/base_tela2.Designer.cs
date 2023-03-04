namespace ProjetoSenai
{
    partial class base_tela2
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lb_nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_funcao = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.box_pesquisa = new System.Windows.Forms.TextBox();
            this.btn_pesquisa_img = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.bordasPerfil1 = new ProjetoSenai.BordasPerfil();
            ((System.ComponentModel.ISupportInitialize)(this.bordasPerfil1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(547, 123);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(132, 22);
            this.txt_nome.TabIndex = 0;
            this.txt_nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(440, 123);
            this.lb_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(45, 17);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Função";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(547, 183);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(132, 22);
            this.txt_email.TabIndex = 4;
            // 
            // txt_funcao
            // 
            this.txt_funcao.Location = new System.Drawing.Point(547, 244);
            this.txt_funcao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_funcao.Name = "txt_funcao";
            this.txt_funcao.Size = new System.Drawing.Size(132, 22);
            this.txt_funcao.TabIndex = 5;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(137, 244);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(132, 22);
            this.txt_id.TabIndex = 6;
            // 
            // box_pesquisa
            // 
            this.box_pesquisa.Location = new System.Drawing.Point(820, 114);
            this.box_pesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.box_pesquisa.Name = "box_pesquisa";
            this.box_pesquisa.Size = new System.Drawing.Size(132, 22);
            this.box_pesquisa.TabIndex = 7;
            // 
            // btn_pesquisa_img
            // 
            this.btn_pesquisa_img.Location = new System.Drawing.Point(839, 177);
            this.btn_pesquisa_img.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pesquisa_img.Name = "btn_pesquisa_img";
            this.btn_pesquisa_img.Size = new System.Drawing.Size(100, 28);
            this.btn_pesquisa_img.TabIndex = 8;
            this.btn_pesquisa_img.Text = "Pesquisar";
            this.btn_pesquisa_img.UseVisualStyleBackColor = true;
            this.btn_pesquisa_img.Click += new System.EventHandler(this.btn_pesquisa_img_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(820, 316);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bordasPerfil1
            // 
            this.bordasPerfil1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.bordasPerfil1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.bordasPerfil1.BorderColor2 = System.Drawing.Color.HotPink;
            this.bordasPerfil1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.bordasPerfil1.BorderSize = 2;
            this.bordasPerfil1.GradientAngle = 50F;
            this.bordasPerfil1.Location = new System.Drawing.Point(91, 13);
            this.bordasPerfil1.Name = "bordasPerfil1";
            this.bordasPerfil1.Size = new System.Drawing.Size(224, 224);
            this.bordasPerfil1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bordasPerfil1.TabIndex = 11;
            this.bordasPerfil1.TabStop = false;
            // 
            // base_tela2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bordasPerfil1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_pesquisa_img);
            this.Controls.Add(this.box_pesquisa);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_funcao);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.txt_nome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "base_tela2";
            this.Text = "tela_2";
            this.Load += new System.EventHandler(this.base_tela2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bordasPerfil1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_funcao;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox box_pesquisa;
        private System.Windows.Forms.Button btn_pesquisa_img;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private BordasPerfil bordasPerfil1;
    }
}