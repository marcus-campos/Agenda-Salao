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
    public partial class novoAgendamento : Form
    {
        public static int _liberaHorario = 0;
        public novoAgendamento()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        // Implementar na 2.0
        /*
        private void verificar_horario()
        {

            MySqlConnection objconexao = new MySqlConnection();
            objconexao.ConnectionString = Program.ConnectionString;

            try
            {
                objconexao.Open();
            }
            catch
            {
                MessageBox.Show("Houve um problema ao verificar se o horário está disponivel!", "Erro!");
            }

            if (objconexao.State == ConnectionState.Open)
            {

                string SQL = "SELECT horario_do_atendimento FROM tbl_agendamento WHERE profissional = '" + cb_profissional.ToString() + "' AND horario_do_atendimento '" + tb_horario.ToString() + "' AND dia_do_atendimento '" + dt_dia.ToString() + "';";
                MySqlDataAdapter objadapter = new MySqlDataAdapter(SQL, objconexao);
                DataSet objdataset = new DataSet();
                objadapter.Fill(objdataset, "dia_do_atendimento");
                DataTable data = new DataTable();
                objadapter.Fill(data);


                if (objdataset.Tables[0].Rows.Count > 0)
                {
                    string _horaAtd = (objdataset.Tables[0].Rows[0]["horario_do_atendimento"]).ToString();

                    if (DateTime.Parse(_horaAtd).ToShortTimeString() == tb_horario.Text)
                    {
                        _liberaHorario = 1;
                    }
                }
                else
                {
                    _liberaHorario = 2;
                }
                objconexao.Close();
            }
        }
         */

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (tb_horario.Text == "")
                {
                    MessageBox.Show("O campo 'horário' nao tem nenhum valor adicionado", "<- Cronos Agenda -> Erro!");
                    return;
                }
                else
                    if (tb_nome.Text == "")
                    {
                        MessageBox.Show("O campo 'nome' nao tem nenhum valor adicionado", "<- Cronos Agenda -> Erro!");
                        return;
                    }
                    else
                        if (tb_valor.Text == "")
                        {
                            MessageBox.Show("O campo 'valor' nao tem nenhum valor adicionado", "<- Cronos Agenda -> Erro!");
                            return;
                        }
                        else
                            if (cb_profissional.Text == "")
                            {
                                MessageBox.Show("O o campo 'profissional' nao tem nenhum valor adicionado", "<- Cronos Agenda -> Erro!");
                                return;
                            }
                            else
                                if (cb_servico.Text == "")
                                {
                                    MessageBox.Show("O campo 'serviço' nao tem nenhum valor adicionado", "<- Cronos Agenda -> Erro!");
                                    return;
                                }
                                else
                                    if (dt_dia.Text == "")
                                    {
                                        MessageBox.Show("O campo 'data' nao tem nenhum valor adicionado", "<- Cronos Agenda -> Erro!");
                                        return;
                                    }
               
                
                    SqlConnection conect = new SqlConnection(Program.ConnectionString);
                    class_agendamento Insert = new class_agendamento();
                    Insert.Insert(tb_nome.Text, DateTime.Parse(dt_dia.Value.ToShortDateString()).ToUniversalTime(), tb_horario.Text, cb_servico.Text, cb_profissional.Text, double.Parse(tb_valor.Text));
                    MessageBox.Show("Agendamento adicionado com sucesso!!!", "<- Cronos Agenda -> Agendamento concluido!");
                
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro 001:\n" + erro, "<- Cronos Agenda -> Erro!");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void novoAgendamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_agendaDataSet8.tbl_account' table. You can move, or remove it, as needed.
            this.tbl_accountTableAdapter.Fill(this.bd_agendaDataSet8.tbl_account);
            // TODO: This line of code loads data into the 'bd_agendaDataSet1.tbl_funcionarios' table. You can move, or remove it, as needed.
            this.tbl_funcionariosTableAdapter.Fill(this.bd_agendaDataSet1.tbl_funcionarios);
            // TODO: This line of code loads data into the 'bd_agendaDataSet.tbl_servico' table. You can move, or remove it, as needed.
            this.tbl_servicoTableAdapter.Fill(this.bd_agendaDataSet.tbl_servico);
            tb_nome.Text = "";
            cb_profissional.Text = "";
            cb_servico.Text = "";
            tb_horario.Text = "__:__";
            tb_valor.Text = "0,00";
            
        }

        private void tb_horario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tb_nome.Text = "";
            tb_valor.Text = "0,00";
            cb_profissional.Text = "";
            cb_servico.Text = "";
            tb_horario.Text = "__:__";
           

        }

        private void tb_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cb_profissional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
