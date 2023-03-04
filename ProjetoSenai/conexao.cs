using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public class conexao
    {
        static private string servidor = "localhost";
        static private string bancodedados = "db_loc";
        static private string usuario = "root";
        static private string senha = "";

        static private string StrCon = "server=" + servidor + ";database=" + bancodedados + ";user id=" + usuario + ";password=" + senha;
        public MySqlConnection getconexao()
        {
            MySqlConnection conn = new MySqlConnection(StrCon);
            return conn;
        }
        public bool conectar()
        {
            var result = false;
            try
            {
                getconexao().Open();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
                MessageBox.Show("Falha: " + ex.Message);
            }
            return result;
        }

    }
}