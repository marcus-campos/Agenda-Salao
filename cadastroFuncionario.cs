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
    public partial class cadastroFuncionario : Form
    {
        public cadastroFuncionario()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tb_nome_fc.Text = "";
            m_tb_cpf_fc.Text = "___.___.___-__";
            tb_endereco_fc.Text = "";
            tb_numero_fc.Text = "";
            tb_complemento_fc.Text = "";
            tb_cidade_fc.Text = "";
            m_tb_telefone_fc.Text = "(__) ____-____";
            m_tb_celular_fc.Text = "(__) ____-____";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Validações

                if (tb_nome_fc.Text == "")
                {
                    MessageBox.Show("O campo 'Nome do funcionario' não foi preenchido coretamente.", "<- Cronos Agenda -> Erro!");
                    return;
                }
                else
                    if (m_tb_cpf_fc.Text == "___.___.___-__")
                    {
                        MessageBox.Show("O campo 'CPF' não foi preenchido coretamente.", "<- Cronos Agenda -> Erro!");
                        return;
                    }
                    else
                        if (tb_endereco_fc.Text == "")
                        {
                            MessageBox.Show("O campo 'Endereço' não foi preenchido coretamente.", "<- Cronos Agenda -> Erro!");
                            return;
                        }
                         else
                            if(tb_numero_fc.Text == "")
                            {
                                MessageBox.Show("O campo 'Número' não foi preenchido coretamente.", "<- Cronos Agenda -> Erro!");
                                return;
                            }
                            else
                                if (tb_cidade_fc.Text == "")
                                {
                                    MessageBox.Show("O campo 'Cidade' não foi preenchido coretamente.", "<- Cronos Agenda -> Erro!");
                                    return;
                                }
                                else 
                                    if( m_tb_telefone_fc.Text == "(__) ____-____")
                                    {
                                        MessageBox.Show("O campo 'Telefone' não foi preenchido coretamente.", "<- Cronos Agenda -> Erro!");
                                        return;
                                    }
              


                Program._nome_n_FC = tb_nome_fc.Text;
                SqlConnection conect = new SqlConnection(Program.ConnectionString);
                class_funcionario Insert = new class_funcionario();
                Insert.CadastrarFuncionarios(tb_nome_fc.Text, m_tb_cpf_fc.Text, tb_endereco_fc.Text, int.Parse(tb_numero_fc.Text), tb_complemento_fc.Text, tb_cidade_fc.Text, m_tb_telefone_fc.Text, m_tb_celular_fc.Text, dt_dataNascimento_fc.Text);
                MessageBox.Show("Funcionário cadastrado com sucesso!!!", "<- Cronos Agenda -> Funcionário cadastrado!");

                if (class_funcionario.valid == 1)
                {
                    Cadastro_de_usuário novoUsu = new Cadastro_de_usuário();
                    novoUsu.ShowDialog();
                    this.Close();
                }
                else
                {

                }
            }
            catch
            {
                MessageBox.Show("Não foi possivel cadastrar um novo funcionario!", "<- Cronos Agenda -> Erro!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void fecharCDfc()
        {
            this.Close();
        }

        private void cadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg)|*.jpg|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.picFoto.Visible = true;
                this.picFoto.ImageLocation = openFileDialog.FileName;
                
            }
        }
    }
}
