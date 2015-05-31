namespace Agenda
{
    partial class Editar_ns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_ns));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tb_valor_medio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.cb_nome_sv = new System.Windows.Forms.TextBox();
            this.cb_cd_sv = new System.Windows.Forms.ComboBox();
            this.tblservicoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bd_agendaDataSet13 = new Agenda.bd_agendaDataSet13();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_descricao_ens = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblservicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_agendaDataSet7 = new Agenda.bd_agendaDataSet7();
            this.tbl_servicoTableAdapter = new Agenda.bd_agendaDataSet7TableAdapters.tbl_servicoTableAdapter();
            this.tbl_servicoTableAdapter1 = new Agenda.bd_agendaDataSet13TableAdapters.tbl_servicoTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblservicoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_agendaDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblservicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_agendaDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Location = new System.Drawing.Point(293, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(241, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(114, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.tb_valor_medio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.cb_nome_sv);
            this.groupBox1.Controls.Add(this.cb_cd_sv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rtb_descricao_ens);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(76, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 327);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar serviço";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(264, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Ver serviços";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tb_valor_medio
            // 
            this.tb_valor_medio.Location = new System.Drawing.Point(114, 121);
            this.tb_valor_medio.Name = "tb_valor_medio";
            this.tb_valor_medio.Size = new System.Drawing.Size(226, 20);
            this.tb_valor_medio.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Valor medio";
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.Location = new System.Drawing.Point(181, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Deletar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cb_nome_sv
            // 
            this.cb_nome_sv.Location = new System.Drawing.Point(114, 82);
            this.cb_nome_sv.Name = "cb_nome_sv";
            this.cb_nome_sv.Size = new System.Drawing.Size(226, 20);
            this.cb_nome_sv.TabIndex = 10;
            this.cb_nome_sv.TextChanged += new System.EventHandler(this.cb_nome_sv_TextChanged);
            // 
            // cb_cd_sv
            // 
            this.cb_cd_sv.DataSource = this.tblservicoBindingSource1;
            this.cb_cd_sv.DisplayMember = "cod_servico";
            this.cb_cd_sv.FormattingEnabled = true;
            this.cb_cd_sv.Location = new System.Drawing.Point(114, 42);
            this.cb_cd_sv.Name = "cb_cd_sv";
            this.cb_cd_sv.Size = new System.Drawing.Size(144, 21);
            this.cb_cd_sv.TabIndex = 9;
            this.cb_cd_sv.ValueMember = "cod_servico";
            this.cb_cd_sv.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tblservicoBindingSource1
            // 
            this.tblservicoBindingSource1.DataMember = "tbl_servico";
            this.tblservicoBindingSource1.DataSource = this.bd_agendaDataSet13;
            // 
            // bd_agendaDataSet13
            // 
            this.bd_agendaDataSet13.DataSetName = "bd_agendaDataSet13";
            this.bd_agendaDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Codigo serviço";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição";
            // 
            // rtb_descricao_ens
            // 
            this.rtb_descricao_ens.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtb_descricao_ens.Location = new System.Drawing.Point(113, 160);
            this.rtb_descricao_ens.Name = "rtb_descricao_ens";
            this.rtb_descricao_ens.Size = new System.Drawing.Size(226, 112);
            this.rtb_descricao_ens.TabIndex = 2;
            this.rtb_descricao_ens.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do serviço";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tblservicoBindingSource
            // 
            this.tblservicoBindingSource.DataMember = "tbl_servico";
            this.tblservicoBindingSource.DataSource = this.bd_agendaDataSet7;
            // 
            // bd_agendaDataSet7
            // 
            this.bd_agendaDataSet7.DataSetName = "bd_agendaDataSet7";
            this.bd_agendaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_servicoTableAdapter
            // 
            this.tbl_servicoTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_servicoTableAdapter1
            // 
            this.tbl_servicoTableAdapter1.ClearBeforeFill = true;
            // 
            // Editar_ns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 383);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(618, 421);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(618, 421);
            this.Name = "Editar_ns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<- Cronos agenda -> Editar serviço";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editar_ns_FormClosing);
            this.Load += new System.EventHandler(this.Editar_ns_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblservicoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_agendaDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblservicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_agendaDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtb_descricao_ens;
        private System.Windows.Forms.Label label1;
        private bd_agendaDataSet7 bd_agendaDataSet7;
        private System.Windows.Forms.BindingSource tblservicoBindingSource;
        private bd_agendaDataSet7TableAdapters.tbl_servicoTableAdapter tbl_servicoTableAdapter;
        private System.Windows.Forms.TextBox cb_nome_sv;
        private System.Windows.Forms.ComboBox cb_cd_sv;
        private System.Windows.Forms.Label label3;
        private bd_agendaDataSet13 bd_agendaDataSet13;
        private System.Windows.Forms.BindingSource tblservicoBindingSource1;
        private bd_agendaDataSet13TableAdapters.tbl_servicoTableAdapter tbl_servicoTableAdapter1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb_valor_medio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
    }
}