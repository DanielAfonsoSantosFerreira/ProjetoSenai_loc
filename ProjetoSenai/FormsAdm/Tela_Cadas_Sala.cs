using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace ProjetoSenai.FormsAdm
{
    public partial class Tela_Cadas_Sala : Form
    {
        conexao con = new conexao();
        public int a;
        public Tela_Cadas_Sala()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cadas_sala_Click(object sender, EventArgs e)
        {
           
            
                   
                    MySqlConnection conexao = con.getconexao();
                    conexao.Open();
                    string inserir1 = "insert into tb_sala_do_predio(nome_sala,descricao_sala,numeracao,bloco) values " + " (@nome_sala,@descricao_sala,@numeracao,@bloco)";
                    MySqlCommand comando = new MySqlCommand(inserir1, conexao);
                   
                    comando.Parameters.AddWithValue("@nome_sala", box_nome_sala.Text);
                    comando.Parameters.AddWithValue("@descricao_sala", descricao_sala.Text);
                    comando.Parameters.AddWithValue("@numeracao", Convert.ToInt32(box_numeracao.Text));
                    comando.Parameters.AddWithValue("@bloco", box_bloco.Text);

                    comando.CommandType = CommandType.Text;
                    comando.ExecuteReader();
                    MessageBox.Show("Foi");
                    conexao.Close();
                   


            
            
            


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void box_bloco_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_numeracao_TextChanged(object sender, EventArgs e)
        {

        }

        private void descricao_sala_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_nome_sala_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
