namespace atv2_exercicio_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(textNumero.Text);

            if (numero % 5 == 0 && numero >= 50)
            {
                MessageBox.Show($"O número é multiplo de 5 e maior que 50, seu numero é {numero}"); 
            }
            else if(numero % 5 == 0)
            {
                MessageBox.Show($"O número é multiplo de 5 e porem menor que 50, seu numero é {numero}");
            }
            else
            {
                MessageBox.Show("O número não é multiplo de 5.");
            }

        }
    }
}
