using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using WindowsFormsApp3;
using System.Threading;

namespace ProjetoSenai
{
    public partial class TelaLogin : Form
    {
        Thread f1;
        Thread f2;
        conexao con = new conexao();
    
        public string id_on;


        public TelaLogin()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
        }
        public TelaLogin(string id_on)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        //comando para a movimentação da tela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //fechar o software
        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //maximar e minimizar tela
        private void Janelas_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        //minimizar o software
        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //evento para conseguir mover o software
        private void BarraSuperior1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnlogin_adm_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = con.getconexao();
            conexao.Open();
            string sql = "select id_funcionario, nome_funcionario,senha_funcionario from tb_funcionario where nome_funcionario = @nome_funcionario";
            MySqlCommand comando_1 = new MySqlCommand(sql, conexao);
            comando_1.Parameters.Clear();
            comando_1.Parameters.AddWithValue("@nome_funcionario", txtusuario_adm.Text);
            
            // comando_1.Parameters.Add("@senha_funcionario", MySqlDbType.Int32).Value = txtsenha_adm.Text;
            comando_1.CommandType = CommandType.Text;
            MySqlDataReader dr;
            dr = comando_1.ExecuteReader();
            dr.Read();
            
            try
            {
                if (/*dr.GetString(1) == txtusuario_adm.Text &&*/ dr.GetString(2) == txtsenha_adm.Text)
                {
                    id_on = dr.GetString(0);
                   // MessageBox.Show(id_on);
                    this.Close();
                    f1 = new Thread(AbrirJan);
                    f1.SetApartmentState(ApartmentState.STA);
                    f1.Start(id_on);
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha incorreto");
                }
            }
            catch (Exception ex)//caso de erro
            {
                MessageBox.Show("Usuário ou Senha incorreto 2", ex.Message);
            }
            conexao.Close();
        }

        private void AbrirJan(object obj)   
        {
            Application.Run(new TelaAdm(id_on));
        }
        private void AbrirJan2(object obj)
        {
            Application.Run(new TelaVisitante());
        }

        private void Olhodesocultar_Click(object sender, EventArgs e)
        {
            OlhoOcultar.BringToFront();
            txtsenha_adm.PasswordChar = '•';
        }

        private void OlhoOcultar_Click(object sender, EventArgs e)
        {
            Olhodesocultar.BringToFront();
            txtsenha_adm.PasswordChar = '\0';
        }

        private void btnlogin_vis_Click(object sender, EventArgs e)
        {
            this.Close();
            f2 = new Thread(AbrirJan2);
            f2.SetApartmentState(ApartmentState.STA);
            f2.Start();
        }
    }

 
}

