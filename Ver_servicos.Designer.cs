namespace Agenda
{
    partial class Ver_servicos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ver_servicos));
            this.dg_serviços = new System.Windows.Forms.DataGridView();
            this.codservicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeservicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valormedioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblservicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_agendaDataSet16 = new Agenda.bd_agendaDataSet16();
            this.Serviços = new System.Windows.Forms.GroupBox();
            this.tbl_servicoTableAdapter = new Agenda.bd_agendaDataSet16TableAdapters.tbl_servicoTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarNovoServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUmServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dg_serviços)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblservicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_agendaDataSet16)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_serviços
            // 
            this.dg_serviços.AllowUserToAddRows = false;
            this.dg_serviços.AllowUserToDeleteRows = false;
            this.dg_serviços.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_serviços.AutoGenerateColumns = false;
            this.dg_serviços.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_serviços.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_serviços.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codservicoDataGridViewTextBoxColumn,
            this.nomeservicoDataGridViewTextBoxColumn,
            this.valormedioDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dg_serviços.DataSource = this.tblservicoBindingSource;
            this.dg_serviços.Location = new System.Drawing.Point(18, 77);
            this.dg_serviços.Name = "dg_serviços";
            this.dg_serviços.ReadOnly = true;
            this.dg_serviços.Size = new System.Drawing.Size(608, 296);
            this.dg_serviços.TabIndex = 0;
            this.dg_serviços.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codservicoDataGridViewTextBoxColumn
            // 
            this.codservicoDataGridViewTextBoxColumn.DataPropertyName = "cod_servico";
            this.codservicoDataGridViewTextBoxColumn.HeaderText = "Codigo do serviço";
            this.codservicoDataGridViewTextBoxColumn.Name = "codservicoDataGridViewTextBoxColumn";
            this.codservicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeservicoDataGridViewTextBoxColumn
            // 
            this.nomeservicoDataGridViewTextBoxColumn.DataPropertyName = "nome_servico";
            this.nomeservicoDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeservicoDataGridViewTextBoxColumn.Name = "nomeservicoDataGridViewTextBoxColumn";
            this.nomeservicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valormedioDataGridViewTextBoxColumn
            // 
            this.valormedioDataGridViewTextBoxColumn.DataPropertyName = "valor_medio";
            this.valormedioDataGridViewTextBoxColumn.HeaderText = "Valor Medio";
            this.valormedioDataGridViewTextBoxColumn.Name = "valormedioDataGridViewTextBoxColumn";
            this.valormedioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblservicoBindingSource
            // 
            this.tblservicoBindingSource.DataMember = "tbl_servico";
            this.tblservicoBindingSource.DataSource = this.bd_agendaDataSet16;
            // 
            // bd_agendaDataSet16
            // 
            this.bd_agendaDataSet16.DataSetName = "bd_agendaDataSet16";
            this.bd_agendaDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Serviços
            // 
            this.Serviços.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Serviços.Location = new System.Drawing.Point(12, 58);
            this.Serviços.Name = "Serviços";
            this.Serviços.Size = new System.Drawing.Size(620, 321);
            this.Serviços.TabIndex = 1;
            this.Serviços.TabStop = false;
            this.Serviços.Text = "Serviços";
            this.Serviços.Enter += new System.EventHandler(this.Serviços_Enter);
            // 
            // tbl_servicoTableAdapter
            // 
            this.tbl_servicoTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviçosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarNovoServiçoToolStripMenuItem,
            this.editarUmServiçoToolStripMenuItem});
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            // 
            // adicionarNovoServiçoToolStripMenuItem
            // 
            this.adicionarNovoServiçoToolStripMenuItem.Name = "adicionarNovoServiçoToolStripMenuItem";
            this.adicionarNovoServiçoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.adicionarNovoServiçoToolStripMenuItem.Text = "Adicionar novo serviço";
            this.adicionarNovoServiçoToolStripMenuItem.Click += new System.EventHandler(this.adicionarNovoServiçoToolStripMenuItem_Click);
            // 
            // editarUmServiçoToolStripMenuItem
            // 
            this.editarUmServiçoToolStripMenuItem.Name = "editarUmServiçoToolStripMenuItem";
            this.editarUmServiçoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.editarUmServiçoToolStripMenuItem.Text = "Editar um serviço";
            this.editarUmServiçoToolStripMenuItem.Click += new System.EventHandler(this.editarUmServiçoToolStripMenuItem_Click);
            // 
            // Ver_servicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 391);
            this.Controls.Add(this.dg_serviços);
            this.Controls.Add(this.Serviços);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ver_servicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<- Cronos agenda -> Ver serviços";
            this.Load += new System.EventHandler(this.Ver_servicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_serviços)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblservicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_agendaDataSet16)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_serviços;
        private System.Windows.Forms.GroupBox Serviços;
        private bd_agendaDataSet16 bd_agendaDataSet16;
        private System.Windows.Forms.BindingSource tblservicoBindingSource;
        private bd_agendaDataSet16TableAdapters.tbl_servicoTableAdapter tbl_servicoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codservicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeservicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valormedioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarNovoServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarUmServiçoToolStripMenuItem;


    }
}