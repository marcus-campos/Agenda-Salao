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
    public partial class Ver_servicos : Form
    {
        public Ver_servicos()
        {
            InitializeComponent();
        }

        private void Ver_servicos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_agendaDataSet16.tbl_servico' table. You can move, or remove it, as needed.
            this.tbl_servicoTableAdapter.Fill(this.bd_agendaDataSet16.tbl_servico);
            dg_serviços.AutoResizeColumns();

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Serviços_Enter(object sender, EventArgs e)
        {

        }

        private void adicionarNovoServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novoServico novo_servico = new novoServico();
            novo_servico.ShowDialog();
        }

        private void editarUmServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editar_ns editar_ns = new Editar_ns();
            editar_ns.ShowDialog();
        }

       
    }
}
