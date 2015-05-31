using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Agenda
{
    public partial class tela_espera : Form
    {
        public tela_espera()
        {
            InitializeComponent();
        }

        private void tela_espera_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 4;
            }
            else
            {
                this.Hide();
                Login log = new Login();
                log.Show();
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0)
            {
                this.Opacity = this.Opacity + 0.1;

            }
            else
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
            }
        }
       
    }
}
