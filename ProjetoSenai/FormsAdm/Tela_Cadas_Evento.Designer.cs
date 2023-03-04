namespace ProjetoSenai.FormsAdm
{
    partial class Tela_Cadas_Evento
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
            this.horario_evento = new System.Windows.Forms.TextBox();
            this.data_evento = new System.Windows.Forms.TextBox();
            this.local_evento = new System.Windows.Forms.TextBox();
            this.box_nome_evento = new System.Windows.Forms.TextBox();
            this.cadas_sala = new System.Windows.Forms.Button();
            this.descricao_evento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Bloco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Numeração";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Descrição sala";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome sala";
            // 
            // horario_evento
            // 
            this.horario_evento.Location = new System.Drawing.Point(394, 240);
            this.horario_evento.Name = "horario_evento";
            this.horario_evento.Size = new System.Drawing.Size(100, 20);
            this.horario_evento.TabIndex = 14;
            // 
            // data_evento
            // 
            this.data_evento.Location = new System.Drawing.Point(394, 214);
            this.data_evento.Name = "data_evento";
            this.data_evento.Size = new System.Drawing.Size(100, 20);
            this.data_evento.TabIndex = 13;
            // 
            // local_evento
            // 
            this.local_evento.Location = new System.Drawing.Point(394, 187);
            this.local_evento.Name = "local_evento";
            this.local_evento.Size = new System.Drawing.Size(100, 20);
            this.local_evento.TabIndex = 12;
            // 
            // box_nome_evento
            // 
            this.box_nome_evento.Location = new System.Drawing.Point(394, 161);
            this.box_nome_evento.Name = "box_nome_evento";
            this.box_nome_evento.Size = new System.Drawing.Size(100, 20);
            this.box_nome_evento.TabIndex = 11;
            // 
            // cadas_sala
            // 
            this.cadas_sala.Location = new System.Drawing.Point(407, 310);
            this.cadas_sala.Name = "cadas_sala";
            this.cadas_sala.Size = new System.Drawing.Size(75, 23);
            this.cadas_sala.TabIndex = 10;
            this.cadas_sala.Text = "cadastrar";
            this.cadas_sala.UseVisualStyleBackColor = true;
            this.cadas_sala.Click += new System.EventHandler(this.cadas_sala_Click);
            // 
            // descricao_evento
            // 
            this.descricao_evento.Location = new System.Drawing.Point(394, 267);
            this.descricao_evento.Name = "descricao_evento";
            this.descricao_evento.Size = new System.Drawing.Size(100, 20);
            this.descricao_evento.TabIndex = 19;
            // 
            // Tela_Cadas_Evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.descricao_evento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.horario_evento);
            this.Controls.Add(this.data_evento);
            this.Controls.Add(this.local_evento);
            this.Controls.Add(this.box_nome_evento);
            this.Controls.Add(this.cadas_sala);
            this.Name = "Tela_Cadas_Evento";
            this.Text = "Tela_Cadas_Evento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox horario_evento;
        private System.Windows.Forms.TextBox data_evento;
        private System.Windows.Forms.TextBox local_evento;
        private System.Windows.Forms.TextBox box_nome_evento;
        private System.Windows.Forms.Button cadas_sala;
        private System.Windows.Forms.TextBox descricao_evento;
    }
}