
namespace SistemaDeCadastro
{
    partial class Cadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Box1 = new System.Windows.Forms.TextBox();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.status1 = new System.Windows.Forms.ComboBox();
            this.Phone1 = new System.Windows.Forms.MaskedTextBox();
            this.veiculo1 = new System.Windows.Forms.CheckBox();
            this.casa1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OutroSexo = new System.Windows.Forms.RadioButton();
            this.Feminino = new System.Windows.Forms.RadioButton();
            this.Masculino = new System.Windows.Forms.RadioButton();
            this.listaDeCadastros = new System.Windows.Forms.ListBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado Civil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone";
            // 
            // Box1
            // 
            this.Box1.Location = new System.Drawing.Point(152, 5);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(441, 20);
            this.Box1.TabIndex = 4;
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(152, 47);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(234, 20);
            this.date1.TabIndex = 5;
            // 
            // status1
            // 
            this.status1.FormattingEnabled = true;
            this.status1.Location = new System.Drawing.Point(152, 97);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(234, 21);
            this.status1.TabIndex = 6;
            // 
            // Phone1
            // 
            this.Phone1.Location = new System.Drawing.Point(152, 139);
            this.Phone1.Mask = "(00)00000-0000";
            this.Phone1.Name = "Phone1";
            this.Phone1.Size = new System.Drawing.Size(234, 20);
            this.Phone1.TabIndex = 7;
            // 
            // veiculo1
            // 
            this.veiculo1.AutoSize = true;
            this.veiculo1.Location = new System.Drawing.Point(152, 177);
            this.veiculo1.Name = "veiculo1";
            this.veiculo1.Size = new System.Drawing.Size(102, 17);
            this.veiculo1.TabIndex = 8;
            this.veiculo1.Text = "Possui veículo?";
            this.veiculo1.UseVisualStyleBackColor = true;
            // 
            // casa1
            // 
            this.casa1.AutoSize = true;
            this.casa1.Location = new System.Drawing.Point(152, 200);
            this.casa1.Name = "casa1";
            this.casa1.Size = new System.Drawing.Size(92, 17);
            this.casa1.TabIndex = 9;
            this.casa1.Text = "Casa Própria?";
            this.casa1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OutroSexo);
            this.groupBox1.Controls.Add(this.Feminino);
            this.groupBox1.Controls.Add(this.Masculino);
            this.groupBox1.Location = new System.Drawing.Point(152, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 93);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // OutroSexo
            // 
            this.OutroSexo.AutoSize = true;
            this.OutroSexo.Location = new System.Drawing.Point(7, 66);
            this.OutroSexo.Name = "OutroSexo";
            this.OutroSexo.Size = new System.Drawing.Size(51, 17);
            this.OutroSexo.TabIndex = 2;
            this.OutroSexo.TabStop = true;
            this.OutroSexo.Text = "Outro";
            this.OutroSexo.UseVisualStyleBackColor = true;
            // 
            // Feminino
            // 
            this.Feminino.AutoSize = true;
            this.Feminino.Location = new System.Drawing.Point(7, 43);
            this.Feminino.Name = "Feminino";
            this.Feminino.Size = new System.Drawing.Size(67, 17);
            this.Feminino.TabIndex = 1;
            this.Feminino.TabStop = true;
            this.Feminino.Text = "Feminino";
            this.Feminino.UseVisualStyleBackColor = true;
            // 
            // Masculino
            // 
            this.Masculino.AutoSize = true;
            this.Masculino.Checked = true;
            this.Masculino.Location = new System.Drawing.Point(7, 20);
            this.Masculino.Name = "Masculino";
            this.Masculino.Size = new System.Drawing.Size(73, 17);
            this.Masculino.TabIndex = 0;
            this.Masculino.TabStop = true;
            this.Masculino.Text = "Masculino";
            this.Masculino.UseVisualStyleBackColor = true;
            // 
            // listaDeCadastros
            // 
            this.listaDeCadastros.FormattingEnabled = true;
            this.listaDeCadastros.Location = new System.Drawing.Point(12, 395);
            this.listaDeCadastros.Name = "listaDeCadastros";
            this.listaDeCadastros.Size = new System.Drawing.Size(608, 82);
            this.listaDeCadastros.TabIndex = 11;
            this.listaDeCadastros.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listaDeCadastros_MouseDoubleClick);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(12, 341);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(137, 33);
            this.btncadastrar.TabIndex = 12;
            this.btncadastrar.Text = "Cadastrar / Alterar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(247, 341);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(137, 33);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(482, 341);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(137, 33);
            this.btnlimpar.TabIndex = 14;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 489);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.casa1);
            this.Controls.Add(this.veiculo1);
            this.Controls.Add(this.Phone1);
            this.Controls.Add(this.status1);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaDeCadastros);
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Box1;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.ComboBox status1;
        private System.Windows.Forms.MaskedTextBox Phone1;
        private System.Windows.Forms.CheckBox veiculo1;
        private System.Windows.Forms.CheckBox casa1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OutroSexo;
        private System.Windows.Forms.RadioButton Feminino;
        private System.Windows.Forms.RadioButton Masculino;
        private System.Windows.Forms.ListBox listaDeCadastros;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnlimpar;
    }
}

