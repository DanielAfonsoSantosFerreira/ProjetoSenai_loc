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

namespace ProjetoSenai
{
    public partial class TelaPerfil : Form
    {
        conexao con = new conexao();

        public string id_on;
        //public string id;
        public TelaPerfil()
        {
            InitializeComponent();

        }
        public TelaPerfil(string id)
        {
            InitializeComponent();
            id_on = id;
            //MessageBox.Show(id_on);

            MySqlConnection conexao = con.getconexao();

            conexao.Open();

            string listar = "select tb_funcionario.id_funcionario, tb_funcionario.nome_funcionario, tb_funcionario.email_funcionario, tb_funcionario.img, tb_funcao_funcionario.funcao_funcionario from tb_funcionario inner join tb_funcao_funcionario on tb_funcionario.id_funcao = tb_funcao_funcionario.id_funcao where id_funcionario = @id_on";
            MySqlCommand comando_1 = new MySqlCommand(listar, conexao);
            comando_1.Parameters.Clear();
            comando_1.Parameters.AddWithValue("@id_on", id_on);
            comando_1.CommandType = CommandType.Text;
            MySqlDataReader dr;
            dr = comando_1.ExecuteReader();
            dr.Read();
            
            Idusuario.Text = dr.GetString(0);

            Nomefun.Text = dr.GetString(1);
            Emailfun.Text = dr.GetString(2);
            box_pesquisa.Text = dr.GetString(3);
            FotoPerfil.Image = Image.FromFile(box_pesquisa.Text);
            Funcaofun.Text = dr.GetString(4);
            
            conexao.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(id_on);
        }
    }
}
