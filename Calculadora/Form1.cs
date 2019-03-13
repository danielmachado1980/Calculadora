using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private string operacao; 

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "1";
            txtresultado.Select(txtresultado.Text.Length, 0);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "+";
            operacao = "+";
            txtresultado.Select(txtresultado.Text.Length, 0);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "2";
            txtresultado.Select(txtresultado.Text.Length, 0);
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            string[] valor;
            switch (operacao)
            {
                case "+":
                    valor = txtresultado.Text.Split('+');
                    txtresultado.Text = (float.Parse(valor[0]) + float.Parse(valor[1])).ToString();
                    break;
                default:
                    break;
            }
            operacao = "";
            txtresultado.Select(txtresultado.Text.Length, 0);
        }
                
    }
}
