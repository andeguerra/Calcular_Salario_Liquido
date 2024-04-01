namespace Calcular_Salario_Liquido
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_sliq = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_irrf = new System.Windows.Forms.TextBox();
            this.txt_inss = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_dep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_slb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exibirLista = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.irrf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outrosdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_busca = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_sliq);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_irrf);
            this.panel2.Controls.Add(this.txt_inss);
            this.panel2.Controls.Add(this.label7);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(26, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 82);
            this.panel2.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(414, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Salario Liquido";
            // 
            // txt_sliq
            // 
            this.txt_sliq.BackColor = System.Drawing.Color.LightGray;
            this.txt_sliq.Enabled = false;
            this.txt_sliq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sliq.ForeColor = System.Drawing.Color.White;
            this.txt_sliq.Location = new System.Drawing.Point(418, 40);
            this.txt_sliq.Name = "txt_sliq";
            this.txt_sliq.Size = new System.Drawing.Size(171, 31);
            this.txt_sliq.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(209, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "IRRF";
            // 
            // txt_irrf
            // 
            this.txt_irrf.BackColor = System.Drawing.Color.LightGray;
            this.txt_irrf.Enabled = false;
            this.txt_irrf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_irrf.ForeColor = System.Drawing.Color.White;
            this.txt_irrf.Location = new System.Drawing.Point(213, 40);
            this.txt_irrf.Name = "txt_irrf";
            this.txt_irrf.Size = new System.Drawing.Size(171, 31);
            this.txt_irrf.TabIndex = 9;
            // 
            // txt_inss
            // 
            this.txt_inss.BackColor = System.Drawing.Color.LightGray;
            this.txt_inss.Enabled = false;
            this.txt_inss.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inss.ForeColor = System.Drawing.Color.White;
            this.txt_inss.Location = new System.Drawing.Point(5, 40);
            this.txt_inss.Name = "txt_inss";
            this.txt_inss.Size = new System.Drawing.Size(171, 31);
            this.txt_inss.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "INSS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_nome);
            this.panel1.Controls.Add(this.txt_dep);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_desc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_slb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(26, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 140);
            this.panel1.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(7, 34);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(582, 31);
            this.txt_nome.TabIndex = 14;
            // 
            // txt_dep
            // 
            this.txt_dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dep.Location = new System.Drawing.Point(438, 103);
            this.txt_dep.Name = "txt_dep";
            this.txt_dep.Size = new System.Drawing.Size(64, 31);
            this.txt_dep.TabIndex = 12;
            this.txt_dep.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(434, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Núm dependentes";
            // 
            // txt_desc
            // 
            this.txt_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.Location = new System.Drawing.Point(213, 103);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(201, 31);
            this.txt_desc.TabIndex = 10;
            this.txt_desc.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(209, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descontos";
            // 
            // txt_slb
            // 
            this.txt_slb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_slb.Location = new System.Drawing.Point(7, 103);
            this.txt_slb.Name = "txt_slb";
            this.txt_slb.Size = new System.Drawing.Size(184, 31);
            this.txt_slb.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Salário bruto";
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(105)))), ((int)(((byte)(50)))));
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.ForeColor = System.Drawing.Color.White;
            this.btn_calcular.Location = new System.Drawing.Point(26, 296);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(137, 37);
            this.btn_calcular.TabIndex = 25;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Calculadora de Salário Líquido";
            // 
            // btn_exibirLista
            // 
            this.btn_exibirLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(105)))), ((int)(((byte)(50)))));
            this.btn_exibirLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exibirLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exibirLista.ForeColor = System.Drawing.Color.White;
            this.btn_exibirLista.Location = new System.Drawing.Point(176, 296);
            this.btn_exibirLista.Name = "btn_exibirLista";
            this.btn_exibirLista.Size = new System.Drawing.Size(137, 37);
            this.btn_exibirLista.TabIndex = 28;
            this.btn_exibirLista.Text = "Exibir Lista";
            this.btn_exibirLista.UseVisualStyleBackColor = false;
            this.btn_exibirLista.Click += new System.EventHandler(this.btn_exibirLista_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.inss,
            this.irrf,
            this.outrosdesc,
            this.dep,
            this.sll,
            this.slb});
            this.dgvLista.Location = new System.Drawing.Point(26, 390);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(599, 168);
            this.dgvLista.TabIndex = 29;
            this.dgvLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellClick);
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome Funcionário";
            this.nome.Name = "nome";
            // 
            // inss
            // 
            this.inss.HeaderText = "INSS";
            this.inss.Name = "inss";
            // 
            // irrf
            // 
            this.irrf.HeaderText = "IRRF";
            this.irrf.Name = "irrf";
            // 
            // outrosdesc
            // 
            this.outrosdesc.HeaderText = "Outros Descontos";
            this.outrosdesc.Name = "outrosdesc";
            // 
            // dep
            // 
            this.dep.HeaderText = "Dependentes";
            this.dep.Name = "dep";
            // 
            // sll
            // 
            this.sll.HeaderText = "Salário Líquido";
            this.sll.Name = "sll";
            // 
            // slb
            // 
            this.slb.HeaderText = "Salário Bruto";
            this.slb.Name = "slb";
            // 
            // btn_busca
            // 
            this.btn_busca.BackColor = System.Drawing.Color.Olive;
            this.btn_busca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busca.ForeColor = System.Drawing.Color.White;
            this.btn_busca.Location = new System.Drawing.Point(476, 347);
            this.btn_busca.Name = "btn_busca";
            this.btn_busca.Size = new System.Drawing.Size(149, 37);
            this.btn_busca.TabIndex = 30;
            this.btn_busca.Text = "Buscar";
            this.btn_busca.UseVisualStyleBackColor = false;
            this.btn_busca.Click += new System.EventHandler(this.btn_busca_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.Red;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.White;
            this.btn_limpar.Location = new System.Drawing.Point(326, 296);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(137, 37);
            this.btn_limpar.TabIndex = 31;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(26, 347);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(427, 20);
            this.txt_buscar.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(648, 586);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_busca);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.btn_exibirLista);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Sálario Liquido";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_sliq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_irrf;
        private System.Windows.Forms.TextBox txt_inss;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_dep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_slb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exibirLista;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn inss;
        private System.Windows.Forms.DataGridViewTextBoxColumn irrf;
        private System.Windows.Forms.DataGridViewTextBoxColumn outrosdesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dep;
        private System.Windows.Forms.DataGridViewTextBoxColumn sll;
        private System.Windows.Forms.DataGridViewTextBoxColumn slb;
        private System.Windows.Forms.Button btn_busca;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.TextBox txt_buscar;
    }
}

