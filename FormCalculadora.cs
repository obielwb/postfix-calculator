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

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            foreach (char caractere in txtVisor.Text)
            {
                if (!".0123456789+-*/^()".Contains(caractere))
                {
                    MessageBox.Show($"Caractere '{caractere}' digitado inválido!");

                    int indiceCaractere = txtVisor.Text.IndexOf(caractere);

                    if (indiceCaractere >= 0)
                        txtVisor.Text = txtVisor.Text.Substring(0, indiceCaractere);

                    else
                        txtVisor.Clear();
                }
            }
        }

        private void txtVisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caractereDigitado = e.KeyChar;

            VerificarOperadores(caractereDigitado);
        }

        private bool VerificarOperadores(char caractereDigitado)
        {
            if (txtVisor.Text.Length >= 2)
            {
                char ultimoCaractere = txtVisor.Text[txtVisor.Text.Length - 1];

                if ("+-*/^".Contains(ultimoCaractere) && "+-*/^".Contains(caractereDigitado))
                {
                    MessageBox.Show($"Dois operadores não podem ser subsequentes!");

                    txtVisor.Clear();

                    return false;
                }

                return true;
            }

            else
                return true;
        }

        private void CliqueBtn(object sender, EventArgs e)
        {
            char caractereDigitado = (sender as Button).Text[0];

            if (VerificarOperadores(caractereDigitado))
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
            PilhaVetor<char> caracterees = new PilhaVetor<char>();

            foreach (char caractere in expressao)
            {
                if (caractere == '(' || caractere == ')')
                {
                    if (caracterees.EstaVazia)
                        caracterees.Empilhar(caractere);

                    else if (caracterees.Topo() == '(' && caractere == ')')
                        caracterees.Desempilhar();

                    else
                        caracterees.Empilhar(caractere);
                }
            }

            if (caracterees.EstaVazia)
                return true;

            return false;
        }

        private string ConverterParaInfixa(string expressao, out double[] valores)
        {
            string infixa = expressao;

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

                if (!"+-*/()".Contains(caractere))
                    posfixa += caractere;

                else
                {
                    if (caractere == '(')
                        pilhaPosfixa.Empilhar(caractere);

                    else if (caractere == ')')
                    {
                        while (!pilhaPosfixa.EstaVazia && pilhaPosfixa.Topo() != '(')
                            posfixa += pilhaPosfixa.Desempilhar();

                        if (!pilhaPosfixa.EstaVazia && pilhaPosfixa.Topo() != '(')
                        {
                            posfixa = "Expressão inválida!";

                            break;
                        }

                        else
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
            txtVisor.Clear();
            txtResultado.Clear();
            lbSequencias.Text = "Infixa: --- Pósfixa: ---";
        }
    }
}
