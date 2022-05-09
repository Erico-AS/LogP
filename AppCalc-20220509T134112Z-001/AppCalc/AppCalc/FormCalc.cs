using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalc
{
    public partial class FormCalc : Form
    {
        public FormCalc()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            float val1 = float.Parse(txtVal1.Text);
            float val2 = float.Parse(txtVal2.Text);
            float varSoma = val1 + val2; 
             MessageBox.Show("O resultado foi " + varSoma );
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            float val1 = float.Parse(txtVal1.Text);
            float val2 = float.Parse(txtVal2.Text);
            float varSub = val1 - val2;
            MessageBox.Show("O resultado foi " + varSub);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            float val1 = float.Parse(txtVal1.Text);
            float val2 = float.Parse(txtVal2.Text);
            float varMult = val1 * val2;
            MessageBox.Show("O resultado foi " + varMult);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            float val1 = float.Parse(txtVal1.Text);
            float val2 = float.Parse(txtVal2.Text);
            float varDiv = val1 / val2;
            if (val2 == 0)
            {
                MessageBox.Show("Impossivel dividir por 0");
            }
            MessageBox.Show("O resultado foi " + varDiv);
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            float val1 = float.Parse(txtVal1.Text);
            float val2 = float.Parse(txtVal2.Text);
            float varPor = (val1 * val2) / 100;
            MessageBox.Show("O resultado foi " + varPor);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtVal2.Text = "0";
            MessageBox.Show("Você apagou o ultimo valor");
        }

        private void txtVal1_Click(object sender, EventArgs e)
        {
            txtVal1.Text = " ";
        }

        private void txtVal2_Click(object sender, EventArgs e)
        {
            txtVal2.Text = " ";
            
        }

        private void txtVal1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtVal2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVal1.Text = "0";
            txtVal2.Text = "0";
            MessageBox.Show("Você apagou todos os valores");
        }
    }
}
