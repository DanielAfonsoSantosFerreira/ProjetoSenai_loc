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
using static ProjetoSenai.TelaLogin;

namespace ProjetoSenai
{
    public partial class base_tela2 : Form
    {
        conexao con = new conexao();

        public string id_on;

        public string FileName { get; }

        public base_tela2()
        {
            InitializeComponent();
        }
        public base_tela2(string id)
        {
            InitializeComponent();
            id_on = id;
            MySqlConnection conexao = con.getconexao();
            conexao.Open();

            string listar = "select tb_funcionario.id_funcionario, tb_funcionario.nome_funcionario, tb_funcionario.email_funcionario, tb_funcionario.img, tb_funcao_funcionario.funcao_funcionario from tb_funcionario inner join tb_funcao_funcionario on tb_funcionario.id_funcao = tb_funcao_funcionario.id_funcao where id_funcionario = @id_on";
            MySqlCommand comando_1 = new MySqlCommand(listar, conexao);
            comando_1.Parameters.Clear();
            comando_1.Parameters.AddWithValue("@id_on", id_on);
    

            // comando_1.Parameters.Add("@senha_funcionario", MySqlDbType.Int32).Value = txtsenha_adm.Text;
            comando_1.CommandType = CommandType.Text;
            MySqlDataReader dr;
            dr = comando_1.ExecuteReader();
            dr.Read();

            txt_id.Text = dr.GetString(0) ;
            txt_nome.Text = dr.GetString(1);
            txt_email.Text = dr.GetString(2);
            box_pesquisa.Text = dr.GetString(3);
           //ft_foto.Image = Image.FromFile(box_pesquisa.Text);
            txt_funcao.Text = dr.GetString(4);


        }

        private void btn_pesquisa_img_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog(); //
                open.Filter = "imagemfiles| *.png"; // abre o windows para escolher imagem .png
                if (open.ShowDialog() == DialogResult.OK) // se escolheu imagem
                {
                    box_pesquisa.Text = open.FileName; //endereçamento da imagem|| usar para quardar a imagem
                    bordasPerfil1.Image = Image.FromFile(open.FileName);// abre a imagem



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("falha ao abrir o arquivi erro" + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // textBox1.Text = func;
             MessageBox.Show(id_on);
        }

        private void ft_foto_Click(object sender, EventArgs e)
        {

        }

        private void base_tela2_Load(object sender, EventArgs e)
        {

        }
    }

}


