using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;



namespace Agenda
{
    public partial class novoServico : Form
    {
        public novoServico()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_nomeServico_ns.Text = "";
            rtb_descricao_ns.Text = "";
            tb_valor_medio.Text = "0,00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validações

                if (tb_nomeServico_ns.Text == "")
                {
                    MessageBox.Show("O campo 'Nome do serviço' não está preenchido coretamente.", "<- Cronos Agenda -> Erro!");
                }
                else
                    if (tb_valor_medio.Text == "0,00")
                    {
                        MessageBox.Show("O campo 'Valor médio' não está preenchido coretamente.", "<- Cronos Agenda -> Erro!");
                    }
                    else
                        if (rtb_descricao_ns.Text == "")
                        {
                            MessageBox.Show("O campo 'Descrição' não está preenchido coretamente.", "<- Cronos Agenda -> Erro!");
                        }


                SqlConnection conect = new SqlConnection(Program.ConnectionString);
                class_servico Insert = new class_servico();
                Insert.novoServico(tb_nomeServico_ns.Text, double.Parse(tb_valor_medio.Text),rtb_descricao_ns.Text);
                MessageBox.Show("Serviço adicionado com sucesso!!!", "<- Cronos Agenda -> Cadastro de serviço concluido");
            }
            catch (Exception erro)
            {
                if (MessageBox.Show("Não foi possivel cadastrar um novo serviço.\n\n\n\nDeseja mosstrar a causa do erro?", "<- Cronos Agenda -> Erro!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Yes)
                {
                    MessageBox.Show(""+erro,"Erro!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rtb_descricao_ns_TextChanged(object sender, EventArgs e)
        {

        }

        private void novoServico_Load(object sender, EventArgs e)
        {
            tb_valor_medio.Text = "0,00";
        }
    }
}
