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
    public partial class FrmExercico04 : Form
    {
        public FrmExercico04()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            float altura = float.Parse(txtNum1.Text);
            float bas3 = float.Parse(txtNum2.Text);
            float area; 
            area = altura * bas3;
            lblResultado.Text = ("A área é igual a: " + area);
        }
    }
}
