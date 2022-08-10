﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace CalculadoraPosfixa
{
    public partial class FormCalculadora : Form
    {
        private string caracteresPermitidos = "0123456789+-*/^().";

        public FormCalculadora()
        {
            InitializeComponent();
        }

        private bool EstaBalanceada(string sequenciaDeOperacao)
        {
            PilhaVetor<char> estaBalanceada = new PilhaVetor<char>();

            foreach (char c in sequenciaDeOperacao)
            {
                if (c == '(') {
                    char parenteses = estaBalanceada.Topo();
                    if (parenteses == ')') return false;
                    estaBalanceada.Empilhar('(');
                }

                if (c == ')')
                {
                    char parenteses = estaBalanceada.Topo();
                    if (parenteses != '(') return false;

                    estaBalanceada.Desempilhar();
                }
            }

            if (estaBalanceada.Tamanho != 0) return false;

            return true;
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtDisplay.Text)
            {
                if (!caracteresPermitidos.Contains(c))
                {
                    MessageBox.Show("Caracter inválido digitado!");
                    txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.IndexOf(c));
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }


        private void btnZero_Click(object sender, EventArgs e)
        {

        }

        private void btnUm_Click(object sender, EventArgs e)
        {

        }

        private void btnDois_Click(object sender, EventArgs e)
        {

        }

        private void btnTres_Click(object sender, EventArgs e)
        {

        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {

        }

        private void btnCinco_Click(object sender, EventArgs e)
        {

        }

        private void btnSeis_Click(object sender, EventArgs e)
        {

        }

        private void btnSete_Click(object sender, EventArgs e)
        {

        }

        private void btnOito_Click(object sender, EventArgs e)
        {

        }

        private void btnNove_Click(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
   
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtResultado.Clear();
        }
    }
}
