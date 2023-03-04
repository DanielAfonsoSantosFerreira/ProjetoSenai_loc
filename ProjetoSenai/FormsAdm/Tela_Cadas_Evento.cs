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
    public partial class Tela_Cadas_Evento : Form
    {
        conexao con = new conexao();
        public Tela_Cadas_Evento()
        {
            InitializeComponent();
        }

        private void cadas_sala_Click(object sender, EventArgs e)
        {

           

            string argumentos  = "nome_evento,local_evento,data_evento,horario_evento,descricao_evento";
            string adicionar = "nicolas, nicolas1, 20230412, 131718, nicolas5";
            Cadastro sla = new Cadastro();
            string erro = sla.Cadastrar("tb_evento", argumentos,adicionar);
            MessageBox.Show(erro);
           









        }
    }
}
