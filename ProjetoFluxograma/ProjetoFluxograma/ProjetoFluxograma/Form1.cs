using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFluxograma
{
    public partial class FrmFluxo : Form
    {
        public FrmFluxo()
        {
            InitializeComponent();
        }
        private void btnResultado_Click(object sender, EventArgs e)
        {
            double produto = double.Parse(txtresultado.Text);
            double resultado;
            resultado = Math.Sqrt(produto);
            MessageBox.Show("A raiz quadrada é: " + resultado);

 

        }

        
    }
}
