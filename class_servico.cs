using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Agenda
{
    class class_servico
    {
        public void novoServico(string nome, double valor_medio, string descricao)
        {
            MySqlConnection conect = new MySqlConnection();
            conect.ConnectionString = Properties.Settings.Default.bd_agendaConnectionString;
            string ComandString = "Insert Into tbl_servico VALUES ('','" + nome.ToString() + "','" + valor_medio.ToString().Replace(",",".") + "','" + descricao.ToString() + "')";

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
             public void Update(int cod_sv, string nome, double valor_medio, string descricao)
            {



            MySqlConnection conect = new MySqlConnection();
            conect.ConnectionString = Properties.Settings.Default.bd_agendaConnectionString;
            string ComandString = "UPDATE tbl_servico SET nome_servico = '" + nome.ToString() + "', valor_medio = '" + valor_medio.ToString().Replace(",",".") + "', descricao = '" + descricao.ToString() + "' WHERE cod_servico = '" + cod_sv + "' LIMIT 1;";

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

