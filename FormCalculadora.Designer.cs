namespace CalculadoraPosfixa
{
    partial class FormCalculadora
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
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnFechaParenteses = new System.Windows.Forms.Button();
            this.btnAbreParentese = new System.Windows.Forms.Button();
            this.lbSequencias = new System.Windows.Forms.Label();
            this.lbUnarios = new System.Windows.Forms.Label();
            this.lbUnariosEg = new System.Windows.Forms.Label();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVisor
            // 
            this.txtVisor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVisor.Location = new System.Drawing.Point(12, 12);
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.Size = new System.Drawing.Size(319, 20);
            this.txtVisor.TabIndex = 0;
            this.txtVisor.TextChanged += new System.EventHandler(this.txtVisor_TextChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultado.Location = new System.Drawing.Point(12, 38);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(319, 20);
            this.txtResultado.TabIndex = 1;
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(0, 120);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(75, 23);
            this.btnZero.TabIndex = 2;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.CliqueBtn);
            // 
            // btnUm
            // 
            this.btnUm.Location = new System.Drawing.Point(0, 91);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(75, 23);
            this.btnUm.TabIndex = 3;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = true;
            this.btnUm.Click += new System.EventHandler(this.CliqueBtn);
            // 
            // btnDois
            // 
            this.btnDois.Location = new System.Drawing.Point(81, 91);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(75, 23);
            this.btnDois.TabIndex = 4;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = true;
            this.btnDois.Click += new System.EventHandler(this.CliqueBtn);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(81, 120);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(75, 23);
            this.btnIgual.TabIndex = 5;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.Location = new System.Drawing.Point(0, 62);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(75, 23);
            this.btnQuatro.TabIndex = 6;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = true;
            this.btnQuatro.Click += new System.EventHandler(this.CliqueBtn);
            // 
            // btnSete
            // 
            this.btnSete.Location = new System.Drawing.Point(0, 33);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(75, 23);
            this.btnSete.TabIndex = 7;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = true;
            this.btnSete.Click += new System.EventHandler(this.CliqueBtn);
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(81, 62);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(75, 23);
            this.btnCinco.TabIndex = 8;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.CliqueBtn);
            // 
            // btnOito
            // 
            this.btnOito.Location = new System.Drawing.Point(81, 33);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(75, 23);
            this.btnOito.TabIndex = 9;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = true;
            this.btnOito.Click += new System.EventHandler(this.CliqueBtn);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(162, 120);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(162, 91);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(75, 23);
            this.btnTres.TabIndex = 11;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.CliqueBtn);
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(162, 62);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(75, 23);
            this.btnSeis.TabIndex = 12;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.CliqueBtn);
            // 
            // btnNove
            // 
            this.btnNove.Location = new System.Drawing.Point(162, 33);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(75, 23);
            this.btnNove.TabIndex = 13;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = true;
            this.btnNove.Click += new System.EventHandler(this.CliqueBtn);
            // 
            // btnPotencia
            // 
            this.btnPotencia.Location = new System.Drawing.Point(0, 4);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(75, 23);
            this.btnPotencia.TabIndex = 14;
            this.btnPotencia.Text = "^";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.CliqueBtn);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(81, 4);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(75, 23);
            this.btnDivisao.TabIndex = 15;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.CliqueBtn);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(162, 4);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicacao.TabIndex = 16;
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.CliqueBtn);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Location = new System.Drawing.Point(243, 4);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(75, 23);
            this.btnSubtracao.TabIndex = 17;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.CliqueBtn);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(243, 33);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(75, 23);
            this.btnSoma.TabIndex = 18;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.CliqueBtn);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(243, 62);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(75, 23);
            this.btnDecimal.TabIndex = 19;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.CliqueBtn);
            // 
            // btnFechaParenteses
            // 
            this.btnFechaParenteses.Location = new System.Drawing.Point(243, 91);
            this.btnFechaParenteses.Name = "btnFechaParenteses";
            this.btnFechaParenteses.Size = new System.Drawing.Size(75, 23);
            this.btnFechaParenteses.TabIndex = 20;
            this.btnFechaParenteses.Text = ")";
            this.btnFechaParenteses.UseVisualStyleBackColor = true;
            this.btnFechaParenteses.Click += new System.EventHandler(this.CliqueBtn);
            // 
            // btnAbreParentese
            // 
            this.btnAbreParentese.Location = new System.Drawing.Point(243, 120);
            this.btnAbreParentese.Name = "btnAbreParentese";
            this.btnAbreParentese.Size = new System.Drawing.Size(75, 23);
            this.btnAbreParentese.TabIndex = 21;
            this.btnAbreParentese.Text = "(";
            this.btnAbreParentese.UseVisualStyleBackColor = true;
            this.btnAbreParentese.Click += new System.EventHandler(this.CliqueBtn);
            // 
            // lbSequencias
            // 
            this.lbSequencias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSequencias.AutoSize = true;
            this.lbSequencias.Location = new System.Drawing.Point(10, 65);
            this.lbSequencias.Name = "lbSequencias";
            this.lbSequencias.Size = new System.Drawing.Size(99, 13);
            this.lbSequencias.TabIndex = 22;
            this.lbSequencias.Text = "Infixa: --- Pósfixa: ---";
            // 
            // lbUnarios
            // 
            this.lbUnarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUnarios.AutoSize = true;
            this.lbUnarios.Location = new System.Drawing.Point(37, 87);
            this.lbUnarios.Name = "lbUnarios";
            this.lbUnarios.Size = new System.Drawing.Size(303, 13);
            this.lbUnarios.TabIndex = 23;
            this.lbUnarios.Text = "Operações unárias devem ser representadas entre parêsentes.";
            // 
            // lbUnariosEg
            // 
            this.lbUnariosEg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUnariosEg.AutoSize = true;
            this.lbUnariosEg.Location = new System.Drawing.Point(38, 100);
            this.lbUnariosEg.Name = "lbUnariosEg";
            this.lbUnariosEg.Size = new System.Drawing.Size(302, 13);
            this.lbUnariosEg.TabIndex = 24;
            this.lbUnariosEg.Text = "E.g. a expressão -2^-2 deverá ser representada como (-2)^(-2).";
            // 
            // pnBotoes
            // 
            this.pnBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnBotoes.Controls.Add(this.btnAbreParentese);
            this.pnBotoes.Controls.Add(this.btnFechaParenteses);
            this.pnBotoes.Controls.Add(this.btnDecimal);
            this.pnBotoes.Controls.Add(this.btnSoma);
            this.pnBotoes.Controls.Add(this.btnSubtracao);
            this.pnBotoes.Controls.Add(this.btnMultiplicacao);
            this.pnBotoes.Controls.Add(this.btnDivisao);
            this.pnBotoes.Controls.Add(this.btnPotencia);
            this.pnBotoes.Controls.Add(this.btnNove);
            this.pnBotoes.Controls.Add(this.btnSeis);
            this.pnBotoes.Controls.Add(this.btnTres);
            this.pnBotoes.Controls.Add(this.btnLimpar);
            this.pnBotoes.Controls.Add(this.btnOito);
            this.pnBotoes.Controls.Add(this.btnCinco);
            this.pnBotoes.Controls.Add(this.btnSete);
            this.pnBotoes.Controls.Add(this.btnQuatro);
            this.pnBotoes.Controls.Add(this.btnIgual);
            this.pnBotoes.Controls.Add(this.btnDois);
            this.pnBotoes.Controls.Add(this.btnUm);
            this.pnBotoes.Controls.Add(this.btnZero);
            this.pnBotoes.Location = new System.Drawing.Point(13, 124);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(318, 145);
            this.pnBotoes.TabIndex = 25;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 281);
            this.Controls.Add(this.pnBotoes);
            this.Controls.Add(this.lbUnariosEg);
            this.Controls.Add(this.lbUnarios);
            this.Controls.Add(this.lbSequencias);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtVisor);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 320);
            this.MinimumSize = new System.Drawing.Size(360, 320);
            this.Name = "FormCalculadora";
            this.Text = "Calculadora";
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnFechaParenteses;
        private System.Windows.Forms.Button btnAbreParentese;
        private System.Windows.Forms.Label lbSequencias;
        private System.Windows.Forms.Label lbUnarios;
        private System.Windows.Forms.Label lbUnariosEg;
        private System.Windows.Forms.Panel pnBotoes;
    }
}

