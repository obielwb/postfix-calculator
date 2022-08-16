using System;
using System.Linq;
using System.Windows.Forms;

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
            foreach (char c in txtDisplay.Text)
            {
                if (!".0123456789+-*/^()".Contains(c))
                {
                    MessageBox.Show($"Caractere '{c}' digitado inválido!");

                    txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.IndexOf(c));
                }
            }
        }

        private void CliqueBtn(object sender, EventArgs e)
        {
            txtDisplay.Text += (sender as Button).Text;
        }

        private bool EstaBalanceada(string expressao)
        {
            PilhaVetor<char> caracterees = new PilhaVetor<char>();

            foreach (char caractere in expressao)
            {
                if (caractere == '(' || caractere == ')')
                {
                    if (caracterees.EstaVazia)
                    {
                        caracterees.Empilhar(caractere);
                    }

                    else if (caracterees.Topo() == '(' && caractere == ')')
                    {
                        caracterees.Desempilhar();
                    }

                    else
                    {
                        caracterees.Empilhar(caractere);
                    }
                }
            }

            if (caracterees.EstaVazia)
            {
                return true;
            }

            return false;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!EstaBalanceada(txtDisplay.Text))
            {
                MessageBox.Show("A expressão indicada não está balanceada!");
            }

            else
            {
                string expressao = txtDisplay.Text;
                string infixa = expressao;

                double[] valores = new double[txtDisplay.Text.Length];
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
                                {
                                    fim = true;
                                }

                                else
                                {
                                    j++;
                                }
                            }
                        }

                        valores[v] = double.Parse(valor);
                        infixa = infixa.Replace(valor.ToString(), ((char)(65 + v)).ToString());
                        v++;
                        i = j;
                    }
                }

                string posfixa = "";
                PilhaVetor<char> umaPilha = new PilhaVetor<char>();
                char operador = '\0';

                for (int indice = 0; indice < infixa.Length; indice++)
                {
                    char caractere = infixa[indice];

                    if (!"+-*/()".Contains(caractere))
                        posfixa += caractere;

                    else
                    {
                        bool parar = false;

                        while (!parar && !umaPilha.EstaVazia && !TerPrecedencia(umaPilha.Topo(), caractere))
                        {
                            operador = umaPilha.Desempilhar();

                            if (operador != '(')
                                posfixa += operador;
                            else
                                parar = true;
                        }

                        if (caractere != ')')
                            umaPilha.Empilhar(caractere);

                        else
                            operador = umaPilha.Desempilhar();
                    }
                }

                while (!umaPilha.EstaVazia)
                {
                    operador = umaPilha.Desempilhar();

                    if (operador != '(')
                        posfixa += operador;
                }

                txtResultado.Text = posfixa;
            }
        }

        private bool TerPrecedencia(char caracterePilha, char caractereLido)
        {
            if (caracterePilha == '(')
                if (caractereLido == ')')
                    return true;
                else
                    return false;

            else if (caracterePilha == '^')
                if (caractereLido == '(' || caractereLido == '^')
                    return false;
                else
                    return true;

            else if (caracterePilha == '*' || caracterePilha == '/')
                if (caractereLido == '(' || caractereLido == '^')
                    return false;
                else
                    return true;

            else if (caracterePilha == '+' || caracterePilha == '-')
                if (caractereLido == '(' || caractereLido == '^' || caractereLido == '*' || caractereLido == '/')
                    return false;
                else
                    return true;

            return false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtResultado.Clear();
        }
    }
}
