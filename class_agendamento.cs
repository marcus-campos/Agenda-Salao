using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace Agenda
{
    class class_agendamento
    {
        public void Insert(string nome, DateTime dia, string horario, string servico, string profissional, double valor)
        {


            
            MySqlConnection conect = new MySqlConnection();
            conect.ConnectionString = Properties.Settings.Default.bd_agendaConnectionString;
            string ComandString = "Insert Into tbl_agendamento VALUES ('','" + nome.ToString() + "','" + dia.ToString() + "','" + horario.ToString() + "','" + servico.ToString() + "','" + profissional.ToString() + "','" + valor.ToString().Replace(",",".") + "');";

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

        public void Update(int cod_ag, string nome, string dia, string horario, string servico, string profissional, double valor)
        {



            MySqlConnection conect = new MySqlConnection();
            conect.ConnectionString = Properties.Settings.Default.bd_agendaConnectionString;
            string ComandString = "UPDATE tbl_agendamento SET nome_do_cliente = '" + nome.ToString() + "', dia_do_atendimento = '" + dia.ToString() + "', horario_do_atendimento = '" + horario.ToString() + "', servico = '" + servico.ToString() + "', profissional = '" + profissional.ToString() + "', valor = '" + valor.ToString().Replace(",",".") + "' WHERE codigo_do_agendamento = '" + cod_ag + "' LIMIT 1;";

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

