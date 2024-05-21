using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Par_ou_Ímpar
{
    public partial class frmParImpar : Form
    {
        public frmParImpar()
        {
            InitializeComponent();
        }
        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private string ValidarCampos()
        {
            string msgErro = string.Empty;
            if (txtNumero.Text == string.Empty)
            {
                msgErro = "Informe o número!\n";
            }
            else
            {
                int numero = int.Parse(txtNumero.Text);
                if (numero < 1 || numero > 100)
                {
                    msgErro = "Número Inválido! O número deve estar entre 1 e 100!\n";
                }
            }
            return msgErro;
        }
        private bool SomenteNumero(char tecla, string texto)
        {
            if (!char.IsDigit(tecla) && tecla != (char)Keys.Back)
            {
                return true;
            }
            return false;
        }
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = SomenteNumero(e.KeyChar, txtNumero.Text);
        }
        private void LimparCampos()
        {
            txtNumero.Clear();
            txtNumero.ReadOnly = false;
            OcultarLabels();
            RedimensionarFormulario(false);
            txtNumero.Focus();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string mensagem = ValidarCampos();
            if (mensagem != string.Empty)
            {
                MessageBox.Show(mensagem, "Erro no Número!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int numero = int.Parse(txtNumero.Text);
            txtNumero.ReadOnly = true;
            RedimensionarFormulario(true);
            ExibirResultado(numero % 2);            
        }
        private void OcultarLabels()
        {
            lblImpar.Visible = false;
            lblPar.Visible = false;
        }
        private void RedimensionarFormulario(bool aberto)
        {
            if (aberto)
            {
                for(int altura = this.Height; altura <=235; altura++)
                {
                    this.Height = altura;
                    Application.DoEvents();
                }
                
            }
            else
            {
                for (int altura = this.Height; altura >= 165; altura--)
                {
                    this.Height = altura;
                    Application.DoEvents();
                }
            }
        }
        private void frmParImpar_Load(object sender, EventArgs e)
        {
            OcultarLabels();
            RedimensionarFormulario(false);
        }
        private void ExibirResultado(int resto)
        {
            lblImpar.Visible = resto == 1;
            lblPar.Visible = resto == 0;
        }
    }
}
