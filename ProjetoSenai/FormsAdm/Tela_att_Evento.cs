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
    public partial class Tela_att_Evento : Form
    {
        conexao con = new conexao();
        public string id_on;
        public Tela_att_Evento(string id)
        {
            InitializeComponent();
            id_on = id;
          
            MySqlConnection conexao = con.getconexao();
            conexao.Open();
            String sql;
            sql = "select * from tb_evento";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable dtUsuario = new DataTable();
            dados.Fill(dtUsuario);
            dataGridView1.DataSource = dtUsuario;

            conexao.Close();

            string listar = "select nome_evento, local_evento,data_evento,horario_evento,descricao_evento from tb_evento where id_evento = @id_on";
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
            horario_evento.Text = dr.GetString(3);
            descricao_evento.Text = dr.GetString(4);

            conexao.Close();
        }

        private void cadas_sala_Click(object sender, EventArgs e)
        {

            try
            {

                MySqlConnection conexao = con.getconexao();
                conexao.Open();
                string att = "UPDATE tb_evento set nome_evento = @nome_evento, local_evento = @local_evento, data_evento = @data_evento, horario_evento = @horario_evento, descricao_evento = @descricao_evento WHERE tb_evento.id_evento = @id_on";
                MySqlCommand comando_2 = new MySqlCommand(att, conexao);
                comando_2.Parameters.AddWithValue("@id_on", id_on);
                comando_2.Parameters.AddWithValue("@nome_evento", box_nome_evento.Text);
                comando_2.Parameters.AddWithValue("@Local_evento", local_evento.Text);
                comando_2.Parameters.AddWithValue("@data_evento", Convert.ToInt32(data_evento.Text));
                comando_2.Parameters.AddWithValue("@horario_evento", Convert.ToInt32(horario_evento.Text));
                comando_2.Parameters.AddWithValue("@descricao_evento", descricao_evento.Text);

                comando_2.CommandType = CommandType.Text;
                comando_2.ExecuteReader();
                MessageBox.Show("Foi");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(id_on);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
