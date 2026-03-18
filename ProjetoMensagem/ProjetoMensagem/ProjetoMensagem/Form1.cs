using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMensagem
{
    public partial class frmDiginhoMensagens : Form
    {
        public frmDiginhoMensagens()
        {
            InitializeComponent();
        }

        private void frmDiginhoMensagens_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Abriu o formulário");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão Mostrar");
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão Limpar");
        }

        private void lblInteiro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei na label Inteiro");
        }

        private void txtDecimal_TextChanged(object sender, EventArgs e)
        {
;            MessageBox.Show("Nil.");
        }

        private void txtInteiro_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Alterei um texto XD");
        }
    }
}
