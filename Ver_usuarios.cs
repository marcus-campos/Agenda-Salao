using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Ver_usuarios : Form
    {
        public Ver_usuarios()
        {
            InitializeComponent();
        }

        private void Ver_usuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_agendaDataSet18.tbl_account' table. You can move, or remove it, as needed.
            this.tbl_accountTableAdapter.Fill(this.bd_agendaDataSet18.tbl_account);

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editar_usuário edi_usu = new Editar_usuário();
            edi_usu.ShowDialog();
        }
    }
}
