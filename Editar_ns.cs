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
    public partial class Editar_ns : Form
    {
        bool condcao = true;

        public Editar_ns()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb_nome_sv.Text = "";
            rtb_descricao_ens.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_nome_sv.Text == "")
            {
                MessageBox.Show("O campo 'Nome do serviço' não está preenchido coretamente.", "<- Cronos Agenda -> Erro!");
            }
            else
                if (tb_valor_medio.Text == "0,00")
                {
                    MessageBox.Show("O campo 'Valor médio' não está preenchido coretamente.", "<- Cronos Agenda -> Erro!");
                }
                else
                    if (rtb_descricao_ens.Text == "")
                    {
                        MessageBox.Show("O campo 'Descrição' não está preenchido coretamente.", "<- Cronos Agenda -> Erro!");
                    }
            
            try
            {
                SqlConnection conect = new SqlConnection(Program.ConnectionString);
                class_servico Insert = new class_servico();
                Insert.Update(int.Parse(cb_cd_sv.Text), cb_nome_sv.Text, double.Parse(tb_valor_medio.Text), rtb_descricao_ens.Text);
                MessageBox.Show("Serviço alterado com sucesso!!!", "<- Cronos Agenda -> Serviço alterado com sucesso!");
            }
            catch(Exception erro)
            {
                if (MessageBox.Show("Não foi possivel editar o serviço.\n\n\n\nDeseja mosstrar a causa do erro?", "<- Cronos Agenda -> Erro!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Yes)
                {
                    MessageBox.Show("" + erro, "<- Cronos Agenda -> Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Editar_ns_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_agendaDataSet13.tbl_servico' table. You can move, or remove it, as needed.
            this.tbl_servicoTableAdapter1.Fill(this.bd_agendaDataSet13.tbl_servico);
            // TODO: This line of code loads data into the 'bd_agendaDataSet7.tbl_servico' table. You can move, or remove it, as needed.
            this.tbl_servicoTableAdapter.Fill(this.bd_agendaDataSet7.tbl_servico);
            cb_nome_sv.Text = "";
            rtb_descricao_ens.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (condcao == true)
            {
                buscarSV();
            }
            else
            {

            }
        }
        private void buscarSV()
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


                string SQL = "SELECT * FROM tbl_servico WHERE cod_servico = '" + cb_cd_sv.Text + "';";
                MySqlDataAdapter objadapter = new MySqlDataAdapter(SQL, objconexao);
                DataSet objdataset = new DataSet();
                objadapter.Fill(objdataset, "usuarios");



                if (objdataset.Tables[0].Rows.Count > 0)
                {

                    Program._nomeSV = (objdataset.Tables[0].Rows[0]["nome_servico"].ToString());
                    Program._descricaoSV = (objdataset.Tables[0].Rows[0]["descricao"].ToString());


                    //Preenche os campos

                    cb_nome_sv.Text = Program._nomeSV;
                    rtb_descricao_ens.Text = Program._descricaoSV;

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
            if (MessageBox.Show("Você realmente deseja excluir este serviço ? ", "<- Cronos Agenda -> Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                DeletarSV();
            }
        }

        public void DeletarSV()
        {



            MySqlConnection conect = new MySqlConnection();
            conect.ConnectionString = Program.ConnectionString;
            string ComandString = "DELETE FROM tbl_servico WHERE cod_servico = '" + cb_cd_sv.Text + "' LIMIT 1;";

            try
            {
                conect.Open();

                MySqlCommand comando = new MySqlCommand(ComandString, conect);

                comando.ExecuteNonQuery();

                MessageBox.Show("Servico deletado com sucesso!", "<- Cronos Agenda -> Atenção!");
            }

            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                conect.Close();
            }

        }

        private void Editar_ns_FormClosing(object sender, FormClosingEventArgs e)
        {
            condcao = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cb_nome_sv_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ver_servicos ver_sv = new Ver_servicos();
            ver_sv.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PrintDialog imprimir = new PrintDialog();
            imprimir.ShowDialog();
        }
    }
}
