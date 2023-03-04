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
    public partial class tela_cadas_feed : Form
    {
        conexao con = new conexao();
        public string id_on;
        public tela_cadas_feed()
        {
        }

        public tela_cadas_feed(string id)
        {
            id_on = id;
            InitializeComponent();
            
            MySqlConnection conexao = con.getconexao();
            conexao.Open();
            String sql;
            sql = "select * from tb_feedback_software";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable dtUsuario = new DataTable();
            dados.Fill(dtUsuario);
            dataGridView1.DataSource = dtUsuario;

            conexao.Close();

            string listar = "select nome_usuario, avaliacao_software, observacoes from tb_feedback_software where id_feedback = @id_on";
            conexao.Open();
            MySqlCommand comando_1 = new MySqlCommand(listar, conexao);
            comando_1.Parameters.Clear();
            comando_1.Parameters.AddWithValue("@id_on", id_on);
            comando_1.CommandType = CommandType.Text;
            MySqlDataReader dr;
            dr = comando_1.ExecuteReader();
            dr.Read();
            box_nome_evento.Text = dr.GetString(0);
            local_evento.Text = dr.GetString(1);
            data_evento.Text = dr.GetString(2);


            conexao.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(id_on);

        }

        private void cadas_sala_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection conexao = con.getconexao();
                conexao.Open();
                string att = "UPDATE tb_feedback_software set nome_usuario = @nome_evento, avaliacao_software = @local_evento, observacoes = @data_evento WHERE tb_feedback_software.id_feedback = @id_on";
                MySqlCommand comando_2 = new MySqlCommand(att, conexao);
                comando_2.Parameters.AddWithValue("@id_on", id_on);
                comando_2.Parameters.AddWithValue("@nome_evento", box_nome_evento.Text);
                comando_2.Parameters.AddWithValue("@Local_evento", local_evento.Text);
                comando_2.Parameters.AddWithValue("@data_evento",data_evento.Text);


                comando_2.CommandType = CommandType.Text;
                comando_2.ExecuteReader();
                MessageBox.Show("Foi");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }
    }
}
