namespace ProjetoSenai.FormsAdm
{
    partial class Tela_Cadas_Sala
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
            this.cadas_sala = new System.Windows.Forms.Button();
            this.box_nome_sala = new System.Windows.Forms.TextBox();
            this.descricao_sala = new System.Windows.Forms.TextBox();
            this.box_numeracao = new System.Windows.Forms.TextBox();
            this.box_bloco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cadas_sala
            // 
            this.cadas_sala.Location = new System.Drawing.Point(181, 289);
            this.cadas_sala.Name = "cadas_sala";
            this.cadas_sala.Size = new System.Drawing.Size(75, 23);
            this.cadas_sala.TabIndex = 0;
            this.cadas_sala.Text = "cadastrar";
            this.cadas_sala.UseVisualStyleBackColor = true;
            this.cadas_sala.Click += new System.EventHandler(this.cadas_sala_Click);
            // 
            // box_nome_sala
            // 
            this.box_nome_sala.Location = new System.Drawing.Point(171, 184);
            this.box_nome_sala.Name = "box_nome_sala";
            this.box_nome_sala.Size = new System.Drawing.Size(100, 20);
            this.box_nome_sala.TabIndex = 2;
            this.box_nome_sala.TextChanged += new System.EventHandler(this.box_nome_sala_TextChanged);
            // 
            // descricao_sala
            // 
            this.descricao_sala.Location = new System.Drawing.Point(171, 210);
            this.descricao_sala.Name = "descricao_sala";
            this.descricao_sala.Size = new System.Drawing.Size(100, 20);
            this.descricao_sala.TabIndex = 3;
            this.descricao_sala.TextChanged += new System.EventHandler(this.descricao_sala_TextChanged);
            // 
            // box_numeracao
            // 
            this.box_numeracao.Location = new System.Drawing.Point(171, 237);
            this.box_numeracao.Name = "box_numeracao";
            this.box_numeracao.Size = new System.Drawing.Size(100, 20);
            this.box_numeracao.TabIndex = 4;
            this.box_numeracao.TextChanged += new System.EventHandler(this.box_numeracao_TextChanged);
            // 
            // box_bloco
            // 
            this.box_bloco.Location = new System.Drawing.Point(171, 263);
            this.box_bloco.Name = "box_bloco";
            this.box_bloco.Size = new System.Drawing.Size(100, 20);
            this.box_bloco.TabIndex = 5;
            this.box_bloco.TextChanged += new System.EventHandler(this.box_bloco_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome sala";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descrição sala";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numeração";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bloco";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Tela_Cadas_Sala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 881);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_bloco);
            this.Controls.Add(this.box_numeracao);
            this.Controls.Add(this.descricao_sala);
            this.Controls.Add(this.box_nome_sala);
            this.Controls.Add(this.cadas_sala);
            this.Name = "Tela_Cadas_Sala";
            this.Text = "Tela_Cadas_Sala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadas_sala;
        private System.Windows.Forms.TextBox box_nome_sala;
        private System.Windows.Forms.TextBox descricao_sala;
        private System.Windows.Forms.TextBox box_numeracao;
        private System.Windows.Forms.TextBox box_bloco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}