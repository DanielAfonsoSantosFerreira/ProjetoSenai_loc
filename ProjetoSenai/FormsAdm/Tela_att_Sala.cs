using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace ProjetoSenai.FormsAdm
{
    public partial class Tela_att_Sala : Form
    {
        conexao con = new conexao();
        public string id_on;
        public Tela_att_Sala(string id)
        {
            id_on = id;
            InitializeComponent();
            MySqlConnection conexao = con.getconexao();
            conexao.Open();
            String sql;
            sql = "select * from tb_sala_do_predio";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable dtUsuario = new DataTable();
            dados.Fill(dtUsuario);
            dataGridView1.DataSource = dtUsuario;

            conexao.Close();

            string listar = "select nome_sala, descricao_sala,numeracao,bloco from tb_sala_do_predio where id_sala = @id_on";
            conexao.Open();
            MySqlCommand comando_1 = new MySqlCommand(listar, conexao);
            comando_1.Parameters.Clear();
            comando_1.Parameters.AddWithValue("@id_on", id_on);
            comando_1.CommandType = CommandType.Text;
            MySqlDataReader dr;
            dr = comando_1.ExecuteReader();
            dr.Read();
            box_nome_sala.Text = dr.GetString(0);
            descricao_sala.Text = dr.GetString(1);
            box_numeracao.Text = dr.GetString(2);
            box_bloco.Text = dr.GetString(3);
            conexao.Close();

        }
        public Tela_att_Sala()
        {
           // id_on = id;
            InitializeComponent();

        }

        private void cadas_sala_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = con.getconexao();
                conexao.Open();
                string att = "UPDATE tb_sala_do_predio set nome_sala = @nome_sala, descricao_sala = @descricao_sala, numeracao = @numeracao, bloco = @bloco WHERE tb_sala_do_predio.id_sala = @id_on";
                MySqlCommand comando_2 = new MySqlCommand(att, conexao);
                comando_2.Parameters.AddWithValue("@id_on", id_on);
                comando_2.Parameters.AddWithValue("@nome_sala", box_nome_sala.Text);
                comando_2.Parameters.AddWithValue("@descricao_sala", descricao_sala.Text);
                comando_2.Parameters.AddWithValue("@numeracao", box_numeracao.Text);
                comando_2.Parameters.AddWithValue("@bloco", box_bloco.Text);
                comando_2.CommandType = CommandType.Text;
                comando_2.ExecuteReader();
                MessageBox.Show("Foi");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(id_on);
        }
    }
}
