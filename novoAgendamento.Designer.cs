namespace Agenda
{
    partial class novoAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(novoAgendamento));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_horario = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_profissional = new System.Windows.Forms.ComboBox();
            this.tblaccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_agendaDataSet8 = new Agenda.bd_agendaDataSet8();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_servico = new System.Windows.Forms.ComboBox();
            this.tblservicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_agendaDataSet = new Agenda.bd_agendaDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_dia = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblfuncionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_agendaDataSet1 = new Agenda.bd_agendaDataSet1();
            this.tbl_servicoTableAdapter = new Agenda.bd_agendaDataSetTableAdapters.tbl_servicoTableAdapter();
            this.bdagendaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_funcionariosTableAdapter = new Agenda.bd_agendaDataSet1TableAdapters.tbl_funcionariosTableAdapter();
            this.tbl_accountTableAdapter = new Agenda.bd_agendaDataSet8TableAdapters.tbl_accountTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblaccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_agendaDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblservicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_agendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfuncionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_agendaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdagendaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tb_valor);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.tb_horario);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_profissional);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_servico);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dt_dia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_nome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(79, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo agendamento";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(116, 247);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(226, 20);
            this.tb_valor.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Location = new System.Drawing.Point(197, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb_horario
            // 
            this.tb_horario.AccessibleDescription = "Recebe o horário do atendimento";
            this.tb_horario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_horario.Location = new System.Drawing.Point(116, 128);
            this.tb_horario.Mask = "00:00";
            this.tb_horario.Name = "tb_horario";
            this.tb_horario.Size = new System.Drawing.Size(226, 20);
            this.tb_horario.TabIndex = 13;
            this.tb_horario.ValidatingType = typeof(System.DateTime);
            this.tb_horario.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tb_horario_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Horário";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(267, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(116, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor";
            // 
            // cb_profissional
            // 
            this.cb_profissional.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_profissional.DataSource = this.tblaccountBindingSource;
            this.cb_profissional.DisplayMember = "nome";
            this.cb_profissional.FormattingEnabled = true;
            this.cb_profissional.Location = new System.Drawing.Point(116, 207);
            this.cb_profissional.Name = "cb_profissional";
            this.cb_profissional.Size = new System.Drawing.Size(226, 21);
            this.cb_profissional.TabIndex = 7;
            this.cb_profissional.ValueMember = "nome";
            this.cb_profissional.SelectedIndexChanged += new System.EventHandler(this.cb_profissional_SelectedIndexChanged);
            // 
            // tblaccountBindingSource
            // 
            this.tblaccountBindingSource.DataMember = "tbl_account";
            this.tblaccountBindingSource.DataSource = this.bd_agendaDataSet8;
            // 
            // bd_agendaDataSet8
            // 
            this.bd_agendaDataSet8.DataSetName = "bd_agendaDataSet8";
            this.bd_agendaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Profissional";
            // 
            // cb_servico
            // 
            this.cb_servico.AccessibleDescription = "Recebe o serviço a ser realizado";
            this.cb_servico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_servico.DataSource = this.tblservicoBindingSource;
            this.cb_servico.DisplayMember = "nome_servico";
            this.cb_servico.FormattingEnabled = true;
            this.cb_servico.Location = new System.Drawing.Point(116, 167);
            this.cb_servico.Name = "cb_servico";
            this.cb_servico.Size = new System.Drawing.Size(226, 21);
            this.cb_servico.TabIndex = 5;
            this.cb_servico.ValueMember = "nome_servico";
            // 
            // tblservicoBindingSource
            // 
            this.tblservicoBindingSource.DataMember = "tbl_servico";
            this.tblservicoBindingSource.DataSource = this.bd_agendaDataSet;
            // 
            // bd_agendaDataSet
            // 
            this.bd_agendaDataSet.DataSetName = "bd_agendaDataSet";
            this.bd_agendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Serviço";
            // 
            // dt_dia
            // 
            this.dt_dia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dt_dia.Checked = false;
            this.dt_dia.Location = new System.Drawing.Point(116, 88);
            this.dt_dia.Name = "dt_dia";
            this.dt_dia.Size = new System.Drawing.Size(226, 20);
            this.dt_dia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dia";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_nome.Location = new System.Drawing.Point(116, 49);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(226, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome cliente";
            // 
            // tblfuncionariosBindingSource
            // 
            this.tblfuncionariosBindingSource.DataMember = "tbl_funcionarios";
            this.tblfuncionariosBindingSource.DataSource = this.bd_agendaDataSet1;
            // 
            // bd_agendaDataSet1
            // 
            this.bd_agendaDataSet1.DataSetName = "bd_agendaDataSet1";
            this.bd_agendaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_servicoTableAdapter
            // 
            this.tbl_servicoTableAdapter.ClearBeforeFill = true;
            // 
            // bdagendaDataSetBindingSource
            // 
            this.bdagendaDataSetBindingSource.DataSource = this.bd_agendaDataSet;
            this.bdagendaDataSetBindingSource.Position = 0;
            // 
            // tbl_funcionariosTableAdapter
            // 
            this.tbl_funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_accountTableAdapter
            // 
            this.tbl_accountTableAdapter.ClearBeforeFill = true;
            // 
            // novoAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 408);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(618, 446);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(618, 446);
            this.Name = "novoAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<- Cronos agenda -> Novo agendamento";
            this.Load += new System.EventHandler(this.novoAgendamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblaccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_agendaDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblservicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_agendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfuncionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_agendaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdagendaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_profissional;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_servico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_dia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox tb_horario;
        private System.Windows.Forms.Button button3;
        private bd_agendaDataSet bd_agendaDataSet;
        private System.Windows.Forms.BindingSource tblservicoBindingSource;
        private bd_agendaDataSetTableAdapters.tbl_servicoTableAdapter tbl_servicoTableAdapter;
        private System.Windows.Forms.BindingSource bdagendaDataSetBindingSource;
        private bd_agendaDataSet1 bd_agendaDataSet1;
        private System.Windows.Forms.BindingSource tblfuncionariosBindingSource;
        private bd_agendaDataSet1TableAdapters.tbl_funcionariosTableAdapter tbl_funcionariosTableAdapter;
        private bd_agendaDataSet8 bd_agendaDataSet8;
        private System.Windows.Forms.BindingSource tblaccountBindingSource;
        private bd_agendaDataSet8TableAdapters.tbl_accountTableAdapter tbl_accountTableAdapter;
        private System.Windows.Forms.TextBox tb_valor;
    }
}