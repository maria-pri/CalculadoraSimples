﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal calculo;
        bool adicao = false;
        bool subtracao = false;
        bool multiplicacao = false;
        bool divisao = false;
        bool resultado = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";

            txtOperacao.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";

            txtOperacao.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";

            txtOperacao.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";

            txtOperacao.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";

            txtOperacao.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";

            txtOperacao.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";

            txtOperacao.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";

            txtOperacao.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";

            txtOperacao.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";

            txtOperacao.Text += "0";
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtOperacao_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void btnAdicao_Click(object sender, EventArgs e)
        {

            calculo = Convert.ToDecimal(txtResultado.Text);

            txtOperacao.Text += "+";

            txtResultado.Text = "";

            adicao = true;
            subtracao = false;
            multiplicacao = false;
            divisao = false;
        }

        private void btnIgualdade_Click(object sender, EventArgs e)
        {
            resultado = true;

            txtOperacao.Text += "=";


            // OPERAÇÃO DE CALCULO PARA ADIÇÃO
            if (adicao == true)
            {
                txtResultado.Text = Convert.ToString(Convert.ToDecimal(txtResultado.Text) + calculo);

                txtOperacao.Text += txtResultado.Text;
            }

            // OPERAÇÃO DE CALCULO PARA SUBTRAÇÃO
            if (subtracao == true)
            {
                txtResultado.Text = Convert.ToString(calculo - Convert.ToDecimal(txtResultado.Text));

                txtOperacao.Text += txtResultado.Text;
            }

            // OPERAÇÃO DE CALCULO PARA MULTIPLICAÇÃO
            if (multiplicacao == true)
            {
                txtResultado.Text = Convert.ToString(Convert.ToDecimal(txtResultado.Text) * calculo);

                txtOperacao.Text += txtResultado.Text;
            }

            // OPERAÇÃO DE CALCULO PARA DIVISÃO
            if (divisao == true)
            {
                txtResultado.Text = Convert.ToString(calculo / Convert.ToDecimal(txtResultado.Text));

                txtOperacao.Text += txtResultado.Text;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            txtOperacao.Text = ""; 
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtResultado.Text);

            txtOperacao.Text += "-";

            txtResultado.Text = "";

            adicao = false;
            subtracao = true;
            multiplicacao = false;
            divisao = false;
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtResultado.Text);

            txtOperacao.Text += "*";

            txtResultado.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = true;
            divisao = false;
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtResultado.Text);

            txtOperacao.Text += "/";

            txtResultado.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = false;
            divisao = true;
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ",";

            txtOperacao.Text += ",";
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            try
            {
                string Apagar = txtResultado.Text;

                Apagar = Apagar.Remove(Apagar.Length - 1);

                txtResultado.Text = Apagar;

                txtOperacao.Text = Apagar;
            }

            catch(Exception)
            {

            }
        }
    }
}
