using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Agenda
{
    class verificacoes
    {
        public string _nome = "";
        private void verificar()
        {
            
            MySqlConnection objconexao = new MySqlConnection();
            objconexao.ConnectionString = Properties.Settings.Default.bd_agendaConnectionString;

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

                string SQL = "SELECT nome FROM tbl_account WHERE nome = '" + _nome + "';";
                MySqlDataAdapter objadapter = new MySqlDataAdapter(SQL, objconexao);
                DataSet objdataset = new DataSet();
                objadapter.Fill(objdataset, "dia_do_atendimento");
                DataTable data = new DataTable();
                objadapter.Fill(data);


                if (objdataset.Tables[0].Rows.Count > 0)
                {
                   
                }
                else
                {
                    MessageBox.Show("Não a nada marcado para o dia selecinado!!!", "<- Cronos Agenda -> Atenção!");
                }
                objconexao.Close();
            }
        }
        
    }
}
