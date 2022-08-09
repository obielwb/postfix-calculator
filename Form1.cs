using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPosfixa
{
    public partial class Form1 : Form
    {
        private string allowedCharacters = "0123456789+-*/^().";
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtDisplay.Text)
            {
                if (!allowedCharacters.Contains(c))
                {
                    MessageBox.Show("Caracter inválido digitado");
                    txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.IndexOf(c));
                }
            }
        }

        private void btnValue0_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("0");
        }
        private void btnValue1_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("1");
        }
        private void btnValue2_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("2");
        }
        private void btnValue3_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("3");
        }
        private void btnValue4_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("4");
        }
        private void btnValue5_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("5");
        }
        private void btnValue6_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("6");
        }
        private void btnValue7_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("7");
        }
        private void btnValue8_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("8");
        }
        private void btnValue9_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("9");
        }

    }
}
