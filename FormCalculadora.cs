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

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtDisplay.Text)
            {
                if (!"0123456789+-*/^().".Contains(c))
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

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!EstaBalanceada(txtDisplay.Text))
            {
                MessageBox.Show("A expressão indicada não está balanceada!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtResultado.Clear();
        }
    }
}
