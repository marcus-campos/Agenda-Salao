using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agenda
{
    public partial class config_banco : Form
    {
        public config_banco()
        {
            InitializeComponent();
        }

        private void config_banco_Load(object sender, EventArgs e)
        {
        }

        private void rb_possui_senha_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_possui_senha.Enabled == true)
            {
                tb_senha.Enabled = true;               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_servidor.Text != "")
            {
                Program._server = tb_servidor.Text;
            }
             else
                if (tb_servidor.Text == "")
                {
                    MessageBox.Show("O campo 'Servidor' não foi preenchido coretamente.", "<- Cronos Agenda -> Atenção!");
                    return;
                }
                else
                    if(tb_nome_banco.Text != "")
                    {
                        Program._database = tb_nome_banco.Text;
                    }
                    else
                        if (tb_nome_banco.Text == "")
                        {
                            MessageBox.Show("O campo 'Nome do banco de dados' não foi preenchido coretamente.", "<- Cronos Agenda -> Atenção!");
                            return;
                        }
                        else
                            if(tb_usuario.Text != "")
                            {
                                Program._usuario = tb_usuario.Text;
                            }
                            else
                                if (tb_usuario.Text == "")
                                {
                                    MessageBox.Show("O campo 'Usuário' não foi preenchido coretamente.", "<- Cronos Agenda -> Atenção!");
                                    return;
                                }
                                else
                                    if (tb_senha.Text != "")
                                    {
                                        Program._senha = tb_senha.Text;
                                    }
                                    else
                                        if (tb_senha.Text == "")
                                        {
                                            MessageBox.Show("O campo 'Senha' não foi preenchido coretamente.", "<- Cronos Agenda -> Atenção!");
                                            return;
                                        }
                                        else
                                            if (rb_possui_senha.Enabled == true)
                                            {
                                                Program._posuiSenha = true;
                                            }
            MessageBox.Show("configurações alteradas com sucesso!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

        
    }
}
