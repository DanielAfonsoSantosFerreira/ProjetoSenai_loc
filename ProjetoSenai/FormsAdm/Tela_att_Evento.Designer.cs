namespace ProjetoSenai.FormsAdm
{
    partial class Tela_att_Evento
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cadas_sala = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.local_evento = new System.Windows.Forms.TextBox();
            this.box_nome_evento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.data_evento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.horario_evento = new System.Windows.Forms.TextBox();
            this.descricao_evento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(135, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 116);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Descrição sala";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nome sala";
            // 
            // cadas_sala
            // 
            this.cadas_sala.Location = new System.Drawing.Point(450, 368);
            this.cadas_sala.Name = "cadas_sala";
            this.cadas_sala.Size = new System.Drawing.Size(75, 23);
            this.cadas_sala.TabIndex = 20;
            this.cadas_sala.Text = "cadastrar";
            this.cadas_sala.UseVisualStyleBackColor = true;
            this.cadas_sala.Click += new System.EventHandler(this.cadas_sala_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // local_evento
            // 
            this.local_evento.Location = new System.Drawing.Point(439, 252);
            this.local_evento.Name = "local_evento";
            this.local_evento.Size = new System.Drawing.Size(100, 20);
            this.local_evento.TabIndex = 32;
            // 
            // box_nome_evento
            // 
            this.box_nome_evento.Location = new System.Drawing.Point(439, 226);
            this.box_nome_evento.Name = "box_nome_evento";
            this.box_nome_evento.Size = new System.Drawing.Size(100, 20);
            this.box_nome_evento.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Numeração";
            // 
            // data_evento
            // 
            this.data_evento.Location = new System.Drawing.Point(439, 279);
            this.data_evento.Name = "data_evento";
            this.data_evento.Size = new System.Drawing.Size(100, 20);
            this.data_evento.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Bloco";
            // 
            // horario_evento
            // 
            this.horario_evento.Location = new System.Drawing.Point(439, 305);
            this.horario_evento.Name = "horario_evento";
            this.horario_evento.Size = new System.Drawing.Size(100, 20);
            this.horario_evento.TabIndex = 34;
            // 
            // descricao_evento
            // 
            this.descricao_evento.Location = new System.Drawing.Point(439, 332);
            this.descricao_evento.Name = "descricao_evento";
            this.descricao_evento.Size = new System.Drawing.Size(100, 20);
            this.descricao_evento.TabIndex = 35;
            // 
            // Tela_att_Evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.descricao_evento);
            this.Controls.Add(this.horario_evento);
            this.Controls.Add(this.data_evento);
            this.Controls.Add(this.local_evento);
            this.Controls.Add(this.box_nome_evento);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cadas_sala);
            this.Name = "Tela_att_Evento";
            this.Text = "Tela_att_Evento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cadas_sala;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox local_evento;
        private System.Windows.Forms.TextBox box_nome_evento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox data_evento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox horario_evento;
        private System.Windows.Forms.TextBox descricao_evento;
    }
}