namespace Agenda
{
    partial class Editar_sv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_sv));
            this.m_tb_celular_fc = new System.Windows.Forms.MaskedTextBox();
            this.m_tb_telefone_fc = new System.Windows.Forms.MaskedTextBox();
            this.m_tb_cpf_fc = new System.Windows.Forms.MaskedTextBox();
            this.dt_dataNascimento_fc = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.cb_cd_fc = new System.Windows.Forms.ComboBox();
            this.tblfuncionariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bd_agendaDataSet15 = new Agenda.bd_agendaDataSet15();
            this.cb_nome_fc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_cidade_fc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_complemento_fc = new System.Windows.Forms.TextBox();
            this.tb_numero_fc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_endereco_fc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblservicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_agendaDataSet12 = new Agenda.bd_agendaDataSet12();
            this.tblfuncionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_agendaDataSet6 = new Agenda.bd_agendaDataSet6();
            this.tbl_funcionariosTableAdapter = new Agenda.bd_agendaDataSet6TableAdapters.tbl_funcionariosTableAdapter();
            this.tbl_servicoTableAdapter = new Agenda.bd_agendaDataSet12TableAdapters.tbl_servicoTableAdapter();
            this.tbl_funcionariosTableAdapter1 = new Agenda.bd_agendaDataSet15TableAdapters.tbl_funcionariosTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblfuncionariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_agendaDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblservicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_agendaDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfuncionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_agendaDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // m_tb_celular_fc
            // 
            this.m_tb_celular_fc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.m_tb_celular_fc.Location = new System.Drawing.Point(236, 278);
            this.m_tb_celular_fc.Mask = "(99) 0000-0000";
            this.m_tb_celular_fc.Name = "m_tb_celular_fc";
            this.m_tb_celular_fc.Size = new System.Drawing.Size(114, 20);
            this.m_tb_celular_fc.TabIndex = 23;
            // 
            // m_tb_telefone_fc
            // 
            this.m_tb_telefone_fc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.m_tb_telefone_fc.Location = new System.Drawing.Point(124, 278);
            this.m_tb_telefone_fc.Mask = "(99) 0000-0000";
            this.m_tb_telefone_fc.Name = "m_tb_telefone_fc";
            this.m_tb_telefone_fc.Size = new System.Drawing.Size(106, 20);
            this.m_tb_telefone_fc.TabIndex = 22;
            // 
            // m_tb_cpf_fc
            // 
            this.m_tb_cpf_fc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.m_tb_cpf_fc.Location = new System.Drawing.Point(124, 122);
            this.m_tb_cpf_fc.Mask = "000.009.999-99";
            this.m_tb_cpf_fc.Name = "m_tb_cpf_fc";
            this.m_tb_cpf_fc.Size = new System.Drawing.Size(226, 20);
            this.m_tb_cpf_fc.TabIndex = 21;
            // 
            // dt_dataNascimento_fc
            // 
            this.dt_dataNascimento_fc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dt_dataNascimento_fc.Location = new System.Drawing.Point(124, 316);
            this.dt_dataNascimento_fc.Name = "dt_dataNascimento_fc";
            this.dt_dataNascimento_fc.Size = new System.Drawing.Size(226, 20);
            this.dt_dataNascimento_fc.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Data de nascimento";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Location = new System.Drawing.Point(205, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(275, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.cb_cd_fc);
            this.groupBox1.Controls.Add(this.cb_nome_fc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.m_tb_celular_fc);
            this.groupBox1.Controls.Add(this.m_tb_telefone_fc);
            this.groupBox1.Controls.Add(this.m_tb_cpf_fc);
            this.groupBox1.Controls.Add(this.dt_dataNascimento_fc);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tb_cidade_fc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_complemento_fc);
            this.groupBox1.Controls.Add(this.tb_numero_fc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_endereco_fc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(76, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 387);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar funcionario";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(255, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "Ver funcionários";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cb_cd_fc
            // 
            this.cb_cd_fc.DataSource = this.tblfuncionariosBindingSource1;
            this.cb_cd_fc.DisplayMember = "cod_proficional";
            this.cb_cd_fc.FormattingEnabled = true;
            this.cb_cd_fc.Location = new System.Drawing.Point(124, 42);
            this.cb_cd_fc.Name = "cb_cd_fc";
            this.cb_cd_fc.Size = new System.Drawing.Size(125, 21);
            this.cb_cd_fc.TabIndex = 27;
            this.cb_cd_fc.ValueMember = "cod_proficional";
            this.cb_cd_fc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tblfuncionariosBindingSource1
            // 
            this.tblfuncionariosBindingSource1.DataMember = "tbl_funcionarios";
            this.tblfuncionariosBindingSource1.DataSource = this.bd_agendaDataSet15;
            // 
            // bd_agendaDataSet15
            // 
            this.bd_agendaDataSet15.DataSetName = "bd_agendaDataSet15";
            this.bd_agendaDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_nome_fc
            // 
            this.cb_nome_fc.Location = new System.Drawing.Point(124, 82);
            this.cb_nome_fc.Name = "cb_nome_fc";
            this.cb_nome_fc.Size = new System.Drawing.Size(227, 20);
            this.cb_nome_fc.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Codigo do funcionario";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(124, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_cidade_fc
            // 
            this.tb_cidade_fc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_cidade_fc.Location = new System.Drawing.Point(124, 238);
            this.tb_cidade_fc.Name = "tb_cidade_fc";
            this.tb_cidade_fc.Size = new System.Drawing.Size(226, 20);
            this.tb_cidade_fc.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cidade";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Celular(opcional)";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefone (fixo)";
            // 
            // tb_complemento_fc
            // 
            this.tb_complemento_fc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_complemento_fc.Location = new System.Drawing.Point(216, 199);
            this.tb_complemento_fc.Name = "tb_complemento_fc";
            this.tb_complemento_fc.Size = new System.Drawing.Size(134, 20);
            this.tb_complemento_fc.TabIndex = 9;
            // 
            // tb_numero_fc
            // 
            this.tb_numero_fc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_numero_fc.Location = new System.Drawing.Point(124, 199);
            this.tb_numero_fc.Name = "tb_numero_fc";
            this.tb_numero_fc.Size = new System.Drawing.Size(86, 20);
            this.tb_numero_fc.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Complemento (opcional)";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Número";
            // 
            // tb_endereco_fc
            // 
            this.tb_endereco_fc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_endereco_fc.Location = new System.Drawing.Point(124, 160);
            this.tb_endereco_fc.Name = "tb_endereco_fc";
            this.tb_endereco_fc.Size = new System.Drawing.Size(226, 20);
            this.tb_endereco_fc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // tblservicoBindingSource
            // 
            this.tblservicoBindingSource.DataMember = "tbl_servico";
            this.tblservicoBindingSource.DataSource = this.bd_agendaDataSet12;
            // 
            // bd_agendaDataSet12
            // 
            this.bd_agendaDataSet12.DataSetName = "bd_agendaDataSet12";
            this.bd_agendaDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblfuncionariosBindingSource
            // 
            this.tblfuncionariosBindingSource.DataMember = "tbl_funcionarios";
            this.tblfuncionariosBindingSource.DataSource = this.bd_agendaDataSet6;
            // 
            // bd_agendaDataSet6
            // 
            this.bd_agendaDataSet6.DataSetName = "bd_agendaDataSet6";
            this.bd_agendaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_funcionariosTableAdapter
            // 
            this.tbl_funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_servicoTableAdapter
            // 
            this.tbl_servicoTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_funcionariosTableAdapter1
            // 
            this.tbl_funcionariosTableAdapter1.ClearBeforeFill = true;
            // 
            // Editar_sv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 453);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(618, 491);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(618, 491);
            this.Name = "Editar_sv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<- Cronos agenda -> Editar funcionário";
            this.Load += new System.EventHandler(this.Editar_sv_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblfuncionariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_agendaDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblservicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_agendaDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfuncionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_agendaDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox m_tb_celular_fc;
        private System.Windows.Forms.MaskedTextBox m_tb_telefone_fc;
        private System.Windows.Forms.MaskedTextBox m_tb_cpf_fc;
        private System.Windows.Forms.DateTimePicker dt_dataNascimento_fc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_cidade_fc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_complemento_fc;
        private System.Windows.Forms.TextBox tb_numero_fc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_endereco_fc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private bd_agendaDataSet6 bd_agendaDataSet6;
        private System.Windows.Forms.BindingSource tblfuncionariosBindingSource;
        private bd_agendaDataSet6TableAdapters.tbl_funcionariosTableAdapter tbl_funcionariosTableAdapter;
        private System.Windows.Forms.ComboBox cb_cd_fc;
        private System.Windows.Forms.TextBox cb_nome_fc;
        private System.Windows.Forms.Label label10;
        private bd_agendaDataSet12 bd_agendaDataSet12;
        private System.Windows.Forms.BindingSource tblservicoBindingSource;
        private bd_agendaDataSet12TableAdapters.tbl_servicoTableAdapter tbl_servicoTableAdapter;
        private bd_agendaDataSet15 bd_agendaDataSet15;
        private System.Windows.Forms.BindingSource tblfuncionariosBindingSource1;
        private bd_agendaDataSet15TableAdapters.tbl_funcionariosTableAdapter tbl_funcionariosTableAdapter1;
        private System.Windows.Forms.Button button4;
    }
}