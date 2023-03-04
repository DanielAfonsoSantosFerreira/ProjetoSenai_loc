using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace ProjetoSenai
{
    
    public partial class TelaAdm : Form
    { 
        conexao con = new conexao();

        Thread nt;
        private Form activeForm;
        public string id_on;
        public TelaAdm(string id)
        {
            id_on = id;
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
           //MessageBox.Show(id_on);
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

        //Mover a tela pela barra superior
        private void BarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //conseguir abrir forms em um painel
        private void OpenChildForm(Form childForm)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PainelGeral.Controls.Add(childForm);
            this.PainelGeral.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Btnperfil_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TelaPerfil(id_on));
        }

        private void btnSala_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TelaSalas());
        }

        private void Btneventos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TelaEventos());
        }

        private void btnfeedback_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TelaFeedback(id_on));
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            } 
        }
        //final

        //sair do adm
        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(AbrirJan);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void AbrirJan(object obj)
        {
            Application.Run(new TelaLogin());
        }
    }
}
