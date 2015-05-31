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
    public partial class Editar_usuário : Form
    {
        public Editar_usuário()
        {
            InitializeComponent();
        }

        private void Editar_usuário_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_agendaDataSet19.tbl_account' table. You can move, or remove it, as needed.
            this.tbl_accountTableAdapter.Fill(this.bd_agendaDataSet19.tbl_account);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buscarUSU();
        }

        private void buscarUSU()
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


                string SQL = "SELECT * FROM tbl_account WHERE id = '" + cb_id.Text + "';";
                MySqlDataAdapter objadapter = new MySqlDataAdapter(SQL, objconexao);
                DataSet objdataset = new DataSet();
                objadapter.Fill(objdataset, "usuarios");



                if (objdataset.Tables[0].Rows.Count > 0)
                {

                    string _login = (objdataset.Tables[0].Rows[0]["login"].ToString());
                    string _senha = (objdataset.Tables[0].Rows[0]["senha"].ToString());
                    string _nome = (objdataset.Tables[0].Rows[0]["nome"].ToString());
                    string _nvadm = (objdataset.Tables[0].Rows[0]["nvadm"].ToString());
                    
                    
                    //Preenche os campos
                    tb_nome.Text = _nome;
                    tb_usuario_eu.Text = _login;
                    tb_senha_eu.Text = _senha;
                    
                    if(_nvadm == "1")
                    {
                        rb_adm.Enabled = true;
                    }
                    else
                        if (_nvadm == "2")
                        {
                            rb_secretario.Enabled = true;
                        }
                        else
                            if (_nvadm == "3")
                            {
                                rb_funcionario.Enabled = true;
                            }                  


                }
                else
                {
                    MessageBox.Show("Erro! Agendamento não encontrado", "<- Cronos Agenda -> Erro!");

                }

                objconexao.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_nome.Text = "";
            tb_senha_eu.Text = "";
            tb_usuario_eu.Text = "";
            rb_adm.Enabled = false;
            rb_funcionario.Enabled = false;
            rb_secretario.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja excluir este usuário ? ", "<- Cronos Agenda -> Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Deletar();
            }
        }
        public void Deletar()
        {



            MySqlConnection conect = new MySqlConnection();
            conect.ConnectionString = Program.ConnectionString;
            string ComandString = "DELETE FROM tbl_account WHERE id = '" + cb_id.Text + "' LIMIT 1;";

            try
            {
                conect.Open();

                MySqlCommand comando = new MySqlCommand(ComandString, conect);

                comando.ExecuteNonQuery();

                MessageBox.Show("Usuário deletado com sucesso!", "<- Cronos Agenda -> Atenção!");
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

        private void button1_Click(object sender, EventArgs e)
        {
            int _nvadm = 0;
           
            if (tb_nome.Text == "")
            {
                MessageBox.Show("Erro! O campo 'Nome' não foi preenchido corretamente.", "<- Cronos Agenda -> Erro!");
            }
            else
                if (tb_usuario_eu.Text == "")
                {
                    MessageBox.Show("Erro! O campo 'Login' não foi preenchido corretamente.", "<- Cronos Agenda -> Erro!");
                }
                else
                    if (tb_senha_eu.Text == "")
                    {
                        MessageBox.Show("Erro! O campo 'Senha' não foi preenchido corretamente.", "<- Cronos Agenda -> Erro!");
                    }
            if(rb_adm.Enabled == true)
            {
                _nvadm = 1;
            }
            else
                if(rb_secretario.Enabled == true)
            {
                _nvadm = 2;
            }
            else
                    if(rb_funcionario.Enabled == true)
            {
                _nvadm = 3;
            }
            else
                    {
                        MessageBox.Show("Erro! Tipo de usuário inválido.", "<- Cronos Agenda -> Erro!");
                    }



            SqlConnection conect = new SqlConnection(Program.ConnectionString);
            class_funcionario Insert = new class_funcionario();
            Insert.UpdateUSU(tb_nome.Text, tb_usuario_eu.Text, tb_senha_eu.Text, _nvadm);
            MessageBox.Show("Usuário alterado com sucesso!!!", "<- Cronos Agenda -> Alteração de usuário concluido!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
