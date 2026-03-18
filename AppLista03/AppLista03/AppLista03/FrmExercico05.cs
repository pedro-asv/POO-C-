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
    public partial class FrmExercico05 : Form
    {
        public FrmExercico05()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            float altura = float.Parse(txtNum1.Text);
            float bas3 = float.Parse(txtNum2.Text);
            float perimetro;
            perimetro = (bas3 * 2) + (altura * 2);
            lblResultado.Text = ("O pedrímetro é de: " + perimetro);
        }
    }
}
