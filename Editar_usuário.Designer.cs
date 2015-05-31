namespace Agenda
{
    partial class Editar_usuário
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_usuário));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_id = new System.Windows.Forms.ComboBox();
            this.tblaccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_agendaDataSet19 = new Agenda.bd_agendaDataSet19();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_senha_eu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_usuario_eu = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_funcionario = new System.Windows.Forms.RadioButton();
            this.rb_adm = new System.Windows.Forms.RadioButton();
            this.rb_secretario = new System.Windows.Forms.RadioButton();
            this.tbl_accountTableAdapter = new Agenda.bd_agendaDataSet19TableAdapters.tbl_accountTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblaccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_agendaDataSet19)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_nome);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_id);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tb_senha_eu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_usuario_eu);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 312);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo usuário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(88, 79);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(154, 20);
            this.tb_nome.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(86, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Deletar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID do usuário";
            // 
            // cb_id
            // 
            this.cb_id.DataSource = this.tblaccountBindingSource;
            this.cb_id.DisplayMember = "id";
            this.cb_id.FormattingEnabled = true;
            this.cb_id.Location = new System.Drawing.Point(88, 39);
            this.cb_id.Name = "cb_id";
            this.cb_id.Size = new System.Drawing.Size(154, 21);
            this.cb_id.TabIndex = 11;
            this.cb_id.ValueMember = "id";
            this.cb_id.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tblaccountBindingSource
            // 
            this.tblaccountBindingSource.DataMember = "tbl_account";
            this.tblaccountBindingSource.DataSource = this.bd_agendaDataSet19;
            // 
            // bd_agendaDataSet19
            // 
            this.bd_agendaDataSet19.DataSetName = "bd_agendaDataSet19";
            this.bd_agendaDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_senha_eu
            // 
            this.tb_senha_eu.Location = new System.Drawing.Point(88, 157);
            this.tb_senha_eu.Name = "tb_senha_eu";
            this.tb_senha_eu.Size = new System.Drawing.Size(154, 20);
            this.tb_senha_eu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // tb_usuario_eu
            // 
            this.tb_usuario_eu.Location = new System.Drawing.Point(88, 118);
            this.tb_usuario_eu.Name = "tb_usuario_eu";
            this.tb_usuario_eu.Size = new System.Drawing.Size(154, 20);
            this.tb_usuario_eu.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_funcionario);
            this.groupBox2.Controls.Add(this.rb_adm);
            this.groupBox2.Controls.Add(this.rb_secretario);
            this.groupBox2.Location = new System.Drawing.Point(88, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 94);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de usuário";
            // 
            // rb_funcionario
            // 
            this.rb_funcionario.AutoSize = true;
            this.rb_funcionario.Location = new System.Drawing.Point(31, 65);
            this.rb_funcionario.Name = "rb_funcionario";
            this.rb_funcionario.Size = new System.Drawing.Size(92, 17);
            this.rb_funcionario.TabIndex = 8;
            this.rb_funcionario.Text = "Funcionário(a)";
            this.rb_funcionario.UseVisualStyleBackColor = true;
            // 
            // rb_adm
            // 
            this.rb_adm.AutoSize = true;
            this.rb_adm.Location = new System.Drawing.Point(31, 19);
            this.rb_adm.Name = "rb_adm";
            this.rb_adm.Size = new System.Drawing.Size(88, 17);
            this.rb_adm.TabIndex = 6;
            this.rb_adm.Text = "Administrador";
            this.rb_adm.UseVisualStyleBackColor = true;
            // 
            // rb_secretario
            // 
            this.rb_secretario.AutoSize = true;
            this.rb_secretario.Location = new System.Drawing.Point(31, 42);
            this.rb_secretario.Name = "rb_secretario";
            this.rb_secretario.Size = new System.Drawing.Size(85, 17);
            this.rb_secretario.TabIndex = 7;
            this.rb_secretario.Text = "Secretário(a)";
            this.rb_secretario.UseVisualStyleBackColor = true;
            // 
            // tbl_accountTableAdapter
            // 
            this.tbl_accountTableAdapter.ClearBeforeFill = true;
            // 
            // Editar_usuário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 336);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(371, 374);
            this.MinimumSize = new System.Drawing.Size(371, 374);
            this.Name = "Editar_usuário";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<- Cronos agenda -> Editar usuário";
            this.Load += new System.EventHandler(this.Editar_usuário_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblaccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_agendaDataSet19)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_senha_eu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_usuario_eu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_funcionario;
        private System.Windows.Forms.RadioButton rb_adm;
        private System.Windows.Forms.RadioButton rb_secretario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_id;
        private bd_agendaDataSet19 bd_agendaDataSet19;
        private System.Windows.Forms.BindingSource tblaccountBindingSource;
        private bd_agendaDataSet19TableAdapters.tbl_accountTableAdapter tbl_accountTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nome;
    }
}