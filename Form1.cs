namespace miniCalculadora
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            if ((txtNum1.Text != string.Empty) && (txtNum1.Text != string.Empty))
            {
                btnDivisao.Enabled = true;
                btnSoma.Enabled = true;
                btnSubtracao.Enabled = true;
                btnMultiplicacao.Enabled = true;

                lblResultado.Visible = true;
                txtResultado.Visible = true;
                btnDivisao.Visible = true;
                btnSoma.Visible = true;
                btnSubtracao.Visible = true;
                btnMultiplicacao.Visible = true;

            }
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            if ((txtNum1.Text != string.Empty) && (txtNum1.Text != string.Empty))
            {
                btnDivisao.Enabled = true;
                btnSoma.Enabled = true;
                btnSubtracao.Enabled = true;
                btnMultiplicacao.Enabled = true;

                lblResultado.Visible = true;
                txtResultado.Visible = true;
                btnDivisao.Visible = true;
                btnSoma.Visible = true;
                btnSubtracao.Visible = true;
                btnMultiplicacao.Visible = true;

            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            float num1, num2, result;
            num1 = float.Parse(txtNum1.Text);
            num2 = float.Parse(txtNum2.Text);
            result = num1 + num2;
            txtResultado.Text = result.ToString();
            

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            float num1, num2, result;
            num1 = float.Parse(txtNum1.Text);
            num2 = float.Parse(txtNum2.Text);
            result = num1 - num2;
            txtResultado.Text = result.ToString();
             
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResultado.Text = "";
                 
            lblResultado.Visible = false;
            txtResultado.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd'-'MM'-'yyyy");
           /* dateTimePicker1.Value = DateTime.Now;*/
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            float num1, num2, result;
            num1 = float.Parse(txtNum1.Text);
            num2 = float.Parse(txtNum2.Text);
            result = num1 / num2;
            txtResultado.Text = result.ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            float num1, num2, result;
            num1 = float.Parse(txtNum1.Text);
            num2 = float.Parse(txtNum2.Text);
            result = num1 * num2;
            txtResultado.Text = result.ToString();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            btnDivisao.Visible = false;
            btnSoma.Visible = false;
            btnSubtracao.Visible = false;
            btnMultiplicacao.Visible = false;
        }
    }
}