using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Agenda
{
    

    public partial class telaPrincipal : Form
    {
        bool sair = true;
       

        public telaPrincipal()
        {
            InitializeComponent();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            novoAgendamento nv_ag = new novoAgendamento();
            nv_ag.ShowDialog();
        }

        private void agendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novoAgendamento nv_ag = new novoAgendamento();
            nv_ag.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sair == true)
            {
                if (MessageBox.Show("Voce realmente deseja fazer Logoff ?", "<- Cronos Agenda -> Deslogar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    sair = false;
                    MessageBox.Show("Você foi desconectado!", "<- Cronos Agenda -> Desconectado!");
                    this.Close();
                    Login frm_login = new Login();
                    frm_login.Show();

                }
            }
            else
            {

            }
            
        }

    
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            Editar_cd frm_editar = new Editar_cd();
            frm_editar.ShowDialog();
        }

        private void editarUmAgendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editar_cd frm_editar = new Editar_cd();
            frm_editar.ShowDialog();
        }

        private void Agenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           

        }

        private void CalculaValorCaixa()
        {
            MySqlConnection objconexao = new MySqlConnection();
            objconexao.ConnectionString = Program.ConnectionString;

            try
            {
                objconexao.Open();
            }
            catch
            {
                MessageBox.Show("Houve um problema ao iniciar a agenda!", "<- Cronos Agenda -> Erro!");
            }

            if (objconexao.State == ConnectionState.Open)
            {


                if (Program._nvadm == "1" || Program._nvadm == "2")
                {

                    string SQL = "SELECT sum(valor) FROM tbl_agendamento WHERE DIA_DO_ATENDIMENTO = '" + dateTimePicker1.Text + "';";
                    MySqlDataAdapter objadapter1 = new MySqlDataAdapter(SQL, objconexao);
                    DataSet objdataset1 = new DataSet();
                    objadapter1.Fill(objdataset1, "dia_do_atendimento");
                    DataTable data1 = new DataTable();
                    objadapter1.Fill(data1);

                    if (objdataset1.Tables[0].Rows.Count > 0)
                    {
                        try
                        {

                            lb_valor_caixa.Text = (objdataset1.Tables[0].Rows[0]["valor"].ToString());
                        }
                        catch
                        {

                        }
                    }

                    else
                    {

                        MessageBox.Show("Não a nada marcado para o dia selecinado!!!", "<- Cronos Agenda -> Atenção!");
                    }
                }
            }
        }

        public void telaPrincipal_Load(object sender, EventArgs e)
        {
            t_lb_nome.Text = Program._nome;

            t_lb_versao.Text = Program._versao;

            t_lb_inicioS.Text = DateTime.Now.ToString();
            
            if (Program._nvadm == "1")
            {
                t_lb_nvadm.Text = "Administrador(a)";
            }
            else
                if(Program._nvadm == "2")
                {
                    t_lb_nvadm.Text = "Secretaria(o)";
                    fc_lb.Enabled = false;
                    fc_nome.Enabled = false;
                    fc_editar.Enabled = false;
                    fc_menu.Enabled = false;
                    fc_ver_funcionarios.Enabled = false;
                    fc_ver_usu.Enabled = false;
                }
            else 
                 if(Program._nvadm == "3")
                {
                    t_lb_nvadm.Text = "Funcionaria(o)";
                    fc_lb.Enabled = false;
                    fc_nome.Enabled = false;
                    fc_editar.Enabled = false;
                    sv_editar.Enabled = false;
                    sv_lb.Enabled = false;
                    sv_novo.Enabled = false;
                    ag_editar.Enabled = false;
                    ag_lb.Enabled = false;
                    ag_novo.Enabled = false;
                    ag_menu.Enabled = false;
                    fc_menu.Enabled = false;
                    sv_menu.Enabled = false;
                    fc_ver_funcionarios.Enabled = false;
                    sv_ver_servicos.Enabled = false;
                    fc_ver_usu.Enabled = false;

                }
            
           
            carregargrid();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carregargrid();
            CalculaValorCaixa();

        }

        public void limpargrid()
        {
            dg_agenda.DataSource = null; //Remover a datasource
            dg_agenda.Columns.Clear(); //Remover as colunas
            dg_agenda.Rows.Clear();    //Remover as linhas
            dg_agenda.Refresh();  //Atualiza grid
        }
          
        
        
        
            public void carregargrid()
            {

            MySqlConnection objconexao = new MySqlConnection();
            objconexao.ConnectionString = Program.ConnectionString;

            try
            {
                objconexao.Open();
            }
            catch
            {
                MessageBox.Show("Houve um problema ao iniciar a agenda!", "<- Cronos Agenda -> Erro!");
            }

            if (objconexao.State == ConnectionState.Open)
            {


                if (Program._nvadm == "1" || Program._nvadm == "2")
                {

                    string SQL1 = "SELECT * FROM tbl_agendamento WHERE DIA_DO_ATENDIMENTO = '" + "0000-00-00" + "';";
                    MySqlDataAdapter objadapter1 = new MySqlDataAdapter(SQL1, objconexao);
                    DataSet objdataset1 = new DataSet();
                    objadapter1.Fill(objdataset1, "dia_do_atendimento");
                    DataTable data1 = new DataTable();
                    objadapter1.Fill(data1);

                    if (objdataset1.Tables[0].Rows.Count > 0)
                    {
                       
                        dg_agenda.DataSource = data1;
                        

                        // Formata os nomes das colunas do grid

                        dg_agenda.Columns[0].HeaderText = "Codigo do atendimento";
                        dg_agenda.Columns[1].HeaderText = "Nome do cliente";
                        dg_agenda.Columns[2].HeaderText = "Dia do atendimento";
                        dg_agenda.Columns[3].HeaderText = "Horário do atendimento";
                        dg_agenda.Columns[4].HeaderText = "Serviço";
                        dg_agenda.Columns[5].HeaderText = "Profissional";
                        dg_agenda.Columns[6].HeaderText = "Valor";
                        dg_agenda.AutoResizeColumns();
                        

                        
                    }

                    else
                    {

                        MessageBox.Show("Não a nada marcado para o dia selecinado!!!", "<- Cronos Agenda -> Atenção!");
                    }
                }

                else
                {
                    string SQL = "SELECT codigo_do_agendamento, nome_do_cliente, dia_do_atendimento, horario_do_atendimento, servico, profissional FROM tbl_agendamento WHERE DIA_DO_ATENDIMENTO = '" + dateTimePicker1.Text + "'AND profissional = '" + Program._nome + "';";
                    MySqlDataAdapter objadapter = new MySqlDataAdapter(SQL, objconexao);
                    DataSet objdataset = new DataSet();
                    objadapter.Fill(objdataset, "dia_do_atendimento");
                    DataTable data = new DataTable();
                    objadapter.Fill(data);


                    if (objdataset.Tables[0].Rows.Count > 0)
                    {
                       
                        dg_agenda.DataSource = data;

                        // Formata os nomes das colunas do grid

                        dg_agenda.Columns[0].HeaderText = "Codigo do atendimento";
                        dg_agenda.Columns[1].HeaderText = "Nome do cliente";
                        dg_agenda.Columns[2].HeaderText = "Dia do atendimento";
                        dg_agenda.Columns[3].HeaderText = "Horário do atendimento";
                        dg_agenda.Columns[4].HeaderText = "Serviço";
                        dg_agenda.Columns[5].HeaderText = "Profissional";
                        dg_agenda.AutoResizeColumns();
                    }
                    else
                    {

                        MessageBox.Show("Não a nada marcado para o dia selecinado!!!", "<- Cronos Agenda -> Atenção!");
                    }
                }
                objconexao.Close();
            }
        }
        /*
            private void valorDiario()
            {


                MySqlConnection objconexao = new MySqlConnection();
                objconexao.ConnectionString = Program.ConnectionString;

                try
                {
                    objconexao.Open();
                }
                catch
                {
                    MessageBox.Show("Não foi possível conectar-se ao banco de dados. Favor conferir se o banco de dados esta corretamente configurado, e online.", "Erro");

                }

                if (objconexao.State == System.Data.ConnectionState.Open)
                {


                    string SQL = "SELECT sum(valor) FROM tbl_agendamento WHERE dia_do_atendimento = '" + dateTimePicker1.Text + "';";
                    MySqlDataAdapter objadapter = new MySqlDataAdapter(SQL, objconexao);
                    DataSet objdataset = new DataSet();
                    objadapter.Fill(objdataset, "usuarios");



                    if (objdataset.Tables[0].Rows.Count > 0)
                    {

                        
                       
                    }
                    else
                    {
                        MessageBox.Show("Erro serviço nao encontrado", "Erro!");

                    }

                    objconexao.Close();

                }
            }
         */
        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void dg_agenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            novoServico ns = new novoServico();
            ns.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            cadastroFuncionario cd_f = new cadastroFuncionario();
            cd_f.ShowDialog();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novoServico ns = new novoServico();
            ns.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Editar_ns ns = new Editar_ns();
            ns.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Editar_sv ed_s = new Editar_sv();
            ed_s.ShowDialog();
        }

        private void telaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sair == true)
            {
                sair = false;
                Application.Exit();
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpargrid();
        }

        private void telaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sair == true)
            {
                sair = false;
                Application.Exit();
            } 
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editar_ns edit_ns = new Editar_ns();
            edit_ns.ShowDialog();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Editar_sv editar_sv = new Editar_sv();
            editar_sv.ShowDialog();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sv_ver_servicos_Click(object sender, EventArgs e)
        {
            Ver_servicos ver_sv = new Ver_servicos();
            ver_sv.ShowDialog();
        }

        private void verServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ver_servicos ver_sv = new Ver_servicos();
            ver_sv.ShowDialog();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fc_ver_funcionarios_Click(object sender, EventArgs e)
        {
            Ver_funcionario ver_func = new Ver_funcionario();
            ver_func.ShowDialog();
        }

        private void verFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ver_funcionario ver_func = new Ver_funcionario();
            ver_func.ShowDialog();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Ver_usuarios ver_usu = new Ver_usuarios();
            ver_usu.ShowDialog();
        }

        private void verUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ver_usuarios ver_usu = new Ver_usuarios();
            ver_usu.ShowDialog();
        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About creditos = new About();
            creditos.ShowDialog();
        }

        

    }
}
