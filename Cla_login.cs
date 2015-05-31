using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace Agenda
{
    class Cla_login
    {
       
       
        public bool Autenticar(string Login, string Senha)
        {
            bool retn = false;

            MySqlConnection objconexao = new MySqlConnection();
            objconexao.ConnectionString = Properties.Settings.Default.bd_agendaConnectionString;

            try
            {
                objconexao.Open();
            }
            catch
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados. Favor conferir se o banco de dados está corretamente configurado, e online.", "<- Cronos Agenda -> Erro!");
                retn = false;
            }

            if (objconexao.State == System.Data.ConnectionState.Open)
            {
                

                string SQL = "SELECT * FROM tbl_account WHERE LOGIN = '" + Login + "'AND SENHA = '" + Senha + "';";
                MySqlDataAdapter objadapter = new MySqlDataAdapter(SQL, objconexao);
                DataSet objdataset = new DataSet();
                objadapter.Fill(objdataset, "usuarios");


                
                if (objdataset.Tables[0].Rows.Count > 0)
                {
                    
                    Program._nome = (objdataset.Tables[0].Rows[0]["NOME"].ToString());
                    Program._nvadm = (objdataset.Tables[0].Rows[0]["NVADM"]).ToString();
                    retn = true;
                }
                else
                {
                    MessageBox.Show("Erro Login ou senha inválidos", "<- Cronos Agenda -> Erro!");
                    retn = false;

                }
                
                objconexao.Close();
                
            }

            return retn;

                     
        }


     }
              
       
 }

