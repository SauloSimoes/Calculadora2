﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        

        void AtribuirOperacao(string oper)
        {
            lblOper.Text = oper;
            btIgual.Enabled = true;
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            AtribuirOperacao(btSub.Text);
        }

        private void btSoma_Click_1(object sender, EventArgs e)
        {
            AtribuirOperacao(btSoma.Text);
        }

        private void btMult_Click(object sender, EventArgs e)
        {
            AtribuirOperacao(btMult.Text);
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            AtribuirOperacao(btDiv.Text);
            if (numOper2.Value == 0 && lblOper.Text == btDiv.Text)
            {
                btIgual.Enabled = false;
            }
            else
            {
                btIgual.Enabled = true;
            }
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            double num1 = (double)numOper1.Value;
            double num2 = (double)numOper2.Value;
            double res = 0.0;
            switch (lblOper.Text)
            {
                case "+":
                    res = num1 + num2;
                    break;
                case "-":  
                    res = num1 - num2;
                    break; 
                case "x": 
                    res = num1 * num2;
                    break;
                case "/":
                    res = num1 / num2;
                    break;
            }
            lblResultado.Text = res.ToString();
        }

        private void numOper1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numOper2_ValueChanged(object sender, EventArgs e)
        {
            if (numOper2.Value == 0 && lblOper.Text == btDiv.Text)
            {
                btIgual.Enabled = false;
            }
            else
            {
                btIgual.Enabled = true;
            }
        }
    }
}
