using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CalculadoraPosfixa
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void txtVisor_TextChanged(object sender, EventArgs e)
        {
            string entrada = txtVisor.Text;
            bool valida = true;

            foreach (char caractere in entrada)
            {
                if (!".0123456789+-*/^()".Contains(caractere))
                {
                    MessageBox.Show($"O caractere '{caractere}' presente na expressão é inválido!");

                    valida = false;
                }
            }

            if (!valida)
                LimparCampos();

            else if (entrada.Length > 0)
                ValidarEntrada(entrada[entrada.Length - 1]);
        }

        private void ValidarEntrada(char caractereDigitado)
        {
            string entrada = txtVisor.Text;

            if (entrada.Length > 1)
            {
                char penultimoCaractere = entrada[entrada.Length - 2];

                if ("+-*/^".Contains(penultimoCaractere) && "+-*/^".Contains(caractereDigitado))
                {
                    MessageBox.Show($"Dois operadores não podem ser subsequentes!");

                    txtVisor.Text = entrada.Substring(0, entrada.Length - 1);
                }
            }

            else if ("+-*/^".Contains(caractereDigitado))
            {
                MessageBox.Show($"Um operador não pode inicar uma expressão!");

                txtVisor.Clear();
            }
        }

        private void CliqueBtn(object sender, EventArgs e)
        {
            char caractereDigitado = (sender as Button).Text[0];

            txtVisor.Text += caractereDigitado;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!EstaBalanceada(txtVisor.Text))
                MessageBox.Show("A expressão não está balanceada!");

            else
            {
                string expressao = txtVisor.Text;

                string infixa = ConverterParaInfixa(expressao, out double[] valores);
                string posfixa = ConverterParaPosfixa(infixa);
                double resultado = CalcularResultado(posfixa, valores);

                lbSequencias.Text = $"Infixa: {infixa} Pósfixa: {posfixa}";
                txtResultado.Text = resultado.ToString("0.00");
            }
        }

        private bool EstaBalanceada(string expressao)
        {
            PilhaVetor<char> caracteres = new PilhaVetor<char>();

            foreach (char caractere in expressao)
            {
                if (caractere == '(' || caractere == ')')
                {
                    if (caracteres.EstaVazia)
                        caracteres.Empilhar(caractere);

                    else if (caracteres.Topo() == '(' && caractere == ')')
                        caracteres.Desempilhar();

                    else
                        caracteres.Empilhar(caractere);
                }
            }

            if (caracteres.EstaVazia)
                return true;

            return false;
        }

        private string ConverterParaInfixa(string expressao, out double[] valores)
        {
            string infixa = expressao.Replace("(-", "(@").Replace("(+", "(");

            valores = new double[expressao.Length];
            int v = 0;

            for (int i = 0; i < expressao.Length; i++)
            {
                if (".0123456789".Contains(expressao[i]))
                {
                    string valor = expressao[i].ToString();
                    int j = i + 1;
                    bool fim = false;

                    if (j < expressao.Length)
                    {
                        while (".0123456789".Contains(expressao[j]) && !fim)
                        {
                            valor += expressao[j];

                            if (j + 1 == expressao.Length)
                                fim = true;

                            else
                                j++;
                        }
                    }

                    Regex regex = new Regex(Regex.Escape(valor.ToString()));
                    infixa = regex.Replace(infixa, ((char)(65 + v)).ToString(), 1);

                    valores[v++] = double.Parse(valor);
                    i = j;
                }
            }

            return infixa;
        }

        private string ConverterParaPosfixa(string infixa)
        {
            string posfixa = "";

            PilhaVetor<char> pilhaPosfixa = new PilhaVetor<char>();

            for (int i = 0; i < infixa.Length; ++i)
            {
                char caractere = infixa[i];

                if (!"+-*/^()".Contains(caractere))
                    posfixa += caractere;

                else
                {
                    if (caractere == '(')
                        pilhaPosfixa.Empilhar(caractere);

                    else if (caractere == ')')
                    {
                        while (!pilhaPosfixa.EstaVazia && pilhaPosfixa.Topo() != '(')
                            posfixa += pilhaPosfixa.Desempilhar();

                        pilhaPosfixa.Desempilhar();
                    }

                    else
                    {
                        while (!pilhaPosfixa.EstaVazia && Precedencia(caractere) <= Precedencia(pilhaPosfixa.Topo()))
                            posfixa += pilhaPosfixa.Desempilhar();

                        pilhaPosfixa.Empilhar(caractere);
                    }
                }
            }

            while (!pilhaPosfixa.EstaVazia)
                posfixa += pilhaPosfixa.Desempilhar();

            return posfixa;
        }

        private int Precedencia(char caractere)
        {
            if (caractere == '+' || caractere == '-')
                return 1;

            else if (caractere == '*' || caractere == '/')
                return 2;

            else if (caractere == '^')
                return 3;

            else
                return 0;
        }

        private double CalcularResultado(string posfixa, double[] valores)
        {
            for (int i = 0; i < posfixa.Length; ++i)
                if (posfixa[i] == '@')
                {
                    int j = i + 1;

                    valores[posfixa[j] - 65] = valores[posfixa[j] - 65] * (-1);
                }

            posfixa = posfixa.Replace("@", "");

            PilhaVetor<double> pilhaResultado = new PilhaVetor<double>();

            for (int i = 0; i < posfixa.Length; i++)
            {
                char caractere = posfixa[i];

                if (!"+-*/^".Contains(caractere))
                {
                    double operando = valores[caractere - 65];

                    pilhaResultado.Empilhar(operando);
                }

                else
                {
                    double operandoDois = pilhaResultado.Desempilhar();
                    double operandoUm = pilhaResultado.Desempilhar();

                    double resultado = 0;

                    switch (caractere)
                    {
                        case '+':
                            resultado = operandoUm + operandoDois;
                            break;
                        case '-':
                            resultado = operandoUm - operandoDois;
                            break;
                        case '*':
                            resultado = operandoUm * operandoDois;
                            break;
                        case '/':
                            resultado = operandoUm / operandoDois;
                            break;
                        case '^':
                            resultado = Math.Pow(operandoUm, operandoDois);
                            break;
                    }

                    pilhaResultado.Empilhar(resultado);
                }
            }

            return pilhaResultado.Desempilhar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtVisor.Clear();
            txtResultado.Clear();
            lbSequencias.Text = "Infixa: --- Pósfixa: ---";
        }
    }
}
