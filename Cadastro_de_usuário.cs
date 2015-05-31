using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Agenda
{
    public partial class Cadastro_de_usuário : Form
    {
        public Cadastro_de_usuário()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_senha_nu.Clear();
            tb_usuario_nu.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_senha_nu.Text == "")
                {
                    MessageBox.Show("O campo 'senha' nao foi preenchido!", "< - Cronos Agenda - > Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                    if (tb_usuario_nu.Text == "")
                    {
                        MessageBox.Show("O campo 'usuário' nao foi preenchido!", "<- Cronos Agenda -> Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                        if (rb_adm.Checked == true)
                        {
                            Program._nvadm_n_fc = 1;
                        }
                        else
                            if (rb_secretario.Checked == true)
                            {
                                Program._nvadm_n_fc = 2;
                            }
                            else
                                if (rb_funcionario.Checked == true)
                                {
                                    Program._nvadm_n_fc = 3;
                                }
                                else
                                {
                                    MessageBox.Show("Erro! Tipo de usuário inválido.", "<- Cronos Agenda -> Erro!");
                                    return;
                                }
                SqlConnection conect = new SqlConnection(Program.ConnectionString);
                class_funcionario Insert = new class_funcionario();
                Insert.NovoUsuario(tb_usuario_nu.Text, tb_senha_nu.Text);
                MessageBox.Show("Usuário cadastrado com sucesso!!!", "<- Cronos Agenda -> Usuário cadastrado!");
                this.Close();
            }
            catch(Exception erro)
            {
                if (MessageBox.Show("Erro, não foi possivel cadastrar um novo usuário.\n\n\nDeseja mostrar a causa do erro?", "<- Cronos Agenda -> Erro!", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {                       
                        MessageBox.Show(""+erro);
                    }
                
                else
                {

                }
            }
       
        }

        private void rb_adm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_secretario_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_funcionario_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cadastro_de_usuário_Load(object sender, EventArgs e)
        {

        }
    }
}
