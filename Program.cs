using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Agenda
{
    static class Program
    {
        // Dados iniciais
        public static string ConnectionString = "Persist Security Info=False;server=localhost;database=bd_agenda;uid=root;pwd=";
        public static string _nome = "";
        public static string _nvadm = "";
        public static string _versao = "1.0.0";

        // Editar agendamento

        public static string _nomeC = "";
        public static string _diaAtd = "";
        public static string _horaAtd = "";
        public static string _servico = "";
        public static string _profissional = "";
        public static string _valor = "";

        //Editar serviço

        public static string _nomeSV = "";
        public static string _descricaoSV = "";

        //Editar funcionario

        public static string _nomeFC = "";
        public static string _cpfFC = "";
        public static string _enderecoFC = "";
        public static string _numeroFC = "";
        public static string _complementoFC = "";
        public static string _cidadeFC = "";
        public static string _telefoneFC = "";
        public static string _celularFC = "";
        public static string _nascimentoFC = "";

        // Novo usuario

        public static string _nome_n_FC = "";
        public static int _nvadm_n_fc = 0;
        
        

        
        
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new tela_espera());
        }
    }
}
