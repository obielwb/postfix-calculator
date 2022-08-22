// Gabriel Willian Bartmanovicz - 21234
// João Pedro Ferreira Barbosa - 21687

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

        // observção da mudança do valor do txtVisor
        private void txtVisor_TextChanged(object sender, EventArgs e)
        {
            string entrada = txtVisor.Text;
            bool valida = true;

            // percorrimento da entrada para a validação de seus caracteres
            foreach (char caractere in entrada)
            {
                // se o caractere for inválido
                if (!".0123456789+-*/^()".Contains(caractere))
                {
                    MessageBox.Show($"O caractere '{caractere}' presente na expressão é inválido!");

                    valida = false;
                }
            }

            // se a entrada não for válida
            if (!valida)
                LimparCampos();

            else if (entrada.Length > 0)
                ValidarEntrada(entrada[entrada.Length - 1]);
        }

        // método para validar a entrada no txtVisor
        private void ValidarEntrada(char caractereDigitado)
        {
            string entrada = txtVisor.Text;

            // se a entrada tem dois caracteres ou mais
            if (entrada.Length > 1)
            {
                char penultimoCaractere = entrada[entrada.Length - 2];

                // verificação da presença de dois operadores seguidos
                if ("+-*/^".Contains(penultimoCaractere) && "+-*/^".Contains(caractereDigitado))
                {
                    MessageBox.Show($"Dois operadores não podem ser subsequentes!");

                    // recorte do operador inválido
                    txtVisor.Text = entrada.Substring(0, entrada.Length - 1);
                }
            }

            // verificação da presença de um operador
            // anterior à presença de um operando,
            // inválido mesmo para unários
            else if ("+-*/^".Contains(caractereDigitado))
            {
                MessageBox.Show($"Um operador não pode iniciar uma expressão!");

                txtVisor.Clear();
            }
        }

        // evento clique para os botões de operandos e operadores
        private void CliqueBtn(object sender, EventArgs e)
        {
            // obtém o caractere a partir do texto do botão,
            // sendo operando ou operador
            char caractereDoBotao = (sender as Button).Text[0];

            txtVisor.Text += caractereDoBotao;
        }

        // evento click do botão "=" ou igual
        private void btnIgual_Click(object sender, EventArgs e)
        {
            // verificação do balanceamento dos parenteses da expressão
            if (!TemParentesesBalanceados(txtVisor.Text))
                MessageBox.Show("A expressão não tem parênteses balanceados!");

            else
            {
                string expressao = txtVisor.Text;

                // conversão da expressão regular para infixa
                string infixa = ConverterParaInfixa(expressao, out double[] valores);
                // conversão da expressão infixa para pósifxa
                string posfixa = ConverterParaPosfixa(infixa);
                // calculo do resultado da expressão a partir
                // da expressão pósfixa e do vetor de valores
                double resultado = CalcularResultado(posfixa, valores);

                // exibição dos resultados
                lbSequencias.Text = $"Infixa: {infixa} Pósfixa: {posfixa}";
                txtResultado.Text = resultado.ToString();
            }
        }

        // método para determinar se uma expressão tem parênteses balanceados
        private bool TemParentesesBalanceados(string expressao)
        {
            // pilha de parênteses 
            PilhaVetor<char> parenteses = new PilhaVetor<char>();

            // percorrimento da expressão para o balanceamento dos parênteses
            foreach (char caractere in expressao)
            {
                // se o caractere "da vez" da expressão for parênteses
                if (caractere == '(' || caractere == ')')
                {
                    // caso a pilha esteja vazia, é 
                    // empilhado o primeiro caractere
                    if (parenteses.EstaVazia)
                        parenteses.Empilhar(caractere);

                    // se há um balanceamento entre o parênteses do topo
                    // da pilha e o parênteses digitado, a pilha é desempilhada
                    else if (parenteses.Topo() == '(' && caractere == ')')
                        parenteses.Desempilhar();

                    // caso contrário, o parênteses é empilhado
                    else
                        parenteses.Empilhar(caractere);
                }
            }

            // a presença ou não de parênteses na pilha
            // determina o balanceamento da expressão
            // EstaVazia: true -> balanceada
            // EstaVazia: false -> desbalanceada
            return parenteses.EstaVazia;
        }

        // método para conversão de uma expressão
        // regular para expressão infixa, retornando um
        // vetor com os valores extraídos da expressão regular
        private string ConverterParaInfixa(string expressao, out double[] valores)
        {
            // atribuição dos operadores unários
            // "-" -> "@"
            // "+" -> ""
            string infixa = expressao.Replace("(-", "(@").Replace("(+", "(");

            // vetor de valores 
            valores = new double[expressao.Length];
            // contador v para o vetor de valores
            int v = 0;

            // percorrimento da expressão para extração
            // dos valores númericos e atribuição de letras
            for (int i = 0; i < expressao.Length; i++)
            {
                char caractere = expressao[i];

                // se o caractere é númerico
                if (".0123456789".Contains(caractere))
                {
                    // inicia-se o processo para a obtenção máxima do valor
                    string valor = caractere.ToString();
                    int j = i + 1;
                    bool fim = false;

                    // j se prolonga até o valor deixar de ser númerico,
                    // seja tal o fim da expressão ou um operador, concatenando
                    // os valores númericos no valor
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

                    // utilização de regex para a substituição do valor para
                    // sua respectiva letra, relativa à posição do valor
                    Regex regex = new Regex(Regex.Escape(valor.ToString()));
                    infixa = regex.Replace(infixa, ((char)(65 + v)).ToString(), 1);

                    valores[v++] = double.Parse(valor);
                    i = j;
                }
            }

            // retorno da expressão regular convertida para infixa
            return infixa;
        }


        // método para conversão de uma expressão infixa para pósfixa
        private string ConverterParaPosfixa(string infixa)
        {
            string posfixa = "";

            // pilha de operadores
            PilhaVetor<char> operadores = new PilhaVetor<char>();

            // percorrimento da expressão infixa para conversão
            // para pósifxa
            foreach (char caractere in infixa)
            {
                // se o caractere é uma letra
                if (!"+-*/^()".Contains(caractere))
                    posfixa += caractere;

                // se o caractere é um operador
                else
                {
                    if (caractere == '(')
                        operadores.Empilhar(caractere);

                    else if (caractere == ')')
                    {
                        // enquanto não haver balanceamento, 
                        // concatena-se o desempilhamento na expressão pósfixa
                        while (!operadores.EstaVazia && operadores.Topo() != '(')
                            posfixa += operadores.Desempilhar();

                        operadores.Desempilhar();
                    }

                    // se o caractere for +, -, *, / ou ^
                    else
                    {
                        // enquanto a pilha não estiver vazia e a precedência do operador
                        // for menor ou igual que a precedência do topo da pilha,
                        // concatena-se o desempilhamento na expressão pósfixa
                        while (
                            !operadores.EstaVazia &&
                            Precedencia(caractere) <= Precedencia(operadores.Topo())
                        )
                            posfixa += operadores.Desempilhar();

                        operadores.Empilhar(caractere);
                    }
                }
            }

            // desempilhamento dos operadores remanescentes
            while (!operadores.EstaVazia)
                posfixa += operadores.Desempilhar();

            // retorno da expressão infixa convertida para pósfixa
            return posfixa;
        }

        // método para retornar a precedência númerica de um operador
        private int Precedencia(char operador)
        {
            // + e - têm precedência númerica 1
            if (operador == '+' || operador == '-')
                return 1;

            // * e / têm precedência númerica 2
            else if (operador == '*' || operador == '/')
                return 2;

            // ^ tem precedência númerica 3
            else if (operador == '^')
                return 3;

            // outros operadores têm precedência númerica 0
            else
                return 0;
        }

        // método para calcular o resultado de uma dada expressão
        // pósfixa através de seu vetor de valores
        private double CalcularResultado(string posfixa, double[] valores)
        {
            // percorrimento da expressão pósfixa para o tratamento
            // de operadores unários negativos
            for (int i = 0; i < posfixa.Length; ++i)
                // se há um operador unário negativo na posição i
                if (posfixa[i] == '@')
                {
                    // a letra que representa o valor unário correspondente a i
                    // está uma posição a frente, subtraída por 65, resulta na
                    // posição j relativa ao valor no vetor de valores
                    int j = posfixa[i + 1] - 65;

                    // oposição do valor da posição j 
                    valores[j] = -1 * valores[j];
                }

            // remoção dos operadores unários negativos da expressão pósfixa
            posfixa = posfixa.Replace("@", "");

            // pilha de operações
            PilhaVetor<double> operacoes = new PilhaVetor<double>();

            // percorrimento da expressão pósfixa para realização do cálculo
            foreach (char caractere in posfixa)
            {
                // se o caractere for uma letra, representando um valor
                if (!"+-*/^".Contains(caractere))
                {
                    // obtém o operando relativo à letra
                    double operando = valores[caractere - 65];

                    operacoes.Empilhar(operando);
                }

                // se o caractere for um operador
                else
                {
                    // desempilha os operandos em ordem
                    double operandoDois = operacoes.Desempilhar();
                    double operandoUm = operacoes.Desempilhar();

                    double operacao = 0;

                    // switch para realização da operação entre
                    // operando um, operador e operando dois
                    switch (caractere)
                    {
                        case '+':
                            operacao = operandoUm + operandoDois;
                            break;
                        case '-':
                            operacao = operandoUm - operandoDois;
                            break;
                        case '*':
                            operacao = operandoUm * operandoDois;
                            break;
                        case '/':
                            operacao = operandoUm / operandoDois;
                            break;
                        case '^':
                            operacao = Math.Pow(operandoUm, operandoDois);
                            break;
                    }

                    operacoes.Empilhar(operacao);
                }
            }

            // o resultado do cálculo da expressão é a operação
            // remanescente na pilha de operações
            return operacoes.Desempilhar();
        }

        // evento clique do botão "clear" ou "C"
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        // método para limpar os campos relacionados à calculadora
        private void LimparCampos()
        {
            txtVisor.Clear();
            txtResultado.Clear();
            lbSequencias.Text = "Infixa: --- Pósfixa: ---";
        }
    }
}
