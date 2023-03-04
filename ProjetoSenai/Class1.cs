using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3;

namespace ProjetoSenai
{
    public class Cadastro : conexao
    {
        public Cadastro()
        {
            string sla = "sla";
        }




        public string Cadastrar(string tabela, string argumentos,string adicionar)
        {
            try
            {
                
                conexao con = new conexao();
                MySqlConnection conexao = con.getconexao();
                conexao.Open();
                string inserir = "insert into"+ tabela +"(@argumentos) values " + "(@adicionar)";
                MySqlCommand comando = new MySqlCommand(inserir, conexao);
                
                comando.Parameters.AddWithValue("@argumentos", argumentos);
                comando.Parameters.AddWithValue("@adicionar", adicionar); 
                comando.CommandType = CommandType.Text;
                comando.ExecuteReader();
                conexao.Close();
                //comando.Parameters.AddWithValue("@horario_evento", Convert.ToInt32(horario_evento.Text));
                //comando.Parameters.AddWithValue("@descricao_evento", descricao_evento.Text);
                
               
                //MessageBox.Show("Foi");
                
                return "sem erro";
                
            }
            catch(Exception ex)
            {
                string erro = ex.ToString();
                return erro;
            }
            
        }
    }
}

