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
    public partial class FrmExercico02 : Form
    {
        public FrmExercico02()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            float vpagar = float.Parse(txtNum1.Text); 
            float vgasolina = float.Parse(txtNum2.Text);
            float resultado;    
            resultado = vpagar / vgasolina;
            lblResultado.Text = ("O valor em litros é de: " + resultado);
        }

       
    }
}
