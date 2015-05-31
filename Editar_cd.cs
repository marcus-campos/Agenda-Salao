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
    public partial class Editar_cd : Form
    {

        bool condcao = true;


        public Editar_cd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_horario_c.Text == "")
                {
                    MessageBox.Show("O campo 'horário' nao tem nenhum valor adicionado", "<- Cronos Agenda -> Erro!");
                    return;
                }
                else
                    if (cb_nome_cliente.Text == "")
                    {
                        MessageBox.Show("O campo 'nome' nao tem nenhum valor adicionado", "<- Cronos Agenda -> Erro!");
                        return;
                    }
                    else
                        if (tb_valor_c.Text == "")
                        {
                            MessageBox.Show("O campo 'valor' nao tem nenhum valor adicionado", "<- Cronos Agenda -> Erro!");
                            return;
                        }
                        else
                            if (cb_porfissional_c.Text == "")
                            {
                                MessageBox.Show("O o campo 'profissional' nao tem nenhum valor adicionado", "<- Cronos Agenda -> Erro!");
                                return;
                            }
                            else
                                if (cb_servico_c.Text == "")
                                {
                                    MessageBox.Show("O campo 'serviço' nao tem nenhum valor adicionado", "<- Cronos Agenda -> Erro!");
                                    return;
                                }
                                else
                                    if (dt_dia_c.Text == "")
                                    {
                                        MessageBox.Show("O campo 'data' nao tem nenhum valor adicionado", "<- Cronos Agenda -> Erro!");
                                        return;
                                    }
            }
            catch
            {
                MessageBox.Show("Nao foi possivel editar este agendamento.", "<- Cronos Agenda -> Erro!");

            }


            SqlConnection conect = new SqlConnection(Program.ConnectionString);
            class_agendamento Insert = new class_agendamento();
            Insert.Update(int.Parse(cb_cd_atendimento.Text), cb_nome_cliente.Text, dt_dia_c.Text, tb_horario_c.Text, cb_servico_c.Text, cb_porfissional_c.Text, double.Parse(tb_valor_c.Text));
            MessageBox.Show("Agendamento alterado com sucesso!!!", "<- Cronos Agenda -> Agendamento concluido!");

        }

        private void Editar_cd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_agendaDataSet10.tbl_servico' table. You can move, or remove it, as needed.
            this.tbl_servicoTableAdapter.Fill(this.bd_agendaDataSet10.tbl_servico);
            // TODO: This line of code loads data into the 'bd_agendaDataSet9.tbl_agendamento' table. You can move, or remove it, as needed.
            this.tbl_agendamentoTableAdapter4.Fill(this.bd_agendaDataSet9.tbl_agendamento);
            // TODO: This line of code loads data into the 'bd_agendaDataSet5.tbl_agendamento' table. You can move, or remove it, as needed.
            this.tbl_agendamentoTableAdapter3.Fill(this.bd_agendaDataSet5.tbl_agendamento);
            // TODO: This line of code loads data into the 'bd_agendaDataSet4.tbl_agendamento' table. You can move, or remove it, as needed.
            this.tbl_agendamentoTableAdapter2.Fill(this.bd_agendaDataSet4.tbl_agendamento);
            // TODO: This line of code loads data into the 'bd_agendaDataSet3.tbl_agendamento' table. You can move, or remove it, as needed.
            this.tbl_agendamentoTableAdapter1.Fill(this.bd_agendaDataSet3.tbl_agendamento);
            // TODO: This line of code loads data into the 'bd_agendaDataSet2.tbl_agendamento' table. You can move, or remove it, as needed.
            this.tbl_agendamentoTableAdapter.Fill(this.bd_agendaDataSet2.tbl_agendamento);

            cb_nome_cliente.Text = "";
            tb_valor_c.Text = "0,00";
            cb_porfissional_c.Text = "";
            cb_servico_c.Text = "";
            tb_horario_c.Text = "__:__";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cb_nome_cliente.Text = "";
            tb_valor_c.Text = "0,00";
            cb_porfissional_c.Text = "";
            cb_servico_c.Text = "";
            tb_horario_c.Text = "__:__";
        }

        private void buscarED()
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


                string SQL = "SELECT * FROM tbl_agendamento WHERE codigo_do_agendamento = '" + cb_cd_atendimento.Text + "';";
                MySqlDataAdapter objadapter = new MySqlDataAdapter(SQL, objconexao);
                DataSet objdataset = new DataSet();
                objadapter.Fill(objdataset, "usuarios");



                if (objdataset.Tables[0].Rows.Count > 0)
                {

                    Program._nomeC = (objdataset.Tables[0].Rows[0]["nome_do_cliente"].ToString());
                    Program._diaAtd = (objdataset.Tables[0].Rows[0]["dia_do_atendimento"]).ToString();
                    Program._servico = (objdataset.Tables[0].Rows[0]["servico"]).ToString();
                    Program._profissional = (objdataset.Tables[0].Rows[0]["profissional"]).ToString();
                    Program._valor = (objdataset.Tables[0].Rows[0]["valor"]).ToString();
                    Program._horaAtd = (objdataset.Tables[0].Rows[0]["horario_do_atendimento"]).ToString();

                    //Preenche os campos

                    cb_nome_cliente.Text = Program._nomeC;
                    cb_porfissional_c.Text = Program._profissional;
                    cb_servico_c.Text = Program._servico;
                    tb_valor_c.Text = Program._valor;
                    tb_horario_c.Text = Program._horaAtd;
                    dt_dia_c.Text = Program._diaAtd;
                }
                else
                {
                    MessageBox.Show("Erro! Agendamento não encontrado", "<- Cronos Agenda -> Erro!");

                }

                objconexao.Close();

            }
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja excluir este agendamento ? ", "<- Cronos Agenda -> Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Deletar();
            }
        }

        public void Deletar()
        {



            MySqlConnection conect = new MySqlConnection();
            conect.ConnectionString = Program.ConnectionString;
            string ComandString = "DELETE FROM tbl_agendamento WHERE codigo_do_agendamento = '" + cb_cd_atendimento.Text + "' LIMIT 1;";

            try
            {
                conect.Open();

                MySqlCommand comando = new MySqlCommand(ComandString, conect);

                comando.ExecuteNonQuery();

                MessageBox.Show("Agendamento deletado com sucesso!", "<- Cronos Agenda -> Atenção!");
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

        private void cb_cd_atendimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (condcao == true)
            {
                buscarED();
            }
            else
            {

            }
        }

        private void tb_valor_c_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Editar_cd_FormClosing(object sender, FormClosingEventArgs e)
        {
            condcao = false;
            telaPrincipal tl_p = new telaPrincipal();
            tl_p.limpargrid();
        }


    }
}
