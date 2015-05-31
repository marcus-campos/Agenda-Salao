namespace Agenda
{
    partial class Cadastro_de_usuário
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_de_usuário));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_senha_nu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_usuario_nu = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_funcionario = new System.Windows.Forms.RadioButton();
            this.rb_adm = new System.Windows.Forms.RadioButton();
            this.rb_secretario = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tb_senha_nu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_usuario_nu);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo usuário";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(197, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_senha_nu
            // 
            this.tb_senha_nu.Location = new System.Drawing.Point(72, 71);
            this.tb_senha_nu.Name = "tb_senha_nu";
            this.tb_senha_nu.PasswordChar = '*';
            this.tb_senha_nu.Size = new System.Drawing.Size(154, 20);
            this.tb_senha_nu.TabIndex = 3;
            this.tb_senha_nu.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // tb_usuario_nu
            // 
            this.tb_usuario_nu.Location = new System.Drawing.Point(72, 32);
            this.tb_usuario_nu.Name = "tb_usuario_nu";
            this.tb_usuario_nu.Size = new System.Drawing.Size(154, 20);
            this.tb_usuario_nu.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_funcionario);
            this.groupBox2.Controls.Add(this.rb_adm);
            this.groupBox2.Controls.Add(this.rb_secretario);
            this.groupBox2.Location = new System.Drawing.Point(72, 97);
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
            this.rb_funcionario.CheckedChanged += new System.EventHandler(this.rb_funcionario_CheckedChanged);
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
            this.rb_adm.CheckedChanged += new System.EventHandler(this.rb_adm_CheckedChanged);
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
            this.rb_secretario.CheckedChanged += new System.EventHandler(this.rb_secretario_CheckedChanged);
            // 
            // Cadastro_de_usuário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 263);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(335, 301);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(335, 301);
            this.Name = "Cadastro_de_usuário";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<- Cronos agenda -> Cadastro de usuário";
            this.Load += new System.EventHandler(this.Cadastro_de_usuário_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_senha_nu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_usuario_nu;
        private System.Windows.Forms.RadioButton rb_funcionario;
        private System.Windows.Forms.RadioButton rb_secretario;
        private System.Windows.Forms.RadioButton rb_adm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
    }
}