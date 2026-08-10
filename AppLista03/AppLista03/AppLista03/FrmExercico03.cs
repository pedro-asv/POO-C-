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
    public partial class FrmExercico03 : Form
    {
        public FrmExercico03()
        {
            InitializeComponent();
        }

        private void lblNum1_Click(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            float peso = float.Parse(txtNum1.Text);
            float resultado;
            resultado = peso * 34;
            lblResultado.Text = ("O´valor a pagar é de: " + resultado); 
        }
    }
}
