using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace Agenda
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static int liberar = 0;
       
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cla_login cls = new Cla_login();
            if (cls.Autenticar(tb_login.Text, tb_senha.Text) == true)
            {
                this.Close();
                telaPrincipal tl_p = new telaPrincipal();
                tl_p.Show();                            
                
            }
            else
            {

            }
        }

       

        

        public void VerificaBanco()
        {
          

            MySqlConnection objconexao = new MySqlConnection();
            objconexao.ConnectionString = Program.ConnectionString;

            try
            {
                lb_verifica_bd.Text = "Verificando...";
                objconexao.Open();
            }
            catch
            {
                label1.Enabled = false;
                label2.Enabled = false;
                tb_login.Enabled = false;
                tb_senha.Enabled = false;
                button1.Enabled = false;
                button3.Visible = true;
                groupBox1.Visible = true;
                button4.Visible = true;
                lb_verifica_bd.Text = "Banco de dados offline";
            }

            if (objconexao.State == System.Data.ConnectionState.Open)
            {
                label1.Enabled = true;
                label2.Enabled = true;
                tb_login.Enabled = true;
                tb_senha.Enabled = true;
                button1.Enabled = true;
                button3.Visible = false;
                groupBox1.Visible = false;
                button4.Visible = false;
                lb_verifica_bd.Text = "Banco de dados online";       
                                            
            }




           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                label1.Enabled = false;
                label2.Enabled = false;
                tb_login.Enabled = false;
                tb_senha.Enabled = false;
                button1.Enabled = false;
                button3.Visible = false;
                groupBox1.Visible = false;
                button4.Visible = false;
                VerificaBanco();
            }
            catch
            {
                MessageBox.Show("Erro! Ocorreu um erro grave e o programa nao pode ser inicializado.", "<- Cronos Agenda -> Erro!");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerificaBanco();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"C:\wamp\wampmanager.exe");
            }

            catch
            {


            }
        }

        private void tb_senha_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
