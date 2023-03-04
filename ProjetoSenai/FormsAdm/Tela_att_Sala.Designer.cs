namespace ProjetoSenai.FormsAdm
{
    partial class Tela_att_Sala
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.box_bloco = new System.Windows.Forms.TextBox();
            this.box_numeracao = new System.Windows.Forms.TextBox();
            this.descricao_sala = new System.Windows.Forms.TextBox();
            this.box_nome_sala = new System.Windows.Forms.TextBox();
            this.cadas_sala = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Bloco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Numeração";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Descrição sala";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome sala";
            // 
            // box_bloco
            // 
            this.box_bloco.Location = new System.Drawing.Point(200, 217);
            this.box_bloco.Name = "box_bloco";
            this.box_bloco.Size = new System.Drawing.Size(100, 20);
            this.box_bloco.TabIndex = 14;
            // 
            // box_numeracao
            // 
            this.box_numeracao.Location = new System.Drawing.Point(200, 191);
            this.box_numeracao.Name = "box_numeracao";
            this.box_numeracao.Size = new System.Drawing.Size(100, 20);
            this.box_numeracao.TabIndex = 13;
            // 
            // descricao_sala
            // 
            this.descricao_sala.Location = new System.Drawing.Point(200, 164);
            this.descricao_sala.Name = "descricao_sala";
            this.descricao_sala.Size = new System.Drawing.Size(100, 20);
            this.descricao_sala.TabIndex = 12;
            // 
            // box_nome_sala
            // 
            this.box_nome_sala.Location = new System.Drawing.Point(200, 138);
            this.box_nome_sala.Name = "box_nome_sala";
            this.box_nome_sala.Size = new System.Drawing.Size(100, 20);
            this.box_nome_sala.TabIndex = 11;
            // 
            // cadas_sala
            // 
            this.cadas_sala.Location = new System.Drawing.Point(210, 243);
            this.cadas_sala.Name = "cadas_sala";
            this.cadas_sala.Size = new System.Drawing.Size(75, 23);
            this.cadas_sala.TabIndex = 10;
            this.cadas_sala.Text = "cadastrar";
            this.cadas_sala.UseVisualStyleBackColor = true;
            this.cadas_sala.Click += new System.EventHandler(this.cadas_sala_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 116);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Tela_att_Sala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_bloco);
            this.Controls.Add(this.box_numeracao);
            this.Controls.Add(this.descricao_sala);
            this.Controls.Add(this.box_nome_sala);
            this.Controls.Add(this.cadas_sala);
            this.Name = "Tela_att_Sala";
            this.Text = "Tela_att_Sala";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_bloco;
        private System.Windows.Forms.TextBox box_numeracao;
        private System.Windows.Forms.TextBox descricao_sala;
        private System.Windows.Forms.TextBox box_nome_sala;
        private System.Windows.Forms.Button cadas_sala;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}