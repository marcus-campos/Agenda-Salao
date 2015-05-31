namespace Agenda
{
    partial class telaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ag_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUmAgendamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sv_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verServiçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fc_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_valor_caixa = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dg_agenda = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.t_lb_nome = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.t_lb_nvadm = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.t_lb_versao = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.t_lb_inicioS = new System.Windows.Forms.ToolStripLabel();
            this.bd_agendaDataSet14 = new Agenda.bd_agendaDataSet14();
            this.ag_lb = new System.Windows.Forms.ToolStripLabel();
            this.ag_novo = new System.Windows.Forms.ToolStripButton();
            this.ag_editar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sv_lb = new System.Windows.Forms.ToolStripLabel();
            this.sv_novo = new System.Windows.Forms.ToolStripButton();
            this.sv_editar = new System.Windows.Forms.ToolStripButton();
            this.sv_ver_servicos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.fc_lb = new System.Windows.Forms.ToolStripLabel();
            this.fc_nome = new System.Windows.Forms.ToolStripButton();
            this.fc_editar = new System.Windows.Forms.ToolStripButton();
            this.fc_ver_funcionarios = new System.Windows.Forms.ToolStripButton();
            this.fc_ver_usu = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_agenda)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bd_agendaDataSet14)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ag_menu,
            this.sv_menu,
            this.fc_menu,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ag_menu
            // 
            this.ag_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarToolStripMenuItem,
            this.editarUmAgendamentoToolStripMenuItem});
            this.ag_menu.Name = "ag_menu";
            this.ag_menu.Size = new System.Drawing.Size(60, 20);
            this.ag_menu.Text = "&Agenda";
            // 
            // agendarToolStripMenuItem
            // 
            this.agendarToolStripMenuItem.Name = "agendarToolStripMenuItem";
            this.agendarToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.agendarToolStripMenuItem.Text = "&Novo";
            this.agendarToolStripMenuItem.Click += new System.EventHandler(this.agendarToolStripMenuItem_Click);
            // 
            // editarUmAgendamentoToolStripMenuItem
            // 
            this.editarUmAgendamentoToolStripMenuItem.Name = "editarUmAgendamentoToolStripMenuItem";
            this.editarUmAgendamentoToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.editarUmAgendamentoToolStripMenuItem.Text = "&Editar";
            this.editarUmAgendamentoToolStripMenuItem.Click += new System.EventHandler(this.editarUmAgendamentoToolStripMenuItem_Click);
            // 
            // sv_menu
            // 
            this.sv_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.verServiçosToolStripMenuItem});
            this.sv_menu.Name = "sv_menu";
            this.sv_menu.Size = new System.Drawing.Size(62, 20);
            this.sv_menu.Text = "&Serviços";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.novoToolStripMenuItem.Text = "&Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.editarToolStripMenuItem.Text = "&Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // verServiçosToolStripMenuItem
            // 
            this.verServiçosToolStripMenuItem.Name = "verServiçosToolStripMenuItem";
            this.verServiçosToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.verServiçosToolStripMenuItem.Text = "&Ver serviços";
            this.verServiçosToolStripMenuItem.Click += new System.EventHandler(this.verServiçosToolStripMenuItem_Click);
            // 
            // fc_menu
            // 
            this.fc_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem1,
            this.editarToolStripMenuItem1,
            this.verFuncionáriosToolStripMenuItem,
            this.verUsuáriosToolStripMenuItem});
            this.fc_menu.Name = "fc_menu";
            this.fc_menu.Size = new System.Drawing.Size(87, 20);
            this.fc_menu.Text = "&Funcionarios";
            // 
            // novoToolStripMenuItem1
            // 
            this.novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            this.novoToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.novoToolStripMenuItem1.Text = "&Novo";
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.editarToolStripMenuItem1.Text = "&Editar";
            this.editarToolStripMenuItem1.Click += new System.EventHandler(this.editarToolStripMenuItem1_Click);
            // 
            // verFuncionáriosToolStripMenuItem
            // 
            this.verFuncionáriosToolStripMenuItem.Name = "verFuncionáriosToolStripMenuItem";
            this.verFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.verFuncionáriosToolStripMenuItem.Text = "&Ver funcionários";
            this.verFuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.verFuncionáriosToolStripMenuItem_Click);
            // 
            // verUsuáriosToolStripMenuItem
            // 
            this.verUsuáriosToolStripMenuItem.Name = "verUsuáriosToolStripMenuItem";
            this.verUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.verUsuáriosToolStripMenuItem.Text = "Ve&r usuários";
            this.verUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.verUsuáriosToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.creditosToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "A&juda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.manualToolStripMenuItem.Text = "&Manual";
            // 
            // creditosToolStripMenuItem
            // 
            this.creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            this.creditosToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.creditosToolStripMenuItem.Text = "&Creditos";
            this.creditosToolStripMenuItem.Click += new System.EventHandler(this.creditosToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(859, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Deslogar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mostrar a partir do dia";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lb_valor_caixa);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dg_agenda);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 417);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agenda";
            // 
            // lb_valor_caixa
            // 
            this.lb_valor_caixa.AutoSize = true;
            this.lb_valor_caixa.Location = new System.Drawing.Point(88, 41);
            this.lb_valor_caixa.Name = "lb_valor_caixa";
            this.lb_valor_caixa.Size = new System.Drawing.Size(0, 13);
            this.lb_valor_caixa.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Location = new System.Drawing.Point(675, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(362, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dg_agenda
            // 
            this.dg_agenda.AllowUserToAddRows = false;
            this.dg_agenda.AllowUserToDeleteRows = false;
            this.dg_agenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_agenda.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_agenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_agenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dg_agenda.Location = new System.Drawing.Point(6, 63);
            this.dg_agenda.Name = "dg_agenda";
            this.dg_agenda.ReadOnly = true;
            this.dg_agenda.Size = new System.Drawing.Size(910, 348);
            this.dg_agenda.TabIndex = 7;
            this.dg_agenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_agenda_CellContentClick);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(594, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 6;
            this.button2.Text = "Mostrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.t_lb_nome,
            this.toolStripSeparator1,
            this.toolStripLabel6,
            this.t_lb_nvadm,
            this.toolStripSeparator4,
            this.toolStripLabel5,
            this.t_lb_versao,
            this.toolStripSeparator5,
            this.toolStripLabel1,
            this.t_lb_inicioS});
            this.toolStrip2.Location = new System.Drawing.Point(0, 501);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(946, 25);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel2.Text = "Nome:";
            // 
            // t_lb_nome
            // 
            this.t_lb_nome.Name = "t_lb_nome";
            this.t_lb_nome.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(89, 22);
            this.toolStripLabel6.Text = "Tipo de usuario";
            // 
            // t_lb_nvadm
            // 
            this.t_lb_nvadm.Name = "t_lb_nvadm";
            this.t_lb_nvadm.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel5.Text = "Versão:";
            // 
            // t_lb_versao
            // 
            this.t_lb_versao.Name = "t_lb_versao";
            this.t_lb_versao.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(73, 22);
            this.toolStripLabel1.Text = "Inicio sessão";
            // 
            // t_lb_inicioS
            // 
            this.t_lb_inicioS.Name = "t_lb_inicioS";
            this.t_lb_inicioS.Size = new System.Drawing.Size(0, 22);
            // 
            // bd_agendaDataSet14
            // 
            this.bd_agendaDataSet14.DataSetName = "bd_agendaDataSet14";
            this.bd_agendaDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ag_lb
            // 
            this.ag_lb.Name = "ag_lb";
            this.ag_lb.Size = new System.Drawing.Size(48, 22);
            this.ag_lb.Text = "Agenda";
            // 
            // ag_novo
            // 
            this.ag_novo.Image = ((System.Drawing.Image)(resources.GetObject("ag_novo.Image")));
            this.ag_novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ag_novo.Name = "ag_novo";
            this.ag_novo.Size = new System.Drawing.Size(56, 22);
            this.ag_novo.Text = "&Novo";
            this.ag_novo.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // ag_editar
            // 
            this.ag_editar.Image = ((System.Drawing.Image)(resources.GetObject("ag_editar.Image")));
            this.ag_editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ag_editar.Name = "ag_editar";
            this.ag_editar.Size = new System.Drawing.Size(57, 22);
            this.ag_editar.Text = "&Editar";
            this.ag_editar.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // sv_lb
            // 
            this.sv_lb.Name = "sv_lb";
            this.sv_lb.Size = new System.Drawing.Size(50, 22);
            this.sv_lb.Text = "Serviços";
            // 
            // sv_novo
            // 
            this.sv_novo.Image = ((System.Drawing.Image)(resources.GetObject("sv_novo.Image")));
            this.sv_novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sv_novo.Name = "sv_novo";
            this.sv_novo.Size = new System.Drawing.Size(56, 22);
            this.sv_novo.Text = "N&ovo";
            this.sv_novo.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // sv_editar
            // 
            this.sv_editar.Image = ((System.Drawing.Image)(resources.GetObject("sv_editar.Image")));
            this.sv_editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sv_editar.Name = "sv_editar";
            this.sv_editar.Size = new System.Drawing.Size(57, 22);
            this.sv_editar.Text = "E&ditar";
            this.sv_editar.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // sv_ver_servicos
            // 
            this.sv_ver_servicos.Image = ((System.Drawing.Image)(resources.GetObject("sv_ver_servicos.Image")));
            this.sv_ver_servicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sv_ver_servicos.Name = "sv_ver_servicos";
            this.sv_ver_servicos.Size = new System.Drawing.Size(89, 22);
            this.sv_ver_servicos.Text = "&Ver serviços";
            this.sv_ver_servicos.Click += new System.EventHandler(this.sv_ver_servicos_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // fc_lb
            // 
            this.fc_lb.Name = "fc_lb";
            this.fc_lb.Size = new System.Drawing.Size(75, 22);
            this.fc_lb.Text = "Funcionarios";
            // 
            // fc_nome
            // 
            this.fc_nome.Image = ((System.Drawing.Image)(resources.GetObject("fc_nome.Image")));
            this.fc_nome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fc_nome.Name = "fc_nome";
            this.fc_nome.Size = new System.Drawing.Size(56, 22);
            this.fc_nome.Text = "No&vo";
            this.fc_nome.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // fc_editar
            // 
            this.fc_editar.Image = ((System.Drawing.Image)(resources.GetObject("fc_editar.Image")));
            this.fc_editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fc_editar.Name = "fc_editar";
            this.fc_editar.Size = new System.Drawing.Size(57, 22);
            this.fc_editar.Text = "Ed&itar";
            this.fc_editar.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // fc_ver_funcionarios
            // 
            this.fc_ver_funcionarios.Image = ((System.Drawing.Image)(resources.GetObject("fc_ver_funcionarios.Image")));
            this.fc_ver_funcionarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fc_ver_funcionarios.Name = "fc_ver_funcionarios";
            this.fc_ver_funcionarios.Size = new System.Drawing.Size(113, 22);
            this.fc_ver_funcionarios.Text = "Ve&r funcionários";
            this.fc_ver_funcionarios.Click += new System.EventHandler(this.fc_ver_funcionarios_Click);
            // 
            // fc_ver_usu
            // 
            this.fc_ver_usu.Image = ((System.Drawing.Image)(resources.GetObject("fc_ver_usu.Image")));
            this.fc_ver_usu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fc_ver_usu.Name = "fc_ver_usu";
            this.fc_ver_usu.Size = new System.Drawing.Size(91, 22);
            this.fc_ver_usu.Text = "Ver &usuários";
            this.fc_ver_usu.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ag_lb,
            this.ag_novo,
            this.ag_editar,
            this.toolStripSeparator2,
            this.sv_lb,
            this.sv_novo,
            this.sv_editar,
            this.sv_ver_servicos,
            this.toolStripSeparator3,
            this.fc_lb,
            this.fc_nome,
            this.fc_editar,
            this.fc_ver_funcionarios,
            this.fc_ver_usu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(946, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "Menu";
            // 
            // telaPrincipal
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 526);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "telaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<- Cronos agenda -> Tela principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.telaPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.telaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_agenda)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bd_agendaDataSet14)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ag_menu;
        private System.Windows.Forms.ToolStripMenuItem agendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarUmAgendamentoToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem sv_menu;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        public System.Windows.Forms.ToolStripLabel t_lb_nome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dg_agenda;
        private System.Windows.Forms.ToolStripMenuItem fc_menu;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripLabel t_lb_nvadm;
        private System.Windows.Forms.ToolStripLabel t_lb_versao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel t_lb_inicioS;
        private System.Windows.Forms.Button button3;
        private bd_agendaDataSet14 bd_agendaDataSet14;
        private System.Windows.Forms.ToolStripMenuItem verServiçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel ag_lb;
        private System.Windows.Forms.ToolStripButton ag_novo;
        private System.Windows.Forms.ToolStripButton ag_editar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel sv_lb;
        private System.Windows.Forms.ToolStripButton sv_novo;
        private System.Windows.Forms.ToolStripButton sv_editar;
        private System.Windows.Forms.ToolStripButton sv_ver_servicos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel fc_lb;
        private System.Windows.Forms.ToolStripButton fc_nome;
        private System.Windows.Forms.ToolStripButton fc_editar;
        private System.Windows.Forms.ToolStripButton fc_ver_funcionarios;
        private System.Windows.Forms.ToolStripButton fc_ver_usu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label lb_valor_caixa;
    }
}