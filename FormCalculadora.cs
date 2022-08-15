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
                    MessageBox.Show($"Caracter {c} digitado inválido!");

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
            PilhaVetor<char> caracteres = new PilhaVetor<char>();

            foreach (char caracter in expressao)
            {
                if (caracter == '(' || caracter == ')')
                {
                    if (caracteres.EstaVazia)
                    {
                        caracteres.Empilhar(caracter);
                    }

                    else if (caracteres.Topo() == '(' && caracter == ')')
                    {
                        caracteres.Desempilhar();
                    }

                    else
                    {
                        caracteres.Empilhar(caracter);
                    }
                }
            }

            if (caracteres.EstaVazia)
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

                        valores[v] = double.Parse(valor);
                        infixa = infixa.Replace(valor.ToString(), ((char)(65 + v)).ToString());
                        v++;
                        i = j;
                    }
                }

                string posfixa = "";
                PilhaVetor<char> umaPilha = new PilhaVetor<char>();
                char operadorComMaiorPrecedencia = '';

                for (int indice = 0; indice < infixa.Length; indice++)
                {
                    char caracter = infixa[indice];

                    if (!"+-*/()".Contains(caracter))
                        posfixa += caracter;

                    else // operador
                    {
                        bool parar = false;

                        while (!parar && !umaPilha.EstaVazia && TerPrecedencia(umaPilha.Topo(), caracter))
                        {
                            operadorComMaiorPrecedencia = umaPilha.Desempilhar();

                            if (operadorComMaiorPrecedencia != '(')
                                posfixa += operadorComMaiorPrecedencia;
                            else
                                parar = true;
                        }

                        if (caracter != ')')
                            umaPilha.Empilhar(caracter);

                        else // fará isso QUANDO o Pilha[TOPO] = '('
                            operadorComMaiorPrecedencia = umaPilha.Desempilhar();
                    }
                } // for

                while (!umaPilha.EstaVazia) // Descarrega a Pilha Para a Saída
                {
                    operadorComMaiorPrecedencia = umaPilha.Desempilhar();

                    if (operadorComMaiorPrecedencia != '(')
                        posfixa += operadorComMaiorPrecedencia;
                }


                txtResultado.Text = infixa;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtResultado.Clear();
        }
    }
}
