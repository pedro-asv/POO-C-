using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLista03
{
    public partial class FrmExercico1 : Form
    {
        public FrmExercico1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtNum1.Text);
            float num3 = float.Parse(txtNum3.Text);
            float soma;
            soma = num1 + num3; 
            lblRSoma.Text = ("Soma é igual a = " + soma);    
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtNum1.Text);
            float num2 = float.Parse(txtNum2.Text);
            float num3 = float.Parse(txtNum3.Text);
            float media;
            media = (num1 + num2 + num3) / 3;
            lblRMedia.Text = ("A média é igual a = " + media);


        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtNum1.Text);
            float num2 = float.Parse(txtNum2.Text);
            float num3 = float.Parse(txtNum3.Text);
            float total, porcNum1, porcNum2, porcNum3;
            total = num1 + num2 + num3; //100%
            porcNum1 = num1 / total;
            porcNum2 = num2 / total;
            porcNum3 = num3 / total;
            lblRPorcentagem.Text = ("Num1 é " + porcNum1 + "% -" + "Num2 é " + porcNum2 + "% -" + "Num3 é " + porcNum3 + "%.");
 
        }
    }
}
