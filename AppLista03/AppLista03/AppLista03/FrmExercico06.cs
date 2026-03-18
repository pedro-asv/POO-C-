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
    public partial class FrmExercico06 : Form
    {
        public FrmExercico06()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            float numero = float.Parse(txtNum1.Text);
            float cubo;
            cubo = numero * numero * numero;
            lblRSoma.Text = ("O cubo é: " + cubo);
        }
    }
}
