using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Agenda
{
    public partial class Editar_sv : Form
    {
        public Editar_sv()
        {
            InitializeComponent();
        }

        private void Editar_sv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_agendaDataSet15.tbl_funcionarios' table. You can move, or remove it, as needed.
            this.tbl_funcionariosTableAdapter1.Fill(this.bd_agendaDataSet15.tbl_funcionarios);
            // TODO: This line of code loads data into the 'bd_agendaDataSet12.tbl_servico' table. You can move, or remove it, as needed.
            this.tbl_servicoTableAdapter.Fill(this.bd_agendaDataSet12.tbl_servico);
            // TODO: This line of code loads data into the 'bd_agendaDataSet6.tbl_funcionarios' table. You can move, or remove it, as needed.
            this.tbl_funcionariosTableAdapter.Fill(this.bd_agendaDataSet6.tbl_funcionarios);

            cb_nome_fc.Text = "";
            m_tb_cpf_fc.Text = "___.___.___-__";
            tb_endereco_fc.Text = "";
            tb_numero_fc.Text = "";
            tb_complemento_fc.Text = "";
            tb_cidade_fc.Text = "";
            m_tb_telefone_fc.Text = "(__) ____-____";
            m_tb_celular_fc.Text = "(__) ____-____";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cb_nome_fc.Text = "";
            m_tb_cpf_fc.Text = "___.___.___-__";
            tb_endereco_fc.Text = "";
            tb_numero_fc.Text = "";
            tb_complemento_fc.Text = "";
            tb_cidade_fc.Text = "";
            m_tb_telefone_fc.Text = "(__) ____-____";
            m_tb_celular_fc.Text = "(__) ____-____";
        }


      


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buscarFC();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conect = new SqlConnection(Program.ConnectionString);
            class_funcionario Insert = new class_funcionario();
            Insert.Update(int.Parse(cb_cd_fc.Text), cb_nome_fc.Text, m_tb_cpf_fc.Text, tb_endereco_fc.Text, int.Parse(tb_numero_fc.Text), tb_complemento_fc.Text, tb_cidade_fc.Text, m_tb_telefone_fc.Text, m_tb_celular_fc.Text, dt_dataNascimento_fc.Text);
            MessageBox.Show("Funcionário alterado com sucesso!!!", "<- Cronos Agenda -> Funcionário editado!");
        }

        private void buscarFC()
        {


            MySqlConnection objconexao = new MySqlConnection();
            objconexao.ConnectionString = Program.ConnectionString;

            try
            {
                objconexao.Open();
            }
            catch
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados. Favor conferir se o banco de dados esta corretamente configurado, e online.", "<- Cronos Agenda -> Erro!");

            }

            if (objconexao.State == System.Data.ConnectionState.Open)
            {


                string SQL = "SELECT * FROM tbl_funcionarios WHERE cod_proficional = '" + cb_cd_fc.Text + "';";
                MySqlDataAdapter objadapter = new MySqlDataAdapter(SQL, objconexao);
                DataSet objdataset = new DataSet();
                objadapter.Fill(objdataset, "usuarios");



                if (objdataset.Tables[0].Rows.Count > 0)
                {

                    Program._nomeFC = (objdataset.Tables[0].Rows[0]["nome"].ToString());
                    Program._cpfFC = (objdataset.Tables[0].Rows[0]["cpf"].ToString());
                    Program._enderecoFC = (objdataset.Tables[0].Rows[0]["endereco"].ToString());
                    Program._numeroFC = (objdataset.Tables[0].Rows[0]["numero"].ToString());
                    Program._complementoFC = (objdataset.Tables[0].Rows[0]["complemento"].ToString());
                    Program._cidadeFC = (objdataset.Tables[0].Rows[0]["cidade"].ToString());
                    Program._telefoneFC = (objdataset.Tables[0].Rows[0]["telefone"].ToString());
                    Program._celularFC = (objdataset.Tables[0].Rows[0]["celular"].ToString());
                    Program._nascimentoFC = (objdataset.Tables[0].Rows[0]["nascimento"].ToString());
                   

                    //Preenche os campos

                    cb_nome_fc.Text = Program._nomeFC;
                    m_tb_cpf_fc.Text = Program._cpfFC;
                    tb_endereco_fc.Text = Program._enderecoFC;
                    tb_numero_fc.Text = Program._numeroFC;
                    tb_complemento_fc.Text = Program._complementoFC;
                    tb_cidade_fc.Text = Program._cidadeFC;
                    m_tb_telefone_fc.Text = Program._telefoneFC;
                    m_tb_celular_fc.Text = Program._celularFC;
                    dt_dataNascimento_fc.Text = Program._nascimentoFC;

                }
                else
                {
                    MessageBox.Show("Erro serviço nao encontrado", "<- Cronos Agenda -> Erro!");

                }

                objconexao.Close();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ver_funcionario ver_func = new Ver_funcionario();
            ver_func.ShowDialog();
        }

        
    }
}
