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
    public partial class Ver_funcionario : Form
    {
        public Ver_funcionario()
        {
            InitializeComponent();
        }

        private void Ver_funcionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_agendaDataSet17.tbl_funcionarios' table. You can move, or remove it, as needed.
            this.tbl_funcionariosTableAdapter.Fill(this.bd_agendaDataSet17.tbl_funcionarios);

        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adicionarNovoFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroFuncionario novo_func = new cadastroFuncionario();
            novo_func.ShowDialog();
        }

        private void editarUmFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editar_sv editar_func = new Editar_sv();
            editar_func.ShowDialog();
        }
    }
}
