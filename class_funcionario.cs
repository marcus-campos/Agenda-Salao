using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Agenda
{
    class class_funcionario
    {
        public static int valid = 0;
        public void CadastrarFuncionarios(string nome, string cpf, string endereco, int numero, string complemento, string cidade, string telefone, string celular, string nascimento)
        {
            MySqlConnection conect = new MySqlConnection();
            conect.ConnectionString = Properties.Settings.Default.bd_agendaConnectionString;
            string ComandString = "Insert Into tbl_funcionarios VALUES ('','" + nome.ToString() + "','" + cpf.ToString() + "','" + endereco.ToString() + "','" + numero.ToString() + "','" + complemento.ToString() + "','" + cidade.ToString() + "','" + telefone.ToString() + "','" + celular.ToString() + "','" + nascimento.ToString() + "')";

            try
            {
                conect.Open();

                MySqlCommand comando = new MySqlCommand(ComandString, conect);

                comando.ExecuteNonQuery();
                valid = 1;
            }

            catch (Exception ex)
            {
                valid = 0;
                throw ex;

            }
            finally
            {
                conect.Close();
            }


        }

        public void Update(int cod_fc, string nome, string cpf, string endereco, int numero, string complemento, string cidade, string telefone, string celular, string dt_nascimento)
        {



            MySqlConnection conect = new MySqlConnection();
            conect.ConnectionString = Properties.Settings.Default.bd_agendaConnectionString;
            string ComandString = "UPDATE tbl_funcionarios SET nome = '" + nome.ToString() + "', cpf = '" + cpf.ToString() + "', endereco = '" + endereco.ToString() + "', numero = '" + numero.ToString() + "', complemento = '" + complemento.ToString() + "', cidade = '" + cidade.ToString() + "', telefone = '" + telefone.ToString() + "', celular = '" + celular.ToString() + "', nascimento = '" + dt_nascimento.ToString() + "' WHERE cod_proficional = '" + cod_fc + "' LIMIT 1;";

            try
            {
                conect.Open();

                MySqlCommand comando = new MySqlCommand(ComandString, conect);

                comando.ExecuteNonQuery();
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
        public void NovoUsuario(string login, string senha)
        {
            MySqlConnection conect = new MySqlConnection();
            conect.ConnectionString = Properties.Settings.Default.bd_agendaConnectionString;
            string ComandString = "Insert Into  tbl_account VALUES ('','" + Program._nome_n_FC.ToString() + "','" + login.ToString() + "','" + senha.ToString() + "','" + Program._nvadm_n_fc.ToString() + "')";

            try
            {
                conect.Open();

                MySqlCommand comando = new MySqlCommand(ComandString, conect);

                comando.ExecuteNonQuery();
                
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

        public void UpdateUSU(string nome, string login, string senha, int nvadm)
        {

            MySqlConnection conect = new MySqlConnection();
            conect.ConnectionString = Properties.Settings.Default.bd_agendaConnectionString;
            string ComandString = "UPDATE tbl_account SET nome = '" + nome.ToString() + "', login = '" + login.ToString() + "', senha = '" + senha.ToString() + "', nvadm = '" + nvadm.ToString() + "' LIMIT 1;";

            try
            {
                conect.Open();

                MySqlCommand comando = new MySqlCommand(ComandString, conect);

                comando.ExecuteNonQuery();
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
    }
}
