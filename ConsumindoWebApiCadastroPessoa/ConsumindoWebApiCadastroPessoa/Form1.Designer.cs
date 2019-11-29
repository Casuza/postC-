namespace ConsumindoWebApiCadastroPessoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtURI = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnObterPessoa = new System.Windows.Forms.Button();
            this.btnPessoaPorCate = new System.Windows.Forms.Button();
            this.btnIncluirPessoa = new System.Windows.Forms.Button();
            this.btnAtualizaPessoa = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL DE ACESSO AO  SISTEMA";
            // 
            // txtURI
            // 
            this.txtURI.Location = new System.Drawing.Point(218, 17);
            this.txtURI.Multiline = true;
            this.txtURI.Name = "txtURI";
            this.txtURI.Size = new System.Drawing.Size(555, 25);
            this.txtURI.TabIndex = 1;
            this.txtURI.Text = "https://localhost:44360/api/pessoas";
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.Color.White;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.GridColor = System.Drawing.Color.Black;
            this.dgvDados.Location = new System.Drawing.Point(218, 82);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(555, 296);
            this.dgvDados.TabIndex = 2;
            // 
            // btnObterPessoa
            // 
            this.btnObterPessoa.ForeColor = System.Drawing.Color.Green;
            this.btnObterPessoa.Location = new System.Drawing.Point(43, 82);
            this.btnObterPessoa.Name = "btnObterPessoa";
            this.btnObterPessoa.Size = new System.Drawing.Size(145, 23);
            this.btnObterPessoa.TabIndex = 3;
            this.btnObterPessoa.Text = "LISTAR  PESSOAS";
            this.btnObterPessoa.UseVisualStyleBackColor = true;
            this.btnObterPessoa.Click += new System.EventHandler(this.BtnObterPessoa_Click);
            // 
            // btnPessoaPorCate
            // 
            this.btnPessoaPorCate.ForeColor = System.Drawing.Color.Green;
            this.btnPessoaPorCate.Location = new System.Drawing.Point(43, 146);
            this.btnPessoaPorCate.Name = "btnPessoaPorCate";
            this.btnPessoaPorCate.Size = new System.Drawing.Size(145, 23);
            this.btnPessoaPorCate.TabIndex = 4;
            this.btnPessoaPorCate.Text = "LISTAR POR CATEGORIA";
            this.btnPessoaPorCate.UseVisualStyleBackColor = true;
            this.btnPessoaPorCate.Click += new System.EventHandler(this.BtnPessoaPorCate_Click);
            // 
            // btnIncluirPessoa
            // 
            this.btnIncluirPessoa.ForeColor = System.Drawing.Color.Green;
            this.btnIncluirPessoa.Location = new System.Drawing.Point(43, 211);
            this.btnIncluirPessoa.Name = "btnIncluirPessoa";
            this.btnIncluirPessoa.Size = new System.Drawing.Size(145, 23);
            this.btnIncluirPessoa.TabIndex = 5;
            this.btnIncluirPessoa.Text = "INSERIR PESSOA";
            this.btnIncluirPessoa.UseVisualStyleBackColor = true;
            this.btnIncluirPessoa.Click += new System.EventHandler(this.BtnIncluirPessoa_Click);
            // 
            // btnAtualizaPessoa
            // 
            this.btnAtualizaPessoa.ForeColor = System.Drawing.Color.Green;
            this.btnAtualizaPessoa.Location = new System.Drawing.Point(43, 275);
            this.btnAtualizaPessoa.Name = "btnAtualizaPessoa";
            this.btnAtualizaPessoa.Size = new System.Drawing.Size(145, 23);
            this.btnAtualizaPessoa.TabIndex = 6;
            this.btnAtualizaPessoa.Text = "ATUALIZAR PESSOA";
            this.btnAtualizaPessoa.UseVisualStyleBackColor = true;
            this.btnAtualizaPessoa.Click += new System.EventHandler(this.BtnAtualizaPessoa_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Green;
            this.button5.Location = new System.Drawing.Point(43, 334);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "DELETAR PESSOA";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnAtualizaPessoa);
            this.Controls.Add(this.btnIncluirPessoa);
            this.Controls.Add(this.btnPessoaPorCate);
            this.Controls.Add(this.btnObterPessoa);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.txtURI);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Cadastro de Pessoa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnObterPessoa;
        private System.Windows.Forms.Button btnPessoaPorCate;
        private System.Windows.Forms.Button btnIncluirPessoa;
        private System.Windows.Forms.Button btnAtualizaPessoa;
        private System.Windows.Forms.Button button5;
    }
}

