namespace CalculadoraPosfixa
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnValue0 = new System.Windows.Forms.Button();
            this.btnValue1 = new System.Windows.Forms.Button();
            this.btnValue2 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnValue4 = new System.Windows.Forms.Button();
            this.btnValue7 = new System.Windows.Forms.Button();
            this.btnValue5 = new System.Windows.Forms.Button();
            this.btnValue8 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnValue3 = new System.Windows.Forms.Button();
            this.btnValue6 = new System.Windows.Forms.Button();
            this.btnValue9 = new System.Windows.Forms.Button();
            this.btnExponencial = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnFloatPoint = new System.Windows.Forms.Button();
            this.btnCloseBracket = new System.Windows.Forms.Button();
            this.btnOpenBracket = new System.Windows.Forms.Button();
            this.lbSequence = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(319, 20);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 38);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(319, 20);
            this.txtResultado.TabIndex = 1;
            // 
            // btnValue0
            // 
            this.btnValue0.Location = new System.Drawing.Point(13, 224);
            this.btnValue0.Name = "btnValue0";
            this.btnValue0.Size = new System.Drawing.Size(75, 23);
            this.btnValue0.TabIndex = 2;
            this.btnValue0.Text = "0";
            this.btnValue0.UseVisualStyleBackColor = true;
            this.btnValue0.Click += new System.EventHandler(this.btnValue0_Click);
            // 
            // btnValue1
            // 
            this.btnValue1.Location = new System.Drawing.Point(13, 195);
            this.btnValue1.Name = "btnValue1";
            this.btnValue1.Size = new System.Drawing.Size(75, 23);
            this.btnValue1.TabIndex = 3;
            this.btnValue1.Text = "1";
            this.btnValue1.UseVisualStyleBackColor = true;
            this.btnValue1.Click += new System.EventHandler(this.btnValue1_Click);
            // 
            // btnValue2
            // 
            this.btnValue2.Location = new System.Drawing.Point(94, 195);
            this.btnValue2.Name = "btnValue2";
            this.btnValue2.Size = new System.Drawing.Size(75, 23);
            this.btnValue2.TabIndex = 4;
            this.btnValue2.Text = "2";
            this.btnValue2.UseVisualStyleBackColor = true;
            this.btnValue2.Click += new System.EventHandler(this.btnValue2_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(94, 224);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(75, 23);
            this.btnEquals.TabIndex = 5;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnValue4
            // 
            this.btnValue4.Location = new System.Drawing.Point(13, 166);
            this.btnValue4.Name = "btnValue4";
            this.btnValue4.Size = new System.Drawing.Size(75, 23);
            this.btnValue4.TabIndex = 6;
            this.btnValue4.Text = "4";
            this.btnValue4.UseVisualStyleBackColor = true;
            this.btnValue4.Click += new System.EventHandler(this.btnValue4_Click);
            // 
            // btnValue7
            // 
            this.btnValue7.Location = new System.Drawing.Point(13, 137);
            this.btnValue7.Name = "btnValue7";
            this.btnValue7.Size = new System.Drawing.Size(75, 23);
            this.btnValue7.TabIndex = 7;
            this.btnValue7.Text = "7";
            this.btnValue7.UseVisualStyleBackColor = true;
            this.btnValue7.Click += new System.EventHandler(this.btnValue7_Click);
            // 
            // btnValue5
            // 
            this.btnValue5.Location = new System.Drawing.Point(94, 166);
            this.btnValue5.Name = "btnValue5";
            this.btnValue5.Size = new System.Drawing.Size(75, 23);
            this.btnValue5.TabIndex = 8;
            this.btnValue5.Text = "5";
            this.btnValue5.UseVisualStyleBackColor = true;
            this.btnValue5.Click += new System.EventHandler(this.btnValue5_Click);
            // 
            // btnValue8
            // 
            this.btnValue8.Location = new System.Drawing.Point(94, 137);
            this.btnValue8.Name = "btnValue8";
            this.btnValue8.Size = new System.Drawing.Size(75, 23);
            this.btnValue8.TabIndex = 9;
            this.btnValue8.Text = "8";
            this.btnValue8.UseVisualStyleBackColor = true;
            this.btnValue8.Click += new System.EventHandler(this.btnValue8_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(175, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "C";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnValue3
            // 
            this.btnValue3.Location = new System.Drawing.Point(175, 195);
            this.btnValue3.Name = "btnValue3";
            this.btnValue3.Size = new System.Drawing.Size(75, 23);
            this.btnValue3.TabIndex = 11;
            this.btnValue3.Text = "3";
            this.btnValue3.UseVisualStyleBackColor = true;
            this.btnValue3.Click += new System.EventHandler(this.btnValue3_Click);
            // 
            // btnValue6
            // 
            this.btnValue6.Location = new System.Drawing.Point(175, 166);
            this.btnValue6.Name = "btnValue6";
            this.btnValue6.Size = new System.Drawing.Size(75, 23);
            this.btnValue6.TabIndex = 12;
            this.btnValue6.Text = "6";
            this.btnValue6.UseVisualStyleBackColor = true;
            this.btnValue6.Click += new System.EventHandler(this.btnValue6_Click);
            // 
            // btnValue9
            // 
            this.btnValue9.Location = new System.Drawing.Point(175, 137);
            this.btnValue9.Name = "btnValue9";
            this.btnValue9.Size = new System.Drawing.Size(75, 23);
            this.btnValue9.TabIndex = 13;
            this.btnValue9.Text = "9";
            this.btnValue9.UseVisualStyleBackColor = true;
            this.btnValue9.Click += new System.EventHandler(this.btnValue9_Click);
            // 
            // btnExponencial
            // 
            this.btnExponencial.Location = new System.Drawing.Point(13, 108);
            this.btnExponencial.Name = "btnExponencial";
            this.btnExponencial.Size = new System.Drawing.Size(75, 23);
            this.btnExponencial.TabIndex = 14;
            this.btnExponencial.Text = "^";
            this.btnExponencial.UseVisualStyleBackColor = true;
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(94, 108);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 23);
            this.btnDivision.TabIndex = 15;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(175, 108);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplication.TabIndex = 16;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Location = new System.Drawing.Point(256, 108);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(75, 23);
            this.btnSubtraction.TabIndex = 17;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(256, 137);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 18;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            // 
            // btnFloatPoint
            // 
            this.btnFloatPoint.Location = new System.Drawing.Point(256, 166);
            this.btnFloatPoint.Name = "btnFloatPoint";
            this.btnFloatPoint.Size = new System.Drawing.Size(75, 23);
            this.btnFloatPoint.TabIndex = 19;
            this.btnFloatPoint.Text = ".";
            this.btnFloatPoint.UseVisualStyleBackColor = true;
            // 
            // btnCloseBracket
            // 
            this.btnCloseBracket.Location = new System.Drawing.Point(256, 195);
            this.btnCloseBracket.Name = "btnCloseBracket";
            this.btnCloseBracket.Size = new System.Drawing.Size(75, 23);
            this.btnCloseBracket.TabIndex = 20;
            this.btnCloseBracket.Text = ")";
            this.btnCloseBracket.UseVisualStyleBackColor = true;
            // 
            // btnOpenBracket
            // 
            this.btnOpenBracket.Location = new System.Drawing.Point(256, 224);
            this.btnOpenBracket.Name = "btnOpenBracket";
            this.btnOpenBracket.Size = new System.Drawing.Size(75, 23);
            this.btnOpenBracket.TabIndex = 21;
            this.btnOpenBracket.Text = "(";
            this.btnOpenBracket.UseVisualStyleBackColor = true;
            // 
            // lbSequence
            // 
            this.lbSequence.AutoSize = true;
            this.lbSequence.Location = new System.Drawing.Point(10, 65);
            this.lbSequence.Name = "lbSequence";
            this.lbSequence.Size = new System.Drawing.Size(41, 13);
            this.lbSequence.TabIndex = 22;
            this.lbSequence.Text = "Pósfixa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 287);
            this.Controls.Add(this.lbSequence);
            this.Controls.Add(this.btnOpenBracket);
            this.Controls.Add(this.btnCloseBracket);
            this.Controls.Add(this.btnFloatPoint);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnExponencial);
            this.Controls.Add(this.btnValue9);
            this.Controls.Add(this.btnValue6);
            this.Controls.Add(this.btnValue3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnValue8);
            this.Controls.Add(this.btnValue5);
            this.Controls.Add(this.btnValue7);
            this.Controls.Add(this.btnValue4);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnValue2);
            this.Controls.Add(this.btnValue1);
            this.Controls.Add(this.btnValue0);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnValue0;
        private System.Windows.Forms.Button btnValue1;
        private System.Windows.Forms.Button btnValue2;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnValue4;
        private System.Windows.Forms.Button btnValue7;
        private System.Windows.Forms.Button btnValue5;
        private System.Windows.Forms.Button btnValue8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnValue3;
        private System.Windows.Forms.Button btnValue6;
        private System.Windows.Forms.Button btnValue9;
        private System.Windows.Forms.Button btnExponencial;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnFloatPoint;
        private System.Windows.Forms.Button btnCloseBracket;
        private System.Windows.Forms.Button btnOpenBracket;
        private System.Windows.Forms.Label lbSequence;
    }
}

